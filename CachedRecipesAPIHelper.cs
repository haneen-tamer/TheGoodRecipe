using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGoodRecipe
{
    class CachedRecipesAPIHelper : RecipeStorageManager
    {
        private RecipeStorageManager service;
        private Dictionary<string, List<Recipe>> cache;

        public CachedRecipesAPIHelper(RecipeStorageManager rsm)
        {
            service = rsm;
            cache = new Dictionary<string, List<Recipe>>();
        }
        
        public async Task<List<Recipe>> fetchRandomRecipesAsync()
        {
            if (!cache.ContainsKey("Random"))
            {
                cache["Random"] = await service.fetchRandomRecipesAsync();
            } 
            return cache["Random"];
        }

        public async Task<Recipe> fetchRecipeAsync(string id)
        {
            if (!cache.ContainsKey(id))
            {
                cache[id] = new List<Recipe>();
                cache[id].Add( await service.fetchRecipeAsync(id));
            }
            return cache[id][0];
        }

        public async Task<List<Recipe>> searchRecipesAsync(string query)
        {
            if (!cache.ContainsKey(query))
            {
                cache[query] = await service.searchRecipesAsync(query);
            }
            return cache[query];
        }
    }
}
