CREATE OR ALTER PROCEDURE Restaurant.AddOrder
	@WaiterFirstName NVARCHAR (32),
	@WaiterLastName NVARCHAR (32),
	@OrderDate DATETIMEOFFSET, 
	@TableNumber INT
AS 

	DECLARE @WaiterID INT =
		(
			SELECT W.WaiterID
			FROM Restaurant.Waiters W
			WHERE W.FirstName = @WaiterFirstName 
				AND W.LastName = @WaiterLastName
				AND TerminationDate IS NULL
		)

	DECLARE @TableID INT =
		(
			SELECT T.TableID
			FROM Restaurant.[Tables] T
			WHERE T.Number = @TableNumber
		)
	INSERT INTO Restaurant.Orders (WaiterID, TableID, OrderedOn)
	VALUES (@WaiterID, @TableID, @OrderDate)
GO