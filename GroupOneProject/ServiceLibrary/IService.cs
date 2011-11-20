using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Net.Security;

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
        [OperationContract]
        bool CheckLogin(string username, string password, int mode);
        [OperationContract]
        SinhVien GetInfoSV(string MSSV);
        //[OperationContract]
        //DataTable GetInfoSV_New(string MSSV);
        [OperationContract]
        bool UpdateInfoSV(SinhVien SV);
        [OperationContract]
        string[] List_HK();
        [OperationContract]
        KetQua[] KetQua_HK(string MSSV, string HK);
        [OperationContract]
        SV_HK InfoSV_HK(string MSSV, string HK);
        [OperationContract]
        Statistic Info_Statistic(string MSSV);
    }
    /// <summary>
    /// ///DataContract
    /// </summary>
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
    public class SinhVien
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
    public class KetQua
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
    }
    //------------------------------------------------------
    [DataContract]
    public class SV_HK
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
    public class Statistic
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

        public Statistic()
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
