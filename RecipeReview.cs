using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    class RecipeReview
    {
        string userName;
        int recipeID;
        string reviewText;
        DateTime timeStamp;
        double starRating;

        public RecipeReview(string userName, int recipeID, string reviewText, DateTime timeStamp, double starRating)
        {
            this.userName = userName;
            this.recipeID = recipeID;
            this.reviewText = reviewText;
            this.timeStamp = timeStamp;
            this.starRating = starRating;
        }

        public void setUsername (string username)
        {
            this.userName = username;
        }

        public string getUsername()
        {
            return userName;
        }

        public void setrecipeID(int recipeid)
        {
            this.recipeID = recipeid;
        }

        public int getrecipeID()
        {
            return recipeID;
        }

        public void setreviewText(string reviewtext)
        {
            this.reviewText = reviewtext;
        }

        public string getreviewText()
        {
            return reviewText
;
        }

        public void settimeStamp(DateTime timestamp)
        {
            this.timeStamp = timestamp;
        }

        public DateTime gettimeStamp()
        {
            return timeStamp
;
        }

        public void setstarRating(double starrating)
        {
            this.starRating = starrating;
        }

        public double getstarRating()
        {
            return starRating;
        }
        
    }
}
