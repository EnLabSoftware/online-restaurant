CREATE TABLE [dbo].[Customer](
	[Id] INT Identity(1,1),
 [ContactTelephone] CHAR(20) NULL, 
    [PostalCode] CHAR(10) NULL, 
    [State] CHAR(2) NULL, 
    [StreetAddress] VARCHAR(75) NULL, 
    [City] VARCHAR(25) NULL, 
    [Email] VARCHAR(128) NULL, 
    [FullName] VARCHAR(50) NULL, 
    [BirthDate] DATETIME NULL, 
    [Gender] BIT NULL, 
    [UserName] VARCHAR(50) NULL, 
    [PasswordHash] VARCHAR(50) NULL, 
    [CustomerId] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

