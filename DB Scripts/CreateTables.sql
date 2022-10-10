USE [Inventories]
GO

/****** Object:  Table [dbo].[Deliveries]    Script Date: 10-Oct-22 12:59:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Telephone] [nvarchar](max) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [dbo].[ProductTypes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Products](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CategoryId] [bigint] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductCategories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ProductCategories] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductCategories]
GO

CREATE TABLE [dbo].[Deliveries](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplierId] [bigint] NOT NULL,
	[DeliveryDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Deliveries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProductDeliveries](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[DeliveryId] [bigint] NOT NULL,
	[Weight] [smallint] NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_ProductDeliveries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProductDeliveries]  WITH CHECK ADD  CONSTRAINT [FK_ProductDeliveries_DeliveryId] FOREIGN KEY([DeliveryId])
REFERENCES [dbo].[Deliveries] ([Id])
GO

ALTER TABLE [dbo].[ProductDeliveries] CHECK CONSTRAINT [FK_ProductDeliveries_DeliveryId]
GO

ALTER TABLE [dbo].[ProductDeliveries]  WITH CHECK ADD  CONSTRAINT [FK_ProductDeliveries_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO

ALTER TABLE [dbo].[ProductDeliveries] CHECK CONSTRAINT [FK_ProductDeliveries_ProductId]
GO


CREATE TABLE [dbo].[ProductCategories](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[TypeId] [bigint] NOT NULL,
 CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProductCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategories_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[ProductTypes] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ProductCategories] CHECK CONSTRAINT [FK_ProductCategories_TypeId]
GO

CREATE TABLE [dbo].[ProductSuppliersInfo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[SupplierId] [bigint] NOT NULL,
	[Price] [money] NOT NULL,
	[PeriodFrom] [datetime2](7) NOT NULL,
	[PeriodTo] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductSuppliersInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_ProductId_SupplierId] UNIQUE NONCLUSTERED 
(
	[ProductId] ASC,
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProductSuppliersInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSuppliersInfo_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ProductSuppliersInfo] CHECK CONSTRAINT [FK_ProductSuppliersInfo_ProductId]
GO

ALTER TABLE [dbo].[ProductSuppliersInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSuppliersInfo_SupplierId] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Suppliers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ProductSuppliersInfo] CHECK CONSTRAINT [FK_ProductSuppliersInfo_SupplierId]
GO