CREATE OR ALTER PROCEDURE Restaurant.RestockIngredient
	@IngredientName NVARCHAR(32),
	@AmountToRestock DECIMAL
AS
	UPDATE Restaurant.Ingredients
	SET
		Amount = Amount + @AmountToRestock
	WHERE
		[Name] = @IngredientName;