USE [master]
GO
/****** Object:  Database [MağazaKayit]    Script Date: 26.12.2023 20:22:47 ******/
CREATE DATABASE [MağazaKayit]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MağazaKayit', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MağazaKayit.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MağazaKayit_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MağazaKayit_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MağazaKayit].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MağazaKayit] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MağazaKayit] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MağazaKayit] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MağazaKayit] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MağazaKayit] SET ARITHABORT OFF 
GO
ALTER DATABASE [MağazaKayit] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MağazaKayit] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MağazaKayit] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MağazaKayit] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MağazaKayit] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MağazaKayit] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MağazaKayit] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MağazaKayit] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MağazaKayit] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MağazaKayit] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MağazaKayit] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MağazaKayit] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MağazaKayit] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MağazaKayit] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MağazaKayit] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MağazaKayit] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MağazaKayit] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MağazaKayit] SET RECOVERY FULL 
GO
ALTER DATABASE [MağazaKayit] SET  MULTI_USER 
GO
ALTER DATABASE [MağazaKayit] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MağazaKayit] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MağazaKayit] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MağazaKayit] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MağazaKayit] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MağazaKayit', N'ON'
GO
USE [MağazaKayit]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 26.12.2023 20:22:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ürünler]    Script Date: 26.12.2023 20:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ürünler](
	[StokNo] [int] IDENTITY(1,1) NOT NULL,
	[ÜrünAdi] [nvarchar](100) NOT NULL,
	[Beden] [nvarchar](100) NOT NULL,
	[Renk] [nvarchar](10) NOT NULL,
	[StokAdedi] [int] NOT NULL,
 CONSTRAINT [PK_Ürünler] PRIMARY KEY CLUSTERED 
(
	[StokNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Password]) VALUES (1, N'yagiz', N'123')
INSERT [dbo].[Users] ([Id], [Name], [Password]) VALUES (2, N'emir', N'123')
INSERT [dbo].[Users] ([Id], [Name], [Password]) VALUES (3, N'cebrail', N'123')
INSERT [dbo].[Users] ([Id], [Name], [Password]) VALUES (4, N'admin', N'123')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Ürünler] ON 

INSERT [dbo].[Ürünler] ([StokNo], [ÜrünAdi], [Beden], [Renk], [StokAdedi]) VALUES (1, N'KAZAK', N'M', N'MAVİ', 100)
INSERT [dbo].[Ürünler] ([StokNo], [ÜrünAdi], [Beden], [Renk], [StokAdedi]) VALUES (2, N'CEKET', N'L', N'SARI', 1000)
INSERT [dbo].[Ürünler] ([StokNo], [ÜrünAdi], [Beden], [Renk], [StokAdedi]) VALUES (3, N'EŞOFMAN', N'XXL', N'GRİ', 360)
INSERT [dbo].[Ürünler] ([StokNo], [ÜrünAdi], [Beden], [Renk], [StokAdedi]) VALUES (4, N'HIRKA', N'XL', N'YEŞİL', 150)
INSERT [dbo].[Ürünler] ([StokNo], [ÜrünAdi], [Beden], [Renk], [StokAdedi]) VALUES (5, N'GÖMLEK', N'XXL', N'YEŞİL', 600)
INSERT [dbo].[Ürünler] ([StokNo], [ÜrünAdi], [Beden], [Renk], [StokAdedi]) VALUES (7, N'CEKET', N'XL', N'YEŞİL', 500)
SET IDENTITY_INSERT [dbo].[Ürünler] OFF
GO
USE [master]
GO
ALTER DATABASE [MağazaKayit] SET  READ_WRITE 
GO
