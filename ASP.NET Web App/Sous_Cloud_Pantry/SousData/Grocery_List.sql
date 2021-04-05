CREATE TABLE Grocery_List(
	UserID int,
	ListItem nvarchar(80),
	PRIMARY KEY (ListItem),
	--FOREIGN KEY (UserID) REFERENCES UserTable(UserID)
);
