CREATE PROCEDURE Restaurant.GetOrders
	--Show current orders
	As
	Select O.[Status] ,O.TableID, O.OrderedOn,W.FirstName,W.LastName
	FROM Restaurant.Orders O inner join Restaurant.Waiters W on O.WaiterID=W.WaiterID
	Where Status =1

	Go