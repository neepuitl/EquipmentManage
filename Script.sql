USE [master]
GO
/****** Object:  Database [EquipmentManage]    Script Date: 2019/5/9 0:44:07 ******/
CREATE DATABASE [EquipmentManage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EquipmentManage', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\EquipmentManage.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EquipmentManage_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\EquipmentManage_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EquipmentManage] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EquipmentManage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EquipmentManage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EquipmentManage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EquipmentManage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EquipmentManage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EquipmentManage] SET ARITHABORT OFF 
GO
ALTER DATABASE [EquipmentManage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EquipmentManage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EquipmentManage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EquipmentManage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EquipmentManage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EquipmentManage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EquipmentManage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EquipmentManage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EquipmentManage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EquipmentManage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EquipmentManage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EquipmentManage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EquipmentManage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EquipmentManage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EquipmentManage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EquipmentManage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EquipmentManage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EquipmentManage] SET RECOVERY FULL 
GO
ALTER DATABASE [EquipmentManage] SET  MULTI_USER 
GO
ALTER DATABASE [EquipmentManage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EquipmentManage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EquipmentManage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EquipmentManage] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EquipmentManage] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EquipmentManage', N'ON'
GO
USE [EquipmentManage]
GO
/****** Object:  Table [dbo].[NoReturnRecord]    Script Date: 2019/5/9 0:44:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoReturnRecord](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApparatusName] [nvarchar](30) NULL,
	[BorrowDate] [nvarchar](30) NULL,
	[BorrowNumber] [nvarchar](30) NULL,
	[ReturnDate] [nvarchar](30) NULL,
	[UserName] [nvarchar](30) NULL,
	[Telephone] [nvarchar](30) NULL,
 CONSTRAINT [PK_NoReturnRecord] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TodayBorrow]    Script Date: 2019/5/9 0:44:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TodayBorrow](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApparatusName] [nvarchar](30) NULL,
	[BorrowDate] [nvarchar](30) NULL,
	[BorrowNumber] [nvarchar](30) NULL,
	[ReturnDate] [nvarchar](30) NULL,
	[UserName] [nvarchar](30) NULL,
	[Telephone] [nvarchar](30) NULL,
 CONSTRAINT [PK_TodayBorrow] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserSet]    Script Date: 2019/5/9 0:44:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSet](
	[Pwd] [nvarchar](50) NULL,
	[ExcelRoute] [nvarchar](max) NULL,
	[ApparatusType] [nvarchar](30) NULL,
	[ApparatusName] [nvarchar](max) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_UserSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[YesterdayBorrow]    Script Date: 2019/5/9 0:44:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YesterdayBorrow](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApparatusName] [nvarchar](30) NULL,
	[BorrowDate] [nvarchar](30) NULL,
	[BorrowNumber] [nvarchar](30) NULL,
	[ReturnDate] [nvarchar](30) NULL,
	[UserName] [nvarchar](30) NULL,
	[Telephone] [nvarchar](30) NULL,
 CONSTRAINT [PK_YesterdayBorrow] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [EquipmentManage] SET  READ_WRITE 
GO
