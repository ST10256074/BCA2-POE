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
            recipe = r;
            Title.Content = recipe.Title;
            steps.Document.Blocks.Clear();
            steps.Document.Blocks.Add(new Paragraph(new Run(String.Join("\n", recipe.steps))));
            lSteps.Content = ( recipe.steps.Count)+ " Steps";
            lCalories.Content = (recipe.checkCalorie()[1]) + " Calories";


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close(); 
        }
    }
}
