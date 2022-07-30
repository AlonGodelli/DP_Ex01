using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public User loggedInUser { get; set; }
        public LoginResult loginResult { get; set; }
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginResult = LoginLogic.Login();

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                loggedInUser = loginResult.LoggedInUser;

                // get it somewhwre else
                buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
                profilePicture.LoadAsync(loggedInUser.PictureLargeURL);
               

            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookLogic.LoginLogic.Logout();
            buttonLogin.Text = "Login";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            switch (this.comboBox1.Text)
            {
                case "Posts":
                    //FacebookLogic.FetchLogic.FetchPosts
                    break;
                case "Albums":
                    fetchAlbums();
                    break;
                case "Events":
                    break;
                case "Groups":
                    break;
                case "Liked Pages":
                    break;
                default:
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //FacebookLogic.PostLogic.Post(this.postTextBox.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fetchAlbums()
        {
            listBox1.Items.Clear();
            listBox1.DisplayMember = "Name";
            foreach (Album album in loggedInUser.Albums)
            {
                listBox1.Items.Add(album);
                //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBox1.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxFetchItems.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxFetchItems.Image = pictureBoxFetchItems.ErrorImage;
                }
            }
        }
    }
}
