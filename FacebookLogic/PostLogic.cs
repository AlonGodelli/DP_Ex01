using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class PostLogic 
    {
        public static void Post(string i_Text, User i_LoggedInUser)
        {
            Status postedStatus = i_LoggedInUser.PostStatus(i_Text);
        }
    }
}
