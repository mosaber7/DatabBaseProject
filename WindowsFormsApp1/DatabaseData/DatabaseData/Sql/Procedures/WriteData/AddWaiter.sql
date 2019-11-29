DROP PROCEDURE IF EXISTS Restaurant.AddWaiter;
GO

CREATE PROCEDURE Restaurant.AddWaiter
	@FirstName NVARCHAR (64),
	@LastName NVARCHAR (64),
	@Salary DECIMAl
AS 
	IF NOT EXISTS
		(
			SELECT *
			FROM Restaurant.Waiters W
			WHERE W.FirstName = @FirstName
				AND W.LastName = @LastName
				AND W.TerminationDate IS NULL
		)
			INSERT Restaurant.Waiters(FirstName, LastName, Salary)
			VALUES (@FirstName, @LastName, @Salary);
	ELSE
		THROW 50001, 'There is already a Waiter with that Name and LastName', 1
GO