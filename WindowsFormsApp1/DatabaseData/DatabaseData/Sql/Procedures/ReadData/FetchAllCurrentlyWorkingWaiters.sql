CREATE OR ALTER PROCEDURE Restaurant.FetchAllCurrentlyWorkingWaiters
AS
	SELECT W.FirstName, W.LastName
	FROM Restaurant.Waiters W
		INNER JOIN Restaurant.Shifts S ON S.WaiterID = W.WaiterID
	WHERE S.ClockOutTime IS NULL
		OR S.ClockOutTime > SYSDATETIMEOFFSET()
