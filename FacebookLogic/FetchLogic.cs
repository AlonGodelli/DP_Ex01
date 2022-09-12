using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;

namespace FacebookLogic
{
    public class FetchLogic
    {
        public static string FetchProfilePicture(User i_LoggedInUser)
        {
            return i_LoggedInUser.PictureLargeURL;
        }

        public static string FetchLocale(User i_LoggedInUser)
        {
            return i_LoggedInUser.Locale;
        }

        public static string FetchUserName(User i_LoggedInUser)
        {
            return i_LoggedInUser.Name;
        }

        public static List<string> FetchUserPosts(User i_LoggedInUser)
        {
            List<string> userPostsList = new List<string>();

            foreach (Post post in i_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    userPostsList.Add(post.Message);
                }
            }

            return userPostsList;
        }

        public static Post FetchMostPopularPost(User i_LoggedInUser)
        {
            Post currentMostPopularPost = null;
            int limit = 0; // FOR NOT LIMITING FACEBOOK API ==============

            foreach (Post post in i_LoggedInUser.Posts)
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

                if (limit++ > 10)
                {
                    break;
                } // FOR NOT LIMITING FACEBOOK API ==============
            }

            return currentMostPopularPost;
        }

        public static List<string> FetchAlbumsNames(User i_LoggedInUser)
        {
            List<string> userAlbumsList = new List<string>();

            foreach (Album album in i_LoggedInUser.Albums)
            {
                userAlbumsList.Add(album.Name);
            }

            return userAlbumsList;
        }

        public static string FetchSelectedAlbumPicture(string i_albumName, User i_LoggedInUser)
        {
            string albumPictureSource = null;

            foreach (Album album in i_LoggedInUser.Albums)
            {
                if (album.Name == i_albumName)
                {
                    albumPictureSource = album.PictureAlbumURL;
                }
            }

            return albumPictureSource;
        }

        public static string FetchSelectedLikedPage(string i_PageName, User i_LoggedInUser)
        {
            string likedPageSource = null;

            foreach (Page page in i_LoggedInUser.LikedPages)
            {
                if (page.Name == i_PageName)
                {
                    likedPageSource = page.PictureNormalURL;
                }
            }

            return likedPageSource;
        }

        public static List<string> FetchEvents(User i_LoggedInUser)
        {
            List<string> userEvents = new List<string>();

            foreach (Event fbEvent in i_LoggedInUser.Events)
            {
                userEvents.Add(fbEvent.Description);
            }

            return userEvents;
        }

        public static List<string> FetchUserGroupsNames(User i_LoggedInUser)
        {
            List<string> userGroupsList = new List<string>();

            foreach (Group group in i_LoggedInUser.Groups)
            {
                userGroupsList.Add(group.Name);
            }

            return userGroupsList;
        }

        public static List<string> FetchLikedPages(User i_LoggedInUser)
        {
            List<string> likedPages = new List<string>();

            foreach (Page page in i_LoggedInUser.LikedPages)
            {
                likedPages.Add(page.Name);
            }

            return likedPages;
        }

        public static IDictionary<string, int> FetchPostActivityStatistic(User i_LoggedInUser)
        {
            IDictionary<string, int> postCountByYear = new Dictionary<string, int>();
            int fromYear = 2009;
            int toYear = 2022;

            initActivityStatisticDictionary(fromYear, toYear, postCountByYear);

            foreach (Post post in i_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    try
                    {
                        postCountByYear[post.CreatedTime.ToString().Substring(6, 4)] += 1;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            return postCountByYear;
        }

        public static IDictionary<string, int> FetchPhotosActivityStatistic(User i_LoggedInUser)
        {
            IDictionary<string, int> postCountByYear = new Dictionary<string, int>();
            int fromYear = 2009;
            int toYear = 2022;

            initActivityStatisticDictionary(fromYear, toYear, postCountByYear);

            foreach (Photo photo in i_LoggedInUser.PhotosTaggedIn)
            {
                try
                {
                    postCountByYear[photo.CreatedTime.ToString().Substring(6, 4)] += 1;
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
