using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    public interface RecipeReviewStorageManager
    {
        void saveReviews();

        void readReviews();
        void AddRecipeReview(RecipeReview rv);
    }
}