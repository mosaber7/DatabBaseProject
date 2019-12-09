CREATE OR ALTER PROCEDURE Restaurant.AddMenuItemIngredient
	@MenuItemName NVARCHAR (32),
	@IngredientName NVARCHAR (32),
	@AmountUsed DECIMAL
AS
	DECLARE @MenuItemID INT = Restaurant.RetrieveActiveMenuItemID(@MenuItemName);
	DECLARE @IngredientID INT = Restaurant.RetrieveIngredientID(@IngredientName);
	IF(@MenuItemID IS NULL)
		THROW 50000,'Menu Item not found in the database',1
	IF(@MenuItemID IS NULL)
		THROW 50000,'Ingredient not found in the database',1

	INSERT INTO Restaurant.MenuItemIngredient(MenuItemID, IngredientID, AmountUsed)
	VALUES(@MenuItemID, @IngredientID, @AmountUsed)