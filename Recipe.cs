using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    public class Recipe
    {
        #region Variables
        private string ID;
        private int servings;
        private int readyInMinutes;
        private int likes;
        private String title;
        private String sourceURL="wwwdbwec";
        private String sourceName;
        private List<String> instructions;
        private double rating;
        private double healthScore;
        private float pricePerServing;
        private String imageURL;
        private Ingredient[] ingredients;
        //private Cuisines cuisines;
        //private Dishtypes dishTypes;
        #endregion

        #region Getters and Setters
        public string ID1 { get => ID; set => ID = value; }
        public int Servings { get => servings; set => servings = value; }

        public int getLikes() { return likes; }
        public void setLikes(int l) { likes = l; }

        public int ReadyInMinutes { get => readyInMinutes; set => readyInMinutes = value; }
        public string Title { get => title; set => title = value; }
        public string SourceURL { get => sourceURL; set => sourceURL = value; }
        public string SourceName { get => sourceName; set => sourceName = value; }
        public List<string> Instructions { get => instructions; set => instructions = value; }
        public double Rating { get => rating; set => rating = value; }
        public double HealthScore { get => healthScore; set => healthScore = value; }
        public float PricePerServing { get => pricePerServing; set => pricePerServing = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public Ingredient[] Ingredients { get => ingredients; set => ingredients = value; }
        #endregion

    }
}
