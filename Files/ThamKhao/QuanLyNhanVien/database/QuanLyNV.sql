USE [master]
GO
/****** Object:  Database [QuanLyNV]    Script Date: 20/04/2020 14:50:34 PM ******/
CREATE DATABASE [QuanLyNV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNV.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyNV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNV_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyNV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyNV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyNV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNV] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyNV] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyNV]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 20/04/2020 14:50:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[nhanvien_id] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SoDienThoai] [nvarchar](11) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[nhanvien_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([nhanvien_id], [TenNhanVien], [DiaChi], [SoDienThoai]) VALUES (5, N'Nguyen Van A', N'Thật tiện lợi', N'0098')
INSERT [dbo].[NhanVien] ([nhanvien_id], [TenNhanVien], [DiaChi], [SoDienThoai]) VALUES (6, N'Nguyen Van B', N'Dễ dùng111', N'Dễ dùng111')
INSERT [dbo].[NhanVien] ([nhanvien_id], [TenNhanVien], [DiaChi], [SoDienThoai]) VALUES (11, N'fsdfsd', N'fsdfsd', N'fsdfsd')
INSERT [dbo].[NhanVien] ([nhanvien_id], [TenNhanVien], [DiaChi], [SoDienThoai]) VALUES (12, N'fsdfsdf', N'32432', N'32432')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
/****** Object:  StoredProcedure [dbo].[nhanvien_sua]    Script Date: 20/04/2020 14:50:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[nhanvien_sua]
@nhanvien_id int,
 @TenNhanVien nvarchar(100),
 @DiaChi nvarchar(255),
 @SoDienThoai nvarchar(11)
AS
BEGIN
	
	UPDATE [dbo].[NhanVien]
   SET [TenNhanVien] =  @TenNhanVien
      ,[DiaChi] =  @DiaChi
      ,[SoDienThoai] = @SoDienThoai
 WHERE nhanvien_id=@nhanvien_id

		Select ErrMsg= N'Lưu Thành Công', ErrCode=0
END

GO
/****** Object:  StoredProcedure [dbo].[nhanvien_them]    Script Date: 20/04/2020 14:50:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[nhanvien_them]
 @TenNhanVien nvarchar(100),
 @DiaChi nvarchar(255),
 @SoDienThoai nvarchar(11)
AS
BEGIN
	
	INSERT INTO [dbo].[NhanVien]
           ([TenNhanVien]
           ,[DiaChi]
           ,[SoDienThoai])
     VALUES
           ( @TenNhanVien,
            @DiaChi
           ,@SoDienThoai )

		Select ErrMsg= N'Thêm Thành Công', ErrCode=0
END

GO
/****** Object:  StoredProcedure [dbo].[nhanvien_xoa]    Script Date: 20/04/2020 14:50:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[nhanvien_xoa]
@nhanvien_id int
AS
BEGIN
	
DELETE FROM [dbo].[NhanVien]     
 WHERE nhanvien_id=@nhanvien_id

		Select ErrMsg= N'Xóa Thành Công', ErrCode=0
END

GO
USE [master]
GO
ALTER DATABASE [QuanLyNV] SET  READ_WRITE 
GO
