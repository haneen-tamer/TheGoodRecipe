using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TheGoodRecipe
{
    [Serializable]
    public class User
    {
        private string username;
        private string password;
        private string name;
        private List<int> favRecipeIDs;

        public User()
        {
            favRecipeIDs = new List<int>();
        }

        public User(string username, string name, string p)
        {
            favRecipeIDs = new List<int>();
            this.username = username;
            this.name = name;
            password = p;
        }

        public List<int> getFavRecipeIDs()
        {
            return new List<int>(this.favRecipeIDs);
        }

        public void addFavRecipe(int id)
        {
            favRecipeIDs.Add(id);
        }
        public void removeFavRecipe(int id)
        {
            favRecipeIDs.Remove(id);
        }

        public string getName() { return this.name; }
        public void setName(string n) { name = n; }
        public string getUserName() { return this.username; }
        public void setUserName(string n) { username = n; }
        public string getPassword() { return this.password; }
        public void setPassword(string p) { password = p; }
    }
}
