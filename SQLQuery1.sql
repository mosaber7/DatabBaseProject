CREATE PROCEDURE Restaurant.GetShifts
  @FirstName NCHAR(32),
  @LastName NCHAR(32)

AS 
--Show Shifts?
	Select FirstName,LastName,ClockIn,ClockOut
	From Shifts S inner join Waiters W on S.EmployeeID=W.EmployeeID

	--------------------------


	CREATE PROCEDURE Restaurant.GetOrders
	--Show current orders
	As
		Select O.[Status] ,O.TableID, O.OrderedOn,W.FirstName,W.LastName
		FROM Restaurant.Orders O inner join Restaurant.Waiters W on O.WaiterID=W.WaiterID
		Where Status =1

----------------------------------------------------------------------------------




CREATE PROCEDURE Restaurant.GetEmployeeShift
  @FirstName NCHAR(32),
 @LastName NCHAR(32)

AS 
--Show Employee shift?
	Select FirstName,LastName,ClockIn,ClockOut
	From Shifts S inner join Waiters W on S.EmployeeID=W.EmployeeID
	Where FirstName=@FirstName And LastName=@LastName
