USE [master]
GO
/****** Object:  Database [bt7]    Script Date: 07/10/2020 10:25:43 SA ******/
CREATE DATABASE [bt7]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bt7', FILENAME = N'D:\btsql\bt7.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'bt7_log', FILENAME = N'D:\btsql\bt7_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [bt7] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bt7].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bt7] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bt7] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bt7] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bt7] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bt7] SET ARITHABORT OFF 
GO
ALTER DATABASE [bt7] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bt7] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bt7] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bt7] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bt7] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bt7] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bt7] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bt7] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bt7] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bt7] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bt7] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bt7] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bt7] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bt7] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bt7] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bt7] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bt7] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bt7] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bt7] SET  MULTI_USER 
GO
ALTER DATABASE [bt7] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bt7] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bt7] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bt7] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [bt7] SET DELAYED_DURABILITY = DISABLED 
GO
USE [bt7]
GO
/****** Object:  Table [dbo].[giaovien]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giaovien](
	[MaGiaoVien] [bigint] IDENTITY(1,1) NOT NULL,
	[TenGiaoVien] [nvarchar](100) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[Luong] [float] NULL,
	[MaKhoa] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC,
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khoa]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoa](
	[MaKhoa] [smallint] NOT NULL,
	[TenKhoa] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_1]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT        dbo.khoa.TenKhoa, dbo.giaovien.TenGiaoVien
FROM            dbo.giaovien INNER JOIN
                         dbo.khoa ON dbo.giaovien.MaKhoa = dbo.khoa.MaKhoa

GO
SET IDENTITY_INSERT [dbo].[giaovien] ON 

INSERT [dbo].[giaovien] ([MaGiaoVien], [TenGiaoVien], [SoDienThoai], [Luong], [MaKhoa]) VALUES (1, N'Nguyen A1111', N'7777', 888, 1)
INSERT [dbo].[giaovien] ([MaGiaoVien], [TenGiaoVien], [SoDienThoai], [Luong], [MaKhoa]) VALUES (3, N'Nguyen B', N'776', 334, 2)
SET IDENTITY_INSERT [dbo].[giaovien] OFF
INSERT [dbo].[khoa] ([MaKhoa], [TenKhoa]) VALUES (1, N'khoa Công CNTT')
INSERT [dbo].[khoa] ([MaKhoa], [TenKhoa]) VALUES (2, N'Khoa QT')
ALTER TABLE [dbo].[giaovien]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[khoa] ([MaKhoa])
GO
/****** Object:  StoredProcedure [dbo].[giaovien_delete]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[giaovien_delete](@MaGiaoVien bigint

)
	
AS
BEGIN
	DELETE FROM [dbo].[giaovien]
		WHERE [MaGiaoVien] = @MaGiaoVien
	SELECT ErrMsg = N'Delete Successfully !'
END

GO
/****** Object:  StoredProcedure [dbo].[giaovien_insert]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--------------------------------------------------------------
CREATE PROCEDURE [dbo].[giaovien_insert](
@TenGiaoVien nvarchar(100)
,@SoDienThoai nvarchar(20)
,@Luong float
,@MaKhoa smallint
)
	
AS
BEGIN
	INSERT INTO [dbo].[giaovien]
           (
           [TenGiaoVien]
		   ,[SoDienThoai]
		   ,[Luong]
		   ,[MaKhoa])
     VALUES
           (
		   @TenGiaoVien
		   ,@SoDienThoai
		   ,@Luong
		   ,@MaKhoa)
	SELECT ErrMsg = N'Insert successfully !'
END

GO
/****** Object:  StoredProcedure [dbo].[giaovien_update]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[giaovien_update](@MaGiaoVien bigint
,@TenGiaoVien nvarchar(100)
,@SoDienThoai nvarchar(20)
,@Luong float
,@MaKhoa smallint
)
	
AS
BEGIN
	UPDATE [dbo].[giaovien]
	SET  [TenGiaoVien] = @TenGiaoVien
		,[SoDienThoai] = @SoDienThoai
		,[Luong] = @Luong
		,[MaKhoa] = @MaKhoa
	WHERE [MaGiaoVien] = @MaGiaoVien
	SELECT ErrMsg = N'Update Successfully !'
END

GO
/****** Object:  StoredProcedure [dbo].[giaovientheokhoa_select]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[giaovientheokhoa_select] (
@MaKhoa smallint
)
AS
BEGIN
	SELECT *
	FROM [dbo].[giaovien]
	WHERE [MaKhoa] = @MaKhoa
END

GO
/****** Object:  StoredProcedure [dbo].[giaovientheomagv_select]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[giaovientheomagv_select] (
@MaGiaoVien bigint

)
AS
BEGIN
	SELECT *
	FROM [dbo].[giaovien]
	WHERE [MaGiaoVien] = @MaGiaoVien
END

GO
/****** Object:  StoredProcedure [dbo].[khoa_delete]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[khoa_delete](@MaKhoa smallint
,@TenKhoa nvarchar(100)
)
	
AS
BEGIN
	DELETE FROM [dbo].[khoa]
		WHERE [MaKhoa] = @MaKhoa
	SELECT ErrMsg = N'Delete Successfully !'
END

GO
/****** Object:  StoredProcedure [dbo].[khoa_insert]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[khoa_insert](@MaKhoa smallint
,@TenKhoa nvarchar(100)
)
	
AS
BEGIN
	INSERT INTO [dbo].[khoa]
           ([MaKhoa]
           ,[TenKhoa])
     VALUES
           (@MaKhoa
		   ,@TenKhoa)
	SELECT ErrMsg = N'Insert successfully !'
END

GO
/****** Object:  StoredProcedure [dbo].[khoa_update]    Script Date: 07/10/2020 10:25:43 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[khoa_update](@MaKhoa smallint
,@TenKhoa nvarchar(100)
)
	
AS
BEGIN
	UPDATE [dbo].[khoa]
	SET [TenKhoa] = @TenKhoa
	WHERE [MaKhoa] = @MaKhoa
	SELECT ErrMsg = N'Update Successfully !'
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "giaovien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "khoa"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 101
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
USE [master]
GO
ALTER DATABASE [bt7] SET  READ_WRITE 
GO
