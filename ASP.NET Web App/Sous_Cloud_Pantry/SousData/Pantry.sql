CREATE TABLE Pantry(
	UserID int,
	PantryLocation nvarchar(40),
	PRIMARY KEY (PantryLocation),
	--FOREIGN KEY (UserID) REFERENCES UserTable(UserID)
);