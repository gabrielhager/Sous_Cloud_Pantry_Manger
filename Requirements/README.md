# Requirements
User Stories, Use Cases, UML Diagram, and Requirements

## User Stories

1.	As a Mother I want to keep track of my recipes so that I can spend less time flipping through cookbooks.

2.	As a Kitchen Manager I need to keep an inventory of all consumable items in my kitchen so that I know when I need buy products before I completely run out.

3.	As a Software Engineer I want to keep track of the meals I cook each night of the week so that I can stay organized given my busy schedule.


## Use Cases

1.	Given a scheduled calendar date to cook a meal when that date has passed then confirm with the user and remove the recipe items from the current inventory.

2.	Given a custom built recipe when the required items are not currently in the inventory and the user clicks the “add” button then add the required recipe items to the grocery list.

3.	Given a custom built recipe  when all required items are currently in the inventory then notify the user that the meal is available to be cooked.

4.	Given a list of ingredients provided by the user when the user clicks create recipe then create a new custom built recipe item.

5.	Given a grocery shopping list when the user clicks the “shopping complete” button then add all items from the grocery list to the inventory and clear the grocery list.

6.	Given a meal calendar when the user clicks the “schedule a meal button” then add the selected recipe to the meal calendar.

7.	Given an inventory item expiration date when the expiration date has passed then notify the user that the inventory item has expired.

## Use-Cases Diagram (UML)

![UML](PLACE HOLDER)


## Requirements
1. The system Shall authenticate users based on username password key/value pair.
      
2. The system shall allow users to create an inventory of all consumable items in his or her kitchen.
   1. (2.1) The system shall parse the inventory.
      1.  (2.1.1) The system shall check if menu item ingredients are present.
      2.  (2.1.2) The system shall notify users when an inventory item is expired.
   2. (2.2) The system shall allow users to mannualy add inventory items to their pantry. 
   3. (2.3) The system shall allow users to create separate pantry locations ie: pantry, refrigerator, deep freezer.
   
3. The system shall have a grocery shopping list. 
   1. (3.1) The system shall remove items from the grocery shopping list after items have been purchased upon verification by the user.
   
4. The system shall have a menu that allows for custom user created menu recipe items.
   1. (4.1) The system shall auto generate items to the grocery list when a menu recipe item is selected.
   
5. The system shall have a meal calendar.
   1. (5.1) The system shall allow users to add menu recipe items to the meal calendar.
   2. (5.2) The system shall remove items from the inventory after the scheduled calendar date has passed.
          
   


[Back to Main](https://github.com/montiqum/My_Carbon_Footprint_Calculator)
