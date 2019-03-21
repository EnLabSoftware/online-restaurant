CREATE TABLE [dbo].[Staff]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [UserName] VARCHAR(25) NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [PasswordHash] VARCHAR(50) NOT NULL, 
    [ContactTelephone] CHAR(20) NULL, 
    [PostalCode] CHAR(10) NULL, 
    [State] CHAR(2) NULL, 
    [StreetAddress] VARCHAR(75) NULL, 
    [City] VARCHAR(25) NULL
)
