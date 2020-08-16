using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    class CachedRecipesAPIHelper : RecipeStorageManager
    {
        private RecipeStorageManager service;
        private Boolean NeedReset;
        private Dictionary<string, List<Recipe>> cache;

        public CachedRecipesAPIHelper(RecipeStorageManager rsm)
        {
            NeedReset = false;
            service = rsm;
            cache = new Dictionary<string, List<Recipe>>();
        }
        
        public async Task<List<Recipe>> fetchRandomRecipesAsync()
        {
            if (!cache.ContainsKey("Random") || NeedReset)
            {
                cache["Random"] = await service.fetchRandomRecipesAsync();
            }
                return cache["Random"];
        }

        public async Task<Recipe> fetchRecipeAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Recipe>> searchRecipesAsync(string query)
        {
            if (!cache.ContainsKey("query") || NeedReset)
            {
                cache["Random"] = await service.searchRecipesAsync(query);
            }
            return cache["Random"];
        }
    }
}
