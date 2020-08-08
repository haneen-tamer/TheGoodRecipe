using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    public interface Builder
    {
        #region Functions
        Recipe GetResult();

        void FetchRecipe(RecipeStorageManager);

        void CalculateRating(RatingCalculator);

        void GetReviews(RecipeReviewStorageManager);

        #endregion
    }
}
