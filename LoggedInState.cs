using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    class LoggedInState : UserState
    {
        public LoggedInState (UserManager um)
        {
            this.um = um;
        }
        public override void login(string username, string pass)
        {
            //login functionality not allowed here
            throw new NotImplementedException("login functionality not allowed in this state");
        }

        public override void logout()
        {
            um.clearCurrentUser();
            um.setState(um.getLoggedOutState());
        }

        public override void postReview()
        {
            throw new NotImplementedException();
        }

        public override void signUp(string username, string name, string pass)
        {
            throw new NotImplementedException("sign up functionality not allowed in this state");
        }
    }
}
