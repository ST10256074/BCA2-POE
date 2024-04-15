using System.Collections;

public class Receipe
{
    // Declaring variables
    public string name { get; set; }
    public int iNumIngredients { get; set; }
    public int iNumSteps { get; set; }
    public float fScale { get; set; }

    public ArrayList ingredients { get; set; }
    public ArrayList steps { get; set; }

    //------------------------------------------------------------------------------------------------------------------------//
    /// <summary>
    /// Public Constructor with initialization of variables
    /// </summary>
    public Receipe()
    {
        ingredients = new ArrayList();
        steps = new ArrayList();
        fScale = 1;
    }

    //------------------------------------------------------------------------------------------------------------------------//
    /// <summary>
    /// To String Method that returns a human readable version of the Receipe
    /// </summary>
    /// <returns>string</returns>
    public string toString()
    {
        // Top information string
        string s = "";
        s = s + "------------\n";
        s = s + "Receipe: " + name;
        s = s + "\nScaling: " + fScale+ "x";
        s = s + "\n\nIngredients: ";
        s = s + "\nNo. Ingredients: " + iNumIngredients;
        
        // List Ingredients
        for (int i = 0; i < ingredients.Count; i++)
        {
            Ingredient ins = (Ingredient) ingredients[i];
            s = s + "\n"+ (i+1) +" : "+ ins.name + " " + (ins.quantity * fScale ) +" "+ ins.unitOfMeasurement;
        }
        s = s + "\n\nSteps: ";
        s = s + "\nNo. Steps: " + iNumSteps;

        // List Steps
        for (int i = 0; i < steps.Count; i++)
        {
            s = s +"\n"+ (i+1) + " : " + steps[i];
        }
        s = s + "\n------------";
        return s;
    }
}


//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
