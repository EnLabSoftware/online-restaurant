CREATE TABLE [dbo].[Restaurant](
	[Id] INT IDENTITY(1,1),
	[Name] [varchar](256) NULL,
	[Description] [varchar](1024) NULL,
	[RestaurantCategoryId] INT NOT NULL,
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
