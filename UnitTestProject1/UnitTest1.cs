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
            // * Checking normal case *
            // Used values
            float i = 150;
            float i1 = 200;
            float expected = i + i1;

            // Create new Recipe object 
            Recipe recipe = new Recipe();
            recipe.iNumIngredients = 2;
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient("Bread", 1, i, "Starch", "g"));
            ingredients.Add(new Ingredient("Berries", 4, i1, "Berry", "g"));
            recipe.ingredients = ingredients;

            // result
            float result = (float)recipe.checkCalorie()[1];

            // Assert
            Assert.AreEqual(expected, result);





            // * Checking edge case (1 Ingredient) *
            // Used values
            float i2 = 100;
            float expected1 = i2;

            // Create new Recipe object
            Recipe recipe1 = new Recipe();
            recipe1.iNumIngredients = 1;
            List<Ingredient> ingredients1 = new List<Ingredient>();
            ingredients1.Add(new Ingredient("Bread", 1, i2, "Starch", "g"));
            recipe1.ingredients = ingredients1;

            // result
            float result1 = (float)recipe1.checkCalorie()[1];
            
            // Assert
            Assert.AreEqual(expected1, result1);






            // * Checking edge case (0 Ingredients) *

            // Used values
            float expected2 = 0;
            Recipe recipe2 = new Recipe();
            recipe2.iNumIngredients = 0;
            List<Ingredient> ingredients2 = new List<Ingredient>();
            recipe2.ingredients = ingredients2;

            // result
            float result2 = (float)recipe2.checkCalorie()[1];
            
            // Assert
            Assert.AreEqual(expected2, result2);

        }



    }
}
