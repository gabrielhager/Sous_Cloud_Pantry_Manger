# Requirements
User Stories, Use Cases, Use-Case Diagram, and Requirements

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
1. The system shall ask the current user if he/she is a new user, existing user, or guest.
   1. (1.1) The system shall provide means for an existing user to enter his/her user ID and password.
      1. (1.1.1) Given a user ID, the system shall verify the validity of the user ID and password.
      2. (1.1.2) Given authorization, the system shall allow the user access to the calculator.
      3. (1.1.3) The system shall provide the new user with a new user ID and allow the new user to select a password.
      4. (1.1.4) The system shall give access to the calculator when the user selects ‘Use system as guest’.
   2. (1.2) The system shall provide calculate every user’s carbon footprint.
      1. (1.2.1) The system shall display the user’s result, along with a graphical comparison to other users.
      2. (1.2.2) The system shall allow the user means to save his/her results as a pdf or image.
   3. (1.3) The system shall display information and links about reducing Carbon emission in the 
      ‘Did You Know’ display box.
      
2. The system shall save the data provided by the user in the Calculator database.
   1. (2.1) Given data from a guest user the system shall store the data in the database marking the 
      user Id value with an asterisk. 
   2. (2.2) The system shall provide easy access to pages by means of page tabs.
   3. (2.3) The system shall provide drop down selections for user input vs. the user typing answers.
  
3. The system shall be developed with C# language, SQL and ASP.NET .
   1. (3.1) The system shall be hosted in Azure and GitHub.


[Back to Main](https://github.com/montiqum/My_Carbon_Footprint_Calculator)
