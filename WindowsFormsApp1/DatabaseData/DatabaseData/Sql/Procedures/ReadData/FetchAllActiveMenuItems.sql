CREATE OR ALTER PROCEDURE Restaurant.FetchAllActiveMenuItems
AS
	SELECT MI.[Name], MI.[Description], MI.Price
	FROM Restaurant.MenuItems MI
	WHERE MI.EffectiveTo IS NULL