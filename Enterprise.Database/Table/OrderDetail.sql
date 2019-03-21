CREATE TABLE [dbo].[OrderDetail](
	[Id] INT Identity(1,1),
	[OrderId] INT NOT NULL,
	[MenuItemId] INT NOT NULL,
	[DeliveryId] INT NULL,
	[Quantity] [int] NOT NULL,
	[UnitCost] [money] NOT NULL,
	[Status] [nchar](20) NULL,
	[StatusUpdatedTime] [smalldatetime] NULL,
	[WorkflowId] [uniqueidentifier] NULL,
	[ETA] [smalldatetime] NULL,
 [Description] NVARCHAR(255) NULL, 
    CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
