DROP PROCEDURE IF EXISTS Restaurant.CreateWaiter;
GO

CREATE PROCEDURE Restaurant.CreateWaiter
	@FirstName NVARCHAR (64),
	@LastName NVARCHAR (64),
	@Salary DECIMAl
AS 

INSERT Restaurant.Waiters(FirstName, LastName, Salary)
VALUES (@FirstName, @LastName, @Salary);
GO