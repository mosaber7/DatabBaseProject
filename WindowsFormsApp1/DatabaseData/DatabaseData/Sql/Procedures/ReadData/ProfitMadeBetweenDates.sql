CREATE OR ALTER PROCEDURE Restaurant.ProfitMadeBetweenDates
	@StartingDate DATETIMEOFFSET,
	@EndingDate DATETIMEOFFSET
AS
	WITH MonthlyProfit ([Year], [Month], TotalEarnings, WorkersWagesLoss, IngredientsLoss, MonthProfit)
	AS
	(
		SELECT YEAR(O.OrderedOn), MONTH(O.OrderedOn), SUM(MI.Price * F.Quantity) AS TotalEarnings,
			SUM(DATEDIFF(MINUTE, S.ClockInTime, S.ClockOutTime) * W.Salary * 60)  / 60 AS WorkersWagesLoss,
			SUM(I.CostPerUnit * FI.AmountUsed) AS IngredientsLoss,
			SUM(MI.Price * F.Quantity) - SUM(DATEDIFF(MINUTE, S.ClockInTime, S.ClockOutTime) * W.Salary * 60) / 60 - SUM(I.CostPerUnit * FI.AmountUsed) AS MonthProfit
		FROM Restaurant.Orders O
			INNER JOIN Restaurant.Foods F ON F.OrderID = O.OrderID
			INNER JOIN Restaurant.MenuItems MI ON F.MenuItemID = MI.MenuItemID
			INNER JOIN Restaurant.FoodIngredient FI ON F.FoodID = FI.FoodID
			INNER JOIN Restaurant.Ingredients I ON FI.IngredientID = I.IngredientID
			INNER JOIN Restaurant.Waiters W ON O.WaiterID = W.WaiterID
			INNER JOIN Restaurant.Shifts S ON S.WaiterID = W.WaiterID
		WHERE S.ClockOutTime IS NOT NULL AND
			O.[Status] = 2 AND 
			O.OrderedOn BETWEEN @StartingDate AND DATEADD(DAY, 1, @EndingDate) AND
			S.ClockInTime BETWEEN @StartingDate AND DATEADD(DAY,1,@EndingDate)
		GROUP BY MONTH(O.OrderedOn), YEAR(O.OrderedOn)
	)
	SELECT MP.[Year], MP.[Month], MP.TotalEarnings, MP.WorkersWagesLoss, MP.IngredientsLoss, MP.MonthProfit, 
	CASE WHEN LAG(MP.MonthProfit, 1) OVER (PARTITION BY MP.[Month] ORDER BY MP.[Year] ASC, MP.[Month] ASC) IS  NOT NULL
		THEN LAG(MP.MonthProfit, 1) OVER (PARTITION BY MP.[Month] ORDER BY MP.[Year] ASC, MP.[Month] ASC) + MP.MonthProfit
		ELSE MP.MonthProfit END AS TotalProfit
	FROM MonthlyProfit MP
	ORDER BY MP.[Year] ASC, MP.[Month] ASC;

