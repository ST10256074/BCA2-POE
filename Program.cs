﻿using System;

namespace BCA2_POE
{
    internal class Program
    {
        // Declaring variables
        static Receipe rec = new Receipe();


        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Main Loop
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Receipe Console Application");
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
            // User Choice Entry
            Console.WriteLine("");
            Console.WriteLine("Would you like to:\n1. Create Receipe\n2. View Receipe\n3. Modify Receipe\n4. Exit Application");
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
                    Console.WriteLine("Enter Valid Number");
                }
            }

            switch (entry)
            {
                case 1:
                    ReceipeEntry();
                    break;
                case 2:
                    ViewReceipe();
                    break;
                case 3:
                    ModifyReceipe();
                    break;
                case 4:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter correct value");
                    break;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Allows the modification of the receipe by scaling the amounts required for the Receipe
        /// </summary>
        private static void ModifyReceipe()
        {
            //User Entry
            Console.WriteLine("");
            Console.WriteLine("Would you like to scale the receipe?");
            string input = Console.ReadLine();
            //User choice 
            if (input.Contains("y") || input.Contains("Y"))
            {
                Console.WriteLine("Enter scaled amount:");
                float scalableAmount = float.Parse(Console.ReadLine());
                rec.fScale = scalableAmount;
            }
            ViewReceipe();
        }

        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Returns the Receipe in a readable format to the console
        /// </summary>
        private static void ViewReceipe()
        {
            Console.WriteLine("");
            Console.WriteLine(rec.toString());
        }

        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Entry of data required for the Receipe
        /// </summary>
        private static void ReceipeEntry()
        {
            string sReceiptName = "";
            int iNumIngredients = 0;
            int iSteps = 0;

            // Re initilize rec with new data
            rec = new Receipe();

            // Receipe Name
            Console.WriteLine("");
            Console.WriteLine("Enter the receipt name");
            sReceiptName = Console.ReadLine();
            rec.name = sReceiptName;

            // Receipe Ingredients Amount
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
                    Console.WriteLine("Please Enter Valid Number");
                }
            }
            rec.iNumIngredients = iNumIngredients;


            // Ingredient Name, Amount, Measurement Entry
            for (int i = 0; i < iNumIngredients; i++)
            {
                Console.WriteLine("\nIngredient: " + (i+1) + "\n");
                Ingredient ing = new Ingredient();
                Console.WriteLine("Ingredient Name");
                ing.name = Console.ReadLine();

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
                        Console.WriteLine("Enter Valid Quantity");
                    }
                }


                Console.WriteLine("Ingredient Unit of Measurement");
                ing.unitOfMeasurement = Console.ReadLine();

                rec.ingredients.Add(ing);
            }

            // Receipe Steps Amount
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
                    Console.WriteLine("Please enter a valid number");
                }
            }
            rec.iNumSteps = iSteps;

            // Receipe Description Entry
            for (int i = 0; i < iSteps; i++)
            {
                Console.WriteLine("\nStep: " + (i + 1) + "\n");
                string s = Console.ReadLine();
                rec.steps.Add(s);
            }

            // Viewing of Receipe
            Console.WriteLine();
            Console.WriteLine(rec.toString());
        }
    }

}


//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
