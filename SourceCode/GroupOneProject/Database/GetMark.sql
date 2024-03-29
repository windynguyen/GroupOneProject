/*Select COUNT(distinct MaMonHoc) As 'Số môn còn nợ' From tbl_KetQua Where MSSV = '070707' and TinhTrang = 0

Select Loai,COUNT(*) As 'Count' From tbl_KetQua Where MSSV = '070707' Group by Loai
Select COUNT(distinct MaMonHoc) As 'Tổng số môn đã học' From tbl_KetQua Where MSSV = '070707'
*/
--Select SUM(SoTC_DangKy_HK) As 'Số tín chỉ đăng ký', SUM(SoTC_Dat_HK) As 'Số tín chỉ đạt được', ROUND(AVG(TBHK),2) As 'Trung bình tích lũy' From tbl_SV_HK Where MSSV = '070707'
Select MH.* From tbl_KetQua KQ,tbl_MonHoc MH Where MSSV ='070707' And KQ.MaMonHoc = MH.MaMonHoc And TenMonHoc like N'%quản trị%'
Select MH.* From tbl_KetQua KQ,tbl_MonHoc MH Where MSSV ='070707' And KQ.MaMonHoc = MH.MaMonHoc And MH.MaMonHoc = 'QT302DV01'
--Select ROUND(AVG(DTB_h4),2) From tbl_KetQua Where MSSV = '070707' And HocKy = '08.1'
--SV: kết quả 1 môn học
--[OperationContract]
 --KetQua Mark_Subject_Single(string code_student, string code_subject);

--Select MH.MaMonHoc, MH.TenMonHoc,MH.SoTinChi, MH.SoTiet, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai,KQ.HocKy, GV.HoTen As 'Giảng viên' From tbl_KetQua KQ, tbl_MonHoc MH, tbl_GiangVien GV Where KQ.MaMonHoc = MH.MaMonHoc And KQ.MSSV = '080808' And KQ.MSGV = GV.MSGV


--GV:liệt kê danh sách SV và kết quả lớp môn học do 1 GV nào đó dạy, theo học kỳ
        
/*Select SV.MSSV, SV.HoTen, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai From tbl_KetQua KQ, tbl_SinhVien SV Where KQ.MSGV = 'GV9999' 
							And KQ.MaMonHoc ='TC306DV01' 
							And KQ.HocKy = '08.1'
							And KQ.MSSV = SV.MSSV
*/

/*-----Sinh Viên:
--Liệt kê tất cả kết quả học tập của SV	
[OperationContract]
 List_Stu_Class[] List_Class(string code_lecturer, string code_subject, string semester); // danh sách sinh viên của 1 lớp môn học
					
Select KQ.HocKy, MH.MaMonHoc, MH.TenMonHoc, MH.SoTinChi, KQ.DiemKiemTra, KQ.DiemThi, KQ.DTB_h10, KQ.DTB_hchu, KQ.DTB_h4, KQ.TinhTrang, KQ.Loai, GV.HoTen As 'Giảng viên' From tbl_KetQua KQ, tbl_MonHoc MH, tbl_GiangVien GV Where MSSV = '070707' 
												And KQ.MaMonHoc = MH.MaMonHoc
												And KQ.MSGV = GV.MSGV
												Order by HocKy
*/

--- Kết quả các học kỳ đã học
--Select * From tbl_SV_HK Where MSSV = '070707'

--Giảng Viên
--: Thống kê
----Thống kê điểm thi theo ý muốn: =, >, <, [], max, min, avg
----Thống kê TB môn theo ý muốn: =, >, <, [], max, min, avg


--Điểm thi dưới 5
/*
Select * From tbl_KetQua Where MSGV = 'GV9999' 
							And MaMonHoc ='TC306DV01' 
							And HocKy = '08.1'*/
/*
Select COUNT(*) From tbl_KetQua Where MSGV = 'GV9999' 
							And MaMonHoc ='TC306DV01' 
							And HocKy = '08.1'
							And DiemThi < 5 UNION
Select COUNT(*) From tbl_KetQua Where MSGV = 'GV9999' 
							And MaMonHoc ='TC306DV01' 
							And HocKy = '08.1'
Select COUNT(*) From tbl_KetQua Where MSGV = 'GV9999' 
							And MaMonHoc ='TC306DV01' 
							And HocKy = '08.1'
							And DiemThi >= 5 and DiemThi < 8

Select COUNT(*) From tbl_KetQua Where MSGV = 'GV9999' 
							And MaMonHoc ='TC306DV01' 
							And HocKy = '08.1'
							And DiemThi >= 8 and DiemThi < 11
*/
----------------/*
/*Select MAX(DiemThi) From tbl_KetQua Where MSGV = 'GV9999' 
							And MaMonHoc ='TC306DV01' 
							And HocKy = '08.1'
Select MIN(DiemThi) From tbl_KetQua Where MSGV = 'GV9999' 
							And MaMonHoc ='TC306DV01' 
							And HocKy = '08.1'

Select ROUND(AVG(DiemThi),1) From tbl_KetQua Where MSGV = 'GV9999' 
							And MaMonHoc ='TC306DV01' 
							And HocKy = '08.1'*/



----Liệt kê danh sách các môn học GV đã dạy

--[OperationContract]
      --  Subject[] Lec_Sub_All(string code_lecturer);

--Select Distinct KQ.HocKy,  MH.* From tbl_KetQua KQ, tbl_MonHoc MH Where MSGV = 'GV9999'
--																And KQ.MaMonHoc = MH.MaMonHoc



------------------
--Danh sách các giảng viên đã từng dạy môn này
--Select distinct GV.* From tbl_KetQua KQ, tbl_GiangVien GV Where KQ.MaMonHoc = 'TIN353DV01' And KQ.MSGV = GV.MSGV

--Thông tin sinh viên có điểm thi cao nhất
/*Select SV.* From tbl_KetQua KQ, tbl_SinhVien SV Where KQ.MSSV = SV.MSSV
												And KQ.MaMonHoc = 'TIN353DV01'
												And KQ.MSGV = 'GV3333'
												And KQ.HocKy = '09.1'
												And DiemThi = (Select Max(DiemThi) From tbl_KetQua Where MaMonHoc= 'TIN353DV01' 
																										And MSGV = 'GV3333'
																										And HocKy = '09.1')
	*/											