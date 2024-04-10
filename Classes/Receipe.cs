using System.Collections;

public class Receipe
{
    public string name { get; set; }
    public int iNumIngredients { get; set; }
    public int iNumSteps { get; set; }

    public ArrayList ingredients { get; set; }
    public ArrayList steps { get; set; }

    public Receipe()
    {
        ingredients = new ArrayList();
        steps = new ArrayList();
    }

    public string toString()
    {
        string s = "";
        s = s + "Receipe: " + name;
        s = s + "\n\nIngredients: ";
        s = s + "\nNo. Ingredients: " + iNumIngredients;
        

        for (int i = 0; i < ingredients.Count; i++)
        {
            Ingredient ins = (Ingredient) ingredients[i];
            s = s + "\n"+ i +" : "+ ins.name + " " + ins.quantity +" "+ ins.unitOfMeasurement;
        }
        s = s + "\n\nSteps: ";
        s = s + "\nNo. Steps: " + iNumSteps;

        for (int i = 0; i < steps.Count; i++)
        {
            s = s +"\n"+ i + " : " + steps[i];
        }
        return s;
    }
}
