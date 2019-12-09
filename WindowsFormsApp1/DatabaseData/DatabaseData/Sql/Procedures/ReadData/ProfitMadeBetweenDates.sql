CREATE OR ALTER PROCEDURE Restaurant.ProfitMadeBetweenDates
	@StartingDate DATETIMEOFFSET,
	@EndingDate DATETIMEOFFSET
AS
	WITH MonthlyProfit ([Year], [Month], TotalEarnings, WorkersWagesLoss, IngredientsLoss, MonthProfit)
	AS
	(
		SELECT YEAR(O.OrderedOn), MONTH(O.OrderedOn),
		(
			SELECT SUM(F.Quantity * MI.Price)
			FROM Restaurant.Orders OS
				INNER JOIN Restaurant.Foods F ON F.OrderID = OS.OrderID
				INNER JOIN Restaurant.MenuItems MI ON MI.MenuItemID = F.MenuItemID
			WHERE YEAR(OS.OrderedOn) = YEAR(O.OrderedOn)
				AND MONTH(OS.OrderedOn) = MONTH(O.OrderedOn)
		) AS TotalEarnings,
			SUM(DATEDIFF(MINUTE, S.ClockInTime, S.ClockOutTime) * W.Salary) / 60 AS WorkersWagesLoss,
			(
				SELECT SUM(I.CostPerUnit * FI.AmountUsed)
				FROM Restaurant.Orders OS
					INNER JOIN Restaurant.Foods F ON F.OrderID = OS.OrderID
					INNER JOIN Restaurant.FoodIngredient FI ON FI.FoodID = F.FoodID
					INNER JOIN Restaurant.Ingredients I ON I.IngredientID = FI.IngredientID
				WHERE YEAR(OS.OrderedOn) = YEAR(O.OrderedOn)
					AND MONTH(OS.OrderedOn) = MONTH(O.OrderedOn)
			)
			AS IngredientsLoss,
			(
				SELECT SUM(F.Quantity * MI.Price)
				FROM Restaurant.Orders OS
					INNER JOIN Restaurant.Foods F ON F.OrderID = OS.OrderID
					INNER JOIN Restaurant.MenuItems MI ON MI.MenuItemID = F.MenuItemID
				WHERE YEAR(OS.OrderedOn) = YEAR(O.OrderedOn)
					AND MONTH(OS.OrderedOn) = MONTH(O.OrderedOn)
			) - SUM(DATEDIFF(MINUTE, S.ClockInTime, S.ClockOutTime) * W.Salary) / 60 - 
			(
				SELECT SUM(I.CostPerUnit * FI.AmountUsed)
				FROM Restaurant.Orders OS
					INNER JOIN Restaurant.Foods F ON F.OrderID = OS.OrderID
					INNER JOIN Restaurant.FoodIngredient FI ON FI.FoodID = F.FoodID
					INNER JOIN Restaurant.Ingredients I ON I.IngredientID = FI.IngredientID
				WHERE YEAR(OS.OrderedOn) = YEAR(O.OrderedOn)
					AND MONTH(OS.OrderedOn) = MONTH(O.OrderedOn)
			) AS MonthProfit
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

