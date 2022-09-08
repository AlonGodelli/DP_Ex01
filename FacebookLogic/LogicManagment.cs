using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;

namespace FacebookLogic
{
    public class LogicManagment
    {
        public static User loggedInUser { get; set; }

        private static LoginResult loginResult { get; set; }


        public static bool Login(out User o_LoggedInUser)
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
                    "user_videos"
                    );

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                loggedInUser = loginResult.LoggedInUser;
                isLogInSucceeded = true;
            }
            else
            {
                loggedInUser = null;
                isLogInSucceeded = false;
            }

            o_LoggedInUser = loggedInUser;

            return isLogInSucceeded;
        }

        public static void Logout()
        {
            FacebookService.LogoutWithUI();
        }
    }
}
