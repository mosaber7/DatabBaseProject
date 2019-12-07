CREATE OR ALTER PROCEDURE Restaurant.FetchAllIngredientsFromFood
	@FoodID INT
AS
	SELECT I.[Name], FI.AmountUsed
	FROM Restaurant.Foods F
		INNER JOIN Restaurant.FoodIngredient FI ON F.FoodID = FI.FoodID
		INNER JOIN Restaurant.Ingredients I ON I.IngredientID = FI.IngredientID
	WHERE FI.FoodID = @FoodID
GO