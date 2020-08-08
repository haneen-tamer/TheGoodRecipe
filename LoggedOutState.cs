using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    class LoggedOutState : UserState
    {
        public LoggedOutState(UserManager um)
        {
            this.um = um;
        }
        public override void login(string username, string pass)
        {
            User u = um.getUser(username);
            if (u == null || !u.getPassword().Equals(pass))
            {
                throw new InvalidLoginException();
            }
                else
            {
                um.setCurrentUser(username);
                um.setState(um.getLoggedInState());
            }
            
        }

        public override void logout()
        {
            throw new NotImplementedException("logout functionality not allowed in this state");
        }

        public override void postReview(RecipeReviewStorageManager rm, RecipeReview rv)
        {
            throw new NotLoggedInException();
        }

        public override void signUp(string username, string name, string pass)
        {
            um.addUser(new User(username, name, pass));
            um.setCurrentUser(username);
            um.setState(um.getLoggedInState());
        }
    }
}
