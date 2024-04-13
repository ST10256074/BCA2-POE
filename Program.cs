using System;

namespace BCA2_POE
{
    internal class Program
    {
        static Receipe rec = new Receipe();


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Receipe Console Application");

            while (true)
            {
                View();
            }


        }

        static void View()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to:\n1. Create Receipe\n2. View Receipe\n3. Modify Receipe\n4. Exit Application");
            int entry = int.Parse(Console.ReadLine());
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
                    break;
            }
        }

        private static void ModifyReceipe()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to scale the receipe?");
            string input = Console.ReadLine();
            if (input.Contains("y") || input.Contains("Y"))
            {
                Console.WriteLine("Enter scaled amount:");
                float scalableAmount = float.Parse(Console.ReadLine());
                rec.fScale = scalableAmount;
            }
        }

        private static void ViewReceipe()
        {
            Console.WriteLine("");
            throw new NotImplementedException();
        }

        private static void ReceipeEntry()
        {
            string sReceiptName = "";
            int iNumIngredients = 0;
            int iSteps = 0;

            Console.WriteLine("");
            Console.WriteLine("Enter the receipt name");
            sReceiptName = Console.ReadLine();
            rec.name = sReceiptName;

            Console.WriteLine("Enter the number of ingredients:");
            iNumIngredients = int.Parse(Console.ReadLine());
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
        }
    }

}
