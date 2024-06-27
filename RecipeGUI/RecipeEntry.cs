using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RecipeGUI
{
    public partial class RecipeEntry : Form
    {
        public RecipeEntry()
        {
            InitializeComponent();
        }


        Recipe recipe = new Recipe();

        /// <summary>
        /// Back Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Confirming creation of Recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Confirmation_Click(object sender, EventArgs e)
        {
            recipe.name = tbName.Text;
            recipe.steps = new List<string> (rISteps.Text.Split('\n'));
            recipe.iNumSteps = recipe.steps.Count;
            recipe.iNumIngredients = recipe.ingredients.Count;
            recipe.Title = recipe.name+" | "+recipe.iNumIngredients+"ing"+" | "+recipe.iNumSteps+"steps";

            // test if entries are blank
            if (recipe.name == "" || recipe.steps.Count == 0 || recipe.ingredients.Count == 0)
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }

            MainWindow mw = new MainWindow();
            mw.Add_Recipe(recipe);
            Close();

        }
        /// <summary>
        /// Adding Ingredients to Recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string Name = tbIName.Text;
            if (Name == "")
            {
                MessageBox.Show("Please enter a name for the ingredient");
                return;
            }
            float Quantity =0 ;
            try
            {
                Quantity = float.Parse(tbIQuan.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number for quantity");
                return;

            }
            float Calories =0 ;
            try
            {
                Calories = float.Parse(tbICal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number for calories");
                return;

            }
            string FoodGroup = "";
            try
            {
                if (cbIGroup.SelectedItem != null)
                {
                    FoodGroup = cbIGroup.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Please choose a food group");
                    return;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a food group");
                return;

            }
            string UnitOfMeasurement = tbIUnit.Text;

            Ingredient ingredient = new Ingredient(Name, Quantity, Calories, FoodGroup, UnitOfMeasurement);
            recipe.ingredients.Add(ingredient);
            listBox1.Items.Add(ingredient.name);
            tbICal.Text = "";
            tbIName.Text = "";
            tbIQuan.Text = "";
            tbIUnit.Text = "";

        }
    }
}
