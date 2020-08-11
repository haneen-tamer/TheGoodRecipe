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
    public partial class recipeForm : Form
    {
        RecipeReviewManager rrm;
        Recipe recipe;
        List <RecipeReview> all_reviews;
        public recipeForm(RecipeReviewManager rrm, Recipe recipe)
        {
            InitializeComponent();
            this.rrm = rrm;
            this.recipe = recipe;
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void recipeForm_Load(object sender, EventArgs e)
        {
            RecipeName.Text = recipe.Title;
            txt_ReadyInMinutes.Text = recipe.ReadyInMinutes.ToString();
            txt_PricePerServing.Text = recipe.PricePerServing.ToString();
            txt_Calories.Text = recipe.Calories.ToString();
            txt_HealthScore.Text = recipe.HealthScore.ToString();
            txt_NumOfServings.Text = recipe.Servings.ToString();
            for (int i=0;i<recipe.Ingredients.Count();i++)
            {
                list_ingredients.Items.Add(recipe.Ingredients[i]);
            }
            for (int i = 0; i < recipe.Instructions.Count(); i++)
            {
                list_instructions.Items.Add(recipe.Instructions[i]);
            }

            all_reviews = rrm.getReviewsByRecipeID(recipe.ID1);
            //Reviews_dgv.ColumnCount=
            for (int i = 0; i < all_reviews.Count(); i++)
            {

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }
}
