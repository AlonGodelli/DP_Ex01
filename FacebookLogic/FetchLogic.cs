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

        public static Post FetchMostPopularPost()
        {
            Post currentMostPopularPost = null;

            foreach (Post post in loggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    if (currentMostPopularPost == null)
                    {
                        currentMostPopularPost = post;
                    }
                    else if (post.Comments.Count > currentMostPopularPost.Comments.Count)
                    {
                        currentMostPopularPost = post;
                    }
                }
            }

            return currentMostPopularPost;
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

            foreach (Group group in loggedInUser.Groups)
            {
                userGroupsList.Add(group.Name);
            }

            return userGroupsList;
        }


        public static List<String> FetchLikedPages()
        {
            List<String> likedPages = new List<String>();

            foreach (Page page in loggedInUser.LikedPages)
            {
                likedPages.Add(page.Name);
            }

            return likedPages;
        }

        public static IDictionary<string, int> FetchPostActivityStatistic()
        {
            IDictionary<string, int> postCountByYear = new Dictionary<string, int>();
            int fromYear = 2009;
            int toYear = 2022;

            initActivityStatisticDictionary(fromYear, toYear, postCountByYear);

            foreach (Post post in loggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    try
                    {
                        postCountByYear[(post.CreatedTime.ToString()).Substring(6, 4)] += 1;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            return postCountByYear;
        }

        public static IDictionary<string, int> FetchPhotosActivityStatistic()
        {
            IDictionary<string, int> postCountByYear = new Dictionary<string, int>();
            int fromYear = 2009;
            int toYear = 2022;

            initActivityStatisticDictionary(fromYear, toYear, postCountByYear);

            foreach (Photo photo in loggedInUser.PhotosTaggedIn) // not work as expected
            {
                try
                {
                    postCountByYear[(photo.CreatedTime.ToString()).Substring(6, 4)] += 1;
                }
                catch
                {
                    continue;
                }
            }

            return postCountByYear;
        }

        private static void initActivityStatisticDictionary(int i_FromYear, int i_ToYear, IDictionary<string, int> io_ActivityStatisticDictionary)
        {

            for (int year = i_FromYear; year <= i_ToYear; year++)
            {
                io_ActivityStatisticDictionary.Add(year.ToString(), 0);
            }
        }
    }
}
