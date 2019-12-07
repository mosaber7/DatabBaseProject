CREATE OR ALTER PROCEDURE Restaurant.FireWaiter
	@WaiterFirstName NVARCHAR (64),
	@WaiterLastName NVARCHAR(64)
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter (@WaiterFirstName, @WaiterLastName);
	IF @WaiterID IS NOT NULL
	BEGIN
		UPDATE Restaurant.Waiters
		SET
			TerminationDate = SYSDATETIMEOFFSET()
		WHERE WaiterID = @WaiterID
	END
GO
		
