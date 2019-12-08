CREATE OR ALTER PROCEDURE Restaurant.WaitersWorkOnDay
	@Date DATETIMEOFFSET
AS
	DECLARE @YearOfDate INT = YEAR(@Date);
	DECLARE @MonthOfDate INT = MONTH(@Date);
	DECLARE @DayOfDate INT = DAY(@Date);

	SELECT W.FirstName, W.LastName,
		DATEDIFF(minute, S.ClockInTime, S.ClockOutTime) / 60 AS HoursWorked,
		DATEDIFF(minute, S.ClockInTime, S.ClockOutTime) * W.Salary / 60 AS WorkersEarnings,
		COUNT(DISTINCT O.OrderID) AS OrdersServed
	FROM Restaurant.Waiters W
		INNER JOIN Restaurant.Shifts S ON S.WaiterID = W.WaiterID
		INNER JOIN Restaurant.Orders O ON O.WaiterID = W.WaiterID
	WHERE YEAR(S.ClockInTime) = @YearOfDate AND
		MONTH(S.ClockInTime) = @MonthOfDate AND
		DAY(S.ClockInTime) = @DayOfDate AND
		O.[Status] = 2
	GROUP BY W.FirstName, W.LastName, W.Salary, S.ClockInTime, S.ClockOutTime