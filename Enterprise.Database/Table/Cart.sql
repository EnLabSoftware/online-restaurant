CREATE TABLE [dbo].[Cart]
(
	[Id] INT PRIMARY KEY IDENTITY (1,1), 
    [CartId] VARCHAR(50) NULL, 
    [MenuItemId] INT NULL, 
    [UnitPrice] DECIMAL NULL, 
    [Count] INT NULL, 
    [DateCreated] DATE NULL, 
    [ImageLocation] VARCHAR(MAX) NULL, 
    [Name] VARCHAR(128) NULL
)
