CREATE PROCEDURE Restaurant.GetShifts
  @FirstName NCHAR(32),
  @LastName NCHAR(32)

AS 
--Show Shifts?
	Select FirstName,LastName,ClockIn,ClockOut
	From Shifts S inner join Waiters W on S.EmployeeID=W.EmployeeID