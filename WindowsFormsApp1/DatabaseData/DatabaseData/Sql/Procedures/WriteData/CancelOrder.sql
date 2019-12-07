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
	UPDATE Restaurant.Orders
	SET
		[Status] = 3
	WHERE
		TableID = @TableID
		AND WaiterID = @WaiterID
		AND OrderedOn = @OrderedOn;