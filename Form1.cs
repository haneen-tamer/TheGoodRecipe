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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel.Hide();
            UserManager.getInstance().readUsers();
            rrm = new RecipeReviewManager();
            rrm.readReviews();
            rsm = new testRecipeStorage();
            recipeController = new RecipeController(rsm.fetchRandomRecipes(), dgv1);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            panel.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserManager.getInstance().saveUsers();
            rrm.saveReviews();
        }

        //private void viewRecipeBtn_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("selection " + dgv1.SelectedRows.Count);
        //    recipeForm recipe = new recipeForm(rrm, recipeController.getSelectedRecipe());
        //    recipe.Show();
        //    this.Close();
        //}

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Columns[e.ColumnIndex].Name == "ViewRecipeCol")
            {
                this.Hide();
                recipeForm recipe = new recipeForm(rrm, recipeController.getSelectedRecipe());
                recipe.Closed += (s, args) => this.Close();
                recipe.Show();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
