CREATE OR ALTER PROCEDURE Restaurant.FireWaiter
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR(64)
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter (@WaiterFirstName, @WaiterLastName);
	IF(@WaiterID IS NULL)
		THROW 50000,'Waiter not found in the database',1
	UPDATE Restaurant.Waiters
	SET
		TerminationDate = SYSDATETIMEOFFSET()
	WHERE WaiterID = @WaiterID
GO
		
