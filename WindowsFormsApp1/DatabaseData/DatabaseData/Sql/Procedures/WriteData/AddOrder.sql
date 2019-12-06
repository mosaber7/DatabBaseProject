CREATE OR ALTER PROCEDURE Restaurant.AddOrder
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR (64),
	@OrderDate DATETIMEOFFSET, 
	@TableNumber INT
AS 

	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	DECLARE @TableID INT = Restaurant.RetrieveTableID(@TableNumber);
	INSERT INTO Restaurant.Orders (WaiterID, TableID, OrderedOn)
	VALUES (@WaiterID, @TableID, @OrderDate)
GO

CREATE OR ALTER PROCEDURE Restaurant.AddOrderNoDate
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR (64),
	@TableNumber INT,
	@OrderID INT OUTPUT,
	@OrderDate DATETIMEOFFSET OUTPUT
AS 

	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	DECLARE @TableID INT = Restaurant.RetrieveTableID(@TableNumber);
	INSERT INTO Restaurant.Orders (WaiterID, TableID)
	VALUES (@WaiterID, @TableID)
	SET @OrderID = SCOPE_IDENTITY();
	SET @OrderDate = (
		SELECT O.OrderedOn
		FROM Restaurant.Orders O
		WHERE O.OrderID = @OrderID
	);
GO
