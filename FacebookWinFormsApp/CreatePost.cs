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
            CreatePost post;
            switch (i_PostDetails.PostType)
            {
                case ePostType.Text:
                    post = new CreateTextPost();
                    break;
                case ePostType.Image:
                    post = new CreateImagePost();
                    break;
                case ePostType.Link:
                    post = new CreateLinkPost();
                    break;
                default:
                    post = new CreateTextPost();
                    break;
            }

            post.Post(i_PostDetails, i_LoggedInUser);
        }
    }
}
