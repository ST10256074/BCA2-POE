using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecipeGUI
{
    /// <summary>
    /// Interaction logic for RecipeViewer.xaml
    /// </summary>
    public partial class RecipeViewer : Window
    {
        public Recipe recipe ;
        public RecipeViewer()
        {
            InitializeComponent();
        }

        public void SetRecipe(Recipe r)
        {
            // Set the recipe to be displayed
            recipe = r;

            // Set the title of the recipe
            Title.Content = recipe.Title;

            // Set the ingredients of the recipe
            steps.Document.Blocks.Clear();
            steps.Document.Blocks.Add(new Paragraph(new Run(String.Join("\n", recipe.steps))));

            // Set the steps of the recipe
            rIngredients.Document.Blocks.Clear();
            string s = "";
            for (int i = 0; i < recipe.ingredients.Count; i++)
            {
                s += recipe.ingredients[i].ToString() + "\n";
            }
            rIngredients.Document.Blocks.Add(new Paragraph(new Run(s)));

            // Set the number of ingredients, steps and calories
            lSteps.Content = ( recipe.steps.Count)+ " Steps";
            lCalories.Content = (recipe.checkCalorie()[1]) + " Calories";

            CalorieWarning.Content = recipe.checkCalorie()[0];

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close(); 
        }
    }
}
