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

        private void viewRecipeBtn_Click(object sender, EventArgs e)
        {
            recipeForm recipe = new recipeForm(rrm, );
            recipe.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
