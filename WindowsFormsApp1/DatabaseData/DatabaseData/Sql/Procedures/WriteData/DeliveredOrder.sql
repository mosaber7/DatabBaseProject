CREATE OR ALTER PROCEDURE Restaurant.DeliveredOrder
	@WaiterFirstName NVARCHAR(64),
	@WaiterLastName NVARCHAR(64),
	@TableNumber INT,
	@OrderedOn DATETIMEOFFSET,
	@Tip DECIMAL
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	DECLARE @TableID INT = Restaurant.RetrieveTableID(@TableNumber);
	UPDATE Restaurant.Orders
	SET
		[Status] = 2,
		Tip = @Tip
	WHERE
		TableID = @TableID
		AND WaiterID = @WaiterID
		AND OrderedOn = @OrderedOn;