CREATE OR ALTER PROCEDURE Restaurant.MostOrderedFoodInYear
	@Year INT
AS
	SELECT MI.[Name] AS ProductName, SUM(F.Quantity) AS AmountSoldInYear,
		SUM(MI.Price * F.Quantity) AS TotalEarnings
	FROM Restaurant.Orders O
		INNER JOIN Restaurant.Foods F ON F.OrderID = O.OrderID
		INNER JOIN Restaurant.MenuItems MI ON MI.MenuItemID = F.MenuItemID
	WHERE YEAR(O.OrderedOn) = @YEAR
	GROUP BY MI.[Name], MI.Price
	ORDER BY AmountSoldInYear DESC, TotalEarnings DESC
		