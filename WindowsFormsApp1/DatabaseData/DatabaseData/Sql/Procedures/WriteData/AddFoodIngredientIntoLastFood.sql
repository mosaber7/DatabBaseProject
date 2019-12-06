CREATE OR ALTER PROCEDURE Restaurant.AddFoodIngredient
	@FoodID INT,
	@IngredientName NVARCHAR (32),
	@AmountUsed DECIMAL
AS
	INSERT INTO Restaurant.FoodIngredient(FoodID, IngredientID, AmountUsed)
	VALUES (@FoodID, Restaurant.RetrieveIngredientID(@IngredientName), @AmountUsed);
GO

CREATE OR ALTER PROCEDURE Restaurant.AddFoodIngredientIntoLastFood
	@TableNumber INT,
	@OrderDate DATETIMEOFFSET,
	@MenuItemName NVARCHAR(32),
	@IngredientName NVARCHAR(32),
	@AmountUsed DECIMAL
AS
	DECLARE @TableID INT = Restaurant.RetrieveTableID(@TableNumber);
	DECLARE @OrderID INT = Restaurant.RetrieveOrderID(@TableID, @OrderDate);
	DECLARE @MenuItemID INT = Restaurant.RetrieveActiveMenuItemID(@MenuItemName);
	---We retrieve the last added food
	DECLARE @FoodID INT = 
	(
		SELECT TOP(1) F.FoodID
		FROM Restaurant.Foods F
		WHERE @MenuItemID = F.MenuItemID
			AND @OrderID = F.OrderID
		ORDER BY F.FoodID DESC
	)
	INSERT INTO Restaurant.FoodIngredient(FoodID, IngredientID, AmountUsed)
	VALUES (@FoodID, Restaurant.RetrieveIngredientID(@IngredientName), @AmountUsed)
GO