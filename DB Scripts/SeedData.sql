USE [Inventories]
GO

USE [Inventories]
GO

INSERT INTO [dbo].[ProductTypes]
           ([Name])
     VALUES
           ('Fruits', ''),
		   ('Vegetables', '')
GO





INSERT INTO [dbo].[ProductCategories]
           ([Name]
           ,[TypeId])
     VALUES
           ('Apple', 7),
		   ('Pear', 7),		   
		   ('Tomato',8),
		   ('Potato',8),
		   ('Onion', 8),
		   ('Cherry',7)		   

GO


DECLARE @AppleCategoryId bigint
Set @AppleCategoryId = (select Id from ProductCategories where Name = 'Apple')

DECLARE @PearCategoryId bigint
Set @PearCategoryId = (select Id from ProductCategories where Name = 'Pear')

INSERT INTO [dbo].[Products]
           ([Name]
           ,[Description]
           ,[CategoryId])
     VALUES
           ('Jonathan', 'Jonathan Description',  @AppleCategoryId),
		   ('Gold', 'Gold Description',  @AppleCategoryId),
		   ('Guidon', 'Guidon Description',  @PearCategoryId),
		   ('Malinka', 'Malinka Description',  @AppleCategoryId),
		   ('Antonovka', 'Antonovka Description',  @AppleCategoryId),
		   ('Spartan', 'Spartan Description',  @AppleCategoryId),
		   ('Caramel', 'Caramel Description',  @AppleCategoryId),
		   ('Vidnaya', 'Vidnaya Description',  @PearCategoryId),
		   ('Veles', 'Veles Description',  @PearCategoryId),
		   ('Winter', 'Winter Description',  @PearCategoryId),
		   ('Chizhovskaya', 'Chizhovskaya Description',  @PearCategoryId),
		   ('Uralskaya', 'Uralskaya Description',  @PearCategoryId)
GO

INSERT INTO [dbo].[Suppliers]
           ([Name]
           ,[Address]
           ,[Telephone])
     VALUES
           ('Supplier1' , 'Supplier1 Adddress', '123456789'),
		   ('Supplier2' , 'Supplier2 Adddress', '987654321'),
		   ('Supplier3' , 'Supplier3 Adddress', '1212121212')
GO


 INSERT INTO [dbo].[ProductSuppliersInfo]
           ([ProductId]
           ,[SupplierId]
           ,[Price]
           ,[PeriodFrom]
           ,[PeriodTo])
     VALUES
           ((select Id from Products where Name = 'Jonathan'), (select Id from Suppliers where Name = 'Supplier1'), 20,GETDATE(),'2023/12/20 10:25:00'),
		   ((select Id from Products where Name = 'Gold'), (select Id from Suppliers where Name = 'Supplier1'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   ((select Id from Products where Name = 'Malinka'), (select Id from Suppliers where Name = 'Supplier2'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   ((select Id from Products where Name = 'Gold'), (select Id from Suppliers where Name = 'Supplier2'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   ((select Id from Products where Name = 'Caramel'), (select Id from Suppliers where Name = 'Supplier3'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   ((select Id from Products where Name = 'Spartan'), (select Id from Suppliers where Name = 'Supplier3'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   
		   ((select Id from Products where Name = 'Vidnaya'), (select Id from Suppliers where Name = 'Supplier1'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   ((select Id from Products where Name = 'Winter'), (select Id from Suppliers where Name = 'Supplier1'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   ((select Id from Products where Name = 'Winter'), (select Id from Suppliers where Name = 'Supplier2'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   ((select Id from Products where Name = 'Spartan'), (select Id from Suppliers where Name = 'Supplier2'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   ((select Id from Products where Name = 'Chizhovskaya'), (select Id from Suppliers where Name = 'Supplier3'), 20,GETDATE(),'2023/10/20 10:25:00'),
		   ((select Id from Products where Name = 'Uralskaya'), (select Id from Suppliers where Name = 'Supplier3'), 20,GETDATE(),'2023/10/20 10:25:00')

