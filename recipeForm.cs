using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGoodRecipe
{
    public partial class recipeForm : Form
    {
        RecipeReviewManager rrm;
        Recipe recipe;

        UserManager um;
        RecipeReview rv;

        RatingStrategy rate;
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
            IngredientsAmount.Items.Clear();
            int amount = int.Parse(txt_NumOfServings.Text);
            IngredientsPanel.Visible = true;
            Dictionary<int, float> c= IngredientAmountCalculator.calculateIngredientAmount(recipe,amount);
            for(int i=0;i<c.Count;i++)
            {

                IngredientsAmount.Items.Add(c[i].ToString("0.00") + " " + recipe.Ingredients[i].Unit + " " + recipe.Ingredients[i].Name);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!um.IsLoogedin())
            {
                MessageBox.Show("You must Login/Sign up to be able to post a review.");
                return;
            }
            string username = um.getCurrentUser().getUserName();
            string recipeID = recipe.ID1;
            string review = Review_richTextBox.Text.ToString();
            DateTime dt = DateTime.Now;
            double rates = recipe.Rating;
            rv = new RecipeReview(username, recipeID, review, dt, rates);

            //rrm.AddRecipeReview(rv);
            UserManager.getInstance().postReview(rrm, rv);
            rrm.saveReviews();

            List<string> newReview = new List<string>();
            newReview.Add(username);
            newReview.Add(review);
            newReview.Add(dt.ToString());
            newReview.Add(rates.ToString());

            Reviews_dgv.Rows.Add(newReview.ToArray());
        }

        private void recipeForm_Load(object sender, EventArgs e)
        {
            um = UserManager.getInstance();
            //cuisine
            //dishtype
            //image
            //Star rating
            //radiobtn ratings
            if (UserManager.getInstance().IsLoogedin())
            {

                logout_btn.Visible = true;
                login_btn.Visible = false;
            }
            else
            {
                login_btn.Visible = true;
                logout_btn.Visible = false;
            }

            IngredientsPanel.Visible = false;
            RecipeName.Text = recipe.Title;
            label2.Text = recipe.Rating.ToString();
            txt_ReadyInMinutes.Text = recipe.ReadyInMinutes.ToString();
            txt_PricePerServing.Text = recipe.PricePerServing.ToString();
            txt_HealthScore.Text = recipe.HealthScore.ToString();
            txt_Servings.Text = recipe.Servings.ToString();
            for (int i=0;i<recipe.Ingredients.Count();i++)
            {
                list_ingredients.Items.Add(recipe.Ingredients[i].Amount+" "+ recipe.Ingredients[i].Unit + " "+ recipe.Ingredients[i].Name);
               
            }
            if(recipe.Instructions.Count()==0)
            {
                list_instructions.Items.Add("Just mix everything together");
            }
            else
            {
                for (int i = 0; i < recipe.Instructions.Count(); i++)
                {
                    list_instructions.Items.Add(recipe.Instructions[i]);
                }

            }

            all_reviews = rrm.getReviewsByRecipeID(recipe.ID1);

            Reviews_dgv.ReadOnly = true;
            string[] columns = { "Name", "Review", "Date" };
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
               // row.Add(all_reviews[i].getstarRating().ToString());

                Reviews_dgv.Rows.Add(row.ToArray());
            }

            WebRequest request = WebRequest.Create(recipe.ImageURL);
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    picture_recipe.Image = Bitmap.FromStream(str);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void HealthRatingradioBtn_CheckedChanged(object sender, EventArgs e)
        {
            rate = new HealthRatingStrategy();
            txt_rating.Text = rate.getRating(recipe).ToString();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rate = new UserRatingStrategy();
            txt_rating.Text = rate.getRating(recipe).ToString();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
            this.Hide();
            f.Closed += (s, args) => this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            login_btn.Visible = false;
            logout_btn.Visible = true;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            UserManager.getInstance().logout();
            login_btn.Visible = true;
            logout_btn.Visible = false;
        }

        private void Reviews_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
