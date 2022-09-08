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
    public sealed class LogicManagment
    {
        private static User s_Instances;

        private static bool s_BoolLoginResult;

        public static bool boolLoginResult 
        { 
            get
            {
                return s_BoolLoginResult;
            }
        }
        private static LoginResult loginResult { get; set; }
        public static User Instance 
        {
            get
            {
                if(s_Instances is null)
                {
                    login();
                }

                return s_Instances;
            }
        }

        private static void login()
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
                s_Instances = loginResult.LoggedInUser;
                s_BoolLoginResult = true;
            }
            else
            {
                s_Instances = null;
                s_BoolLoginResult = false;
            }

            //o_LoggedInUser = loggedInUser;

            //return isLogInSucceeded;
        }

        public static void Logout()
        {
            FacebookService.LogoutWithUI();
        }
    }
}
