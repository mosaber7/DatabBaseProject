CREATE OR ALTER PROCEDURE Restaurant.AddFood
	@OrderID INT,
	@MenuItemName NVARCHAR(32),
	@Quantity INT,
	@FoodID INT OUTPUT
AS
	DECLARE @MenuItemID INT = Restaurant.RetrieveActiveMenuItemID(@MenuItemName);
	IF (@MenuItemID IS NULL)
		THROW 50000, 'Menu Item not found in the database', 1
	INSERT INTO Restaurant.Foods (OrderID, MenuItemID, Quantity)
	VALUES (@OrderID, @MenuItemID, @Quantity)
	SET @FoodID = SCOPE_IDENTITY();
GO


CREATE OR ALTER PROCEDURE Restaurant.AddFoodUsingTableAndOrderDate
	@TableNumber INT,
	@OrderDate DATETIMEOFFSET,
	@MenuItemName NVARCHAR(32),
	@Quantity INT,
	@FoodID INT OUTPUT
AS
	DECLARE @TableID INT = Restaurant.RetrieveTableID(@TableNumber);
	DECLARE @OrderID INT = Restaurant.RetrieveOrderID(@TableID, @OrderDate);
	DECLARE @MenuItemID INT = Restaurant.RetrieveActiveMenuItemID(@MenuItemName);
	INSERT INTO Restaurant.Foods (OrderID, MenuItemID, Quantity)
	VALUES (@OrderID, @MenuItemID, @Quantity)
	SET @FoodID = SCOPE_IDENTITY();
GO