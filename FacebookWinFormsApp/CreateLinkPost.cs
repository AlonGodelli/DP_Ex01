using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class CreateLinkPost : CreatePost
    {
        public CreateLinkPost(PostParameters i_PostDetails, User i_LoggedInUser)
        {
            Post(i_PostDetails, i_LoggedInUser);
        }

        public override void Post(PostParameters i_PostDetails, User i_LoggedInUser)
        {
            i_LoggedInUser.PostStatus(i_PostDetails.Text, null, null, null, i_PostDetails.LinkUrl);
        }
    }
}
