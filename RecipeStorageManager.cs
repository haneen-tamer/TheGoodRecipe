using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TheGoodRecipe
{
    public interface RecipeStorageManager
    {
        Task<Recipe> fetchRecipeAsync(string id);
        Task<List<Recipe>> fetchRandomRecipesAsync();
        Task<List<Recipe>> searchRecipesAsync(string query);
    }
}
