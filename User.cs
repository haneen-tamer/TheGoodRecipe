using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    class User
    {
        #region Variables
        private String userName;
        private String name;
        private String job;
        private List<int> favouriteRecipesIDs;
        #endregion

        #region Constructors
        public User()
        {
            this.userName = "";
            this.name = "";
            this.job = "";
            this.favouriteRecipesIDs = new List<int>();
        }
        public User(String userName, String name, String job, List<int> favouriteRecipesIDs)
        {
            this.userName = userName;
            this.name = name;
            this.job = job;
            this.favouriteRecipesIDs = favouriteRecipesIDs;
        }
        #endregion

        #region Getters and Setters
        public string UserName { get => userName; set => userName = value; }
        public string Name { get => name; set => name = value; }
        public string Job { get => job; set => job = value; }
        public List<int> FavouriteRecipesIDs { get => favouriteRecipesIDs; set => favouriteRecipesIDs = value; }
        #endregion
    }
}
