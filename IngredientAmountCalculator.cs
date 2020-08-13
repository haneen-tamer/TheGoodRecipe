using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    class IngredientAmountCalculator
    {

        public static Dictionary<int,float> calculateIngredientAmount(Recipe r, int numServings)
        {
            Dictionary<int, float> calc = new Dictionary<int, float>();
            if (r.Servings == 0)
            {
                throw new ServingException();
            }
            float factor = ((float)numServings / (float)r.Servings);
            
            for(int i=0;i<r.Ingredients.Length;i++)
            {
                calc.Add(i, (float)r.Ingredients[i].Amount * factor);
            }
            return calc;
        }
    }
}
