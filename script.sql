USE [master]
GO
/****** Object:  Database [NZFurniture]    Script Date: 12/14/2020 3:25:49 AM ******/
CREATE DATABASE [NZFurniture]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NZFurniture_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NZFurniture.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NZFurniture_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NZFurniture.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NZFurniture] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NZFurniture].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NZFurniture] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NZFurniture] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NZFurniture] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NZFurniture] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NZFurniture] SET ARITHABORT OFF 
GO
ALTER DATABASE [NZFurniture] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NZFurniture] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NZFurniture] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NZFurniture] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NZFurniture] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NZFurniture] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NZFurniture] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NZFurniture] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NZFurniture] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NZFurniture] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NZFurniture] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NZFurniture] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NZFurniture] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NZFurniture] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NZFurniture] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NZFurniture] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NZFurniture] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NZFurniture] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NZFurniture] SET  MULTI_USER 
GO
ALTER DATABASE [NZFurniture] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NZFurniture] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NZFurniture] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NZFurniture] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NZFurniture] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NZFurniture] SET QUERY_STORE = OFF
GO
USE [NZFurniture]
GO
/****** Object:  Table [dbo].[headDetails]    Script Date: 12/14/2020 3:25:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[headDetails](
	[headID] [varchar](50) NULL,
	[headPassword] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Labour]    Script Date: 12/14/2020 3:25:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Labour](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Skills] [varchar](50) NULL,
 CONSTRAINT [PK_Labour] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/14/2020 3:25:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[Quality] [varchar](50) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuerySection]    Script Date: 12/14/2020 3:25:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuerySection](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
 CONSTRAINT [PK_QuerySection] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 12/14/2020 3:25:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Salary] [varchar](50) NULL,
	[PaymentDate] [varchar](50) NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[headDetails] ([headID], [headPassword]) VALUES (N'getfurni@gmail.com', N'getadmin')
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [Name], [Price], [Quality]) VALUES (1, N'Table', N'250', N'very good')
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[QuerySection] ON 

INSERT [dbo].[QuerySection] ([id], [Name], [Email], [Phone], [Message]) VALUES (1, N'qwq', N'qww@as.com', N'123', N'qwqww')
SET IDENTITY_INSERT [dbo].[QuerySection] OFF
USE [master]
GO
ALTER DATABASE [NZFurniture] SET  READ_WRITE 
GO
