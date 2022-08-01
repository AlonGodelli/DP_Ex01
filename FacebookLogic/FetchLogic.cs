using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic
{
    public class FetchLogic : FacebookLogicManagment
    {
        public static string FetchProfilePicture()
        {
            return loggedInUser.PictureLargeURL;
        }

        public static string FetchUserName()
        {
            return loggedInUser.Name;
        }

        public static List<String> FetchUserPosts()
        {
            List<String> userPostsList = new List<String>();

            foreach (Post post in loggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    userPostsList.Add(post.Message);
                }
            }

            return userPostsList;
        }

        public static List<String> FetchAlbumsNames()
        {
            List<String> userAlbumsList = new List<String>();

            foreach (Album album in loggedInUser.Albums)
            {
                userAlbumsList.Add(album.Name);
            }

            return userAlbumsList;
        }

        public static string FetchSelectedAlbumPicture(string i_albumName)
        {
            string albumPictureSource = null;

            foreach (Album album in loggedInUser.Albums)
            {
                if (album.Name == i_albumName)
                {
                    albumPictureSource = album.PictureAlbumURL;
                }
            }

            return albumPictureSource;
        }

        public static string FetchSelectedLikedPage(string i_PageName)
        {
            string likedPageSource = null;

            foreach (Page page in loggedInUser.LikedPages)
            {
                if (page.Name == i_PageName)
                {
                    likedPageSource = page.PictureNormalURL;
                }
            }

            return likedPageSource;
        }

        public static List<String> FetchEvents()
        {
            List<String> userEvents = new List<String>();

            foreach (Event fbEvent in loggedInUser.Events)
            {
                userEvents.Add(fbEvent.Description);
            }

            return userEvents;
        }

        public static List<String> FetchUserGroupsNames()
        {
            List<String> userGroupsList = new List<String>();

            foreach (Group group in loggedInUser.Groups) // ?????????????????????????????????
            {
                userGroupsList.Add(group.Name);
            }

            return userGroupsList;
        }

        public static List<String> fetchLikedPages()
        {
            List<String> likedPages = new List<String>();

            foreach (Page page in loggedInUser.LikedPages)
            {
                likedPages.Add(page.Name);
            }

            return likedPages;
        }
    }
}
