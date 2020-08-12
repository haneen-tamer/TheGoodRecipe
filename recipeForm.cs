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
            int amount = int.Parse(txt_NumOfServings.Text);
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
            //cuisine
            //dishtype
            //image
            //Star rating
            //radiobtn ratings

            RecipeName.Text = recipe.Title;
            txt_ReadyInMinutes.Text = recipe.ReadyInMinutes.ToString();
            txt_PricePerServing.Text = recipe.PricePerServing.ToString();
            txt_Calories.Text = recipe.Calories.ToString();
            txt_HealthScore.Text = recipe.HealthScore.ToString();
            txt_Servings.Text = recipe.Servings.ToString();
            for (int i=0;i<recipe.Ingredients.Count();i++)
            {
                list_ingredients.Items.Add(recipe.Ingredients[i]);
            }
            //for (int i = 0; i < recipe.Instructions.Count(); i++)
            //{
            //    list_instructions.Items.Add(recipe.Instructions[i]);
            //}

            all_reviews = rrm.getReviewsByRecipeID(recipe.ID1);

            Reviews_dgv.ReadOnly = true;
            string[] columns = { "Name", "Review", "Date","Rating" };
            Reviews_dgv.ColumnCount = columns.Length;
            for (int i = 0; i < columns.Length; i++)
            {
                Reviews_dgv.Columns[i].Name = columns[i];
            }
            for (int i = 0; i < all_reviews.Count; i++)
            {
                List<string> row = new List<string>();
                row.Add(all_reviews[i].getUsername());
                row.Add(all_reviews[i].getreviewText());
                row.Add(all_reviews[i].gettimeStamp().ToString());
                row.Add(all_reviews[i].getstarRating().ToString());

                Reviews_dgv.Rows.Add(row.ToArray());
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }
}
