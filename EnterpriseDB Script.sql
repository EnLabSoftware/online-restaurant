USE [master]
GO
/****** Object:  Database [Enterprise]    Script Date: 5/1/2014 6:56:42 AM ******/
CREATE DATABASE [Enterprise] ON  PRIMARY 
( NAME = N'DinnerNownew', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Enterprise.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DinnerNownew_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Enterprise_1.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Enterprise] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Enterprise].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Enterprise] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Enterprise] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Enterprise] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Enterprise] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Enterprise] SET ARITHABORT OFF 
GO
ALTER DATABASE [Enterprise] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Enterprise] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Enterprise] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Enterprise] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Enterprise] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Enterprise] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Enterprise] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Enterprise] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Enterprise] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Enterprise] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Enterprise] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Enterprise] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Enterprise] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Enterprise] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Enterprise] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Enterprise] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Enterprise] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Enterprise] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Enterprise] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Enterprise] SET  MULTI_USER 
GO
ALTER DATABASE [Enterprise] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Enterprise] SET DB_CHAINING OFF 
GO
USE [Enterprise]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/1/2014 6:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[UserName] [varchar](256) NOT NULL,
	[Password] [nvarchar](256) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 5/1/2014 6:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Menu](
	[Id] [uniqueidentifier] NOT NULL,
	[RestaurantId] [uniqueidentifier] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[MenuType] [varchar](50) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MenuItem]    Script Date: 5/1/2014 6:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MenuItem](
	[Id] [uniqueidentifier] NOT NULL,
	[MenuId] [uniqueidentifier] NOT NULL,
	[Name] [varchar](128) NULL,
	[Description] [varchar](512) NULL,
	[ImageLocation] [varchar](max) NULL,
	[Price] [money] NULL,
	[PreparationTime] [int] NULL,
 CONSTRAINT [PK_MenuItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 5/1/2014 6:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [uniqueidentifier] NOT NULL,
	[SubmittedDate] [smalldatetime] NOT NULL,
	[CustomerID] [uniqueidentifier] NOT NULL,
	[Total] [money] NOT NULL,
	[ContactTelephone] [char](20) NULL,
	[PostalCode] [char](10) NULL,
	[State] [char](2) NULL,
	[StreetAddress] [varchar](75) NULL,
	[City] [varchar](25) NULL,
 CONSTRAINT [PK_Order2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 5/1/2014 6:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
	[RestaurantId] [uniqueidentifier] NOT NULL,
	[MenuItemId] [uniqueidentifier] NOT NULL,
	[DeliveryId] [uniqueidentifier] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitCost] [money] NOT NULL,
	[Status] [nchar](20) NOT NULL,
	[StatusUpdatedTime] [smalldatetime] NOT NULL,
	[WorkflowId] [uniqueidentifier] NOT NULL,
	[ETA] [smalldatetime] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderPayment]    Script Date: 5/1/2014 6:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrderPayment](
	[Id] [uniqueidentifier] NOT NULL,
	[OrderID] [uniqueidentifier] NOT NULL,
	[CreditCardNumber] [char](4) NULL,
	[NameOnCard] [varchar](75) NULL,
	[Address] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[PostalCode] [char](10) NULL,
	[ExpirationDate] [smalldatetime] NULL,
	[CreditCardType] [varchar](50) NULL,
 CONSTRAINT [PK_OrderPayment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Restaurant]    Script Date: 5/1/2014 6:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Restaurant](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](256) NULL,
	[Description] [varchar](1024) NULL,
	[RestaurantCategoryId] [uniqueidentifier] NOT NULL,
	[LogoImageLocation] [nvarchar](max) NULL,
	[SmallLogoImageLocation] [nvarchar](max) NULL,
	[BannerImageLocation] [nvarchar](max) NULL,
	[MainImageLocation] [nvarchar](max) NULL,
	[BackgroundLocation] [nvarchar](max) NULL,
	[PostalCode] [varchar](128) NOT NULL,
	[StreetAddress] [varchar](256) NULL,
	[City] [varchar](512) NULL,
	[State] [varchar](256) NULL,
 CONSTRAINT [PK_Restaurant] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RestaurantCategory]    Script Date: 5/1/2014 6:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RestaurantCategory](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [varchar](255) NOT NULL,
 CONSTRAINT [PK_RestaurantCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_Restaurant] FOREIGN KEY([RestaurantId])
REFERENCES [dbo].[Restaurant] ([Id])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_Restaurant]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order2_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order2_Customer]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_MenuItem] FOREIGN KEY([MenuItemId])
REFERENCES [dbo].[MenuItem] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_MenuItem]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order2] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order2]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Restaurant] FOREIGN KEY([RestaurantId])
REFERENCES [dbo].[Restaurant] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Restaurant]
GO
ALTER TABLE [dbo].[OrderPayment]  WITH CHECK ADD  CONSTRAINT [FK_OrderPayment_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderPayment] CHECK CONSTRAINT [FK_OrderPayment_Order]
GO
ALTER TABLE [dbo].[Restaurant]  WITH CHECK ADD  CONSTRAINT [FK_Restaurant_RestaurantCategory] FOREIGN KEY([RestaurantCategoryId])
REFERENCES [dbo].[RestaurantCategory] ([Id])
GO
ALTER TABLE [dbo].[Restaurant] CHECK CONSTRAINT [FK_Restaurant_RestaurantCategory]
GO
USE [master]
GO
ALTER DATABASE [Enterprise] SET  READ_WRITE 
GO
