using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecipeGUI
{
    /// <summary>
    /// Interaction logic for MenuViewer.xaml
    /// </summary>
    public partial class MenuViewer : Window
    {
        List<Recipe> selected_recipes = new List<Recipe>();
        public MenuViewer(List<Recipe> s)
        {
            InitializeComponent();

            // Display the selected recipes
            selected_recipes = s;
            string srecipes = "";
            float total_calories = 0;
            int total_steps = 0;

            // Loop through the selected recipes 
            foreach (Recipe r in selected_recipes)
            {
                srecipes = r.Title + "\n";
                total_calories +=  float.Parse(r.checkCalorie()[1].ToString());
                total_steps += r.iNumSteps;
            }

            lCalories.Content = total_calories;
            lSteps.Content = total_steps;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
