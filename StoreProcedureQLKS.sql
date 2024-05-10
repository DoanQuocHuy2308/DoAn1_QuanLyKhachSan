use QuanLyKhachSan
go

--Hiển thị dữ liệu phòng
create procedure HienThiDuLieuPhong
as
begin
	select ID_Phong,Ten_Phong,lp.ID_LoaiPhong,Ten_LoaiPhong,SucChua,Gia_Phong from Phong as p
	inner join LoaiPhong as lp on lp.ID_LoaiPhong= p.ID_LoaiPhong
end

--tìm kiếm phòng
CREATE PROCEDURE TimKiemPhong
    @Search NVARCHAR(500) = NULL,
    @IDPhong INT = NULL,
    @TenPhong NVARCHAR(500) = NULL,
    @IDLoaiPhong INT = NULL
AS
BEGIN
    SELECT p.ID_Phong, p.Ten_Phong, lp.ID_LoaiPhong, lp.Ten_LoaiPhong, lp.SucChua, lp.Gia_Phong
    FROM Phong AS p
    INNER JOIN LoaiPhong AS lp ON lp.ID_LoaiPhong = p.ID_LoaiPhong
    WHERE (p.Ten_Phong LIKE '%' + @Search + '%' OR @Search IS NULL)
          AND (p.ID_Phong = @IDPhong OR @IDPhong IS NULL)
          AND (p.Ten_Phong LIKE '%' + @TenPhong + '%' OR @TenPhong IS NULL)
          AND (p.ID_LoaiPhong = @IDLoaiPhong OR @IDLoaiPhong IS NULL)
END

--Hiển thị dịch vụ
create procedure HienThiDuLieuDichVu
as
begin
	select dv.ID_DichVu, dv.Ten_DichVu , ldv.ID_LoaiDichVu , ldv.Ten_LoaiDichVu, dv.Gia_DichVu  from DichVu as dv
	inner join LoaiDichVu as ldv on dv.ID_LoaiDichVu=ldv.ID_LoaiDichVu
end

--Tìm kiếm dịch vụ
CREATE PROCEDURE TimKiemDichVu
    @Search NVARCHAR(500) = NULL,
    @IDDichVu INT = NULL,
    @TenDichVu NVARCHAR(500) = NULL,
    @IDLoaiDichVu INT = NULL,
	@GiaDichVu Decimal = null
AS
BEGIN
    SELECT dv.ID_DichVu, dv.Ten_DichVu, ldv.ID_LoaiDichVu, ldv.Ten_LoaiDichVu ,dv.Gia_DichVu
    FROM DichVu AS dv
    INNER JOIN LoaiDichVu AS ldv ON ldv.ID_LoaiDichVu=ldv.ID_LoaiDichVu
    WHERE (dv.Ten_DichVu LIKE '%' + @Search + '%' OR @Search IS NULL)
          AND (dv.ID_DichVu = @IDDichVu OR @IDDichVu IS NULL)
          AND (dv.Ten_DichVu LIKE '%' + @TenDichVu + '%' OR @TenDichVu IS NULL)
          AND (ldv.ID_LoaiDichVu = @IDLoaiDichVu OR @IDLoaiDichVu IS NULL)
		  AND (dv.Gia_DichVu >= @GiaDichVu OR @GiaDichVu IS NULL)
END

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
	SELECT dp.ID_DatPhong, kh.Ten_KhachHang, p.Ten_Phong , lp.Ten_LoaiPhong, lp.SucChua  FROM DatPhong AS dp 
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
    SELECT dp.ID_DatPhong,dp.ID_NhanVien,nv.Ten_NhanVien,kh.Ten_KhachHang,p.Ten_Phong,lp.Ten_LoaiPhong,lp.SucChua,
	lp.Gia_Phong,km.Ten_KhuyenMai,dp.Check_In,dp.Check_Out,dp.TienCoc,dp.TongTien,dp.TrangThai
    FROM DatPhong dp
    INNER JOIN NhanVien nv ON dp.ID_NhanVien = nv.ID_NhanVien
    INNER JOIN KhachHang kh ON dp.ID_KhachHang = kh.ID_KhachHang
    INNER JOIN Phong p ON dp.ID_Phong = p.ID_Phong
    INNER JOIN LoaiPhong lp ON p.ID_LoaiPhong = lp.ID_LoaiPhong
    LEFT JOIN KhuyenMai km ON dp.ID_KhuyenMai = km.ID_KhuyenMai
    WHERE dp.ID_DatPhong = @IDDatPhong;
END








