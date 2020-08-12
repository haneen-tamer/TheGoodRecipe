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
        public List<Recipe> fetchRandomRecipes()
        {
            return this.searchRecipes("");
        }

        public Recipe fetchRecipe(string id)
        {
            Recipe r = new Recipe();
            WebRequest request = WebRequest.Create("https://recipesapi.herokuapp.com/api/get?rId="+id);
            request.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                WebResponse response = request.GetResponse();
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                //TODO CHeck response status
                using (Stream dataStream = response.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.
                    StreamReader sreader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = sreader.ReadToEnd();
                    //parse json object
                    JToken outer = JToken.Parse(responseFromServer);
                    JObject inner = outer["recipe"].Value<JObject>();
                    r.Title = inner["title"].ToString();
                    r.ID1 = inner["recipe_id"].ToString();
                    r.ImageURL = inner["image_url"].ToString();
                    r.SourceName = inner["publisher"].ToString();
                    r.SourceURL = inner["source_url"].ToString();
                    r.Rating = double.Parse( inner["social_rank"].ToString());
                    JArray ingredients = inner["ingredients"].Value<JArray>();
                    r.Ingredients = new string[ingredients.Count];
                    for (int i = 0; i < ingredients.Count; i++)
                    {
                        r.Ingredients[i] = ingredients[i].ToString();
                    }

                }
                response.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return r;
        }

        public List<Recipe> searchRecipes(string query)
        {
            List<Recipe> rl = new List<Recipe>();
            query.Replace(" ", "%20");
            WebRequest request = WebRequest.Create("https://recipesapi.herokuapp.com/api/search?q=" + query);
            request.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                WebResponse response = request.GetResponse();
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                //TODO CHeck response status
                using (Stream dataStream = response.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.
                    StreamReader sreader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = sreader.ReadToEnd();
                    //parse json object
                    JToken outer = JToken.Parse(responseFromServer);
                    JArray inner = outer["recipes"].Value<JArray>();
                    int count = int.Parse(outer["count"].ToString());
                    Recipe r;
                    for (int i = 0; i < count; i++)
                    {
                        JObject rec = inner[i].Value<JObject>();
                        r = new Recipe();
                        r.Title = rec["title"].ToString();
                        r.ID1 = rec["recipe_id"].ToString();
                        r.ImageURL = rec["image_url"].ToString();
                        r.SourceName = rec["publisher"].ToString();
                        r.SourceURL = rec["source_url"].ToString();
                        r.Rating = double.Parse(rec["social_rank"].ToString());
                        
                        rl.Add(r);
                    }

                }
                response.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Line: "+e.Source+"/nMessage:"+e.Message+ "/nStacktrace/n"+e.StackTrace);
            }

            return rl;
        }
    }
}
