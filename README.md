# Sous: Cloud Pantry Manger 
## [Table of Contents](#table-of-contents)
1) [Concept](#Concept)
2) [Entity Relationship Diagram](#Entity-Relationship-Diagram)
3) [User Stories](#User-Stories)
4) [Use Cases](#Use-Cases)
5) [Use Case Diagram](#Use-Case-Diagram)
6) [Draft Wire Frames](#Draft-Wire-Frames)
7) [Home](#Home)
8) [Pantry Inventory](#Pantry-Inventory)
9) [Recipe Book](#Recipe-Book)
10) [Requirements List](#Requirements-List)
11) [Test Table](#Test-Table)

# <a name="Concept"></a>
#### <div alignt="Left"> Concept</div> [Return to Table of Contents](#table-of-contents)
Many families struggle with wasteful grocery shopping habits and have kitchen pantries that are far too full. Sous: Cloud Pantry Manager is a cloud-based solution to assist families who struggle keeping their food products organized. At the most basic level, Sous is a database inventory of all food related items located in a family’s kitchen. Information can be powerful, if leveraged properly, and Sous will allow users to make meaningful, time saving decisions based on their kitchen data with some key features.

# <a name="Entity-Relationship-Diagram"></a>
#### <div alignt="Left"> Entity Relationship Diagram</div> [Return to Table of Contents](#table-of-contents)
![](https://github.com/gabrielhager/Sous_Cloud_Pantry_Manger/blob/main/ProjectStep4ERD_GabrielHagerSD9.jpg)

# <a name="User Stories"></a>
#### <div alignt="Left"> User Stories</div> [Return to Table of Contents](#table-of-contents)
#### [User Stories](https://github.com/gabrielhager/Sous_Cloud_Pantry_Manger/blob/main/Requirements/UserStories):
1.	As a Mother I want to keep track of my recipes so that I can spend less time flipping through cookbooks.

2.	As a Kitchen Manager I need to keep an inventory of all consumable items in my kitchen so that I know when I need buy products before I completely run out.

3.	As a Software Engineer I want to keep track of the meals I cook each night of the week so that I can stay organized given my busy schedule.

# <a name="Use Cases"></a>
#### <div alignt="Left"> Use Cases</div> [Return to Table of Contents](#table-of-contents)
#### [Use Cases](https://github.com/gabrielhager/Sous_Cloud_Pantry_Manger/blob/main/Requirements/UseCases):
1.	Given a scheduled calendar date to cook a meal when that date has passed then confirm with the user and remove the recipe items from the current inventory.

2.	Given a custom built recipe when the required items are not currently in the inventory and the user clicks the “add” button then add the required recipe items to the grocery list.

3.	Given a custom built recipe  when all required items are currently in the inventory then notify the user that the meal is available to be cooked.

4.	Given a list of ingredients provided by the user when the user clicks create recipe then create a new custom built recipe item.

5.	Given a grocery shopping list when the user clicks the “shopping complete” button then add all items from the grocery list to the inventory and clear the grocery list.

6.	Given a meal calendar when the user clicks the “schedule a meal button” then add the selected recipe to the meal calendar.

7.	Given an inventory item expiration date when the expiration date has passed then notify the user that the inventory item has expired.

# <a name="Use-Case-Diagram"></a>
#### <div alignt="Left"> Use Case Diagram</div> [Return to Table of Contents](#table-of-contents)
![Use Case Diagram](https://github.com/gabrielhager/Sous_Cloud_Pantry_Manger/blob/main/Requirements/UMLDiagram.jpg)

# <a name="Draft-Wire-Frames"></a>
#### <div align="Left"> Draft Wire Frams</div>  [Return to Table of Contents](#table-of-contents)
---
 
# <a name="Home"></a>
#### <div align="Left"> Home</div>  [Return to Table of Contents](#table-of-contents)
![Home](https://github.com/gabrielhager/Sous_Cloud_Pantry_Manger/blob/main/HomePageMock.jpeg)

# <a name="Pantry-Inventory"></a>
#### <div align="Left"> Pantry Inventory</div>  [Return to Table of Contents](#table-of-contents)
![Pantry Inventory](https://github.com/gabrielhager/Sous_Cloud_Pantry_Manger/blob/main/MyPantryMock.jpeg)

# <a name="Recipe-Book"></a>
#### <div align="Left"> Recipe Book</div>  [Return to Table of Contents](#table-of-contents)
![Recipe Book](https://github.com/gabrielhager/Sous_Cloud_Pantry_Manger/blob/main/MyRecipesMock.jpeg)

# <a name="Requirements-List"></a>
#### <div alignt="Left"> Requirements List</div> [Return to Table of Contents](#table-of-contents)
#### [Requirements List](https://github.com/gabrielhager/Sous_Cloud_Pantry_Manger/blob/main/Requirements/RequirementsList)

| Requirement ID | Requirement                                                                                         | Test Method   | Test ID |
|----------------|-----------------------------------------------------------------------------------------------------|---------------|---------|
| 1.0.0          | The system Shall authenticate users based on username password key/value pair.                      | Test          | 1       |
| 2.0.0          | The system shall allow users to create an inventory of all consumable items in his or her kitchen.  | Test          | 1       |
| 2.1.0          | The system shall parse the inventory.                                                               | Test          | 1       |
| 2.1.1          | The system shall check if menu item ingredients are present.                                        | Test          | 1       |
| 2.1.2          | The system shall notify users when an inventory item is expired.                                    | Test          | 1       |
| 2.2.0          | The system shall allow users to mannualy add inventory items to their pantry.                       | Test          | 1       | 
| 2.3.0          | The system shall allow users to create separate pantry locations ie: pantry, refrigerator, deep freezer. | Test          | 1       | 
|3.0.0           | The system shall have a grocery shopping list.                                                      | Test          | 1       | 
|3.1.0           | The system shall remove items from the grocery shopping list after items have been purchased upon verification by the user. | Test          | 1       |    
|4.0.0           | The system shall have a menu that allows for custom user created menu recipe items.                 | Test          | 1       | 
|4.1.0           | The system shall auto generate items to the grocery list when a menu recipe item is selected.       | Test          | 1       |  
|5.0.0           | The system shall have a meal calendar.                                                              | Test          | 1       | 
|5.1.0           | The system shall allow users to add menu recipe items to the meal calendar.                         | Test          | 1       | 
|5.2.0           | The system shall remove items from the inventory after the scheduled calendar date has passed.      | Test          | 1       | 

# <a name="Test-Table"></a>
#### <div align="Left"> Test Table</div>  [Return to Table of Contents](#table-of-contents)
[Test Table] TO DO
