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
        private static bool s_IsLoggedIn;

        private LogicManagment()
        {
        }

        public static bool boolLoginResult
        {
            get
            {
                return s_IsLoggedIn;
            }
        }

        private static LoginResult FacebookLoginResult { get; set; }

        public static User Instance
        {
            get
            {
                if (s_Instances is null)
                {
                    login();
                }

                return s_Instances;
            }
        }

        private static void login()
        {
            FacebookLoginResult = FacebookService.Login(
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

            if (!string.IsNullOrEmpty(FacebookLoginResult.AccessToken))
            {
                s_Instances = FacebookLoginResult.LoggedInUser;
                s_IsLoggedIn = true;
            }
            else
            {
                s_Instances = null;
                s_IsLoggedIn = false;
            }
        }

        public static void Logout()
        {
            FacebookService.LogoutWithUI();
        }
    }
}
