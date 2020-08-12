using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheGoodRecipe
{
    public class RecipeReviewManager : RecipeReviewStorageManager
    {
        List<RecipeReview> allRecipeReviews;
        List<RecipeReview> showRecipeReviews;
        string REVIEW_FILENAME = "reviews.txt";

        public void saveReviews()
        {
            FileStream f = new FileStream(REVIEW_FILENAME, FileMode.Truncate);
            StreamWriter sw = new StreamWriter(f);
            foreach(RecipeReview r in allRecipeReviews)
            {
                sw.WriteLine(r.getUsername() + "," + r.getrecipeID() + "," + r.getreviewText() + "," + r.gettimeStamp() + "," + r.getstarRating());

            }
            sw.Close();
            f.Close();
        }

        public void readReviews()
        {
            allRecipeReviews = new List<RecipeReview>();
            FileStream f = new FileStream(REVIEW_FILENAME, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);
            while(sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] line_var = line.Split(',');
                allRecipeReviews.Add(new RecipeReview(line_var[0], line_var[1], line_var[2], DateTime.Parse(line_var[3]), double.Parse(line_var[4])));
            }
            sr.Close();
            f.Close();
        }

        public List<RecipeReview> getReviewsByRecipeID(string id)
        {
            showRecipeReviews = new List<RecipeReview>();
            foreach(RecipeReview r in allRecipeReviews)
            {
                if (r.getrecipeID().Equals( id))
                    showRecipeReviews.Add(r);
            }
            return showRecipeReviews;
        }

        public void AddRecipeReview(RecipeReview recipeReview)
        {
            allRecipeReviews.Add(recipeReview);
        }
    }
}
