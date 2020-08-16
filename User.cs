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


        public User(string username, string name, string p)
        {
            this.username = username;
            this.name = name;
            password = p;
        }

        public string getName() { return this.name; }
        public void setName(string n) { name = n; }
        public string getUserName() { return this.username; }
        public void setUserName(string n) { username = n; }
        public string getPassword() { return this.password; }
        public void setPassword(string p) { password = p; }
    }
}
