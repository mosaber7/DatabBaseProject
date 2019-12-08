CREATE OR ALTER FUNCTION Restaurant.RetrieveTableID
(
	@TableNumber INT
)
RETURNS INT
AS
BEGIN
	DECLARE @TableID INT =
	(
		SELECT T.TableID
		FROM Restaurant.[Tables] T
		WHERE T.[Number] = @TableNumber
	);

	RETURN @TableID
END;
GO

CREATE OR ALTER FUNCTION Restaurant.RetrieveOrderID
(
	@TableID INT,
	@OrderDate DATETIMEOFFSET
)
RETURNS INT
AS
BEGIN
	DECLARE @OrderID INT =
	(
		SELECT O.OrderID
		FROM Restaurant.Orders O
		WHERE O.TableID = @TableID
		AND @OrderDate = O.OrderedOn
	)

	RETURN @OrderID
END;
GO

CREATE OR ALTER FUNCTION Restaurant.RetrieveActiveMenuItemID
(
	@Name NVARCHAR(32)
)
RETURNS INT
AS
BEGIN
	RETURN
	(
		SELECT MI.MenuItemID
		FROM Restaurant.MenuItems MI
		WHERE MI.[Name] = @Name
			AND MI.EffectiveTo IS NULL
	)
END;
GO

CREATE OR ALTER FUNCTION Restaurant.RetrieveIngredientID
(
	@Name NVARCHAR (32)
)
RETURNS INT
AS
BEGIN
	RETURN
	(
		SELECT I.IngredientID
		FROM Restaurant.Ingredients I
		WHERE I.[Name] = @Name
	)
END;
GO

CREATE OR ALTER FUNCTION Restaurant.RetrieveWaiter
(
	@WaiterFirstName NVARCHAR(64),
	@WaiterLastName NVARCHAR(64)
)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT W.WaiterID
			FROM Restaurant.Waiters W
			WHERE W.FirstName = @WaiterFirstName 
				AND W.LastName = @WaiterLastName
				AND TerminationDate IS NULL
		)
END;
GO
		
