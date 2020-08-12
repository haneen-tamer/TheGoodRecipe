using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    public interface RecipeStorageManager
    {
        Recipe fetchRecipe(string id);
        List<Recipe> fetchRandomRecipes();
        List<Recipe> searchRecipes(string query);
    }
}
