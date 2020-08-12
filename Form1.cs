using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGoodRecipe
{
    public partial class Form1 : Form
    {
        RecipeReviewManager rrm;
        RecipeController recipeController;
        RecipeStorageManager rsm;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            panel.Hide();
            recipeController = new RecipeController(rsm.fetchRandomRecipes(), dgv1);
            searchedRecipeTxt.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel.Hide();
            UserManager.getInstance().readUsers();
            rrm = new RecipeReviewManager();
            rrm.readReviews();
            rsm = new RecipesAPIHelper();
            recipeController = new RecipeController(rsm.fetchRandomRecipes(), dgv1);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            recipeController = new RecipeController(rsm.searchRecipes(searchedRecipeTxt.Text), dgvSearch);
            panel.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserManager.getInstance().saveUsers();
            rrm.saveReviews();
        }


        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Columns[e.ColumnIndex].Name == "ViewRecipeCol")
            {
                this.Hide();
                recipeForm recipe = new recipeForm(rrm, rsm.fetchRecipe(recipeController.getSelectedRecipe().ID1));
                recipe.Closed += (s, args) => this.Close();
                recipe.Show();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearch.Columns[e.ColumnIndex].Name == "sViewRecipeCol")
            {
                this.Hide();
                recipeForm recipe = new recipeForm(rrm, rsm.fetchRecipe(recipeController.getSelectedRecipe().ID1));
                recipe.Closed += (s, args) => this.Close();
                recipe.Show();

            }
        }
    }
}
