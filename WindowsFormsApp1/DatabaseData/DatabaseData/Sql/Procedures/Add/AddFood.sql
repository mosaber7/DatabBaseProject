CREATE OR ALTER PROCEDURE Restaurant.CreateFood
	@TableNumber INT,
	@OrderDate DATETIMEOFFSET,
	@MenuItemName NVARCHAR(32),
	@Quantity INT
AS
	DECLARE @TableID INT =
	(
		SELECT T.TableID
		FROM Restaurant.[Tables] T
		WHERE T.Number = @TableNumber
	)
	DECLARE @OrderID INT =
	(
		SELECT O.OrderID
		FROM Restaurant.Orders O
		WHERE O.TableID = @TableID
		AND @OrderDate = O.OrderedOn
	)
	DECLARE @MenuItemID INT =
	(
		SELECT MI.MenuItemID
		FROM Restaurant.MenuItems MI
		WHERE @MenuItemName = MI.[Name]
		AND EffectiveTo = NULL
	)
	INSERT INTO Restaurant.Foods (OrderID, MenuItemID, Quantity)
	VALUES (@OrderID, @MenuItemID, @Quantity)
GO