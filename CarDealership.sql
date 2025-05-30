USE [master]
GO
/****** Object:  Database [CarDealership]    Script Date: 6/13/2024 2:54:53 PM ******/
CREATE DATABASE [CarDealership]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarDealership', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CarDealership.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarDealership_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CarDealership_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CarDealership] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarDealership].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarDealership] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarDealership] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarDealership] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarDealership] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarDealership] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarDealership] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarDealership] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarDealership] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarDealership] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarDealership] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarDealership] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarDealership] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarDealership] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarDealership] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarDealership] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarDealership] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarDealership] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarDealership] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarDealership] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarDealership] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarDealership] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarDealership] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarDealership] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CarDealership] SET  MULTI_USER 
GO
ALTER DATABASE [CarDealership] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarDealership] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarDealership] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarDealership] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarDealership] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarDealership] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CarDealership] SET QUERY_STORE = ON
GO
ALTER DATABASE [CarDealership] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CarDealership]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 6/13/2024 2:54:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[SellerID] [int] NOT NULL,
	[ListingDate] [date] NOT NULL,
	[Make] [varchar](50) NOT NULL,
	[Model] [varchar](50) NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Engine] [varchar](50) NULL,
	[Mileage] [int] NULL,
	[Horsepower] [int] NULL,
	[BatteryCap] [decimal](10, 2) NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/13/2024 2:54:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([CarID], [SellerID], [ListingDate], [Make], [Model], [Color], [Age], [Price], [Engine], [Mileage], [Horsepower], [BatteryCap]) VALUES (2, 2, CAST(N'2024-06-11' AS Date), N'Toyota', N'Camry', N'Blue', 20, 3000.0000, NULL, 300, NULL, NULL)
INSERT [dbo].[Cars] ([CarID], [SellerID], [ListingDate], [Make], [Model], [Color], [Age], [Price], [Engine], [Mileage], [Horsepower], [BatteryCap]) VALUES (3, 1, CAST(N'2024-05-12' AS Date), N'BMW', N'X3', N'Silver', 50, 20000.0000, N'M3', NULL, NULL, NULL)
INSERT [dbo].[Cars] ([CarID], [SellerID], [ListingDate], [Make], [Model], [Color], [Age], [Price], [Engine], [Mileage], [Horsepower], [BatteryCap]) VALUES (5, 1, CAST(N'2024-02-12' AS Date), N'BMW', N'X4', N'Yellow', 8, 333000.0000, N'M4', NULL, NULL, NULL)
INSERT [dbo].[Cars] ([CarID], [SellerID], [ListingDate], [Make], [Model], [Color], [Age], [Price], [Engine], [Mileage], [Horsepower], [BatteryCap]) VALUES (6, 2, CAST(N'2024-03-01' AS Date), N'Mercedes', N'GLA 45', N'Red', 12, 56650.0000, NULL, NULL, 382, NULL)
INSERT [dbo].[Cars] ([CarID], [SellerID], [ListingDate], [Make], [Model], [Color], [Age], [Price], [Engine], [Mileage], [Horsepower], [BatteryCap]) VALUES (7, 2, CAST(N'2024-04-24' AS Date), N'Honda', N'Accord', N'White', 20, 200.0000, NULL, NULL, NULL, CAST(45.00 AS Decimal(10, 2)))
INSERT [dbo].[Cars] ([CarID], [SellerID], [ListingDate], [Make], [Model], [Color], [Age], [Price], [Engine], [Mileage], [Horsepower], [BatteryCap]) VALUES (8, 1, CAST(N'2024-05-25' AS Date), N'Toyota', N'Prius', N'Green', 15, 2000.0000, NULL, 200, NULL, NULL)
INSERT [dbo].[Cars] ([CarID], [SellerID], [ListingDate], [Make], [Model], [Color], [Age], [Price], [Engine], [Mileage], [Horsepower], [BatteryCap]) VALUES (10, 1, CAST(N'2024-06-12' AS Date), N'Honda', N'Civic', N'Tan', 20, 1750.0000, NULL, NULL, NULL, CAST(175.00 AS Decimal(10, 2)))
INSERT [dbo].[Cars] ([CarID], [SellerID], [ListingDate], [Make], [Model], [Color], [Age], [Price], [Engine], [Mileage], [Horsepower], [BatteryCap]) VALUES (11, 1, CAST(N'2024-06-12' AS Date), N'Honda', N'Civic', N'Green', 20, 1500.0000, NULL, NULL, NULL, CAST(250.00 AS Decimal(10, 2)))
INSERT [dbo].[Cars] ([CarID], [SellerID], [ListingDate], [Make], [Model], [Color], [Age], [Price], [Engine], [Mileage], [Horsepower], [BatteryCap]) VALUES (12, 1, CAST(N'2024-06-12' AS Date), N'BMW', N'X1', N'Green', 4, 5620.0000, N'M5', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Username], [Password]) VALUES (1, N'tnelson98', N'testPassword')
INSERT [dbo].[Users] ([UserID], [Username], [Password]) VALUES (2, N'otherUser', N'fakePass')
INSERT [dbo].[Users] ([UserID], [Username], [Password]) VALUES (11, N'emptyUser', N'theBest')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Users] FOREIGN KEY([SellerID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Users]
GO
USE [master]
GO
ALTER DATABASE [CarDealership] SET  READ_WRITE 
GO
