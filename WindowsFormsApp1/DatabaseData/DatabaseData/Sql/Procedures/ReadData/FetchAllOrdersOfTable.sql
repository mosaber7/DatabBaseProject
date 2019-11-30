CREATE OR ALTER PROCEDURE Restaurant.FetchAllOrdersOfTable
	@TableNumber INT
AS
	SELECT W.FirstName, W.LastName, O.OrderID, O.OrderedOn
	FROM Restaurant.Orders O
		INNER JOIN Restaurant.[Tables] T ON T.TableID = O.TableID
		INNER JOIN Restaurant.Waiters W ON W.WaiterID = O.WaiterID
	WHERE O.[Status] = 1
		AND T.Number = @TableNumber
	ORDER BY O.OrderedOn ASC;