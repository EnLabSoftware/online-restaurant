CREATE TABLE [dbo].[Order](
	[Id] INT Identity(1,1),
	[SubmittedDate] [smalldatetime] NOT NULL,
	[CustomerID] VARCHAR(50),
	[Total] [money] NULL,
	[ContactTelephone] [char](20) NULL,
	[PostalCode] [char](10) NULL,
	[State] [char](2) NULL,
	[StreetAddress] [varchar](75) NULL,
	[City] [varchar](25) NULL,
 [Email] VARCHAR(128) NULL, 
    [FulllName] VARCHAR(50) NULL, 
    [OrderStatusId] INT NULL, 
    CONSTRAINT [PK_Order2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
