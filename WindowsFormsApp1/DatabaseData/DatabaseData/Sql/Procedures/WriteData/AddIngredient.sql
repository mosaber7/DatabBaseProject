CREATE OR ALTER PROCEDURE Restaurant.AddIngredient
	@Name NVARCHAR(32),
	@Amount DECIMAL,
	@Units NVARCHAR (32),
	@CostPerUnit DECIMAL
AS
	INSERT INTO Restaurant.Ingredients([Name], Amount, Units, CostPerUnit)
	VALUES (@Name, @Amount, @Units, @CostPerUnit)