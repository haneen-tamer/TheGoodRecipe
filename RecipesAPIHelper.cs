using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TheGoodRecipe
{
    class RecipesAPIHelper : RecipeStorageManager
    {

        //private const string API_KEY = "df8c0251c12449a295a5c7b76c95b756";
        //private const string API_KEY = "ffcc9445764c4caea745dbe6155eef80";
        //private const string API_KEY = "2edcc5f5f65142c3a29e28acb9de86fe";
        private const string API_KEY = "737170500df7437b81d3f003166723a8";        
        public async Task<List<Recipe>> fetchRandomRecipesAsync()

        {
            List<Recipe> rl = new List<Recipe>();
            rl = await this.searchRecipesAsync("");
            return rl;
        }

        public async Task<Recipe> fetchRecipeAsync(string id)
        {
            Recipe r = new Recipe();
            WebRequest request = WebRequest.Create("https://api.spoonacular.com/recipes/"+id+"/information?" +
                "apiKey="+API_KEY+ "&includeNutrition=true");
            request.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                WebResponse response = await request.GetResponseAsync();

                if (((HttpWebResponse)response).StatusCode == HttpStatusCode.NotFound)
                    MessageBox.Show("not foun cuz yay");
                else if (((HttpWebResponse)response).StatusCode == HttpStatusCode.BadGateway)
                    MessageBox.Show("internet is crazy");
                else if (((HttpWebResponse)response).StatusCode == HttpStatusCode.Unauthorized)
                    MessageBox.Show("api actin UPPP");
                else if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Open the stream using a StreamReader for easy access.
                        StreamReader sreader = new StreamReader(dataStream);
                        // Read the content.
                        string responseFromServer = sreader.ReadToEnd();
                        //parse json object
                        JToken rec = JToken.Parse(responseFromServer);
                        r.Title = rec["title"].ToString();
                        r.ID1 = rec["id"].ToString();
                        r.ImageURL = rec["image"].ToString();
                        r.SourceName = rec["sourceName"].ToString();
                        r.SourceURL = rec["sourceUrl"].ToString();
                        r.Rating = double.Parse(rec["spoonacularScore"].ToString());
                        r.ReadyInMinutes = int.Parse(rec["readyInMinutes"].ToString());
                        r.HealthScore = double.Parse(rec["healthScore"].ToString());
                        r.PricePerServing = float.Parse(rec["pricePerServing"].ToString());
                        r.Servings = int.Parse(rec["servings"].ToString());
                        r.setLikes(int.Parse(rec["aggregateLikes"].ToString()));
                        JArray ingredients = rec["extendedIngredients"].Value<JArray>();
                        r.Ingredients = new Ingredient[ingredients.Count];
                        for (int i = 0; i < ingredients.Count; i++)
                        {
                            JObject ing = ingredients[i].Value<JObject>();
                            Ingredient x = new Ingredient();
                            x.ID1 = int.Parse(ing["id"].ToString());
                            x.Amount = float.Parse(ing["amount"].ToString());
                            x.Unit = ing["unit"].ToString();
                            x.Name = ing["name"].ToString();
                            r.Ingredients[i] = x;
                        }

                        
                        if(!rec["instructions"].Equals("")/*rec["instructions"]!=null*/)
                        {
                            r.Instructions = new List<string>(rec["instructions"].ToString().Split('.'));
                        }
                        else
                            r.Instructions = new List<string>();


                    }
                }
                response.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return r;
        }

        public async Task<List<Recipe>> searchRecipesAsync(string query)
        {
            List<Recipe> rl = new List<Recipe>();
            List<string> ids = new List<string>();
            query = query.Replace(" ", "%20");
            WebRequest request = WebRequest.Create("https://api.spoonacular.com/recipes/complexSearch?apiKey=" +
                API_KEY + "&query="+ query);
            request.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                WebResponse response = await request.GetResponseAsync();

                if (((HttpWebResponse)response).StatusCode == HttpStatusCode.NotFound)
                    MessageBox.Show("not foun cuz yay");
                else if (((HttpWebResponse)response).StatusCode == HttpStatusCode.BadGateway)
                    MessageBox.Show("internet is crazy");
                else if (((HttpWebResponse)response).StatusCode == HttpStatusCode.Unauthorized)
                    MessageBox.Show("api actin UPPP");
                else if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Open the stream using a StreamReader for easy access.
                        StreamReader sreader = new StreamReader(dataStream);
                        // Read the content.
                        string responseFromServer = sreader.ReadToEnd();
                        //parse json object
                        JToken outer = JToken.Parse(responseFromServer);
                        JArray inner = outer["results"].Value<JArray>();
                        Recipe r;
                        for (int i = 0; i < inner.Count; i++)
                        {
                            JObject rec = inner[i].Value<JObject>();
                            ids.Add(rec["id"].ToString());
                        }

                    }
                }
                response.Close();

                string req = "https://api.spoonacular.com/recipes/informationBulk?apiKey=" +
                API_KEY + "&ids=";
                for (int i = 0; i < ids.Count; i++)
                {
                    req += ids[i];
                    if (i < ids.Count - 1) req += ",";
                }
                WebRequest reqDetails = WebRequest.Create(req);
                reqDetails.Credentials = CredentialCache.DefaultCredentials;
                WebResponse responseDetails = await reqDetails.GetResponseAsync();
                if (((HttpWebResponse)responseDetails).StatusCode == HttpStatusCode.NotFound)
                    MessageBox.Show("not foun cuz yay");
                else if (((HttpWebResponse)responseDetails).StatusCode == HttpStatusCode.BadGateway)
                    MessageBox.Show("internet is crazy");
                else if (((HttpWebResponse)responseDetails).StatusCode == HttpStatusCode.Unauthorized)
                    MessageBox.Show("api actin UPPP");
                else if (((HttpWebResponse)responseDetails).StatusCode == HttpStatusCode.OK)
                {
                    using (Stream dataStream = responseDetails.GetResponseStream())
                    {
                        StreamReader sreader = new StreamReader(dataStream);
                        string responseFromServer = sreader.ReadToEnd();
                        JToken outer = JToken.Parse(responseFromServer);
                        JArray inner = outer.Value<JArray>();
                        for (int i = 0; i < inner.Count; i++)
                        {
                            JObject rec = inner[i].Value<JObject>();
                            Recipe r = new Recipe();
                            r.Title = rec["title"].ToString();
                            r.ID1 = rec["id"].ToString();
                            r.ImageURL = rec["image"].ToString();
                            r.SourceName = rec["sourceName"].ToString();
                            r.SourceURL = rec["sourceUrl"].ToString();
                            r.Rating = double.Parse(rec["spoonacularScore"].ToString());
                            r.ReadyInMinutes = int.Parse(rec["readyInMinutes"].ToString());
                            r.HealthScore = double.Parse(rec["healthScore"].ToString());
                            r.PricePerServing = float.Parse(rec["pricePerServing"].ToString());
                            r.Servings = int.Parse(rec["servings"].ToString());
                            r.setLikes(int.Parse(rec["aggregateLikes"].ToString()));
                            JArray ingredients = rec["extendedIngredients"].Value<JArray>();
                            r.Ingredients = new Ingredient[ingredients.Count];
                            for (int j = 0; j < ingredients.Count; j++)
                            {
                                JObject ing = ingredients[j].Value<JObject>();
                                Ingredient x = new Ingredient();
                                x.ID1 = int.Parse(ing["id"].ToString());
                                x.Amount = float.Parse(ing["amount"].ToString());
                                x.Unit = ing["unit"].ToString();
                                x.Name = ing["name"].ToString();
                                r.Ingredients[j] = x;
                            }


                            if (!rec["instructions"].Equals(""))
                            {
                                r.Instructions = new List<string>(rec["instructions"].ToString().Split('.'));
                            }
                            else
                                r.Instructions = new List<string>();
                            rl.Add(r);

                        }


                    }
                }
                responseDetails.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

                return rl;
        }
    }
}
