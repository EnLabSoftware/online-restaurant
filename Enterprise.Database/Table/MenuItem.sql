CREATE TABLE [dbo].[MenuItem](
	[Id] INT Identity(1,1),
	[MenuId] INT,
	[Name] [varchar](128) NULL,
	[Description] [varchar](MAX) NULL,
	[ImageLocation] [varchar](max) NULL,
	[Price] [money] NULL,
	[PreparationTime] [int] NULL,
 CONSTRAINT [PK_MenuItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
