using System.Collections;
using System.Collections.Generic;
// James Hart ST10256074

public class Recipe
{
    // Declaring variables
    public string name { get; set; }
    public int iNumIngredients { get; set; }
    public int iNumSteps { get; set; }
    public float fScale { get; set; }

    public List<Ingredient> ingredients { get; set; }
    // (Microsoft Learn, 2024)
    public List<string> steps { get; set; }
    // (Microsoft Learn, 2024)

    public delegate string DelegateMethod(float total);

    //------------------------------------------------------------------------------------------------------------------------//
    /// <summary>
    /// Public Constructor with initialization of variables
    /// </summary>
    public Recipe()
    {
        steps = new List<string>();
        ingredients = new List<Ingredient>();
        fScale = 1;
        // (JavaPoint, 2024)
    }

    //------------------------------------------------------------------------------------------------------------------------//
    /// <summary>
    /// To String Method that returns a human readable version of the Recipe
    /// </summary>
    /// <returns>string</returns>
    public string toString()
    {
        // Top information string
        string s = "";
        s = s + "------------\n";
        s = s + "Recipe: " + name;
        s = s + "\nScaling: " + fScale + "x";
        s = s + "\n\nIngredients: ";
        s = s + "\nNo. Ingredients: " + iNumIngredients;

        // List Ingredients
        for (int i = 0; i < ingredients.Count; i++)
        {
            Ingredient ins = (Ingredient)ingredients[i];
            s = s + "\n" + (i + 1) + " : " + ins.name + " (" + ins.foodGroup + ")" + " " + (ins.quantity * fScale) + " " + ins.unitOfMeasurement;
        }
        // Checking for excess calories
        s = s + "\n" + checkCalorie()[0];
        s = s + "\n\nSteps: ";
        s = s + "\nNo. Steps: " + iNumSteps;

        // List Steps
        for (int i = 0; i < steps.Count; i++)
        {
            s = s + "\n" + (i + 1) + " : " + steps[i];
        }
        s = s + "\n------------";
        return s;
    }

    /// <summary>
    /// Goes through all the ingredients and calculates the total number of calories present and if 
    /// exceeds 300, warns user. 
    /// </summary>
    /// <returns>[string,amount]</returns>
    public ArrayList checkCalorie()
    {
        float total = 0;
        for (int i = 0; i < ingredients.Count; i++)
        {
            total += ingredients[i].calories;
        }

        // Return an ArrayList with a string and the total amount of calories
        ArrayList a = new ArrayList();

        //call delegate method

        DelegateMethod DelegateMethod = new DelegateMethod(CalcCalories);

        string calorie_ranges = "\n" + @"Calorie Ranges:" + "\n" + @"Low: Typically under 300 calories per serving.
Moderate: Ranging from 300 to 600 calories per serving.
High: Above 600 calories per serving." + "\n";

        a.Add(calorie_ranges + DelegateMethod(total));
        a.Add(total);
        return a;


    }
    // Delegate method checking total is over 300 calories or not
    public static string CalcCalories(float total)
    {
        if (total >= 300)
        {
            return "Recipe contains 300+ calories";
        }
        else
        {
            return "Recipe contains sub 300 calories";
        }
    }
}


//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
