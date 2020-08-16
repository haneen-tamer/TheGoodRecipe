using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    public class RecipeReview
    {
        string userName;
        string recipeID;
        string reviewText;
        DateTime timeStamp;

        public RecipeReview(string userName, string recipeID, string reviewText, DateTime timeStamp)
        {
            this.userName = userName;
            this.recipeID = recipeID;
            this.reviewText = reviewText;
            this.timeStamp = timeStamp;
        }

        public void setUsername (string username)
        {
            this.userName = username;
        }

        public string getUsername()
        {
            return userName;
        }

        public void setrecipeID(string recipeid)
        {
            this.recipeID = recipeid;
        }

        public string getrecipeID()
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
            return timeStamp;

        }

      
        
    }
}
