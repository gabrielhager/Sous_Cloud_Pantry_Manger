CREATE TABLE Recipes(
	Title nvarchar(40),
	Ingredient_List nvarchar(80)
	--FOREIGN KEY (Ingredient_List) REFERENCES Grocery_List(ListItem)
);