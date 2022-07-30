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
            bool isLogInSucceeded = LoginLogic.Login();

            if (isLogInSucceeded == true)
            {
                buttonLogin.Text = $"Logged in as {FacebookLogic.FetchLogic.getUserName()}";
                profilePicture.LoadAsync(FacebookLogic.FetchLogic.getProfilePicture());
            }
            else
            {
                MessageBox.Show(" Login Failed");
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
                    fetchPosts();
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

        private void listBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.Text)
            {
                case "Posts":
                    //FacebookLogic.FetchLogic.FetchPosts
                    break;
                case "Albums":
                    displaySelectedAlbum();
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

        private void displaySelectedAlbum()
        {
            pictureBoxFetchItems.Visible = true;
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

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        /// <summary>
        /// Fetching posts *** made by the logged in user ***:
        /// </summary>
        private void fetchPosts()
        {
            listBox1.Items.Clear();
            pictureBoxFetchItems.Visible = false;

            foreach (Post post in loggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBox1.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBox1.Items.Add(post.Caption);
                }
                else
                {
                    listBox1.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }
    }
}
