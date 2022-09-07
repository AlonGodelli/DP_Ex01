using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class PostLogic : LogicManagment
    {
        public static void Post(string i_Text)
        {
            Status postedStatus =  loggedInUser.PostStatus(i_Text);
        }
    }
}
