CREATE OR ALTER PROCEDURE Restaurant.CancelOrder
	@OrderID INT
AS
	UPDATE Restaurant.Orders
	SET
		[Status] = 3
	WHERE
		OrderID = @OrderID
GO

CREATE OR ALTER PROCEDURE Restaurant.CancelOrderUsingWaiterTableDate
	@WaiterFirstName NVARCHAR(64),
	@WaiterLastName NVARCHAR(64),
	@TableNumber INT,
	@OrderedOn DATETIMEOFFSET
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	DECLARE @TableID INT = Restaurant.RetrieveTableID(@TableNumber);
	IF(@WaiterID IS NULL)
		THROW 50000,'Waiter not found in the database',1
	IF(@TableID IS NULL)
		THROW 50000,'Table not found in the database',1
	UPDATE Restaurant.Orders
	SET
		[Status] = 3
	WHERE
		TableID = @TableID
		AND WaiterID = @WaiterID
		AND OrderedOn = @OrderedOn;