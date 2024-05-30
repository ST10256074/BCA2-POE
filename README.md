# BCA2-POE Assignment Part 1
# ST10256074 James Hart

# Recipe Manager Part 1

Github Link: https://github.com/ST10256074/BCA2-POE

## Update:
1. Added the collection of calories and foodgroups for Recipes
2. Added the ability to save multiple recipes
3. Added the ability view all recipes alphabetically
4. Recipe checks for calories exceeding 300 calories
5. Unit Test for calorie calculation
6. Increased colored text for better readability


## About
This program allows you to create and manage an infinite amount of recipes. The Recipe stores information about the steps, ingredients, calories, foodgroups, calorie ranges and safe amounts. It provides a human-readable string representation of the recipe for easy display or sharing.

## Prerequisites

Visual Studio: A free or paid edition of Visual Studio must be used. 
Basic C# Knowledge: This is due to this running using an IDE and not an executable.

## Getting Started

1. Clone the Repository 
    Using Git or Github you can clone the repo using the url
2. Open the Project File (.sln) in Visual Studio (Microsoft Learn, 2024)
    Open a solution file or project file using visual studio
3. Run the project 
    Using the green arrow at the top of the page.

## User Interaction Chain

1. User is prompted with a list of commands the Recipe application can do
2. User can choose between (New/Add Recipe, View All Recipes, View Specific Recipe, Modify Recipe, Exit Application)
3. User creates new Recipe creates a new Recipe that is held in memory
4. User can scale the Recipe using "Modify Recipe" method.
5. User can view updated Recipe using "View Specific Recipe" with the recipe name
6. User can create a new Recipe by using "New Recipe"
7. User can exit application using "Exit Application"

## Classes:

### Program Class:

This is the main file of the program with a main loop for user interactions.
It handles all the user inputs and console outputs effectively.

### Recipe Class:

This class represents the recipe and its variables:
name: The name of the recipe.
iNumIngredients: The number of ingredients.
iNumSteps: The number of steps in the recipe.
fScale: A scaling factor to adjust the quantity of ingredients for more makings of the Recipe.
ingredients: A Generic List to store Ingredient objects of its respective class.
steps: A Generic List to store the recipe's instructions.
DeleagateMethod: A container for Delegate Methods

toString() Method: This method formats the recipe information into a human-readable format for display in the console.
checkCalories() Method: This method checks the calories of the recipe and returns an ArrayList of whether the recipe exeeds 300 calories and the total amount of calories contained in the recipe
CalcCalories() Method: This is a delegate method that checks if the total amount of calories exceed 300 calories

### Ingredient Class:

This class represents the ingredients required for the Recipe:
name: Name of the ingredient.
quantity: Quantity of the ingredient
calories: The amount of calories in the ingredient
foodGroup: The food group the ingredient belongs to
unitOfMeasurement: The unit of measurement

### UnitTest1 Class:

This class tests the Recipe class's calorie calculation for all cases to assert that the calories are calculated correctly.
This class tests for 
0 Ingredients
1 Ingredient
2 Ingredients

## Commits
![image](https://github.com/ST10256074/BCA2-POE/assets/129170767/eb762593-af79-4be7-bd7c-96b1f37d3be2)
![image](https://github.com/ST10256074/BCA2-POE/assets/129170767/c4de2604-827a-4033-864a-fe0c27f18d67)
![screenshot-1](https://github.com/ST10256074/BCA2-POE/assets/129170767/c3c17e32-6d0c-4dd1-a88c-a8c76b12e1e0)
![screenshot-2](https://github.com/ST10256074/BCA2-POE/assets/129170767/91c5ef44-c0cc-4a84-bd87-77369225751a)
![screenshot-3](https://github.com/ST10256074/BCA2-POE/assets/129170767/579c919a-5280-4858-916e-f9df8aee9e1e)


## References 

JavaPoint. (2024, April 13). C# Oject and Class. Retrieved from JavaPoint: https://www.javatpoint.com/c-sharp-object-and-class
Microsoft Learn. (2024, April 15). ArrayList Class. Retrieved from Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-8.0
Microsoft Learn. (2024, April 13). Run a C# program in Visual Studio. Retrieved from Microsoft Learn: https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/run-program?view=vs-2022
W3 Schools. (2024, April 14). C# Tutorial. Retrieved from W3 Schools: https://www.w3schools.com/cs/index.php
GeeksforGeeks. (2024, May 27). C Sharp Delegates. Retrieved from GeeksforGeeks: https://www.geeksforgeeks.org/c-sharp-delegates/
