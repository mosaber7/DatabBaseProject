CREATE OR ALTER PROCEDURE Restaurant.AddTable
	@TableNumber INT,
	@Capacity INT
AS
	INSERT INTO Restaurant.[Tables] ([Number], Capacity)
	VALUES (@TableNumber, @Capacity)