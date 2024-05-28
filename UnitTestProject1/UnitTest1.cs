using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalorieSum()
        {

            // Create new Recipe object 
            float i = 150;
            float i1 = 200;
            float expected = i + i1;

            Recipe recipe = new Recipe();
            recipe.iNumIngredients = 2;
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient("Bread", 1, i, "Starch", "g"));
            ingredients.Add(new Ingredient("Berries", 4, i1, "Berry", "g"));
            recipe.ingredients = ingredients;

            float result = (float)recipe.checkCalorie()[1];

            Assert.AreEqual(expected, result);
        }



    }
}
