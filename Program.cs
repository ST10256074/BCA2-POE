using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BCA2_POE
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //1.The user shall be able to enter the details for a single recipe:
            //a.The number of ingredients.
            //b.For each ingredient: the name, quantity, and unit of measurement.For example, one
            //tablespoon of sugar.
            //c.The number of steps.
            //d.For each step: a description of what the user should do.
            //2.The software shall display the full recipe, including the ingredients and steps, in a neat
            //format to the user.
            //3.The user shall be able to request that the recipe is scaled by a factor of 0.5(half), 2
            //(double), or 3(triple).All the ingredient quantities shall be changed accordingly when the
            //recipe is displayed.For example, one tablespoon of sugar will become two tablespoons of
            //sugar if the factor is 2.
            //4.The user can request that the quantities be reset to the original values.
            //5.The user shall be able to clear all the data to enter a new recipe.
            //6.The software shall not persist the user data between runs.The data shall only be stored in
            //memory while the software is running.

            string sReceiptName = "";
            int iNumIngredients = 0;



            Console.WriteLine("Welcome to the Receipe Console Application");

            Console.WriteLine("Enter the receipt name");
            sReceiptName =  Console.ReadLine();

            Console.WriteLine("Enter the number of ingredients:");
            iNumIngredients =  Console.ReadLine();

            Receipe rec = new Receipe();


            for (int i = 0; i < iNumIngredients; i++)
            {
                Ingredient ing = new Ingredient();
                ing.name = Console.ReadLine("Ingredient Name");
                ing.quantity = Console.ReadLine("Ingredient Quantity");
                ing.unitOfMeasurement = Console.ReadLine("Ingredient Unit of Measurement");

            }











            Console.ReadKey();

        }
    }
}
