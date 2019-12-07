CREATE OR ALTER PROCEDURE Restaurant.SalesFromDay
	@Date DATETIMEOFFSET
AS
	DECLARE @YearOfDate INT = YEAR(@Date);
	DECLARE @MonthOfDate INT = MONTH(@Date);
	DECLARE @DayOfDate INT = DAY(@Date);

	SELECT MI.[Name] AS ProductName, SUM(F.Quantity) AS OrderedTimes, SUM(MI.Price * F.Quantity) AS TotalSalesOnItem
	FROM Restaurant.Orders O
		INNER JOIN Restaurant.Foods F ON F.OrderID = O.OrderID
		INNER JOIN Restaurant.MenuItems MI ON F.MenuItemID = MI.MenuItemID
	WHERE YEAR(O.OrderedOn) = @YearOfDate AND
		MONTH(O.OrderedOn) = @MonthOfDate AND
		DAY(O.OrderedOn) = @DayOfDate AND
		O.[Status] = 2
	GROUP BY MI.[Name]
	ORDER BY TotalSalesOnItem DESC, OrderedTimes DESC;