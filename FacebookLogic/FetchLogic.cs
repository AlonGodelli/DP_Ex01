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
    public static class FetchLogic
    {
        //private static bool fetchUserInfo(FacebookWrapper.ObjectModel.User i_loggedInUser,  string o_post)
        //{
        //    bool isPostAvailable;
        //    int a = i_loggedInUser.Posts.Count;

        //    //if (((int)i_loggedInUser.Posts.Count) > 0)
        //    //pictureBoxProfile.LoadAsync(i_loggedInUser.PictureNormalURL);

        //    if (i_loggedInUser.Birthday != null)
        //    {
        //        //o_post = i_loggedInUser.Posts[0].Message;
        //        isPostAvailable = true;
        //    }
        //    else
        //    {
        //        o_post = null;
        //        isPostAvailable = false;

        //    }

        //    return isPostAvailable;
        //}

        //private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    fetchPosts();
        //}

        ///// <summary>
        ///// Fetching posts *** made by the logged in user ***:
        ///// </summary>
        //private void fetchPosts()
        //{
        //    listBoxPosts.Items.Clear();

        //    foreach (Post post in m_LoggedInUser.Posts)
        //    {
        //        if (post.Message != null)
        //        {
        //            listBoxPosts.Items.Add(post.Message);
        //        }
        //        else if (post.Caption != null)
        //        {
        //            listBoxPosts.Items.Add(post.Caption);
        //        }
        //        else
        //        {
        //            listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
        //        }
        //    }

        //    if (listBoxPosts.Items.Count == 0)
        //    {
        //        MessageBox.Show("No Posts to retrieve :(");
        //    }
        //}
    }
}
