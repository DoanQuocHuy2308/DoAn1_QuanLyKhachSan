CREATE DATABASE QuanLyKhachSan;
GO

USE QuanLyKhachSan;
GO

CREATE TABLE NhanVien
(
    ID_NhanVien INT IDENTITY(1,1) PRIMARY KEY,
    Ten_NhanVien NVARCHAR(255) NOT NULL,
    CMND_NhanVien VARCHAR(20) NOT NULL UNIQUE,
    SDT_NhanVien VARCHAR(15) NOT NULL UNIQUE, 
    GioiTinh_NhanVien NVARCHAR(10) NOT NULL,
    Email_NhanVien VARCHAR(100) NOT NULL UNIQUE, 
    DiaChi_NhanVien NVARCHAR(500) NOT NULL,
    Role_NhanVien NVARCHAR(50) 
);

CREATE TABLE TaiKhoan
(
    ID_TaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
	Email_TaiKhoan VARCHAR(100) NOT NULL UNIQUE, 
    Pass_TaiKhoan VARCHAR(50) NOT NULL,
    Role_TaiKhoan NVARCHAR(50) NOT NULL,
    Ban_TaiKhoan INT NOT NULL DEFAULT 0
);

CREATE TABLE KhachHang
(
    ID_KhachHang INT IDENTITY(1,1) PRIMARY KEY,
    Ten_KhachHang NVARCHAR(255) NOT NULL,
    Tuoi_KhachHang INT NOT NULL,
    CMND_KhachHang VARCHAR(20) NOT NULL UNIQUE, 
    GioiTinh_KhachHang NVARCHAR(10) NOT NULL,
    Email_KhachHang VARCHAR(100) NOT NULL UNIQUE, 
    SDT_KhachHang VARCHAR(15) NOT NULL UNIQUE, 
    DiaChi_KhachHang NVARCHAR(500) NOT NULL
);

CREATE TABLE KhuyenMai
(
    ID_KhuyenMai VARCHAR(100) PRIMARY KEY,
    Ten_KhuyenMai NVARCHAR(255) NOT NULL,
    GiaTri DECIMAL(18,2) NOT NULL,
    MoTa NVARCHAR(MAX),
    NgayBatDau DATETIME NOT NULL, 
    NgayKetThuc DATETIME NOT NULL 
);
CREATE TABLE LoaiPhong
(
    ID_LoaiPhong INT IDENTITY(1,1) PRIMARY KEY,
    Ten_LoaiPhong NVARCHAR(255) NOT NULL,
    SucChua INT NOT NULL,
    Gia_Phong DECIMAL(18,2) NOT NULL
);

CREATE TABLE Phong
(
    ID_Phong INT IDENTITY(1,1) PRIMARY KEY,
    Ten_Phong NVARCHAR(100) NOT NULL,
    ID_LoaiPhong INT FOREIGN KEY REFERENCES LoaiPhong(ID_LoaiPhong)
);

CREATE TABLE DatPhong
(
    ID_DatPhong INT IDENTITY(1,1) PRIMARY KEY,
	ID_NhanVien INT NOT NULL FOREIGN KEY REFERENCES NhanVien(ID_NhanVien),
    ID_KhachHang INT NOT NULL FOREIGN KEY REFERENCES KhachHang(ID_KhachHang),
    ID_Phong INT NOT NULL FOREIGN KEY REFERENCES Phong(ID_Phong),
	ID_KhuyenMai VARCHAR(100) FOREIGN KEY REFERENCES KhuyenMai(ID_KhuyenMai),
    Check_In DATETIME NOT NULL, 
    Check_Out DATETIME NOT NULL,
    TienCoc DECIMAL(18,2) NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL,
    HinhThucThanhToan NVARCHAR(100) NOT NULL,
    KetQua NVARCHAR(100) NOT NULL
);

CREATE TABLE LoaiDichVu
(
    ID_LoaiDichVu INT IDENTITY(1,1) PRIMARY KEY,
    Ten_LoaiDichVu NVARCHAR(255) NOT NULL
);

CREATE TABLE DichVu
(
    ID_DichVu INT IDENTITY(1,1) PRIMARY KEY,
    ID_LoaiDichVu INT FOREIGN KEY REFERENCES LoaiDichVu(ID_LoaiDichVu),
    Ten_DichVu NVARCHAR(255) NOT NULL,
    Gia_DichVu DECIMAL(18,2) NOT NULL
);

CREATE TABLE DatDichVu
(
	ID_DatDichVu INT IDENTITY(1,1) PRIMARY KEY,
	ID_NhanVien INT NOT NULL FOREIGN KEY REFERENCES NhanVien(ID_NhanVien),
	ID_KhachHang INT NOT NULL FOREIGN KEY REFERENCES KhachHang(ID_KhachHang),
	ID_DichVu INT NOT NULL FOREIGN KEY REFERENCES DichVu(ID_DichVu),
	ID_KhuyenMai VARCHAR(100) FOREIGN KEY REFERENCES KhuyenMai(ID_KhuyenMai),
	SoLuong INT NOT NULL,
	NgayDat DATETIME NOT NULL,
	TongTien DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL,
    HinhThucThanhToan NVARCHAR(100) NOT NULL,
    KetQua NVARCHAR(100) NOT NULL
);

-- Chèn dữ liệu vào bảng TaiKhoan
INSERT INTO TaiKhoan (Email_TaiKhoan, Pass_TaiKhoan, Role_TaiKhoan, Ban_TaiKhoan)
VALUES 
    ('doanquochuy23082004@gmail.com', '1', N'Admin', 0),
    ('doanhuypc2308@gmail.com', '1', N'Nhân viên', 1), 
    ('doanhuypc2004@gmail.com', '2', N'Nhân viên', 0);
-- Chèn dữ liệu vào bảng KhuyenMai
INSERT INTO KhuyenMai (ID_KhuyenMai,Ten_KhuyenMai, GiaTri, MoTa, NgayBatDau, NgayKetThuc)
VALUES 
	(0,N'Không Giảm Giá',0, N'Áp dụng cho tất cả các chương trình','2024-05-01', '2024-05-31'),
    (1,N'Giảm giá 10%', 0.1, N'Áp dụng cho tất cả dịch vụ', '2024-05-01', '2024-05-31'),
    (2,N'Giảm giá 20%', 0.2, N'Áp dụng cho các phòng loại Phòng Gia Đình', '2024-06-01', '2024-06-30'),
    (3,N'Giảm giá 30%', 0.3, N'Áp dụng cho các đơn đặt phòng trên 3 ngày', '2024-07-01', '2024-07-31');



