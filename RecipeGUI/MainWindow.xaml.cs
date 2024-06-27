using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

/// <summary>
/// James Warden Edgecombe Hart 
/// ST10256074
/// PRG6221
/// </summary>
/// 


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

        /// <summary>
        /// On Create Recipe Button Click this method is called to create a new Recipe with Recipe Entry Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreate_Recipe_Click(object sender, RoutedEventArgs e)
        {
            RecipeEntry re = new RecipeEntry();
            re.Show();
        }

        /// <summary>
        /// On Window Loaded this method is called to load the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // add food groups to combobox
            cbFoodGroup.Items.Add("Dairy");
            cbFoodGroup.Items.Add("Protein");
            cbFoodGroup.Items.Add("Fruit");
            cbFoodGroup.Items.Add("Vegetable");
            cbFoodGroup.Items.Add("Grain");
            cbFoodGroup.Items.Add("Sweets");
            cbFoodGroup.Items.Add("Fats");
            cbFoodGroup.Items.Add("Other");
            cbFoodGroup.Items.Add("");
        }

        /// <summary>
        /// On Recipe Selection and View Recipe Button Clicked this method is called to view the Recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bView_Recipe_Click(object sender, RoutedEventArgs e)
        {
            // if no recipe is selected, show a warning
            if (gRecipes.SelectedItems.Count == 0)
            {
                System.Windows.MessageBox.Show("Please select a recipe to view.");
                return;
            }

            // on success open up recipe viewer
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
        /// On Sort Ascending Button Click this method is called to sort the listbox items alphabetically asc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// On Sort Descending Button Click this method is called to sort the listbox items alphabetically desc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// On Window Close this method is called to close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, System.EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        /// <summary>
        /// On Remove Recipe Button Click this method is called to remove a recipe from the Recipe Manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRemove_Recipe_Click(object sender, RoutedEventArgs e)
        {
            var a = gRecipes.SelectedItems[0];
            string t = (a as Recipe).Title;
            RecipeViewer recipeViewer = new RecipeViewer();
            if (Recipes.Find(t) == null)
            {
                return;
            }
            Recipes.RemoveRecipe(Recipes.Find(t));
        }

        private void bFilter_Click(object sender, RoutedEventArgs e)
        {
            // create a search filter using ingredients, foodgroups and maximum calories entries
            string ingredients = tbIngredient.Text;
            string foodgroups = "";
            try
            {
                if (cbFoodGroup.SelectedItem != null)
                {
                    foodgroups = cbFoodGroup.SelectedItem.ToString();
                }
            }
            catch (System.Exception)
            {

            }
            string smaxCalories = tbCalories.Text;
            int maxCalories = 0;
            try
            {
                maxCalories = int.Parse(smaxCalories);
            }
            catch (System.Exception)
            {
                maxCalories = 0;
            }

            List<Recipe> filteredRecipes = new List<Recipe>();
            filteredRecipes = Recipes.Find(foodgroups, ingredients, maxCalories);

            gRecipes.ItemsSource = filteredRecipes;
            return;
        }

        private void tbIngredient_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            tbIngredient.Text = "";
        }

        private void tbCalories_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            tbCalories.Text = "";

        }
    }
}
