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

        /// <summary>
        /// Add Recipe Method that takes in a recipe and adds it to the collection
        /// </summary>
        /// <param name="recipe"></param>
        public void AddRecipe(Recipe recipe)
        {
            this.Add(recipe);
        }

        /// <summary>
        /// Find Method that takes in a string and finds a recipe with the same title
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Find Method that takes in a food group, ingredient name and max calories and finds recipes that fit any criteria
        /// </summary>
        /// <param name="foodGroup"></param>
        /// <param name="ingredientName"></param>
        /// <param name="maxCalories"></param>
        /// <returns></returns>
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
