CREATE OR ALTER PROCEDURE Restaurant.CloseShift
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR (64),
	@ClockOut DATETIMEOFFSET
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	IF(@WaiterID IS NULL)
		THROW 50000,'Waiter not found in the database',1
	UPDATE Restaurant.Shifts
	SET
		ClockOutTime = @ClockOut
	WHERE WaiterID = @WaiterID
		AND ClockOutTime IS NULL
GO

CREATE OR ALTER PROCEDURE Restaurant.CloseShiftNoDate
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR (64),
	@ClockOut DATETIMEOFFSET OUTPUT
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	IF(@WaiterID IS NULL)
		THROW 50000,'Waiter not found in the database',1
	SET @ClockOut = SYSDATETIMEOFFSET();
	UPDATE Restaurant.Shifts
	SET
		ClockOutTime = @ClockOut
	WHERE WaiterID = @WaiterID
		AND ClockOutTime IS NULL
GO