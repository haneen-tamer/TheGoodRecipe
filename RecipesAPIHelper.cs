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
        private const string API_KEY = "ffcc9445764c4caea745dbe6155eef80";
        public async Task<List<Recipe>> fetchRandomRecipesAsync()

        {
            List<Recipe> rl = new List<Recipe>();
            //for (int c = 0; c < 5; c++)
            //{
                WebRequest request = WebRequest.Create("https://api.spoonacular.com/recipes/random" +
                    "?apiKey=" + API_KEY);
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
                            JArray inner = outer["recipes"].Value<JArray>();
                            Recipe r;
                            for (int i = 0; i < inner.Count; i++)
                            {
                                JObject rec = inner[i].Value<JObject>();
                                r = new Recipe();
                                r.Title = rec["title"].ToString();
                                r.ID1 = rec["id"].ToString();
                                r.ImageURL = rec["image"].ToString();
                                //r.SourceName = rec["sourceName"].ToString();
                                //r.SourceURL = rec["sourceUrl"].ToString();
                                r.Rating = double.Parse(rec["spoonacularScore"].ToString());
                                r.ReadyInMinutes = int.Parse(rec["readyInMinutes"].ToString());

                                rl.Add(r);
                            }

                        }
                    }
                    response.Close();
                }

                catch (Exception e)
                {
                    MessageBox.Show("Line: " + e.Source + "/nMessage:" + e.Message + "/nStacktrace/n" + e.StackTrace);
                }
            // }

            WebRequest request2 = WebRequest.Create("https://api.spoonacular.com/recipes/"+rl[0].ID1 
                +"/similar"+ "?apiKey=" + API_KEY);
            request.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                WebResponse response = await request2.GetResponseAsync();

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
                        JArray arr = outer.Value<JArray>();
                        Recipe r;
                        for (int i = 0; i < arr.Count; i++)
                        {
                            JObject rec = arr[i].Value<JObject>();
                            r = new Recipe();
                            r.Title = rec["title"].ToString();
                            r.ID1 = rec["id"].ToString();
                            //r.ImageURL = rec["image"].ToString();
                            //r.SourceName = rec["sourceName"].ToString();
                            //r.SourceURL = rec["sourceUrl"].ToString();
                            //r.Rating = double.Parse(rec["spoonacularScore"].ToString());
                            r.ReadyInMinutes = int.Parse(rec["readyInMinutes"].ToString());

                            rl.Add(r);
                        }

                    }
                }
                response.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show("Line: " + e.Source + "/nMessage:" + e.Message + "/nStacktrace/n" + e.StackTrace);
            }
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

                        r.Instructions = new List<string>();
                        r.Instructions.Add(rec["instructions"].ToString());//TODO split instructions


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
                            r = new Recipe();
                            r.Title = rec["title"].ToString();
                            r.ID1 = rec["id"].ToString();
                            r.ImageURL = rec["image"].ToString();


                            rl.Add(r);
                        }

                    }
                }
                response.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

                return rl;
        }
    }
}
