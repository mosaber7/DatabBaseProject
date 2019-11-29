CREATE OR ALTER PROCEDURE Restaurant.AddMenuItem
	@MenuItemName NVARCHAR (32),
	@Price INT,
	@Description NVARCHAR(1024)
AS
	---Checks to see if a Menu Item with that name already exists
	IF NOT EXISTS
		(
			SELECT MI.MenuItemID
			FROM Restaurant.MenuItems MI
			WHERE @MenuItemName = MI.[Name] AND 
				MI.EffectiveTo IS NULL
		) 
		INSERT INTO Restaurant.MenuItems([Name], Price, Description)
		VALUES(@MenuItemName, @Price, @Description)
	ELSE
		THROW 50000, 'There is already a Menu Item with that name', 1

