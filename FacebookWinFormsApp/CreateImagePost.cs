using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class CreateImagePost : CreatePost
    {
        public override void Post(PostParameters i_PostDetails, User i_LoggedInUser)
        {
            i_LoggedInUser.PostStatus(i_PostDetails.Text, null, i_PostDetails.ImgUrl);
        }
    }
}
