CREATE OR ALTER PROCEDURE Restaurant.DeliveredOrder
	@OrderID INT,
	@Tip DECIMAL
AS
	UPDATE Restaurant.Orders
	SET
		[Status] = 2,
		Tip = @Tip
	WHERE
		OrderID = @OrderID;

	WITH IngredientsUsed (IngredientID, AmountUsed) AS
	(
		SELECT I.IngredientID, SUM(FI.AmountUsed * F.Quantity)
		FROM Restaurant.Foods F 
			INNER JOIN Restaurant.FoodIngredient FI ON F.FoodID = FI.FoodID
			INNER JOIN Restaurant.Ingredients I ON I.IngredientID = FI.IngredientID
		WHERE F.OrderID = @OrderID
		GROUP BY I.IngredientID
	)
	MERGE Restaurant.Ingredients I
	USING IngredientsUsed IU ON I.IngredientID = IU.IngredientID
	WHEN MATCHED THEN
		UPDATE
		SET
			I.Amount = I.Amount - IU.AmountUsed;
GO