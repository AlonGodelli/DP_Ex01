using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class FetchLogic : FacebookLogicManagment
    {
        public static string getProfilePicture()
        {
            return loggedInUser.PictureLargeURL;
        }

        public static string getUserName()
        {
            return loggedInUser.Name;
        }
    }
}
