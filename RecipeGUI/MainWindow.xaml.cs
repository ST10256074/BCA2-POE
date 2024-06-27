using System.Collections.Generic;
using System.Windows;

namespace RecipeGUI
{



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {

        #region public properties

        // List of Recipes
        public static RecipeCollection Recipes { get; } = new RecipeCollection();
        //List<DataItem> Data = new List<DataItem>();

        #endregion public properties
        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bCreate_Recipe_Click(object sender, RoutedEventArgs e)
        {
            RecipeEntry re = new RecipeEntry();
            re.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// On Recipe Selection and View Recipe Button Clicked this method is called to view the Recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bView_Recipe_Click(object sender, RoutedEventArgs e)
        {
            if (gRecipes.SelectedItems.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select a recipe to view.");
                return;
            }
            var a = gRecipes.SelectedItems[0];
            string t = (a as Recipe).Title;
            RecipeViewer recipeViewer = new RecipeViewer();
            if (Recipes.Find(t) == null)
            {
                return;
            }
            recipeViewer.SetRecipe(Recipes.Find(t));
            recipeViewer.Show();


        }

        /// <summary>
        /// On Recipe Entry Collapse this method is called to add the Recipe to the Recipe Manager
        /// </summary>
        /// <param name="r"></param>
        public void Add_Recipe(Recipe r)
        {
            System.Windows.MessageBox.Show(r.name + " Added to Recipe Manager");

            Recipes.Add(r);
            gRecipes.Items.Refresh();
        }

        /// <summary>
        /// Test Add to Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Recipes.AddTest("Pancakes");
        }

        /// <summary>
        /// Create a Menu from selected Recipes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreate_Menu_Click(object sender, RoutedEventArgs e)
        {
            if (gRecipes.SelectedItems.Count < 2)
            {
                System.Windows.MessageBox.Show("Please select multiple recipes to combine.");
                return;
            }
            List<Recipe> selectedRecipes = new List<Recipe>();
            foreach (var a in gRecipes.SelectedItems)
            {
                selectedRecipes.Add(a as Recipe);
            }
            MenuViewer mv = new MenuViewer(selectedRecipes);
            mv.Show();

        }

        private void bSort_Asc_Click(object sender, RoutedEventArgs e)
        {
            // sort a listboxes items alphabetically
            List<Recipe> sortedList = new List<Recipe>();
            foreach (Recipe r in gRecipes.Items)
            {
                sortedList.Add(r);
            }
            sortedList.Sort((x, y) => x.Title.CompareTo(y.Title));
            gRecipes.ItemsSource = sortedList;

        }

        private void bSort_Desc_Click(object sender, RoutedEventArgs e)
        {
            // sort a listboxes items alphabetically desc
            List<Recipe> sortedList = new List<Recipe>();
            foreach (Recipe r in gRecipes.Items)
            {
                sortedList.Add(r);
            }
            sortedList.Sort((x, y) => y.Title.CompareTo(x.Title));
            gRecipes.ItemsSource = sortedList;

        }
    }
}
