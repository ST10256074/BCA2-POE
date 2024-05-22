using System;
using System.Collections.Generic;

namespace BCA2_POE
{
    internal class Program
    {
        // Declaring variables
        static List<Recipe> recipes = new List<Recipe>();
        static Boolean bfirstRecipe = true;
        // (JavaPoint, 2024)


        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Main Loop
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Recipe Console Application");
            // Main Loop
            while (true)
            {
                View();
            }

        }

        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// The View manager that allows for user-input to direct them to the right methods
        /// </summary>
        static void View()
        {
            // User Choice Entry and exception handling
            Console.WriteLine("");
            //Console.WriteLine("Would you like to:\n1. Create Recipe\n2. View Recipe\n3. Modify Recipe\n4. Exit Application");
            Console.WriteLine(@"Would you like to:
1. Create Recipe
2. View All Recipes
3. View Specific Recipe
4. Modify Specific Recipe
5. Exit Application");
            int entry = 4;
            while (true)
            {
                try
                {
                    entry = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    // Red color for catched exceptions
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter Valid Number");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }

            // User Entry switch case
            switch (entry)
            {
                case 1:
                    RecipeEntry();
                    break;
                case 2:
                    ViewAllRecipes();
                    break;
                case 3:
                    UserViewSpecificRecipe();
                    break;
                case 4:
                    ModifySpecificRecipe();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter correct value");
                    break;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Allows the modification of the Recipe by scaling the amounts required for the Recipe
        /// </summary>
        private static void ModifySpecificRecipe(Recipe r)
        {
            //User Entry
            Console.WriteLine("");
            Console.WriteLine("Would you like to scale the Recipe? (Y/N)");
            string input = Console.ReadLine();
            //User choice 
            if (input.Contains("y") || input.Contains("Y"))
            {
                Console.WriteLine("Enter scaled amount: \n(Recipe can be scaled back to default by inputting 1)\n");
                float scalableAmount = float.Parse(Console.ReadLine());
                r.fScale = scalableAmount;
            }
            ViewSpecificRecipe(r);
        }

        /// <summary>
        /// Finds a recipe by prompting user 
        /// </summary>
        /// <returns>Recipe</returns>
        private static Recipe UserFindRecipe()
        {
            Recipe r = null;
            Console.WriteLine("Please enter Recipe name");
            while (true)
            {

                string sinput = Console.ReadLine();
                if (sinput.Length < 2)
                {
                    Console.WriteLine("Please enter a name longer than 2 characters");
                    continue;
                }
                if (sinput is null)
                {
                    Console.WriteLine("Please enter a value");
                    continue;
                }
                var temp = FindRecipe(sinput);
                if (temp is null)
                {
                    Console.WriteLine("Recipe Not Found please try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("Recipe Found");
                    r = temp;
                    break;
                }
            }
            return r;

        }


        /// <summary>
        /// Finds a recipe provided a string and returns the Recipe
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Recipe</returns>
        private static Recipe FindRecipe(String s)
        {
            for (int i = 0; i < recipes.Count; i++)
            {
                if (s.Contains(recipes[i].name))
                {
                    return recipes[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Handles the user for viewing a recipe
        /// </summary>
        private static void UserViewSpecificRecipe()
        {
            Recipe r = UserFindRecipe();
            if (r is null)
            {
                return;
            }
            else
            {
                ViewSpecificRecipe(r);
            }
        }

        /// <summary>
        /// Handles the user for modifying a recipe
        /// </summary>
        private static void ModifySpecificRecipe()
        {
            Recipe r = UserFindRecipe();
            if (r is null)
            {
                return;
            }
            else
            {
                ModifySpecificRecipe(r);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Returns the Recipe in a readable format to the console 
        /// </summary>
        private static void ViewSpecificRecipe(Recipe r)
        {
            Console.WriteLine("");
            Console.WriteLine(r.toString());
        }

        /// <summary>
        /// Prints out all the recipes 
        /// </summary>
        private static void ViewAllRecipes()
        {
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine(recipes[i].toString());
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Entry of data required for the Recipe
        /// </summary>
        private static void RecipeEntry()
        {
            Recipe rec = new Recipe();
            string sReceiptName = "";
            int iNumIngredients = 0;
            int iSteps = 0;

            bfirstRecipe = false;
            // Re initilize rec with new data
            rec = new Recipe();

            // Recipe Name
            Console.WriteLine("");
            Console.WriteLine("Enter the receipt name");
            sReceiptName = Console.ReadLine();
            rec.name = sReceiptName;

            // Recipe Ingredients Amount
            // Exception Handeling for No. Ingredients
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the number of ingredients:");
                    iNumIngredients = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    // Red color for catched exceptions
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter Valid Number");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            rec.iNumIngredients = iNumIngredients;


            // Ingredient Name, Amount, Measurement Entry
            for (int i = 0; i < iNumIngredients; i++)
            {
                Console.WriteLine("\nIngredient: " + (i + 1) + "\n");
                Ingredient ing = new Ingredient();

                // Exception Handling for Ingredient Name
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Ingredient Name");
                        ing.name = Console.ReadLine();
                        if (ing.name.Length < 2)
                        {
                            Console.WriteLine("Please enter a name longer than 2 characters");
                            continue;
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        // Red color for catched exceptions
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter Valid Name");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                // Exception Handling for Ingredient Food Group
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Ingredient Food Group");
                        ing.foodGroup = Console.ReadLine();
                        if (ing.foodGroup.Length < 2)
                        {
                            Console.WriteLine("Please enter a food group longer than 2 characters");
                            continue;
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        // Red color for catched exceptions
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter Valid Food Group");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                // Exception Handeling for Ingredient Calories
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Ingredient Calories");
                        ing.calories = float.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        // Red color for catched exceptions
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter Valid Calories");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                // Exception Handeling for Ingredient Quantity
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Ingredient Quantity");
                        ing.quantity = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        // Red color for catched exceptions
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter Valid Quantity");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                // Exception Handeling for Ingredient Unit of Measurement
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Ingredient Unit of Measurement");
                        ing.unitOfMeasurement = Console.ReadLine();
                        if (ing.unitOfMeasurement.Length ==0)
                        {
                            Console.WriteLine("Please enter a unit of measurement");
                            continue;
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        // Red color for catched exceptions
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter Valid Unit of Measurement");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                rec.ingredients.Add(ing);
            }

            // Recipe Steps Amount
            Console.WriteLine("");

            // Exception Handeling for No. Steps
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number of steps");
                    iSteps = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    // Red color for catched exceptions
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            rec.iNumSteps = iSteps;

            // Recipe Description Entry
            for (int i = 0; i < iSteps; i++)
            {
                Console.WriteLine("\nStep: " + (i + 1) + "\n");
                string s = Console.ReadLine();
                rec.steps.Add(s);
            }

            // Viewing of Recipe
            Console.WriteLine();
            Console.WriteLine(rec.toString());

            //Add Recipe to List
            recipes.Add(rec);
        }
    }

}


//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
