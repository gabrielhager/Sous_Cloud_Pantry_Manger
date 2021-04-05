CREATE TABLE Ingredients(
	ingredient_name nvarchar(80),
	measurementID int,
	ExpiryDate datetime2,
	--FOREIGN KEY (measurementID) REFERENCES Measurements(measurementID)
);
