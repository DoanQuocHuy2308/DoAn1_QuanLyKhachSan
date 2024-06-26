USE [master]
GO
/****** Object:  Database [QuanLyKhachSan]    Script Date: 5/22/2024 10:15:57 PM ******/
CREATE DATABASE [QuanLyKhachSan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhachSan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DOANQUOCHUY\MSSQL\DATA\QuanLyKhachSan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyKhachSan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DOANQUOCHUY\MSSQL\DATA\QuanLyKhachSan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyKhachSan] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhachSan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhachSan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhachSan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyKhachSan] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhachSan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhachSan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhachSan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKhachSan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKhachSan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyKhachSan', N'ON'
GO
ALTER DATABASE [QuanLyKhachSan] SET QUERY_STORE = OFF
GO
USE [QuanLyKhachSan]
GO
/****** Object:  Table [dbo].[DatDichVu]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatDichVu](
	[ID_DatDichVu] [int] IDENTITY(1,1) NOT NULL,
	[ID_NhanVien] [int] NOT NULL,
	[ID_KhachHang] [int] NOT NULL,
	[ID_DichVu] [int] NOT NULL,
	[ID_KhuyenMai] [varchar](100) NULL,
	[SoLuong] [int] NOT NULL,
	[NgayDat] [datetime] NOT NULL,
	[TongTien] [decimal](18, 2) NOT NULL,
	[TrangThai] [nvarchar](20) NOT NULL,
	[HinhThucThanhToan] [nvarchar](100) NOT NULL,
	[KetQua] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_DatDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatPhong](
	[ID_DatPhong] [int] IDENTITY(1,1) NOT NULL,
	[ID_NhanVien] [int] NOT NULL,
	[ID_KhachHang] [int] NOT NULL,
	[ID_Phong] [int] NOT NULL,
	[ID_KhuyenMai] [varchar](100) NULL,
	[Check_In] [datetime] NOT NULL,
	[Check_Out] [datetime] NOT NULL,
	[TienCoc] [decimal](18, 2) NOT NULL,
	[TongTien] [decimal](18, 2) NOT NULL,
	[TrangThai] [nvarchar](20) NOT NULL,
	[HinhThucThanhToan] [nvarchar](100) NOT NULL,
	[KetQua] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_DatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[ID_DichVu] [int] IDENTITY(1,1) NOT NULL,
	[ID_LoaiDichVu] [int] NULL,
	[Ten_DichVu] [nvarchar](255) NOT NULL,
	[Gia_DichVu] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_DichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID_KhachHang] [int] IDENTITY(1,1) NOT NULL,
	[Ten_KhachHang] [nvarchar](255) NOT NULL,
	[Tuoi_KhachHang] [int] NOT NULL,
	[CMND_KhachHang] [varchar](20) NOT NULL,
	[GioiTinh_KhachHang] [nvarchar](10) NOT NULL,
	[Email_KhachHang] [varchar](100) NOT NULL,
	[SDT_KhachHang] [varchar](15) NOT NULL,
	[DiaChi_KhachHang] [nvarchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CMND_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SDT_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[ID_KhuyenMai] [varchar](100) NOT NULL,
	[Ten_KhuyenMai] [nvarchar](255) NOT NULL,
	[GiaTri] [decimal](18, 2) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[NgayKetThuc] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_KhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDichVu]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDichVu](
	[ID_LoaiDichVu] [int] IDENTITY(1,1) NOT NULL,
	[Ten_LoaiDichVu] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_LoaiDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[ID_LoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[Ten_LoaiPhong] [nvarchar](255) NOT NULL,
	[SucChua] [int] NOT NULL,
	[Gia_Phong] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_LoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID_NhanVien] [int] IDENTITY(1,1) NOT NULL,
	[Ten_NhanVien] [nvarchar](255) NOT NULL,
	[CMND_NhanVien] [varchar](20) NOT NULL,
	[SDT_NhanVien] [varchar](15) NOT NULL,
	[GioiTinh_NhanVien] [nvarchar](10) NOT NULL,
	[Email_NhanVien] [varchar](100) NOT NULL,
	[DiaChi_NhanVien] [nvarchar](500) NOT NULL,
	[Role_NhanVien] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CMND_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SDT_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[ID_Phong] [int] IDENTITY(1,1) NOT NULL,
	[Ten_Phong] [nvarchar](100) NOT NULL,
	[ID_LoaiPhong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Phong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID_TaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[Email_TaiKhoan] [varchar](100) NOT NULL,
	[Pass_TaiKhoan] [varchar](50) NOT NULL,
	[Role_TaiKhoan] [nvarchar](50) NOT NULL,
	[Ban_TaiKhoan] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email_TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((0)) FOR [Ban_TaiKhoan]
GO
ALTER TABLE [dbo].[DatDichVu]  WITH CHECK ADD FOREIGN KEY([ID_DichVu])
REFERENCES [dbo].[DichVu] ([ID_DichVu])
GO
ALTER TABLE [dbo].[DatDichVu]  WITH CHECK ADD FOREIGN KEY([ID_KhachHang])
REFERENCES [dbo].[KhachHang] ([ID_KhachHang])
GO
ALTER TABLE [dbo].[DatDichVu]  WITH CHECK ADD FOREIGN KEY([ID_KhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([ID_KhuyenMai])
GO
ALTER TABLE [dbo].[DatDichVu]  WITH CHECK ADD FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NhanVien] ([ID_NhanVien])
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD FOREIGN KEY([ID_KhachHang])
REFERENCES [dbo].[KhachHang] ([ID_KhachHang])
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD FOREIGN KEY([ID_KhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([ID_KhuyenMai])
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NhanVien] ([ID_NhanVien])
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[Phong] ([ID_Phong])
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD FOREIGN KEY([ID_LoaiDichVu])
REFERENCES [dbo].[LoaiDichVu] ([ID_LoaiDichVu])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([ID_LoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([ID_LoaiPhong])
GO
/****** Object:  StoredProcedure [dbo].[DeleteKhachHang]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--xóa khách hàng
CREATE PROCEDURE [dbo].[DeleteKhachHang]
    @ID_KhachHang INT
AS
BEGIN
	DELETE FROM DatPhong WHERE ID_KhachHang = (SELECT ID_KhachHang FROM KhachHang WHERE ID_KhachHang = @ID_KhachHang);
	DELETE FROM DatDichVu WHERE ID_KhachHang = (SELECT ID_KhachHang FROM KhachHang WHERE ID_KhachHang = @ID_KhachHang);
	DELETE FROM ChiTietHoaDon WHERE ID_HoaDon = (SELECT ID_HoaDon FROM HoaDon WHERE ID_KhachHang = @ID_KhachHang);
    DELETE FROM HoaDon WHERE ID_KhachHang = (SELECT ID_KhachHang FROM KhachHang WHERE ID_KhachHang = @ID_KhachHang);
    DELETE FROM KhachHang WHERE ID_KhachHang = @ID_KhachHang;
END
GO
/****** Object:  StoredProcedure [dbo].[InDonDatDichVu]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InDonDatDichVu]
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
GO
/****** Object:  StoredProcedure [dbo].[InDonDatPhong]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--In Đơn Đặt Phòng
CREATE PROCEDURE [dbo].[InDonDatPhong]
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
GO
/****** Object:  StoredProcedure [dbo].[InPhongDat]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InPhongDat]
	@IDDatPhong INT
AS
BEGIN
	SELECT dp.ID_DatPhong, kh.ID_KhachHang, kh.Ten_KhachHang, p.Ten_Phong , lp.Ten_LoaiPhong, lp.SucChua  FROM DatPhong AS dp 
	INNER JOIN KhachHang kh ON dp.ID_KhachHang = kh.ID_KhachHang
    INNER JOIN Phong p ON dp.ID_Phong = p.ID_Phong
    INNER JOIN LoaiPhong lp ON p.ID_LoaiPhong = lp.ID_LoaiPhong
	WHERE dp.ID_DatPhong =@IDDatPhong
END
GO
/****** Object:  StoredProcedure [dbo].[KTPhongTrong]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[KTPhongTrong]
	@Check_In date,
	@Check_Out date
as
begin
	select ID_Phong,Ten_Phong,lp.ID_LoaiPhong,Ten_LoaiPhong,SucChua,Gia_Phong from Phong as p
	inner join LoaiPhong as lp on lp.ID_LoaiPhong= p.ID_LoaiPhong
	 WHERE p.ID_Phong NOT IN ( SELECT DISTINCT ID_Phong FROM DatPhong WHERE Check_In <= @Check_Out AND Check_Out >= @Check_In )
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKeDonDatDichVu]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Thống kê đơn đặt dịch vụ
CREATE PROCEDURE [dbo].[ThongKeDonDatDichVu]
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
GO
/****** Object:  StoredProcedure [dbo].[ThongKeDonDatPhong]    Script Date: 5/22/2024 10:15:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThongKeDonDatPhong]
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
    WHERE (@Check_In IS NULL OR (dp.Check_In <= @Check_Out))
	  AND (@Check_Out IS NULL OR (dp.Check_Out >= @Check_In))
      AND (@Ten_Phong IS NULL OR p.Ten_Phong LIKE '%' + @Ten_Phong + '%')
      AND (@Ten_LoaiPhong IS NULL OR lp.Ten_LoaiPhong LIKE '%' + @Ten_LoaiPhong + '%');
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhachSan] SET  READ_WRITE 
GO
