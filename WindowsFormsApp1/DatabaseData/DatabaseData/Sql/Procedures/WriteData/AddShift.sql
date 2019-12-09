CREATE OR ALTER PROCEDURE Restaurant.AddShift
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR (64),
	@ClockIn DATETIMEOFFSET
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	IF(@WaiterID IS NULL)
		THROW 50000,'Waiter not found in the database',1
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
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR (64),
	@ClockIn DATETIMEOFFSET OUTPUT
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	IF(@WaiterID IS NULL)
		THROW 50000,'Waiter not found in the database',1
	---If that waiter doesn't have an open shift already
	IF NOT EXISTS
	(
		SELECT *
		FROM Restaurant.Waiters W
			INNER JOIN Restaurant.Shifts S ON S.WaiterID = W.WaiterID
		WHERE S.ClockOutTime IS NULL
			AND @WaiterID = W.WaiterID
	)
	BEGIN
		INSERT INTO Restaurant.Shifts(WaiterID)
		VALUES(@WaiterID);
		SET @ClockIn = (
			SELECT S.ClockInTime
			FROM Restaurant.Waiters W
				INNER JOIN Restaurant.Shifts S ON W.WaiterID = S.WaiterID
			WHERE W.WaiterID = @WaiterID
				AND S.ClockOutTime IS NULL
		);
	END
	ELSE
		THROW 50000, 'The Waiter already has an open shift', 1