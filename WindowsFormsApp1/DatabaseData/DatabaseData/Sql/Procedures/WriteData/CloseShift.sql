CREATE OR ALTER PROCEDURE Restaurant.CloseShift
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR (64),
	@ClockOut DATETIMEOFFSET
AS
	UPDATE Restaurant.Shifts
	SET
		ClockOutTime = @ClockOut
	WHERE WaiterID = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName)
		AND ClockOutTime IS NULL
GO

CREATE OR ALTER PROCEDURE Restaurant.CloseShiftNoDate
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR (64),
	@ClockOut DATETIMEOFFSET OUTPUT
AS
	SET @ClockOut = SYSDATETIMEOFFSET();
	UPDATE Restaurant.Shifts
	SET
		ClockOutTime = @ClockOut
	WHERE WaiterID = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName)
		AND ClockOutTime IS NULL
GO