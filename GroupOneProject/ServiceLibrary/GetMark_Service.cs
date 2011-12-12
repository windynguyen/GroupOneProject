using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ServiceLibrary
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetMark_Service : IService
    {
        public static string HostPath = "";
        private InfoFault fault;
        private List<InfoFault> lstFault;
        public GetMark_Service()
        {
        }

        public List<Member> GetAuthors()
        {
            //return danh sách nhóm
            Member mem1 = new Member("080873", "Nguyễn Thanh Phong", "PM081");
            Member mem2 = new Member("080922", "Nguyễn Đình Tín", "PM081");
            Member mem3 = new Member("080890", "Đặng Minh Thành", "PM081");
            List<Member> lst_mem = new List<Member>();
            lst_mem.Add(mem1);
            lst_mem.Add(mem2);
            lst_mem.Add(mem3);
            return lst_mem;
        }

        public bool ChangePassword(string username, string old_password, string new_password, int mode)
        {
            bool kt_pass_old = CheckLogin(username, old_password, mode);
            string query="";
            if (kt_pass_old)
            {
                connect.Open_Connect();
                switch (mode)
                {
                    case 0:
                        query = "Update tbl_SinhVien " +
                                "Set MatKhau = '" + new_password + "' " +
                                "Where MSSV = '" + username + "'";
                        break;
                    case 1:
                        query = "Update tbl_SinhVien " +
                                "Set MatKhauGD = '" + new_password + "' " +
                                "Where MSSV = '" + username + "'";
                        break;
                    case 2:
                        query = "Update tbl_GiangVien " +
                                "Set MatKhau = '" + new_password + "' " +
                                "Where MSGV = '" + username + "'";
                        break;
                }
                
                SqlCommand cmd = new SqlCommand(query, connect.con);
                int roweff = cmd.ExecuteNonQuery();
                connect.Close_Connect();
                if (roweff != 0)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                throw new FaultException("Mật khẩu cũ không đúng");


        }
        public Subject[] Search_Subject(string keyword)
        {
            List<Subject> lst_sub = new List<Subject>();
            SqlDataReader sdr = null;
            Subject sub;
            string query1 = "Select MH.* From tbl_KetQua KQ,tbl_MonHoc MH Where MSSV ='070707' And KQ.MaMonHoc = MH.MaMonHoc And MH.MaMonHoc = '"+keyword+"'";
            string query2 = "Select MH.* From tbl_KetQua KQ,tbl_MonHoc MH Where MSSV ='070707' And KQ.MaMonHoc = MH.MaMonHoc And TenMonHoc like N'%"+keyword+"%'";
            try
            {
                connect.Open_Connect();
                SqlCommand cmd1 = new SqlCommand(query1, connect.con);
                sdr = cmd1.ExecuteReader();
                if (sdr.HasRows == true)
                {
                    while (sdr.Read())
                    {
                        sub = new Subject();
                        sub.Semester = "HK";
                        sub.Code_sub = sdr[0].ToString();
                        sub.Name_sub = sdr[1].ToString();
                        sub.SoTC = (int)sdr[2];
                        sub.Sotiet = (int)sdr[3];
                        lst_sub.Add(sub);
                    }
                }
                else
	            {
                    connect.Open_Connect();
		            SqlCommand cmd2 = new SqlCommand(query2, connect.con);
                    SqlDataReader sdr2 = null;
                    sdr2 = cmd2.ExecuteReader();
                    while (sdr2.Read())
                    {
                        sub = new Subject();
                        sub.Semester = "HK";
                        sub.Code_sub = sdr2[0].ToString();
                        sub.Name_sub = sdr2[1].ToString();
                        sub.SoTC = (int)sdr2[2];
                        sub.Sotiet = (int)sdr2[3];
                        lst_sub.Add(sub);
                    }
	            }
                
                
            }
            catch
            {
                lst_sub = null;
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                if (connect.con != null)
                {
                    connect.Close_Connect();
                }

            }
            return lst_sub.ToArray();
        }
        public Student Get_Info_Stu(string code_student)
        {
            Student SV = new Student();
            DataTable dt = new DataTable();
            string query = "Select * From tbl_SinhVien Where MSSV = '" + code_student + "'";
            connect.Open_Connect();
            SqlDataAdapter adap = new SqlDataAdapter(query, connect.con);
            adap.Fill(dt);

            SV.Mssv = dt.Rows[0][0].ToString();
            SV.Hoten = dt.Rows[0][2].ToString();
            SV.Gioitinh = Convert.ToInt32(dt.Rows[0][3]);
            SV.Ngaysinh = dt.Rows[0][4].ToString();
            SV.Noisinh = dt.Rows[0][5].ToString();
            SV.Khoa = dt.Rows[0][6].ToString();
            SV.Lop = dt.Rows[0][7].ToString();
            SV.Nganh = dt.Rows[0][8].ToString();
            SV.HeDT = dt.Rows[0][9].ToString();
            SV.Khoahoc = dt.Rows[0][10].ToString();
            SV.TongTC = Convert.ToInt32(dt.Rows[0][11]);
            SV.Diachi = dt.Rows[0][12].ToString();
            SV.Dienthoai = dt.Rows[0][13].ToString();
            SV.Email = dt.Rows[0][14].ToString();
            SV.Dantoc = dt.Rows[0][15].ToString();
            SV.Tongiao = dt.Rows[0][16].ToString();
            SV.Quoctich = dt.Rows[0][17].ToString();
            SV.Hotencha = dt.Rows[0][18].ToString();
            SV.Nghenghiepcha = dt.Rows[0][19].ToString();
            SV.Hotenme = dt.Rows[0][20].ToString();
            SV.Nghenghiepme = dt.Rows[0][21].ToString();

            connect.Close_Connect();
            return SV;
        }
        public bool Update_Info_Stu(Student Stu)
        {
            lstFault = new List<InfoFault>();
            if (Stu.Diachi == "" || Stu.Dantoc == "" || Stu.Quoctich == "" || Stu.Tongiao == "")
            {
                fault = new InfoFault();
                fault.Type = "Required Info";
                fault.Message = "Yêu cầu nhập đầy đủ các thông bắt buộc (*): Địa chỉ, Quốc tịch, Dân tộc, Tôn giáo";
                lstFault.Add(fault);
            }
            if (Stu.Dienthoai != "")
            {
                if (IsNumber(Stu.Dienthoai) == false)
                {
                    fault = new InfoFault();
                    fault.Type = "Correctness";
                    fault.Message = "Số điện thoại phải là số";
                    lstFault.Add(fault);
                }
                else if (Stu.Dienthoai.Length < 8 || Stu.Dienthoai.Length > 12)
                {
                    fault = new InfoFault();
                    fault.Type = "Correctness";
                    fault.Message = "Số điện thoại ít nhất 8 số, nhiều nhất 12 số";
                    lstFault.Add(fault);
                }
            }
            if (Stu.Email != "")
            {
                if (IsValidEmail(Stu.Email) == false)
                {
                    fault = new InfoFault();
                    fault.Type = "Correctness";
                    fault.Message = "Email không đúng dạng";
                    lstFault.Add(fault);
                }
            }
            if (lstFault.Count != 0)
                throw new FaultException<InfoFault[]>(lstFault.ToArray());
            else
            {
                connect.Open_Connect();
                string query = "Update tbl_SinhVien" +
                    " Set DiaChi = N'" + Stu.Diachi + "', DienThoai = '" + Stu.Dienthoai + "', Email = '" + Stu.Email + "', QuocTich = N'" + Stu.Quoctich +
                    "', TonGiao = N'" + Stu.Tongiao + "', DanToc = N'" + Stu.Dantoc + "',HoTenCha = N'" + Stu.Hotencha + "', NgheNghiepCha = N'" + Stu.Nghenghiepcha + "', HoTenMe = N'" + Stu.Hotenme + "', NghenghiepMe = N'" + Stu.Nghenghiepme + "'" +
                               " Where MSSV = '" + Stu.Mssv + "'";
                SqlCommand cmd = new SqlCommand(query, connect.con);
                int roweff = cmd.ExecuteNonQuery();
                connect.Close_Connect();
                if (roweff != 0)
                {
                    return true;
                }
                else
                    return false;
            }

        }
        public void Send_Feedback(string code_student, string subject, string content)
        {
            if (subject == "" || content == "")
            {
                throw new FaultException("Tiêu đề và nội dung không được rỗng");
            }
            else
            {
                DateTime dtime = DateTime.Now;
                string query = "Insert Into tbl_PhanHoi Values('"+code_student+"','"+dtime+"','"+subject+"', '"+content+"','','0')";
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                cmd.ExecuteNonQuery();
                connect.Close_Connect();
            }
        }
        public Feedback[] Load_Feedback(string code_student)
        {
            string query = "Select * From tbl_PhanHoi Where Username = '"+code_student+"'";
            List<Feedback> lstFeedback = new List<Feedback>();
            Feedback fb;
            SqlDataReader sdr = null;
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    fb = new Feedback();
                    fb.Thoigian = sdr[2].ToString();
                    fb.Tieude = sdr[3].ToString();
                    fb.Noidung = sdr[4].ToString();
                    fb.Traloi = sdr[5].ToString();
                    fb.Trangthai = (bool)sdr[6];
                    lstFeedback.Add(fb);
                }
            }
            catch
            {
                lstFeedback = null;
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                if (connect.con != null)
                {
                    connect.Close_Connect();
                }

            }
            return lstFeedback.ToArray();
        }
        public Mark[] Get_Mark(string code_student, string code_subject)
        {
            List<Mark> lstKetQua = new List<Mark>();
            Mark mark = new Mark();
            SqlDataReader dr = null;
            string query = "Select MH.MaMonHoc, MH.TenMonHoc,MH.SoTinChi, MH.SoTiet, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai,KQ.HocKy, GV.HoTen As 'Giảng viên' "+
                "From tbl_KetQua KQ, tbl_MonHoc MH, tbl_GiangVien GV "+
                "Where KQ.MaMonHoc = MH.MaMonHoc And KQ.MSSV = '"+code_student+"' And KQ.MaMonHoc = '"+code_subject+"' And KQ.MSGV = GV.MSGV";
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Mark kq = new Mark();
                    kq.MaMH = dr[0].ToString();
                    kq.TenMH = dr[1].ToString();
                    kq.SoTC = (int)dr[2];
                    kq.SoTiet = (int)dr[3];
                    kq.DiemKT = float.Parse(dr[4].ToString());
                    kq.DiemThi = float.Parse(dr[5].ToString());
                    kq.DTB_h10 = float.Parse(dr[6].ToString());
                    kq.DTB_hchu = dr[7].ToString();
                    kq.DTB_h4 = float.Parse(dr[8].ToString());
                    kq.Tinhtrang = (bool)dr[9];
                    kq.Loai = dr[10].ToString();
                    kq.Hocky = dr[11].ToString();
                    kq.Giangvien = dr[12].ToString();
                    lstKetQua.Add(kq);
                }
            }
            catch
            {
                lstKetQua = null;
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (connect.con != null)
                {
                    connect.Close_Connect();
                }

            }
            return lstKetQua.ToArray();
        }
        public Mark[] Get_Mark(string code_student)
        {
            List<Mark> lstKetQua = new List<Mark>();
            SqlDataReader sdr = null;
            string query = "Select MH.MaMonHoc, MH.TenMonHoc,MH.SoTinChi, MH.SoTiet, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai,KQ.HocKy, GV.HoTen As 'Giảng viên' " +
                "From tbl_KetQua KQ, tbl_MonHoc MH, tbl_GiangVien GV " +
                "Where KQ.MaMonHoc = MH.MaMonHoc And KQ.MSSV = '" + code_student + "' And KQ.MSGV = GV.MSGV";
            //Select MH.MaMonHoc, MH.TenMonHoc,MH.SoTinChi, MH.SoTiet, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai,KQ.HocKy, GV.HoTen As 'Giảng viên' From tbl_KetQua KQ, tbl_MonHoc MH, tbl_GiangVien GV Where KQ.MaMonHoc = MH.MaMonHoc And KQ.MSSV = '070707' And KQ.HocKy = '08.1' And KQ.MSGV = GV.MSGV
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Mark kq = new Mark();
                    kq.MaMH = sdr[0].ToString();
                    kq.TenMH = sdr[1].ToString();
                    kq.SoTC = (int)sdr[2];
                    kq.SoTiet = (int)sdr[3];
                    kq.DiemKT = float.Parse(sdr[4].ToString());
                    kq.DiemThi = float.Parse(sdr[5].ToString());
                    kq.DTB_h10 = float.Parse(sdr[6].ToString());
                    kq.DTB_hchu = sdr[7].ToString();
                    kq.DTB_h4 = float.Parse(sdr[8].ToString());
                    kq.Tinhtrang = (bool)sdr[9];
                    kq.Loai = sdr[10].ToString();
                    kq.Hocky = sdr[11].ToString();
                    kq.Giangvien = sdr[12].ToString();
                    lstKetQua.Add(kq);
                }
            }
            catch
            {
                lstKetQua = null;
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                if (connect.con != null)
                {
                    connect.Close_Connect();
                }

            }
            return lstKetQua.ToArray();

        }
        public Student_Semester[] Info_Semester(string code_student)
        {
            List<Student_Semester> lst = new List<Student_Semester>();
            return lst.ToArray();
        }
        public float Get_Avg_Semester(string code_student, string semester)
        {
            string query = "Select ROUND(AVG(DTB_h4),2) From tbl_KetQua Where MSSV = '"+code_student+"' And HocKy = '"+semester+"'";
            connect.Open_Connect();
            SqlCommand cmd = new SqlCommand(query, connect.con);
            float result = float.Parse(cmd.ExecuteScalar().ToString());
            connect.Close_Connect();
            return result;
        }
        public float Get_Avg_Cumulative(string code_student)
        {
            string query = "Select ROUND(AVG(TBHK),2) As 'Trung bình tích lũy' From tbl_SV_HK Where MSSV = '"+code_student+"'";
            connect.Open_Connect();
            SqlCommand cmd = new SqlCommand(query, connect.con);
            float result = float.Parse(cmd.ExecuteScalar().ToString());
            connect.Close_Connect();
            return result;
        }
        public Lecturer Get_Info_Lec(string code_lecturer)
        {
            return new Lecturer();
        }
        public bool Update_Info_Lec(Lecturer lec)
        {
            return true;
        }
        public Subject[] Lec_Sub(string code_lecturer)
        {
            List<Subject> lst_sub = new List<Subject>();
            SqlDataReader sdr = null;
            Subject sub;
            string query = "Select Distinct KQ.HocKy,  MH.* From tbl_KetQua KQ, tbl_MonHoc MH Where MSGV = '" + code_lecturer + "'	And KQ.MaMonHoc = MH.MaMonHoc";
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    sub = new Subject();
                    sub.Semester = sdr[0].ToString();
                    sub.Code_sub = sdr[1].ToString();
                    sub.Name_sub = sdr[2].ToString();
                    sub.SoTC = (int)sdr[3];
                    sub.Sotiet = (int)sdr[4];
                    lst_sub.Add(sub);
                }
            }
            catch
            {
                lst_sub = null;
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                if (connect.con != null)
                {
                    connect.Close_Connect();
                }

            }
            return lst_sub.ToArray();
        }
        public Subject[] Lec_Sub(string code_lecturer, string semester)
        {
            List<Subject> lst_sub = new List<Subject>();
            SqlDataReader sdr = null;
            Subject sub;
            string query = "Select Distinct KQ.HocKy,  MH.* From tbl_KetQua KQ, tbl_MonHoc MH Where MSGV = '" + code_lecturer + "' And KQ.HocKy = '" + semester + "' And KQ.MaMonHoc = MH.MaMonHoc";
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    sub = new Subject();
                    sub.Semester = sdr[0].ToString();
                    sub.Code_sub = sdr[1].ToString();
                    sub.Name_sub = sdr[2].ToString();
                    sub.SoTC = (int)sdr[3];
                    sub.Sotiet = (int)sdr[4];
                    lst_sub.Add(sub);
                }
            }
            catch
            {
                lst_sub = null;
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                if (connect.con != null)
                {
                    connect.Close_Connect();
                }

            }
            return lst_sub.ToArray();
        }
        public List_Stu_Class[] List_Class(string code_lecturer, string code_subject, string semester)
        {
            List<List_Stu_Class> lst_stu = new List<List_Stu_Class>();
            SqlDataReader sdr = null;
            List_Stu_Class stu;
            string query = "Select SV.MSSV, SV.HoTen, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai " +
                            "From tbl_KetQua KQ, tbl_SinhVien SV " +
                            "Where KQ.MSGV = '" + code_lecturer + "' " +
                                            "And KQ.MaMonHoc ='" + code_subject + "' " +
                                            "And KQ.HocKy = '" + semester + "' " +
                                            "And KQ.MSSV = SV.MSSV";
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    stu = new List_Stu_Class();
                    stu.Mssv = sdr[0].ToString();
                    stu.Hoten = sdr[1].ToString();
                    stu.DiemKT = float.Parse(sdr[2].ToString());
                    stu.DiemThi = float.Parse(sdr[3].ToString());
                    stu.DTB_h10 = float.Parse(sdr[4].ToString());
                    stu.DTB_hchu = sdr[5].ToString();
                    stu.DTB_h4 = float.Parse(sdr[6].ToString());
                    stu.Tinhtrang = (bool)sdr[7];
                    stu.Loai = sdr[8].ToString();
                    lst_stu.Add(stu);
                }
            }
            catch
            {
                lst_stu = null;
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                if (connect.con != null)
                {
                    connect.Close_Connect();
                }

            }
            return lst_stu.ToArray();
        }
        //--------------------
        public float Get_Min_Mark(string code_lecturer, string code_subject, string semester)
        {
            string query = "Select MIN(DiemThi) From tbl_KetQua Where MSGV = '" + code_lecturer + "' " +
                                                            "And MaMonHoc ='" + code_subject + "' " +
                                                            "And HocKy = '" + semester + "'";
            connect.Open_Connect();
            SqlCommand cmd = new SqlCommand(query, connect.con);
            float result = float.Parse(cmd.ExecuteScalar().ToString());
            connect.Close_Connect();
            return result;
        }
        public float Get_Max_Mark(string code_lecturer, string code_subject, string semester)
        {
            string query = "Select MAX(DiemThi) From tbl_KetQua Where MSGV = '" + code_lecturer + "' " +
                                                            "And MaMonHoc ='" + code_subject + "' " +
                                                            "And HocKy = '" + semester + "'";
            connect.Open_Connect();
            SqlCommand cmd = new SqlCommand(query, connect.con);
            float result = float.Parse(cmd.ExecuteScalar().ToString());
            connect.Close_Connect();
            return result;
        }
        public float Get_Avg_Mark(string code_lecturer, string code_subject, string semester)
        {
            string query = "Select ROUND(AVG(DiemThi),1) From tbl_KetQua Where MSGV = '" + code_lecturer + "' " +
                                                            "And MaMonHoc ='" + code_subject + "' " +
                                                            "And HocKy = '" + semester + "'";
            connect.Open_Connect();
            SqlCommand cmd = new SqlCommand(query, connect.con);
            float result = float.Parse(cmd.ExecuteScalar().ToString());
            connect.Close_Connect();
            return result;
        }
        public int Class_Stu_Total(string code_lecturer, string code_subject, string semester) //thống kê sỉ số lớp MH
        {
            string query = "Select COUNT(*) From tbl_KetQua Where MSGV = '" + code_lecturer + "' " +
                                                            "And MaMonHoc ='" + code_subject + "' " +
                                                            "And HocKy = '" + semester + "'";
            connect.Open_Connect();
            SqlCommand cmd = new SqlCommand(query, connect.con);
            int result = (int)cmd.ExecuteScalar();
            connect.Close_Connect();
            return result;
        }
        public int Statistic_Mark_Equal(string code_lecturer, string code_subject, string semester, float mark) //thống kê điểm của 1 môn học, =
        {
            return 1;
        }
        public int Statistic_Mark_Distance(string code_lecturer, string code_subject, string semester, float from, float to) //thống kê điểm của 1 môn học, []
        {
            string query = "Select COUNT(*) From tbl_KetQua Where MSGV = '" + code_lecturer + "' " +
                            "And MaMonHoc ='" + code_subject + "' " +
                            "And HocKy = '" + semester + "' " +
                            "And DiemThi >= " + from + " and DiemThi < " + to + "";

            connect.Open_Connect();
            SqlCommand cmd = new SqlCommand(query, connect.con);
            int result = (int)cmd.ExecuteScalar();
            connect.Close_Connect();
            return result;
        }
        public int Statistic_Mark_Less(string code_lecturer, string code_subject, string semester, float mark) //thống kê điểm của 1 môn học, <
        {
            string query = "Select COUNT(*) From tbl_KetQua Where MSGV = '" + code_lecturer + "' " +
                            "And MaMonHoc ='" + code_subject + "' " +
                            "And HocKy = '" + semester + "' " +
                            "And DiemThi < " + mark + "";
            connect.Open_Connect();
            SqlCommand cmd = new SqlCommand(query, connect.con);
            int result = (int)cmd.ExecuteScalar();
            connect.Close_Connect();
            return result;
        }
        public int Statistic_Mark_Greater(string code_lecturer, string code_subject, string semester, float mark) //thống kê điểm của 1 môn học, >
        {
            string query = "Select COUNT(*) From tbl_KetQua Where MSGV = '" + code_lecturer + "' " +
                            "And MaMonHoc ='" + code_subject + "' " +
                            "And HocKy = '" + semester + "' " +
                            "And DiemThi > " + mark + "";
            connect.Open_Connect();
            SqlCommand cmd = new SqlCommand(query, connect.con);
            int result = (int)cmd.ExecuteScalar();
            connect.Close_Connect();
            return result;
        }
        public Statistic_Mark Statistic_Mark_General(string code_lecturer, string code_subject, string semester) //thống kê điểm của 1 môn học, >
        {
            Statistic_Mark sta_mark = new Statistic_Mark();
            sta_mark.Total = Class_Stu_Total(code_lecturer, code_subject, semester);
            sta_mark.Less_than_5 = Statistic_Mark_Less(code_lecturer, code_subject, semester, 5);
            sta_mark.Distance_5_8 = Statistic_Mark_Distance(code_lecturer, code_subject, semester, 5, 8);
            sta_mark.Distance_8_10 = Statistic_Mark_Distance(code_lecturer, code_subject, semester, 8, 11);
            sta_mark.Max_mark = Get_Max_Mark(code_lecturer, code_subject, semester);
            sta_mark.Min_mark = Get_Min_Mark(code_lecturer, code_subject, semester);
            sta_mark.Avg_mark = Get_Avg_Mark(code_lecturer, code_subject, semester);
            return sta_mark;
        }

        //Get thông tin SV có điểm thi min, max
        public Student Get_Student_Min_Mark(string code_lecturer, string code_subject, string semester) //Get thông tin SV có điểm thi MIN
        {
            return new Student();
        }
        public Student Get_Student_Max_Mark(string code_lecturer, string code_subject, string semester)//Get thông tin SV có điểm thi MAX
        {
            return new Student();
        }

        //Get thông tin SV có điểm trung bình  min, max
        public Student Get_Student_Min_Avg(string code_lecturer, string code_subject, string semester) //Get thông tin SV có điểm trung bình  MIN
        {
            return new Student();
        }
        public Student Get_Student_Max_Avg(string code_lecturer, string code_subject, string semester)//Get thông tin SV có điểm trung bình  MAX
        {
            return new Student();
        }

        //Thống kê trung bình môn:  max, min, avg
        public float Get_Max_Avg(string code_lecturer, string code_subject, string semester) //trung bình môn thấp nhất của 1 môn học trong hk
        {
            return 1;
        }
        public float Get_Min_Avg(string code_lecturer, string code_subject, string semester)//trung bình môn cao nhất của 1 môn học trong hk
        {
            return 1;
        }
        public float Get_Avg_Avg(string code_lecturer, string code_subject, string semester) //trung bình môn trung bình của 1 môn học trong hk
        {
            return 1;
        }

        //Thống kê trung bình môn theo ý muốn: =, >, <, []
        public int Statistic_Avg_Equal(string code_lecturer, string code_subject, string semester, float mark) //thống kê trung bình môn của 1 môn học, =
        {
            return 1;
        }
        public int Statistic_Avg_Distance(string code_lecturer, string code_subject, string semester, float from, float to) //thống kê trung bình môn của 1 môn học, []
        {
            return 1;
        }
        public int Statistic_Avg_Less(string code_lecturer, string code_subject, string semester, float mark) //thống kê trung bình môn của 1 môn học, <
        {
            return 1;
        }
        public int Statistic_Avg_Greater(string code_lecturer, string code_subject, string semester, float mark) //thống kê trung bình môn của 1 môn học, >
        {
            return 1;
        }
        
        public Mark[] Get_Mark_Semester(string code_student, string semester) ////xem kết quả các môn học trong học kỳ - bảng điểm
        {
            List<Mark> lstKetQua = new List<Mark>();
            SqlDataReader sdr = null;
            string query = "Select MH.MaMonHoc, MH.TenMonHoc As 'Tên môn học',MH.SoTinChi, MH.SoTiet, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai, KQ.HocKy, GV.HoTen " +
                           "From tbl_KetQua KQ, tbl_MonHoc MH, tbl_GiangVien GV " +
                           "Where KQ.MaMonHoc = MH.MaMonHoc And KQ.MSGV = GV.MSGV And KQ.MSSV = '" + code_student + "' And KQ.HocKy = '" + semester + "'";
            //Select MH.MaMonHoc, MH.TenMonHoc,MH.SoTinChi, MH.SoTiet, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai,KQ.HocKy, GV.HoTen As 'Giảng viên' From tbl_KetQua KQ, tbl_MonHoc MH, tbl_GiangVien GV Where KQ.MaMonHoc = MH.MaMonHoc And KQ.MSSV = '070707' And KQ.HocKy = '08.1' And KQ.MSGV = GV.MSGV
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Mark kq = new Mark();
                    kq.MaMH = sdr[0].ToString();
                    kq.TenMH = sdr[1].ToString();
                    kq.SoTC = (int)sdr[2];
                    kq.SoTiet = (int)sdr[3];
                    kq.DiemKT = float.Parse(sdr[4].ToString());
                    kq.DiemThi = float.Parse(sdr[5].ToString());
                    kq.DTB_h10 = float.Parse(sdr[6].ToString());
                    kq.DTB_hchu = sdr[7].ToString();
                    kq.DTB_h4 = float.Parse(sdr[8].ToString());
                    kq.Tinhtrang = (bool)sdr[9];
                    kq.Loai = sdr[10].ToString();
                    kq.Hocky = sdr[11].ToString();
                    kq.Giangvien = sdr[12].ToString();
                    lstKetQua.Add(kq);
                }
            }
            catch
            {
                lstKetQua = null;
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                if (connect.con != null)
                {
                    connect.Close_Connect();
                }

            }
            return lstKetQua.ToArray();
        }
        public Student_Semester Info_Semester(string MSSV, string HK) ////thông tin kết quả một học kỳ
        {
            Student_Semester Sv_HK = new Student_Semester();
            DataTable dt = new DataTable();
            string query = "Select * From tbl_SV_HK Where MSSV = '" + MSSV + "' And HocKy = '" + HK + "'";
            connect.Open_Connect();
            SqlDataAdapter adap = new SqlDataAdapter(query, connect.con);
            adap.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                Sv_HK.Mssv = dt.Rows[0][0].ToString();
                Sv_HK.Hocky = dt.Rows[0][1].ToString();
                Sv_HK.TBHK = float.Parse(dt.Rows[0][2].ToString()); ;
                Sv_HK.TC_dk_HK = Convert.ToInt32(dt.Rows[0][3]);
                Sv_HK.TC_dat_HK = Convert.ToInt32(dt.Rows[0][4]);
            }
            else
                Sv_HK = null;

            connect.Close_Connect();
            return Sv_HK;
        }
        public Statistic_Student Info_Statistic_Stu_General(string code_student) //thống kê tổng quát sinh viên
        {
            Statistic_Student infoSta = new Statistic_Student();
            SqlCommand cmd;
            SqlDataAdapter adap;
            DataTable dt;
            string query_TongMH = "Select COUNT(distinct MaMonHoc) From tbl_KetQua Where MSSV = '" + code_student + "'";
            string query_TongMH_no = "Select COUNT(distinct MaMonHoc) From tbl_KetQua Where MSSV = '" + code_student + "' and TinhTrang = 0";
            string query_TinChi_TB = "Select SUM(SoTC_DangKy_HK) As 'Số tín chỉ đăng ký', SUM(SoTC_Dat_HK) As 'Số tín chỉ đạt được', ROUND(AVG(TBHK),2) As 'Trung bình tích lũy' From tbl_SV_HK Where MSSV = '" + code_student + "'";
            string query_ThongkeLoai = "Select Loai,COUNT(*) As 'Count' From tbl_KetQua Where MSSV = '" + code_student + "' Group by Loai";
            try
            {
                connect.Open_Connect();
                SqlConnection con = connect.con;

                cmd = new SqlCommand(query_TongMH, con);
                infoSta.TongMH = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand(query_TongMH_no, con);
                infoSta.TongMH_no = (int)cmd.ExecuteScalar();

                adap = new SqlDataAdapter(query_TinChi_TB, con);
                dt = new DataTable();
                adap.Fill(dt);
                infoSta.TongTC_dk = (int)(dt.Rows[0][0]);
                infoSta.TongTC_dat = (int)(dt.Rows[0][1]);
                infoSta.TB_tichluy = float.Parse(dt.Rows[0][2].ToString());

                SqlDataReader dr;
                cmd = new SqlCommand(query_ThongkeLoai, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    switch (dr[0].ToString())
                    {
                        case "Xuất sắc": infoSta.Tong_xuatsac = (int)dr[1];
                            break;
                        case "Giỏi": infoSta.Tong_gioi = (int)dr[1];
                            break;
                        case "Khá": infoSta.Tong_kha = (int)dr[1];
                            break;
                        case "Trung bình": infoSta.Tong_trungbinh = (int)dr[1];
                            break;
                        case "Kém": infoSta.Tong_kem = (int)dr[1];
                            break;
                    }
                }
            }
            catch
            {

                infoSta = null;
            }

            return infoSta;
        }
        public string[] List_Semester()
        {
            List<string> lst = new List<string>();
            SqlDataReader sdr = null;
            string query = "Select HocKy From tbl_HocKy";
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    lst.Add(sdr[0].ToString());
                }
            }
            finally
            {
                connect.Close_Connect();
            }
            return lst.ToArray();
        }

        public Subject[] List_Subject()
        {
            Subject sub;
            List<Subject> lstSub = new List<Subject>();
            SqlDataReader sdr = null;
            string query = "Select * From tbl_MonHoc";
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    sub = new Subject();
                    sub.Code_sub = sdr[0].ToString();
                    sub.Name_sub = sdr[1].ToString();
                    lstSub.Add(sub);
                }
            }
            catch
            {
                lstSub = null;
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
                if (connect.con != null)
                {
                    connect.Close_Connect();
                }

            }
            return lstSub.ToArray();
        }
        public int Download(string path)
        {
            /*FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            Thread.Sleep(100000);*/

            return 1;
        }
        public byte[] GetResource(string resName)
        {
            //Ca 1 nghe thuat^^
            string filepath = HostPath + @"Sources\" + resName;
            FileStream fs = File.OpenRead(filepath);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return bytes;
        }
        public bool CheckLogin(string username, string password, int mode)
        {

            DataSet ds = new DataSet();
            if (username == "" || password == "")
            {
                fault = new InfoFault();
                fault.Type = "ArgumentException";
                fault.Message = "Username and Password is not null";
                throw new FaultException<InfoFault>(fault);
            }
            else
            {
                switch (mode)
                {
                    case 0:
                        {
                            string query = "Select * From tbl_SinhVien Where MSSV = '" + username + "' And MatKhau = '" + password + "'";
                            try
                            {
                                connect.Open_Connect();
                                SqlDataAdapter adap = new SqlDataAdapter(query, connect.con);
                                adap.Fill(ds);
                                connect.Close_Connect();
                                if (ds.Tables[0].Rows.Count != 0)
                                {
                                    return true;
                                }
                                else
                                    return false;
                            }
                            catch (Exception)
                            {

                                return false;
                            }
                        }
                    case 1:
                        {
                            string query = "Select * From tbl_SinhVien Where MSSV = '" + username + "' And MatKhauGD = '" + password + "'";
                            try
                            {
                                connect.Open_Connect();
                                SqlDataAdapter adap = new SqlDataAdapter(query, connect.con);
                                adap.Fill(ds);
                                connect.Close_Connect();
                                if (ds.Tables[0].Rows.Count != 0)
                                {
                                    return true;
                                }
                                else
                                    return false;
                            }
                            catch (Exception)
                            {

                                return false;
                            }

                        }
                    case 2:
                        {
                            string query = "Select * From tbl_GiangVien Where MSGV = '" + username + "' And MatKhau = '" + password + "'";
                            try
                            {
                                connect.Open_Connect();
                                SqlDataAdapter adap = new SqlDataAdapter(query, connect.con);
                                adap.Fill(ds);
                                connect.Close_Connect();
                                if (ds.Tables[0].Rows.Count != 0)
                                {
                                    return true;
                                }
                                else
                                    return false;
                            }
                            catch (Exception)
                            {

                                return false;
                            }

                        }
                    default: { return false; }
                }
            }
        }
        //----------------------------------------
        public bool IsNumber(string str)
        {
            foreach (char c in str)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                int nFirt = int.Parse(email.Substring(0, 1));
                return false;
            }
            catch
            {
                string pattern = @"^[_a-zA-Z0-9][_.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[_.a-zA-Z0-9]+)*\.
    (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|vn|[a-zA-Z]{2})$";
                //Regular expression object
                Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
                //boolean variable to return to calling method
                bool valid = false;

                //make sure an email address was provided
                if (string.IsNullOrEmpty(email))
                {
                    valid = false;
                }
                else
                {
                    //use IsMatch to validate the address
                    valid = check.IsMatch(email.ToLower());
                }
                //return the value to the calling method
                return valid;
            }
        }
    }
}
