CREATE OR ALTER PROCEDURE Restaurant.AddFood
	@TableNumber INT,
	@OrderDate DATETIMEOFFSET,
	@MenuItemName NVARCHAR(32),
	@Quantity INT
AS
	DECLARE @TableID INT = Restaurant.RetrieveTableID(@TableNumber);
	DECLARE @OrderID INT = Restaurant.RetrieveOrderID(@TableID, @OrderDate);
	DECLARE @MenuItemID INT = Restaurant.RetrieveActiveMenuItemID(@MenuItemName);
	INSERT INTO Restaurant.Foods (OrderID, MenuItemID, Quantity)
	VALUES (@OrderID, @MenuItemID, @Quantity)
GO