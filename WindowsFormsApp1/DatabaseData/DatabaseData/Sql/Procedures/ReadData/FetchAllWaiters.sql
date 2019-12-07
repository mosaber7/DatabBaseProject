CREATE OR ALTER PROCEDURE Restaurant.FetchAllWaiters
AS
	SELECT W.FirstName, W.LastName, W.Salary
	FROM Restaurant.Waiters W
	WHERE TerminationDate IS NULL OR
		TerminationDate > SYSDATETIMEOFFSET();