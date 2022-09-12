using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public abstract class CreatePost
    {
        public abstract void Post(PostParameters i_PostDetails, User i_LoggedInUser);

        public static void CreateNewPost(PostParameters i_PostDetails, User i_LoggedInUser)
        {
            switch (i_PostDetails.PostType)
            {
                case ePostType.Text:
                    new CreateTextPost(i_PostDetails, i_LoggedInUser);
                    break;
                case ePostType.Image:
                    new CreateImagePost(i_PostDetails, i_LoggedInUser);
                    break;
                case ePostType.Link:
                    new CreateLinkPost(i_PostDetails, i_LoggedInUser);
                    break;
                default:
                    break;
            }
        }
    }
}
