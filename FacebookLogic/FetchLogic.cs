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
        public static string getProfilePicture()
        {
            return loggedInUser.PictureLargeURL;
        }

        public static string getUserName()
        {
            return loggedInUser.Name;
        }

    //    public static List<String> getUserPosts(ref int o_PostCounter)
    //    {
    //        List <String> userPostsList = new List <String>();
    //        o_PostCounter = 0;


    //        foreach (Post post in loggedInUser.Posts)
    //        {
    //            if (post.Message != null)
    //            {
    //                userPostsList.Add(post.Message);
    //                o_PostCounter++;
    //            }
    //            else if (post.Caption != null)
    //            {
    //                //listBox1.Items.Add(post.Caption);
    //            }
              
    //        }
    //    }
    //    private void getAlbumsNames()
    //    {
    //        foreach (Album album in loggedInUser.Albums)
    //        {
    //            listBox1.Items.Add(album);
    //            //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
    //        }
    //    }

    //    private void displaySelectedAlbum()
    //    {
    //        pictureBoxFetchItems.Visible = true;
    //        if (listBox1.SelectedItems.Count == 1)
    //        {
    //            Album selectedAlbum = listBox1.SelectedItem as Album;
    //            if (selectedAlbum.PictureAlbumURL != null)
    //            {
    //                pictureBoxFetchItems.LoadAsync(selectedAlbum.PictureAlbumURL);
    //            }
    //            else
    //            {
    //                pictureBoxFetchItems.Image = pictureBoxFetchItems.ErrorImage;
    //            }
    //        }
    //    }
    }
}
