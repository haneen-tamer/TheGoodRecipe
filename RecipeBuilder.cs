using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    public class RecipeBuilder : Builder
    {
        private Recipe recipe;

        public Recipe GetResult()
        {
            return this.recipe;
        }
        public void FetchRecipe(RecipeStorageManager manager)
        {

        }

        //public void CalculateRating(RatingCalculator calculator)
        //{
        //   // recipe.Rating = calculator.CalculateRating();
        //}

        
    }
}
