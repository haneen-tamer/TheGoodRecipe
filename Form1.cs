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

        private async void backBtn_Click(object sender, EventArgs e)
        {
            panel.Hide();
            recipeController = new RecipeController(await rsm.fetchRandomRecipesAsync(), dgv1);
            searchedRecipeTxt.Clear();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            panel.Hide();
            UserManager.getInstance().readUsers();
            rrm = new RecipeReviewManager();
            rrm.readReviews();
            rsm = new RecipesAPIHelper();
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            progressBar.Value = 0;
            recipeController = new RecipeController(await rsm.fetchRandomRecipesAsync(), dgv1);
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            recipeController = new RecipeController(await rsm.searchRecipesAsync(searchedRecipeTxt.Text), dgvSearch);
            panel.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserManager.getInstance().saveUsers();
            rrm.saveReviews();
        }


        private async void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Columns[e.ColumnIndex].Name == "ViewRecipeCol")
            {
                this.Hide();
                recipeForm recipe = new recipeForm(rrm, await rsm.fetchRecipeAsync(recipeController.getSelectedRecipe().ID1));
                recipe.Closed += (s, args) => this.Close();
                recipe.Show();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearch.Columns[e.ColumnIndex].Name == "sViewRecipeCol")
            {
                this.Hide();
                recipeForm recipe = new recipeForm(rrm, await rsm.fetchRecipeAsync(recipeController.getSelectedRecipe().ID1));
                recipe.Closed += (s, args) => this.Close();
                recipe.Show();

            }
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            //backgroundWorker1.ReportProgress((6 * 100) / 100000);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
        }
    }
}
