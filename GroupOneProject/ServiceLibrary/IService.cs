using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Data;
using System.Net.Security;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ServiceLibrary
{
    //Interface Service: định nghĩa các hàm cung cấp cho client
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Member> GetAuthors();
        [OperationContract]
        int Download(string path);
        [OperationContract]
        byte[] GetResource(string resName);
        
        //Hàm cơ bản
        [OperationContract]
        bool CheckLogin(string username, string password, int mode); //kiểm tra đăng nhập
        [OperationContract]
        bool ChangePassword(string username, string old_password, string new_password, int mode); //đổi mật khẩu đăng nhập
        [OperationContract]
        string[] List_Semester();//xuất danh sách học kỳ cho client
        [OperationContract]
        Subject[] List_Subject();//xuất danh sách môn học cho client
        //-------------------------------------------------------------------------------------------------------------
        //Sinh Viên
        [OperationContract]
        Student Get_Info_Stu(string code_student); //lấy thông tin
        [OperationContract]
        bool Update_Info_Stu(Student Stu); //cập nhật profile
        //Overloading

        //Xem điểm môn học
        [OperationContract(Name = "Mark_Subject_Single")]
        Mark Get_Mark(string code_student, string code_subject); //xem kết quả 1 môn học của SV
        [OperationContract(Name = "Mark_Subject_All")]
        Mark[] Get_Mark(string code_student);//xem kết quả tất cả các môn đã học (trong tất các các học kỳ)
        [OperationContract]
        Mark[] Get_Mark_Semester(string code_student, string semester);//xem kết quả các môn học trong học kỳ - bảng điểm
        
        //kết quả học tập theo học kỳ của SV
        [OperationContract(Name = "Info_Stu_Sem_Only")]
        Student_Semester Info_Semester(string code_student, string semester); //thông tin kết quả một học kỳ
        [OperationContract(Name = "Info_Stu_Sem_All")]
        Student_Semester[] Info_Semester(string code_student); //thông tin kết quả tất cả các học kỳ
        
        [OperationContract]
        float Get_Avg_Semester (string code_student, string semester);//get trung bình học kỳ
        [OperationContract]
        float Get_Avg_Cumulative (string code_student, string semester);//get trung bình tích lũy
        [OperationContract]
        Statistic_Student Info_Statistic_Stu_General(string code_student); //thống kê SV tổng quát
        
        //-----------------------------------------------------------------------------------------------------------------
        //Giảng viên
        [OperationContract]
        Lecturer Get_Info_Lec(string code_lecturer); //lấy thông tin
        [OperationContract]
        bool Update_Info_Lec(Lecturer lec); //cập nhật profile
        [OperationContract(Name = "Lec_Sub_All")]
        Subject[] Lec_Sub(string code_lecturer); // danh sách tất cả các môn GV đã dạy
        [OperationContract(Name = "Lec_Sub_Single")]
        Subject[] Lec_Sub(string code_lecturer, string semester); // danh sách các môn GV đã dạy trong 1 học kỳ cụ thể
        [OperationContract]
        List_Stu_Class[] List_Class(string code_lecturer, string code_subject, string semester); // danh sách sinh viên và bảng điểm của 1 lớp môn học
        
        //WCF ko hỗ trợ override

        //Thống kê điểm thi: max, min, avg
        [OperationContract]
        float Get_Min_Mark(string code_lecturer, string code_subject, string semester); //điểm thi thấp nhất của 1 môn học trong hk
        [OperationContract]
        float Get_Max_Mark(string code_lecturer, string code_subject, string semester);//điểm thi cao nhất của 1 môn học trong hk
        [OperationContract]
        float Get_Avg_Mark(string code_lecturer, string code_subject, string semester); //điểm thi trung bình của 1 môn học trong hk

        //Thống kê điểm thi môn theo ý muốn: =, >, <, []
        [OperationContract]
        int Class_Stu_Total(string code_lecturer, string code_subject, string semester); //thống kê sỉ số lớp MH
        [OperationContract]
        int Statistic_Mark_Equal(string code_lecturer, string code_subject, string semester, float mark); //thống kê điểm của 1 môn học, =
        [OperationContract]
        int Statistic_Mark_Distance(string code_lecturer, string code_subject, string semester, float from, float to); //thống kê điểm của 1 môn học, []
        [OperationContract]
        int Statistic_Mark_Less(string code_lecturer, string code_subject, string semester, float mark); //thống kê điểm của 1 môn học, <
        [OperationContract]
        int Statistic_Mark_Greater(string code_lecturer, string code_subject, string semester, float mark); //thống kê điểm của 1 môn học, >

        //Thống kê điểm thi tổng quát, là tập hợp các thống kê về điểm thi xây dựng ở trên: total, < 5, min, max, avg
        [OperationContract]
        Statistic_Mark Statistic_Mark_General(string code_lecturer, string code_subject, string semester); //thống kê điểm của 1 môn học, >


        //Get thông tin SV có điểm thi min, max
        [OperationContract]
        Student Get_Student_Min_Mark(string code_lecturer, string code_subject, string semester); //Get thông tin SV có điểm thi MIN
        [OperationContract]
        Student Get_Student_Max_Mark(string code_lecturer, string code_subject, string semester);//Get thông tin SV có điểm thi MAX
        
        //Get thông tin SV có điểm trung bình  min, max
        [OperationContract]
        Student Get_Student_Min_Avg(string code_lecturer, string code_subject, string semester); //Get thông tin SV có điểm trung bình  MIN
        [OperationContract]
        Student Get_Student_Max_Avg(string code_lecturer, string code_subject, string semester);//Get thông tin SV có điểm trung bình  MAX

        //Thống kê trung bình môn:  max, min, avg
        [OperationContract]
        float Get_Max_Avg(string code_lecturer, string code_subject, string semester); //trung bình môn thấp nhất của 1 môn học trong hk
        [OperationContract]
        float Get_Min_Avg(string code_lecturer, string code_subject, string semester);//trung bình môn cao nhất của 1 môn học trong hk
        [OperationContract]
        float Get_Avg_Avg(string code_lecturer, string code_subject, string semester); //trung bình môn trung bình của 1 môn học trong hk

        //Thống kê trung bình môn theo ý muốn: =, >, <, []
        [OperationContract]
        int Statistic_Avg_Equal(string code_lecturer, string code_subject, string semester, float mark); //thống kê trung bình môn của 1 môn học, =
        [OperationContract]
        int Statistic_Avg_Distance(string code_lecturer, string code_subject, string semester, float from, float to); //thống kê trung bình môn của 1 môn học, []
        [OperationContract]
        int Statistic_Avg_Less(string code_lecturer, string code_subject, string semester, float mark); //thống kê trung bình môn của 1 môn học, <
        [OperationContract]
        int Statistic_Avg_Greater(string code_lecturer, string code_subject, string semester, float mark); //thống kê trung bình môn của 1 môn học, >

                
    }
    /// <summary>
    /// ///DataContract
    /// </summary>
    [DataContract]
    public class Lecturer
    { }
    [DataContract]
    public class Subject
    {
        private string semester;
        private string code_sub;
        private string name_sub;
        private int soTC;
        private int sotiet;
        [DataMember]
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        [DataMember]
        public string Code_sub
        {
            get { return code_sub; }
            set { code_sub = value; }
        }
        [DataMember]
        public string Name_sub
        {
            get { return name_sub; }
            set { name_sub = value; }
        }
        [DataMember]
        public int SoTC
        {
            get { return soTC; }
            set { soTC = value; }
        }
        [DataMember]
        public int Sotiet
        {
            get { return sotiet; }
            set { sotiet = value; }
        }
    }
    [DataContract]
    public class List_Stu_Class
    {
        private string mssv;
        private string hoten;
        private float diemKT;
        private float diemThi;
        private float TB_h10;
        private string TB_hchu;
        private float TB_h4;
        private bool tinhtrang;
        private string loai;
        
        [DataMember]
        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }
        [DataMember]
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        [DataMember]
        public float DiemKT
        {
            get { return diemKT; }
            set { diemKT = value; }
        }
        [DataMember]
        public float DiemThi
        {
            get { return diemThi; }
            set { diemThi = value; }
        }
        [DataMember]
        public float DTB_h10
        {
            get { return TB_h10; }
            set { TB_h10 = value; }
        }
        [DataMember]
        public string DTB_hchu
        {
            get { return TB_hchu; }
            set { TB_hchu = value; }
        }
        [DataMember]
        public float DTB_h4
        {
            get { return TB_h4; }
            set { TB_h4 = value; }
        }

        [DataMember]
        public bool Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        [DataMember]
        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }
    }
    [DataContract]
    public class Statistic_Mark
    {
        private int total;
        private int less_than_5;
        private int distance_5_8;
        private int distance_8_10;
        private float min_mark;
        private float max_mark;
        private float avg_mark;
        
        [DataMember]
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        [DataMember]
        public int Less_than_5
        {
            get { return less_than_5; }
            set { less_than_5 = value; }
        }
        [DataMember]
        public int Distance_5_8
        {
            get { return distance_5_8; }
            set { distance_5_8 = value; }
        }
        [DataMember]
        public int Distance_8_10
        {
            get { return distance_8_10; }
            set { distance_8_10 = value; }
        }
        [DataMember]
        public float Min_mark
        {
            get { return min_mark; }
            set { min_mark = value; }
        }
        [DataMember]
        public float Max_mark
        {
            get { return max_mark; }
            set { max_mark = value; }
        }
        [DataMember]
        public float Avg_mark
        {
            get { return avg_mark; }
            set { avg_mark = value; }
        }
    }
    [DataContract]
    public class Member
    {
        private string code;
        private string fullname;
        private string _class;

        [DataMember]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        [DataMember]
        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }
        [DataMember]
        public string _Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public Member(string _code, string _fullname, string __class)
        {
            this.code = _code;
            this.fullname = _fullname;
            this._Class = __class;
        }
    }
    //-------------------------------------------------------------------------------
    [DataContract]
    public class Student
    {
        private string mssv;
        private string hoten;
        private int gioitinh;
        private string ngaysinh;
        private string noisinh;
        private string lop;
        private string nganh;
        private string khoa;
        private string heDT;
        private string khoahoc;
        private int tongTC_DT;
        private string diachi;
        private string dienthoai;
        private string email;
        private string dantoc;
        private string tongiao;
        private string quoctich;
        private string hotencha;
        private string nghenghiepcha;
        private string hotenme;
        private string nghenghiepme;

        [DataMember]
        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }
        [DataMember]
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        [DataMember]
        public int Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        [DataMember]
        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        [DataMember]
        public string Noisinh
        {
            get { return noisinh; }
            set { noisinh = value; }
        }
        [DataMember]
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        [DataMember]
        public string Nganh
        {
            get { return nganh; }
            set { nganh = value; }
        }
        [DataMember]
        public string Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }
        [DataMember]
        public string HeDT
        {
            get { return heDT; }
            set { heDT = value; }
        }
        [DataMember]
        public string Khoahoc
        {
            get { return khoahoc; }
            set { khoahoc = value; }
        }
        [DataMember]
        public int TongTC
        {
            get { return tongTC_DT; }
            set { tongTC_DT = value; }
        }
        [DataMember]
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        [DataMember]
        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public string Dantoc
        {
            get { return dantoc; }
            set { dantoc = value; }
        }
        [DataMember]
        public string Tongiao
        {
            get { return tongiao; }
            set { tongiao = value; }
        }
        [DataMember]
        public string Quoctich
        {
            get { return quoctich; }
            set { quoctich = value; }
        }
        [DataMember]
        public string Hotencha
        {
            get { return hotencha; }
            set { hotencha = value; }
        }
        [DataMember]
        public string Nghenghiepcha
        {
            get { return nghenghiepcha; }
            set { nghenghiepcha = value; }
        }
        [DataMember]
        public string Hotenme
        {
            get { return hotenme; }
            set { hotenme = value; }
        }
        [DataMember]
        public string Nghenghiepme
        {
            get { return nghenghiepme; }
            set { nghenghiepme = value; }
        }
    }
    //-----------------------------------------------------------------
    [DataContract]
    public class Mark
    {
        private string maMH;
        private string tenMH;
        private int soTC;
        private int soTiet;
        private float diemKT;
        private float diemThi;
        private float TB_h10;
        private string TB_hchu;
        private float TB_h4;
        private bool tinhtrang;
        private string loai;
        private string hocky;
        private string giangvien;

        [DataMember]
        public int SoTC
        {
            get { return soTC; }
            set { soTC = value; }
        }
        [DataMember]
        public int SoTiet
        {
            get { return soTiet; }
            set { soTiet = value; }
        }
        [DataMember]
        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        [DataMember]
        public string TenMH
        {
            get { return tenMH; }
            set { tenMH = value; }
        }
        [DataMember]
        public float DiemKT
        {
            get { return diemKT; }
            set { diemKT = value; }
        }
        [DataMember]
        public float DiemThi
        {
            get { return diemThi; }
            set { diemThi = value; }
        }
        [DataMember]
        public float DTB_h10
        {
            get { return TB_h10; }
            set { TB_h10 = value; }
        }
        [DataMember]
        public string DTB_hchu
        {
            get { return TB_hchu; }
            set { TB_hchu = value; }
        }
        [DataMember]
        public float DTB_h4
        {
            get { return TB_h4; }
            set { TB_h4 = value; }
        }
        
        [DataMember]
        public bool Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        [DataMember]
        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }
        [DataMember]
        public string Hocky
        {
            get { return hocky; }
            set { hocky = value; }
        }
        [DataMember]
        public string Giangvien
        {
            get { return giangvien; }
            set { giangvien = value; }
        }
    }
    //------------------------------------------------------
    [DataContract]
    public class Student_Semester
    {
        private string mssv;
        private string hocky;
        private float tbhk;
        private int tc_dk_hk;
        private int tc_dat_hk;

        [DataMember]
        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }
        [DataMember]
        public string Hocky
        {
            get { return hocky; }
            set { hocky = value; }
        }
        [DataMember]
        public float TBHK
        {
            get { return tbhk; }
            set { tbhk = value; }
        }
        [DataMember]
        public int TC_dat_HK
        {
            get { return tc_dat_hk; }
            set { tc_dat_hk = value; }
        }
        [DataMember]
        public int TC_dk_HK
        {
            get { return tc_dk_hk; }
            set { tc_dk_hk = value; }
        }

    }
    //-------------------------------------------------------------------------------
    [DataContract]
    public class Statistic_Student
    {
        private int tongMH;
        private int tongMH_no;
        private int tongTC_dk;
        private int tongTC_dat;
        private float tb_tichluy;
        private int tong_xuatsac;
        private int tong_gioi;
        private int tong_kha;
        private int tong_trungbinh;
        private int tong_kem;

        public Statistic_Student()
        {
            this.tongMH = 0;
            this.tongMH_no = 0;
            this.tongTC_dk = 0;
            this.tongTC_dat = 0;
            this.tb_tichluy = 0;
            this.tong_gioi = 0;
            this.tong_kha = 0;
            this.tong_trungbinh = 0;
            this.tong_kem = 0;
        }

        [DataMember]
        public int TongMH
        {
            get { return tongMH; }
            set { tongMH = value; }
        }
        [DataMember]
        public int TongMH_no
        {
            get { return tongMH_no; }
            set { tongMH_no = value; }
        }
        [DataMember]
        public int TongTC_dk
        {
            get { return tongTC_dk; }
            set { tongTC_dk = value; }
        }
        [DataMember]
        public int TongTC_dat
        {
            get { return tongTC_dat; }
            set { tongTC_dat = value; }
        }
        [DataMember]
        public float TB_tichluy
        {
            get { return tb_tichluy; }
            set { tb_tichluy = value; }
        }
        [DataMember]
        public int Tong_xuatsac
        {
            get { return tong_xuatsac; }
            set { tong_xuatsac = value; }
        }
        [DataMember]
        public int Tong_gioi
        {
            get { return tong_gioi; }
            set { tong_gioi = value; }
        }
        [DataMember]
        public int Tong_kha
        {
            get { return tong_kha; }
            set { tong_kha = value; }
        }
        [DataMember]
        public int Tong_trungbinh
        {
            get { return tong_trungbinh; }
            set { tong_trungbinh = value; }
        }
        [DataMember]
        public int Tong_kem
        {
            get { return tong_kem; }
            set { tong_kem = value; }
        }
    }
}
