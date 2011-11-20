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

namespace ServiceLibrary
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetMark_Service : IService
    {
        public static string HostPath = "";
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

        //public DataTable GetInfoSV_New(string MSSV)
        //{
        //    DataTable dt = new DataTable();
        //    //string query = "Select * From tbl_SinhVien Where MSSV = '" + MSSV + "'";
        //    string query = "Select * From tbl_SinhVien";
        //    connect.Open_Connect();
        //    SqlDataAdapter adap = new SqlDataAdapter(query, connect.con);
        //    adap.Fill(dt);
        //    return dt;
        //}

        public SinhVien GetInfoSV(string MSSV)
        {
            SinhVien SV = new SinhVien();
            DataTable dt = new DataTable();
            string query = "Select * From tbl_SinhVien Where MSSV = '" + MSSV + "'";
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
        public bool UpdateInfoSV(SinhVien SV)
        {
            connect.Open_Connect();
            string query = "Update tbl_SinhVien"+
                " Set DiaChi = N'" + SV.Diachi + "', DienThoai = '" + SV.Dienthoai + "', Email = '" + SV.Email + "', QuocTich = N'" + SV.Quoctich +
                "', TonGiao = N'" + SV.Tongiao + "', DanToc = N'" + SV.Dantoc + "',HoTenCha = N'" + SV.Hotencha + "', NgheNghiepCha = N'" + SV.Nghenghiepcha + "', HoTenMe = N'" + SV.Hotenme + "', NghenghiepMe = N'" + SV.Nghenghiepme + "'" +
                           " Where MSSV = '"+SV.Mssv+"'";
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
        public KetQua[] KetQua_HK(string MSSV, string HK)
        {
            List<KetQua> lstKetQua = new List<KetQua>();
            SqlDataReader sdr = null;
            //string query = "select MH.MaMonHoc, MH.TenMonHoc,MH.SoTinChi, MH.SoTiet, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai  from tbl_KetQua KQ, tbl_MonHoc MH where KQ.MaMonHoc = MH.MaMonHoc And KQ.MSSV = '070707' And KQ.HocKy = '08.1'";
            string query = "Select MH.MaMonHoc, MH.TenMonHoc,MH.SoTinChi, MH.SoTiet, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai "+
                           "From tbl_KetQua KQ, tbl_MonHoc MH "+
                           "Where KQ.MaMonHoc = MH.MaMonHoc And KQ.MSSV = '"+ MSSV +"' And KQ.HocKy = '"+ HK +"'";
            try
            {
                connect.Open_Connect();
                SqlCommand cmd = new SqlCommand(query, connect.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    KetQua kq = new KetQua();
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
                if (connect.con !=null)
                {
                    connect.Close_Connect();
                }
                
            }
            return lstKetQua.ToArray();
        }
        public SV_HK InfoSV_HK(string MSSV, string HK)
        {
            SV_HK Sv_HK = new SV_HK();
            DataTable dt = new DataTable();
            string query = "Select * From tbl_SV_HK Where MSSV = '"+MSSV+"' And HocKy = '"+HK+"'";
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
        public Statistic Info_Statistic(string MSSV)
        {
            Statistic infoSta = new Statistic();
            SqlCommand cmd;
            SqlDataAdapter adap;
            DataTable dt;
            string query_TongMH = "Select COUNT(distinct MaMonHoc) From tbl_KetQua Where MSSV = '" + MSSV + "'";
            string query_TongMH_no = "Select COUNT(distinct MaMonHoc) From tbl_KetQua Where MSSV = '" + MSSV + "' and TinhTrang = 0";
            string query_TinChi_TB = "Select SUM(SoTC_DangKy_HK) As 'Số tín chỉ đăng ký', SUM(SoTC_Dat_HK) As 'Số tín chỉ đạt được', ROUND(AVG(TBHK),2) As 'Trung bình tích lũy' From tbl_SV_HK Where MSSV = '" + MSSV + "'";
            string query_ThongkeLoai = "Select Loai,COUNT(*) As 'Count' From tbl_KetQua Where MSSV = '" + MSSV + "' Group by Loai";
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
        public string[] List_HK()
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
            switch (mode)
            {
                case 0: 
                    {
                        string query = "Select * From tbl_SinhVien Where MSSV = '"+ username +"' And MatKhau = '"+ password +"'";
                        try
                        {
                            connect.Open_Connect();
                            SqlDataAdapter adap = new SqlDataAdapter(query,connect.con);
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
                        string query = "Select * From tbl_MatKhauGD Where MSSV = '" + username + "' And MatKhau_GiaDinh = '" + password + "'";
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
}
