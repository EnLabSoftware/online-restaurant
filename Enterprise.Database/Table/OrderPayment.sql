CREATE TABLE [dbo].[OrderPayment](
	[Id] INT IDENTITY(1,1),
	[OrderId] INT NOT NULL,
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
