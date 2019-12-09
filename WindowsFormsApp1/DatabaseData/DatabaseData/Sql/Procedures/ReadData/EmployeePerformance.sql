CREATE OR ALTER PROCEDURE Restaurant.EmployeePerformance
	@Year INT,
	@Month INT
AS
	SELECT W.FirstName, W.LastName, SUM(DATEDIFF(SECOND, S.ClockInTime, S.ClockOutTime)) / 3600 AS HoursWorked,
		COUNT(DISTINCT O.OrderID) AS OrdersServed,
		(
			SELECT SUM(O.Tip)
			FROM Restaurant.Orders O
				INNER JOIN Restaurant.Waiters WA ON WA.WaiterID = O.WaiterID
			WHERE W.WaiterID = O.WaiterID AND
				MONTH(O.OrderedOn) = @Month AND
				YEAR(O.OrderedOn) = @Year
			GROUP BY WA.WaiterID
		) AS TotalTipEarnings,
		(
			SELECT SUM(O.Tip)
			FROM Restaurant.Orders O
				INNER JOIN Restaurant.Waiters WA ON WA.WaiterID = O.WaiterID
			WHERE W.WaiterID = O.WaiterID AND
				MONTH(O.OrderedOn) = @Month AND
				YEAR(O.OrderedOn) = @Year
			GROUP BY WA.WaiterID
		) / COUNT(DISTINCT O.OrderID) AS AverageTipOrder
	FROM Restaurant.Waiters W
		INNER JOIN Restaurant.Shifts S ON S.WaiterID = W.WaiterID
		INNER JOIN Restaurant.Orders O ON W.WaiterID = O.WaiterID
	WHERE MONTH(O.OrderedOn) = @Month AND
		MONTH(S.ClockInTime) = @Month AND
		YEAR(O.OrderedOn) = @Year AND
		YEAR(S.ClockInTime) = @Year AND
		O.[Status] = 2
	GROUP BY W.FirstName, W.LastName, W.WaiterID
	--ORDER BY AverageTipOrder DESC, TotalTipEarnings DESC, HoursWorked DESC;