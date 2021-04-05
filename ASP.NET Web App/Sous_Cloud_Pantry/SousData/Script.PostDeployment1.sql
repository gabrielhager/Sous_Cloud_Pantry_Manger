/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

MERGE INTO UserTable AS Target 
USING (VALUES 
        (1, 'gabrielHager', 'superSecurepw', 'gabriel.a.hager@outlook.com'),
        (2, 'bethanyHager', 'badpw', 'mywife@outlook.com'),
        (3, 'roseHager', 'babypw', 'littlebaby@outlook.com')
) 
AS Source (UserID, UserName, User_PW, EmailAddress) 
ON Target.UserID = Source.UserID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (UserName, User_PW, EmailAddress) 
VALUES (UserName, User_PW, EmailAddress);

MERGE INTO Grocery_List AS Target
USING (VALUES 
        (1, 'eggs'),
        (1, 'milk'),
        (1, 'bread'),
        (1, 'beans'),
        (1, 'orange juice'),
        (1, 'butter'),
        (1, 'noodles')
)
AS Source (UserID, ListItem)
ON Target.UserID = Source.UserID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ListItem)
VALUES (ListItem);

MERGE INTO Recipes AS Target
USING (VALUES 
('Jake''s Spaghetti', 'noodles'),
('Black Bean Burgers', 'beans'),
('Gabe''s Scrambler', 'eggs')
)
AS Source (Title, Ingredient_List)
ON Target.Title = Source.Title
WHEN NOT MATCHED BY TARGET THEN
INSERT (Ingredient_List)
VALUES (Ingredient_List);

MERGE INTO Pantry AS Target
USING (VALUES 
        (1, 'Refrigerator'),
        (1, 'Dry Pantry')
)
AS Source (UserID, PantryLocation)
ON Target.UserID = Source.UserID
WHEN NOT MATCHED BY TARGET THEN
INSERT (PantryLocation)
VALUES (PantryLocation);

MERGE INTO Measurements AS Target
USING (VALUES 
        (1, 'Quantity'),
        (2, 'Weight in oz'),
        (3, 'Weight in cups')
)
AS Source (measurementID, measurementMethod)
ON Target.measurementID = Source.measurementID
WHEN NOT MATCHED BY TARGET THEN
INSERT (measurementMethod)
VALUES (measurementMethod);

MERGE INTO Ingredients AS Target
USING (VALUES 
        ('Brocoli', 3, '20210815'),
        ('Fiber One', 1, '20210815'),
        ('Gold Fish', 1, '20210815'),
        ('Frozen Chicken', 2, '20210815'),
        ('Apple Juice', 3, '20210815'),
        ('Frozen Pizza', 1, '20210815'),
        ('Cookies', 1, '20210815')
)
AS Source (ingredient_name, measurementID, ExpiryDate)
ON Target.ingredient_name = Source.ingredient_name
WHEN NOT MATCHED BY TARGET THEN
INSERT (measurementID, ExpiryDate)
VALUES (measurementID, ExpiryDate);
