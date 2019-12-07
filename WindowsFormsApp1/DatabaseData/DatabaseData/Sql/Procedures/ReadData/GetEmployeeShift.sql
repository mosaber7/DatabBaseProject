CREATE PROCEDURE Restaurant.GetEmployeeShift
  @FirstName NCHAR(32),
 @LastName NCHAR(32)

AS 
--Show Employee shift?
	Select FirstName,LastName,ClockIn,ClockOut
	From Shifts S inner join Waiters W on S.EmployeeID=W.EmployeeID
	Where FirstName=@FirstName And LastName=@LastName