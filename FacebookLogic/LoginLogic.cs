using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic
{
    public class LoginLogic : FacebookLogicManagment
    {
        public static LoginResult loginResult { get; set; }

        public static bool Login()
        {
            bool isLogInSucceeded;

            loginResult = FacebookService.Login(
                    "463643038546199",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                loggedInUser = loginResult.LoggedInUser;
                isLogInSucceeded = true;
            }
            else
            {
                isLogInSucceeded = false;
            }

            return isLogInSucceeded;
        }

        public static void Logout() // not work
        {
            FacebookService.LogoutWithUI();
        }
    }
}
