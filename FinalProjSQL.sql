--Employees by Salary
Select Name,Salary
From Resturant.Waiters
Order By Salary Dec;

--highest payed

Select [Name],max(Salary)
From Resturant.Waiters
Group By [Name]

--Cost of empolyee salaries
Select Sum(Salary)
From Resturant.Waiters
Group by EmployeeID

-- what is the cost of the order on the resturant?
Select O.OrderID,T.TableID as TableNumber ,F.Name , OrderedOn Sum(FO.Quantity*FI.AmountUsed*I.CostPerUnit)
From Orders O Inner join [Tables] T on O.OrderID=T.OrderID
Inner join FoodOrders FO on FO.OrderID= O.OrderID
inner join Foods F on F.FoodID=FO.FoodID 
inner join FoodIngredients FI on FI.FoodID =F.FoodID
inner join Ingredients I on I.IngredientID = FI.IngredientID
Group by O.OrderID,T.TableID ,TableNumber ,F.Name
Order By O.OrderID ASC;

--Show Shifts?
Select *
From Shifts

--Add MenuItem.
DECLARE @MenuName NCHAR(32);;
DECLARE @Price INT;
DECLARE @Description NCHAR(32);
INSERT Resturant.MenuItem([Name], Price,[Description])
VALUES
   (@MenuName, @Price,@Description)

--Insert Table

DECLARE @Capacity INT;
DECLARE @Number INT;
INSERT Resturant.[Tables](Capacity,Area)
VALUES
   (@Capacity, @Number)

--YOU GOT A RAISE!
DECLARE  @FirstName NCHAR(32);
DECLARE @LastName NCHAR(32);
DECLARE @RaisePercent INT;
UPDATE Resturant.Waiters
	SET
	Salary=Salary*@RaisePercent
	WHERE Waiters.EmployeeID =
      (
         SELECT Waiters.ClubId
         FROM  Resturant.Waiters
         WHERE Waiters.FirstName = @FirstName
		 And Waiters.LastName = @LastName
      )
	

--Shift Time Change
DECLARE  @FirstName NCHAR(32);
DECLARE @LastName NCHAR(32);
--DECLARE @LastName NCHAR(32);
DECLARE @ClockIN DATETIMEOFFSET;
DECLARE @ClockOut DATETIMEOFFSET;
UPDATE Resturant.Shifts
	SET
	ClockInTime=@ClockIN
	ClockOutTime=@ClockOut
	WHERE Shifts.EmployeeID=
      (
         SELECT Waiters.ClubId
         FROM  Resturant.Waiters
         WHERE Waiters.FirstName = @FirstName
		 And Waiters.LastName = @LastName
      )
	

	--Show current orders
	Select O.[Status] ,O.TableID, O.OrderedOn,W.FirstName
	FROM Restaurant.Orders O inner join Restaurant.Waiters W on O.WaiterID=W.WaiterID
	Where Status !=1






