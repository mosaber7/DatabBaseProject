CREATE OR ALTER PROCEDURE Restaurant.AddMenuItemIngredient
	@MenuItemName NVARCHAR (32),
	@IngredientName NVARCHAR (32),
	@AmountUsed DECIMAL
AS
	DECLARE @MenuItemID INT = Restaurant.RetrieveActiveMenuItemID(@MenuItemName);
	DECLARE @IngredientID INT = Restaurant.RetrieveIngredientID(@IngredientName);

	INSERT INTO Restaurant.MenuItemIngredient(MenuItemID, IngredientID, AmountUsed)
	VALUES(@MenuItemID, @IngredientID, @AmountUsed)