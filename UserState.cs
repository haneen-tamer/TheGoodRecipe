using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    abstract class UserState
    {
        protected UserManager um;
        public abstract void login(string username, string pass);
        public abstract void signUp(string username, string name, string pass);
        public abstract void logout();
        public abstract void postReview(RecipeReviewStorageManager rm, RecipeReview rv);
    }
}
