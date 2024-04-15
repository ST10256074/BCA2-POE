# BCA2-POE Assignment Part 1
# ST10256074 James Hart

# Receipe Manager Part 1

Github Link: https://github.com/ST10256074/BCA2-POE

## About
This program allows you to create and manage recipes with ingredients, quantities, units of measurement, and instructions (steps). It provides a human-readable string representation of the recipe for easy display or sharing.

## Prerequisites

Visual Studio: A free or paid edition of Visual Studio must be used. 
Basic C# Knowledge: This is due to this running using an IDE and not an executable.

## Getting Started

1. Clone the Repository 
    Using Git or Github you can clone the repo using the url
2. Open the Project File (.sln) in Visual Studio
    Open a solution file or project file using visual studio
3. Run the project 
    Using the green arrow at the top of the page.

## User Interaction Chain

1. User is prompted with a list of commands the receipe application can do
2. User can choose between (New Receipe, View Receipe, Modify Receipe, Exit Application)
3. User creates new Receipe creates a new Receipe that is held in memory
4. User can scale the Receipe using "Modify Receipe" method.
5. User can view updated receipe using "View Receipe"
6. User can overwrite exsisting receipe by using "New Receipe"
7. User can exit application using "Exit Application"

## Classes:

### Program Class:
This is the main file of the program with a main loop for user interactions.
It handles all the user inputs and console outputs effectively.

### Receipe Class:

This class represents the recipe and its variables:
name: The name of the recipe.
iNumIngredients: The number of ingredients.
iNumSteps: The number of steps in the recipe.
fScale: A scaling factor to adjust the quantity of ingredients for more makings of the receipe.
ingredients: An ArrayList to store Ingredient objects of its respective class.
steps: An ArrayList to store the recipe's instructions.

toString() Method: This method formats the recipe information into a human-readable format for display in the console.

### Ingredient Class:

This class represents the ingredients required for the receipe:
name: Name of the ingredient.
quantity: Quantity of the ingredient
unitOfMeasurement: The unit of measurement
