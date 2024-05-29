using System;
// James Hart ST10256074

public class Ingredient
{
    // Declaring variables
    public string name { get; set; }
    public float quantity { get; set; }
    public float calories { get; set; }
    public string foodGroup { get; set; }
    public string unitOfMeasurement { get; set; }
    public Ingredient()
	{
        // (JavaPoint, 2024)
    }

    public Ingredient(string name,float quantity,float calories,string foodGroup,string unitOfMeasurement)
    {
        // (JavaPoint, 2024)
        this.name = name;
        this.quantity = quantity;
        this.calories = calories;
        this.foodGroup = foodGroup;
        this.unitOfMeasurement = unitOfMeasurement;
    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
