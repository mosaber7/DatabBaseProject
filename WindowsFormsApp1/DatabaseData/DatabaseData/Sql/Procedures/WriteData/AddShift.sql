CREATE OR ALTER PROCEDURE Restaurant.AddShift
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR (64),
	@ClockIn DATETIMEOFFSET
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	---If that waiter doesn't have an open shift already
	IF NOT EXISTS
	(
		SELECT *
		FROM Restaurant.Waiters W
			INNER JOIN Restaurant.Shifts S ON S.WaiterID = W.WaiterID
		WHERE S.ClockOutTime IS NULL
			AND @WaiterID = W.WaiterID
	)
	INSERT INTO Restaurant.Shifts(WaiterID, ClockInTime)
	VALUES(@WaiterID, @ClockIn);
	ELSE
		THROW 50000, 'The Waiter already has an open shift', 1
GO

CREATE OR ALTER PROCEDURE Restaurant.AddShiftNoDate
	@WaiterFirstName NVARCHAR (32),
	@WaiterLastName NVARCHAR (32)
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	---If that waiter doesn't have an open shift already
	IF NOT EXISTS
	(
		SELECT *
		FROM Restaurant.Waiters W
			INNER JOIN Restaurant.Shifts S ON S.WaiterID = W.WaiterID
		WHERE S.ClockOutTime IS NULL
			AND @WaiterID = W.WaiterID
	)
	INSERT INTO Restaurant.Shifts(WaiterID)
	VALUES(@WaiterID);
	ELSE
		THROW 50000, 'The Waiter already has an open shift', 1