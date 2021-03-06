USE [master]
GO
/****** Object:  Database [dataNguyenHoangThanh]    Script Date: 21/10/2020 8:17:45 CH ******/
CREATE DATABASE [dataNguyenHoangThanh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dataNguyenHoangThanh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dataNguyenHoangThanh.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dataNguyenHoangThanh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dataNguyenHoangThanh_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dataNguyenHoangThanh] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dataNguyenHoangThanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dataNguyenHoangThanh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET ARITHABORT OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET  MULTI_USER 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dataNguyenHoangThanh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dataNguyenHoangThanh] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dataNguyenHoangThanh]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 21/10/2020 8:17:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [bigint] IDENTITY(1,1) NOT NULL,
	[TenGV] [nvarchar](100) NULL,
	[SoDT] [nvarchar](100) NULL,
	[Luong] [float] NULL,
	[MaKhoa] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 21/10/2020 8:17:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [smallint] NOT NULL,
	[TenKhoa] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[GiaoVien] ON 

INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [SoDT], [Luong], [MaKhoa]) VALUES (3, N'Ngô Văn r', N'090337777', 3000, 103)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [SoDT], [Luong], [MaKhoa]) VALUES (7, N'a', N'a', 1, 101)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [SoDT], [Luong], [MaKhoa]) VALUES (8, N'baaagagaga', N'b', 2, 101)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [SoDT], [Luong], [MaKhoa]) VALUES (9, N'y', N'777', 8, 102)
SET IDENTITY_INSERT [dbo].[GiaoVien] OFF
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (101, N'Khoa công nghệ')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (102, N'Khoa may')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (103, N'Khoa quản trị')
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
/****** Object:  StoredProcedure [dbo].[ChonGVTheoKhoa]    Script Date: 21/10/2020 8:17:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ChonGVTheoKhoa]
@MaKhoa smallint
as
begin
	select * from GiaoVien where MaKhoa = @MaKhoa
end

GO
/****** Object:  StoredProcedure [dbo].[ChonGVTheoMaGV]    Script Date: 21/10/2020 8:17:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc	[dbo].[ChonGVTheoMaGV]
@MaGV bigint
as
begin
	select * from GiaoVien where MaGV = @MaGV
end

GO
/****** Object:  StoredProcedure [dbo].[SuaGV]    Script Date: 21/10/2020 8:17:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaGV]
@MaGV bigint,
@TenGV nvarchar(100),
@SoDT nvarchar(100),
@Luong float,
@MaKhoa smallint
as
begin
	update GiaoVien 
	set TenGV = @TenGV, SoDT = @SoDT, Luong = @Luong, MaKhoa = @MaKhoa
	where MaGV =  @MaGV
	select ErrMsg = N'Sửa thành công !'	
end

GO
/****** Object:  StoredProcedure [dbo].[ThemGV]    Script Date: 21/10/2020 8:17:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ThemGV]
@TenGV nvarchar(100),
@SoDT nvarchar(100),
@Luong float,
@MaKhoa smallint
as
begin
	insert GiaoVien (TenGV, SoDT, Luong, MaKhoa) values (@TenGV, @SoDT, @Luong, @MaKhoa)
	select ErrMsg = N'Thêm thành công !'	
end

GO
/****** Object:  StoredProcedure [dbo].[XoaGV]    Script Date: 21/10/2020 8:17:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[XoaGV]
@MaGV bigint
as
begin
	delete from GiaoVien
	where MaGV = @MaGV
	select ErrMsg = N'Xóa thành công !'	
end

GO
USE [master]
GO
ALTER DATABASE [dataNguyenHoangThanh] SET  READ_WRITE 
GO
