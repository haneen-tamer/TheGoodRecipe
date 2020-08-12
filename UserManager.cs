using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TheGoodRecipe
{
    class UserManager : UserStorageManager
    {
        private static UserManager instance;
        public static UserManager getInstance()
        {
            if (instance == null)
                instance = new UserManager();
            return instance;
        }
        private static string USER_FILENAME = "users.txt";
        
        
        private List<User> allUsers;
        private UserState currentState;
        private User currentUser;

        private UserState loggedIn;
        private UserState loggedOut;

        private UserManager()
        {
            loggedIn = new LoggedInState(this);
            loggedOut = new LoggedOutState(this);

            currentState = loggedOut;
            allUsers = new List<User>();
        }

        public User getCurrentUser() { return currentUser; }
        public void setCurrentUser(string username)
        {
            for(int i=0; i<allUsers.Count; i++)
            {
                if (allUsers[i].getUserName().Equals(username))
                {
                    currentUser = allUsers[i];
                    return;
                }
                    
            }
        }

        public void clearCurrentUser()
        {
            currentUser = null;
        }

        public void addUser(User u)
        {
            allUsers.Add(u);
        }

        public User getUser(string username)
        {
            foreach (User u in allUsers)
            {
                if (u.getUserName().Equals(username))
                {
                    return u;
                }

            }
            return null;
        }
        
        public void setState(UserState us) { currentState = us; }
        public UserState getState() { return currentState; }
        public bool IsLoogedin()
        {
            return (currentState == loggedIn);
        }
        public UserState getLoggedInState() { return loggedIn; }
        public UserState getLoggedOutState() { return loggedOut; }
        public void login(string username, string pass)
        {
            currentState.login( username, pass);
        }

        public void logout()
        {
            currentState.logout();
        }

        public void postReview(RecipeReviewStorageManager rm, RecipeReview rv)
        {
            currentState.postReview(rm,rv);
        }

        public void signUp(string username, string name, string pass)
        {
            currentState.signUp(username, name, pass);
        }
        public void readUsers()
        {
            allUsers = new List<User>();
            FileStream f = new FileStream(USER_FILENAME, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);
            while (sr.Peek() >-1)
            {
                string l = sr.ReadLine();
                string[] vals = l.Split(',');
                allUsers.Add(new User(vals[0], vals[1], vals[2]));
            }

            sr.Close();
            f.Close();
        }

        public void saveUsers()
        {

            FileStream f = new FileStream(USER_FILENAME, FileMode.Truncate);
            StreamWriter sw = new StreamWriter(f);
            foreach(User u in allUsers)
            {
                sw.WriteLine(u.getUserName() + "," + u.getName() + "," + u.getPassword());
            }
            sw.Close();
            f.Close();
        }
    }
}
