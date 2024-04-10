using System;
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

}
