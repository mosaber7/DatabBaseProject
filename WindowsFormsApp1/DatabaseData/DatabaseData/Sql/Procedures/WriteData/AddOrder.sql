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
	@TableNumber INT
AS 

	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	DECLARE @TableID INT = Restaurant.RetrieveTableID(@TableNumber);
	INSERT INTO Restaurant.Orders (WaiterID, TableID)
	VALUES (@WaiterID, @TableID)
GO
