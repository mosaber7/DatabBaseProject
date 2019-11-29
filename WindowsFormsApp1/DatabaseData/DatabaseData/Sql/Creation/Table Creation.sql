/*
* CIS 560 Project
* 11/9/2019 2:31 PM
*/

/*
* TABLE CREATION
*/
DROP TABLE IF EXISTS Restaurant.FoodIngredient;
DROP TABLE IF EXISTS Restaurant.MenuItemIngredient;
DROP TABLE IF EXISTS Restaurant.Shifts;
DROP TABLE IF EXISTS Restaurant.Foods;
DROP TABLE IF EXISTS Restaurant.Orders;

DROP TABLE IF EXISTS Restaurant.MenuItems;

CREATE TABLE Restaurant.MenuItems
(
	MenuItemID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR (32) NOT NULL,
	Price DECIMAL NOT NULL,
	Description NVARCHAR(1024),
	EffectiveFrom DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	EffectiveTo DATETIMEOFFSET

	UNIQUE ([Name], EffectiveFrom, EffectiveTo)
	
);
GO

---Checks to see if a MenuItem already exists with that name
---whichs is currently Effective
CREATE OR ALTER FUNCTION Restaurant.CheckNameAlreadyExisting
(
	@FoodName NVARCHAR (32),
	@EffectiveDate DATETIMEOFFSET
)
RETURNS BIT
AS
BEGIN 
	IF EXISTS
	(
		SELECT MI.MenuItemID
		FROM Restaurant.MenuItems MI
		WHERE @FoodName = MI.[Name] AND 
		(MI.EffectiveTo =  NULL OR
			MI.EffectiveTo > @EffectiveDate)
	) RETURN 0
	RETURN 1
END;
GO

ALTER TABLE Restaurant.MenuItems
ADD CONSTRAINT CheckUniqueNameOnDate CHECK
(
	Restaurant.CheckNameAlreadyExisting([Name], EffectiveFrom) = 0
)

DROP TABLE IF EXISTS Restaurant.Ingredients;

CREATE TABLE Restaurant.Ingredients
(
	IngredientID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(32) NOT NULL UNIQUE,
	Amount DECIMAL NOT NULL,
	Units NVARCHAR(32) NOT NULL,
	CostPerUnit DECIMAL NOT NULL
);

DROP TABLE IF EXISTS Restaurant.Waiters;

CREATE TABLE Restaurant.Waiters
(
	WaiterID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	FirstName NVARCHAR(64) NOT NULL,
	LastName NVARCHAR(64) NOT NULL,
	HireDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	TerminationDate DATETIMEOFFSET,
	Salary DECIMAL NOT NULL
);

DROP TABLE IF EXISTS Restaurant.Shifts;

CREATE TABLE Restaurant.Shifts
(
	WaiterID INT FOREIGN KEY REFERENCES Restaurant.Waiters(WaiterID),
	ClockInTime DATETIMEOFFSET NOT NULL DEFAULT (SYSDATETIMEOFFSET()),
	ClockOutTime DATETIMEOFFSET
);
GO

---Checks to see if there is an open shift for a certain Waiter
CREATE OR ALTER FUNCTION Restaurant.CheckNoOpenShiftsForWaiter
(
	@WaiterID INT
)
RETURNS BIT
AS
BEGIN 
	IF EXISTS
	(
		SELECT *
		FROM Restaurant.Waiters W
			INNER JOIN Restaurant.Shifts S ON S.WaiterID = W.WaiterID
		WHERE S.ClockOutTime = NULL AND W.WaiterID = @WaiterID
	) RETURN 0
	RETURN 1
END;
GO

ALTER TABLE Restaurant.Shifts
ADD CONSTRAINT CheckUniqueOpenShift CHECK
(
	Restaurant.CheckNoOpenShiftsForWaiter(WaiterID) = 1
)

DROP TABLE IF EXISTS Restaurant.[Tables];

CREATE TABLE Restaurant.[Tables]
(
	TableID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Capacity INT NOT NULL,
	Number INT NOT NULL UNIQUE
);

DROP TABLE IF EXISTS Restaurant.Orders;

CREATE TABLE Restaurant.Orders
(
	OrderID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	WaiterID INT NOT NULL FOREIGN KEY REFERENCES Restaurant.Waiters (WaiterID),
	TableID INT NOT NULL FOREIGN KEY REFERENCES Restaurant.[Tables] (TableID),
	OrderedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	[Status] INT NOT NULL DEFAULT(1),
	Tip DECIMAL

	UNIQUE 
	(
		OrderedOn, TableID
	)
);

DROP TABLE IF EXISTS Restaurant.Foods;

CREATE TABLE Restaurant.Foods
(
	FoodID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	OrderID INT NOT NULL FOREIGN KEY REFERENCES Restaurant.Orders (OrderID),
	MenuItemID INT NOT NULL FOREIGN KEY REFERENCES Restaurant.MenuItems (MenuItemID),
	Quantity INT NOT NULL DEFAULT (1)
);

DROP TABLE IF EXISTS Restaurant.FoodIngredient;

CREATE TABLE Restaurant.FoodIngredient
(
	FoodID INT NOT NULL FOREIGN KEY REFERENCES Restaurant.Foods (FoodID),
	IngredientID INT NOT NULL FOREIGN KEY REFERENCES Restaurant.Ingredients (IngredientID),
	AmountUsed DECIMAL NOT NULL DEFAULT (1)
);

DROP TABLE IF EXISTS Restaurant.MenuItemIngredient;

CREATE TABLE Restaurant.MenuItemIngredient
(
	MenuItemID INT NOT NULL FOREIGN KEY REFERENCES Restaurant.MenuItems (MenuItemID),
	IngredientID INT NOT NULL FOREIGN KEY REFERENCES Restaurant.Ingredients (IngredientID),
	AmountUsed DECIMAL NOT NULL DEFAULT (1)
);