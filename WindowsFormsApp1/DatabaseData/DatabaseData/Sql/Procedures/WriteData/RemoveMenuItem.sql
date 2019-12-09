CREATE OR ALTER PROCEDURE Restaurant.RemoveMenuItem
	@MenuItemName NVARCHAR(32)
AS
	DECLARE @MenuItemID INT= Restaurant.RetrieveActiveMenuItemID(@MenuItemName);
	IF(@MenuItemID IS NULL)
		THROW 50000, 'Menu Item not found in the database', 1
	UPDATE Restaurant.MenuItems
	SET
		EffectiveTo = SYSDATETIMEOFFSET()
	WHERE
		MenuItemID = @MenuItemID