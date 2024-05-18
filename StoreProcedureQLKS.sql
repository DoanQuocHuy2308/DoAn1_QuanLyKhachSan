use QuanLyKhachSan
go

--xóa nhân viên
CREATE PROCEDURE DeleteNhanVien
    @ID_NhanVien INT
AS
BEGIN
    DELETE FROM TaiKhoan WHERE Email_TaiKhoan = (SELECT Email_NhanVien FROM NhanVien WHERE ID_NhanVien = @ID_NhanVien);
    DELETE FROM NhanVien WHERE ID_NhanVien = @ID_NhanVien;
END

--xóa tài khoản
CREATE PROCEDURE DeleteTaiKhoan
    @ID_TaiKhoan INT
AS
BEGIN
    DELETE FROM NhanVien WHERE Email_NhanVien = (SELECT Email_TaiKhoan FROM TaiKhoan WHERE ID_TaiKhoan = @ID_TaiKhoan);
    DELETE FROM TaiKhoan WHERE ID_TaiKhoan = @ID_TaiKhoan;
END

--xóa khách hàng
CREATE PROCEDURE DeleteKhachHang
    @ID_KhachHang INT
AS
BEGIN
	DELETE FROM DatPhong WHERE ID_KhachHang = (SELECT ID_KhachHang FROM KhachHang WHERE ID_KhachHang = @ID_KhachHang);
	DELETE FROM DatDichVu WHERE ID_KhachHang = (SELECT ID_KhachHang FROM KhachHang WHERE ID_KhachHang = @ID_KhachHang);
	DELETE FROM ChiTietHoaDon WHERE ID_HoaDon = (SELECT ID_HoaDon FROM HoaDon WHERE ID_KhachHang = @ID_KhachHang);
    DELETE FROM HoaDon WHERE ID_KhachHang = (SELECT ID_KhachHang FROM KhachHang WHERE ID_KhachHang = @ID_KhachHang);
    DELETE FROM KhachHang WHERE ID_KhachHang = @ID_KhachHang;
END

--hiển thị phòng trống
create procedure KTPhongTrong
	@Check_In date,
	@Check_Out date
as
begin
	select ID_Phong,Ten_Phong,lp.ID_LoaiPhong,Ten_LoaiPhong,SucChua,Gia_Phong from Phong as p
	inner join LoaiPhong as lp on lp.ID_LoaiPhong= p.ID_LoaiPhong
	 WHERE p.ID_Phong NOT IN ( SELECT DISTINCT ID_Phong FROM DatPhong WHERE Check_In <= @Check_Out AND Check_Out >= @Check_In )
end

--In Phòng Được Đặt
CREATE PROCEDURE InPhongDat
	@IDDatPhong INT
AS
BEGIN
	SELECT dp.ID_DatPhong, kh.ID_KhachHang, kh.Ten_KhachHang, p.Ten_Phong , lp.Ten_LoaiPhong, lp.SucChua  FROM DatPhong AS dp 
	INNER JOIN KhachHang kh ON dp.ID_KhachHang = kh.ID_KhachHang
    INNER JOIN Phong p ON dp.ID_Phong = p.ID_Phong
    INNER JOIN LoaiPhong lp ON p.ID_LoaiPhong = lp.ID_LoaiPhong
	WHERE dp.ID_DatPhong =@IDDatPhong
END

--In Đơn Đặt Phòng
CREATE PROCEDURE InDonDatPhong
    @IDDatPhong INT
AS
BEGIN
    SELECT dp.ID_DatPhong,dp.ID_NhanVien,nv.Ten_NhanVien,kh.Ten_KhachHang, kh.GioiTinh_KhachHang ,kh.SDT_KhachHang , kh.DiaChi_KhachHang 
	,p.Ten_Phong,lp.Ten_LoaiPhong,lp.SucChua,lp.Gia_Phong,km.Ten_KhuyenMai,dp.Check_In,dp.Check_Out,dp.TienCoc,dp.TongTien,dp.TrangThai
    FROM DatPhong dp
    INNER JOIN NhanVien nv ON dp.ID_NhanVien = nv.ID_NhanVien
    INNER JOIN KhachHang kh ON dp.ID_KhachHang = kh.ID_KhachHang
    INNER JOIN Phong p ON dp.ID_Phong = p.ID_Phong
    INNER JOIN LoaiPhong lp ON p.ID_LoaiPhong = lp.ID_LoaiPhong
    LEFT JOIN KhuyenMai km ON dp.ID_KhuyenMai = km.ID_KhuyenMai
    WHERE dp.ID_DatPhong = @IDDatPhong;
