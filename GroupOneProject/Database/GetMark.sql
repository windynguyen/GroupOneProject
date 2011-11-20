Select COUNT(distinct MaMonHoc) As 'Số môn còn nợ' From tbl_KetQua Where MSSV = '070707' and TinhTrang = 0

Select Loai,COUNT(*) As 'Count' From tbl_KetQua Where MSSV = '070707' Group by Loai
Select COUNT(distinct MaMonHoc) As 'Tổng số môn đã học' From tbl_KetQua Where MSSV = '070707'
Select SUM(SoTC_DangKy_HK) As 'Số tín chỉ đăng ký', SUM(SoTC_Dat_HK) As 'Số tín chỉ đạt được', ROUND(AVG(TBHK),2) As 'Trung bình tích lũy' From tbl_SV_HK Where MSSV = '070707'
