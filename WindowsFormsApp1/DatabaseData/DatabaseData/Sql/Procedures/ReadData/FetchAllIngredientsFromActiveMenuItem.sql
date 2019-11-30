CREATE OR ALTER PROCEDURE Restaurant.FetchAllIngredientsFromActiveMenuItem
	@MenuItemName NVARCHAR(32)
AS
	SELECT I.[Name], MII.AmountUsed
	FROM Restaurant.MenuItems MI
		INNER JOIN Restaurant.MenuItemIngredient MII ON MI.MenuItemID = MII.MenuItemID
		INNER JOIN Restaurant.Ingredients I ON I.IngredientID = MII.IngredientID
	WHERE MI.[Name] = @MenuItemName
		AND MI.EffectiveTo IS NULL