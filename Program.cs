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
            string sReceiptName = "";
            int iNumIngredients = 0;
            int iSteps = 0;


            Receipe rec = new Receipe();
            Console.WriteLine("Welcome to the Receipe Console Application");

            Console.WriteLine("Enter the receipt name");
            sReceiptName =  Console.ReadLine();
            rec.name = sReceiptName;

            Console.WriteLine("Enter the number of ingredients:");
            iNumIngredients = int.Parse( Console.ReadLine());
            rec.iNumIngredients = iNumIngredients;


            for (int i = 0; i < iNumIngredients; i++)
            {
                Ingredient ing = new Ingredient();
                Console.WriteLine("Ingredient Name");
                ing.name = Console.ReadLine();
                Console.WriteLine("Ingredient Quantity");
                ing.quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingredient Unit of Measurement");
                ing.unitOfMeasurement = Console.ReadLine();

                rec.ingredients.Add(ing);
                Console.WriteLine("\nNext Ingredient\n");
            }

            Console.WriteLine("Enter number of steps");
            iSteps = int.Parse(Console.ReadLine());
            rec.iNumSteps = iSteps;

            for (int i = 0; i < iSteps; i++)
            {
                Console.WriteLine("Enter Step Desription");
                string s = Console.ReadLine();
                rec.steps.Add(s);
            }
            Console.WriteLine();
            Console.WriteLine(rec.toString());

            Console.WriteLine("");
            Console.WriteLine("Would you like to scale the receipe?");
            string input = Console.ReadLine();
            if (input.Contains("y") || input.Contains("Y"))
            {
                Console.WriteLine("Enter scaled amount:");
                float scalableAmount = float.Parse(Console.ReadLine());
                rec.fScale = scalableAmount;
            }









            Console.ReadKey();

        }
    }
}