END

--In Hóa Đơn Đặt Dịch Vụ
CREATE PROCEDURE InDonDatDichVu
	@IDKhachHang INT
AS
BEGIN
	SELECT ddv.ID_DatDichVu, ddv.ID_NhanVien,nv.Ten_NhanVien, kh.Ten_KhachHang, kh.SDT_KhachHang, dv.Ten_DichVu, ldv.Ten_LoaiDichVu , ddv.SoLuong, 
	dv.Gia_DichVu, km.Ten_KhuyenMai, ddv.NgayDat ,ddv.TongTien,ddv.TrangThai
	FROM DatDichVu ddv
	INNER JOIN NhanVien nv on ddv.ID_NhanVien = nv.ID_NhanVien
	INNER JOIN KhachHang kh on ddv.ID_KhachHang = kh.ID_KhachHang
	INNER JOIN DichVu dv on ddv.ID_DichVu = dv.ID_DichVu
	INNER JOIN LoaiDichVu ldv on ldv.ID_LoaiDichVu = dv.ID_LoaiDichVu
	LEFT JOIN KhuyenMai km on km.ID_KhuyenMai = ddv.ID_KhuyenMai
	WHERE ddv.ID_KhachHang = @IDKhachHang
END

--Thống Kê Đơn Đặt Phòng
CREATE PROCEDURE ThongKeDonDatPhong
    @Check_In DATETIME = NULL,
    @Check_Out DATETIME = NULL,
    @Ten_Phong NVARCHAR(100) = NULL,
    @Ten_LoaiPhong NVARCHAR(255) = NULL
AS
BEGIN
    SELECT dp.ID_DatPhong, p.Ten_Phong, lp.Ten_LoaiPhong, kh.Ten_KhachHang,
           kh.SDT_KhachHang, dp.Check_In, dp.Check_Out, dp.TienCoc, km.Ten_KhuyenMai, dp.TongTien,
           SUM(dp.TongTien) OVER () AS Tong
    FROM DatPhong dp
    JOIN Phong p ON dp.ID_Phong = p.ID_Phong
    JOIN LoaiPhong lp ON p.ID_LoaiPhong = lp.ID_LoaiPhong
    JOIN KhachHang kh ON dp.ID_KhachHang = kh.ID_KhachHang
    LEFT JOIN KhuyenMai km ON dp.ID_KhuyenMai = km.ID_KhuyenMai
    WHERE (@Check_In IS NULL OR (dp.Check_In <= @Check_Out AND dp.Check_Out >= @Check_In))
      AND (@Ten_Phong IS NULL OR p.Ten_Phong LIKE '%' + @Ten_Phong + '%')
      AND (@Ten_LoaiPhong IS NULL OR lp.Ten_LoaiPhong LIKE '%' + @Ten_LoaiPhong + '%');
END

--Thống kê đơn đặt dịch vụ
CREATE PROCEDURE ThongKeDonDatDichVu
    @NgayBatDau DATETIME = NULL,
    @NgayKetThuc DATETIME = NULL,
    @Ten_DichVu NVARCHAR(255) = NULL,
    @Ten_LoaiDichVu NVARCHAR(255) = NULL
AS
BEGIN
    SELECT ddv.ID_DatDichVu, kh.Ten_KhachHang, kh.SDT_KhachHang, ddv.NgayDat, dv.Ten_DichVu, ldv.Ten_LoaiDichVu,
           ddv.SoLuong, km.Ten_KhuyenMai, ddv.TongTien , SUM(ddv.TongTien) OVER () AS DoanhThu
    FROM DatDichVu ddv
    JOIN DichVu dv ON ddv.ID_DichVu = dv.ID_DichVu
    JOIN LoaiDichVu ldv ON dv.ID_LoaiDichVu = ldv.ID_LoaiDichVu
    JOIN KhachHang kh ON ddv.ID_KhachHang = kh.ID_KhachHang
    LEFT JOIN KhuyenMai km ON ddv.ID_KhuyenMai = km.ID_KhuyenMai
    WHERE (@NgayBatDau IS NULL OR ddv.NgayDat >= @NgayBatDau)
      AND (@NgayKetThuc IS NULL OR ddv.NgayDat <= @NgayKetThuc)
      AND (@Ten_DichVu IS NULL OR dv.Ten_DichVu LIKE '%' + @Ten_DichVu + '%')
      AND (@Ten_LoaiDichVu IS NULL OR ldv.Ten_LoaiDichVu LIKE '%' + @Ten_LoaiDichVu + '%');
END










