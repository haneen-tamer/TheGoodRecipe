using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    public class RecipeBuilder : Builder
    {
        Recipe GetResult() { }

        void FetchRecipe(RecipeStorageManager) { }

        void CalculateRating(RatingCalculator) { }

        void GetReviews(RecipeReviewStorageManager) { }
    }
}
