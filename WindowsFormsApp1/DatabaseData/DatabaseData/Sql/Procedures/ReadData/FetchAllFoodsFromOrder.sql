CREATE OR ALTER PROCEDURE Restaurant.FetchAllFoodsFromOrder
	@WaiterFirstName NVARCHAR(64),
	@WaiterLastName NVARCHAR(64),
	@TableNumber INT,
	@OrderdedOn DATETIMEOFFSET
AS
	DECLARE @WaiterID INT = Restaurant.RetrieveWaiter(@WaiterFirstName, @WaiterLastName);
	DECLARE @TableID INT = Restaurant.RetrieveTableID(@TableNumber);
	SELECT MI.[Name], F.Quantity, MI.Price
	FROM Restaurant.Orders O
		INNER JOIN Restaurant.Foods F ON F.OrderID = O.OrderID
		INNER JOIN Restaurant.MenuItems MI ON F.MenuItemID = MI.MenuItemID
	WHERE
		O.TableID = @TableID AND O.WaiterID = @WaiterID
		AND O.OrderedOn = @OrderdedOn
