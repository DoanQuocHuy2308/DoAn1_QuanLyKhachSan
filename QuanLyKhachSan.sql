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
    ID_KhuyenMai INT IDENTITY(0,1) PRIMARY KEY,
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
	ID_KhuyenMai INT FOREIGN KEY REFERENCES KhuyenMai(ID_KhuyenMai),
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
	ID_KhuyenMai INT FOREIGN KEY REFERENCES KhuyenMai(ID_KhuyenMai),
	SoLuong INT NOT NULL,
	NgayDat DATETIME NOT NULL,
	TongTien DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL,
    HinhThucThanhToan NVARCHAR(100) NOT NULL,
    KetQua NVARCHAR(100) NOT NULL
);

-- Chèn dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (Ten_NhanVien, CMND_NhanVien, SDT_NhanVien, GioiTinh_NhanVien, Email_NhanVien, DiaChi_NhanVien, Role_NhanVien)
VALUES 
    (N'Nguyễn Văn A', '123456789', '0987654321', N'Nam', 'nguyenvana@example.com', N'123 Đường ABC, Quận XYZ, TP HCM', N'Quản lý'),
    (N'Trần Thị B', '987654321', '0123456789', N'Nữ', 'tranthib@example.com', N'456 Đường XYZ, Quận ABC, TP HCM', N'Nhân viên'),
    (N'Lê Văn C', '456789123', '0912345678', N'Nam', 'levanc@example.com', N'789 Đường XYZ, Quận ABC, TP HCM', N'Nhân viên');

-- Chèn dữ liệu vào bảng TaiKhoan
INSERT INTO TaiKhoan (Email_TaiKhoan, Pass_TaiKhoan, Role_TaiKhoan, Ban_TaiKhoan)
VALUES 
    ('doanquochuy23082004@gmail.com', '1', N'Admin', 0),
    ('doanhuypc2308@gmail.com', '1', N'Nhân viên', 1), 
    ('doanhuypc2004@gmail.com', '2', N'Nhân viên', 0);

-- Chèn dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (Ten_KhachHang, Tuoi_KhachHang, CMND_KhachHang, GioiTinh_KhachHang, Email_KhachHang, SDT_KhachHang, DiaChi_KhachHang)
VALUES 
    (N'Phạm Thị D', 30, '012345678', N'Nữ', 'doanquochuy23082004@gmail.com', '0987654321', N'321 Đường XYZ, Quận ABC, TP HCM'),
    (N'Nguyễn Văn E', 25, '987654321', N'Nam', 'doanhuypc2308@gmail.com', '0123456789', N'654 Đường ABC, Quận XYZ, TP HCM'),
    (N'Trần Văn F', 40, '456789012', N'Nam', 'doanhuypc2004@gmail.com', '0912345678', N'987 Đường XYZ, Quận ABC, TP HCM');

-- Chèn dữ liệu vào bảng LoaiPhong
INSERT INTO LoaiPhong (Ten_LoaiPhong, SucChua, Gia_Phong)
VALUES 
    (N'Phòng Đơn', 1, 100000),
    (N'Phòng Đôi', 2, 150000),
    (N'Phòng Gia Đình', 4, 250000);

-- Chèn dữ liệu vào bảng Phong
INSERT INTO Phong (Ten_Phong, ID_LoaiPhong)
VALUES 
    ('101', 1),
    ('201', 2),
    ('301', 3);

-- Chèn dữ liệu vào bảng DatPhong
INSERT INTO DatPhong (ID_NhanVien, ID_KhachHang, ID_Phong, ID_KhuyenMai, Check_In, Check_Out, TienCoc, TongTien, TrangThai, HinhThucThanhToan, KetQua)
VALUES 
    (1, 1, 1, NULL, '2024-05-10', '2024-05-12', 50000, 200000, N'Đã Thanh Toán', N'Tiền Mặt', N'Đang Hoạt Động'),
    (2, 2, 2, 1, '2024-06-15', '2024-06-18', 80000, 300000, N'Đã Thanh Toán', N'Quẹt Thẻ', N'Chưa Hoạt Động'),
    (3, 3, 3, NULL, '2024-07-20', '2024-07-25', 100000, 500000, N'Chưa Thanh Toán', N'Chuyển Khoản', N'Đang Hoạt Động');

-- Chèn dữ liệu vào bảng LoaiDichVu
INSERT INTO LoaiDichVu (Ten_LoaiDichVu)
VALUES 
    (N'Đồ uống'),
    (N'Đồ ăn'),
    (N'Dịch vụ giặt là');

-- Chèn dữ liệu vào bảng DichVu
INSERT INTO DichVu (ID_LoaiDichVu, Ten_DichVu, Gia_DichVu)
VALUES 
    (1, N'Nước suối', 10000),
    (2, N'Cơm rang', 50000),
    (3, N'Giặt áo thường', 20000);

-- Chèn dữ liệu vào bảng DatDichVu
INSERT INTO DatDichVu (ID_NhanVien, ID_KhachHang, ID_DichVu, ID_KhuyenMai, SoLuong, NgayDat, TongTien, TrangThai, HinhThucThanhToan, KetQua)
VALUES 
    (1, 1, 1, NULL, 2, '2024-05-11', 20000, N'Đã thanh toán', N'Tiền mặt', N'Đặt dịch vụ thành công'),
    (2, 2, 2, 1, 3, '2024-06-16', 135000, N'Đã thanh toán', N'Thẻ tín dụng', N'Đặt dịch vụ thành công'),
    (3, 3, 3, NULL, 1, '2024-07-21', 20000, N'Chưa thanh toán', N'Chuyển khoản', N'Đặt dịch vụ thành công');

-- Chèn dữ liệu vào bảng KhuyenMai
INSERT INTO KhuyenMai (Ten_KhuyenMai, GiaTri, MoTa, NgayBatDau, NgayKetThuc)
VALUES 
	(N'Không Giảm Giá',0, N'Áp dụng cho tất cả các chương trình','2024-05-01', '2024-05-31'),
    (N'Giảm giá 10%', 0.1, N'Áp dụng cho tất cả dịch vụ', '2024-05-01', '2024-05-31'),
    (N'Giảm giá 20%', 0.2, N'Áp dụng cho các phòng loại Phòng Gia Đình', '2024-06-01', '2024-06-30'),
    (N'Giảm giá 30%', 0.3, N'Áp dụng cho các đơn đặt phòng trên 3 ngày', '2024-07-01', '2024-07-31');



