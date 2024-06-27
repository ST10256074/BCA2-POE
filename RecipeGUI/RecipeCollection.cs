using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RecipeGUI
{
    public class RecipeCollection : ObservableCollection<Recipe>
    {
        // some wrapper functions for example:
        public void AddTest(string title)
        {
            this.Add(new Recipe { Title = title });
        }

        public void AddRecipe(Recipe recipe)
        {
            this.Add(recipe);
        }

        public Recipe Find(string t)
        {
            foreach (Recipe recipe in this)
            {
                if (recipe.Title == t)
                {
                    return recipe;
                }
            }
            return null;
        }

        // Add a find method that takes in the ingredient foodgroup, ingredient name and maximum calories and checks if an ingredient matches those values and returns the recipe

        public List<Recipe> Find(string foodGroup, string ingredientName, int maxCalories)
        {
            // return a collection of recipes that match
            List<Recipe> rc = new List<Recipe>() ;
            foreach (Recipe recipe in this)
            {
                if (foodGroup ==""&& ingredientName ==""&& maxCalories==0)
                {
                    rc.Add(recipe);
                    continue;
                }
                if ( int.Parse(recipe.checkCalorie()[1].ToString()) < maxCalories)
                {
                    rc.Add( recipe );
                }
                foreach (Ingredient ingredient in recipe.ingredients)
                {
                    if (ingredient.foodGroup == foodGroup || ingredient.name == ingredientName )
                    {
                        rc.Add( recipe );
                    }
                }
            }
            return rc;
        }

    }
}
