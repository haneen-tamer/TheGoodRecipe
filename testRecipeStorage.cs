using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    class testRecipeStorage : RecipeStorageManager
    {
        public List<Recipe> fetchRandomRecipes()
        {
            List<Recipe> r = new List<Recipe>();
            Recipe rec = new Recipe();
            rec.Title = "aahasbua;u;";
            Recipe rec1 = new Recipe();
            rec1.Title = "b";
            r.Add(rec);
            r.Add(rec1);
            return r;
        }

        public Recipe fetchRecipe(int id)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> searchRecipes(string query)
        {
            throw new NotImplementedException();
        }
    }
}
