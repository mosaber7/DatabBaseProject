CREATE OR ALTER PROCEDURE Restaurant.RemoveMenuItem
	@MenuItemName NVARCHAR(32)
AS
	UPDATE Restaurant.MenuItems
	SET
		EffectiveTo = SYSDATETIMEOFFSET()
	WHERE
		MenuItemID = Restaurant.RetrieveActiveMenuItemID(@MenuItemName)