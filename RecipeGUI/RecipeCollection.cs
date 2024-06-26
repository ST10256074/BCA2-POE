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
    }
}
