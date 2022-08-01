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
                buttonLogin.Text = $"Logged in as {FacebookLogic.FetchLogic.FetchUserName()}";
                profilePicture.LoadAsync(FacebookLogic.FetchLogic.FetchProfilePicture());
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
                    getPosts();
                    //FacebookLogic.FetchLogic.FetchPosts
                    break;
                case "Albums":
                    getAlbums();
                    break;
                case "Events":
                    getEvents();
                    break;
                case "Groups":
                    getGroups();
                    break;
                case "Liked Pages": 
                    getLikedPages();
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
                    //displaySelectedGroup();
                    break;
                case "Liked Pages":
                    break;
                default:
                    break;
            }
        }

        private void getAlbums()
        {
            List<string> userAlbumsList = new List<string>();

            listBox1.Items.Clear();
            listBox1.DisplayMember = "Name";

            userAlbumsList = FacebookLogic.FetchLogic.FetchAlbumsNames();

            foreach (string albumName in userAlbumsList)
            {
                listBox1.Items.Add(albumName);
            }

            if (userAlbumsList.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve");
            }
        }

        private void displaySelectedAlbum()
        {
            pictureBoxFetchItems.Visible = true;
            if (listBox1.SelectedItems.Count == 1)
            {
                // not working
                string selectedAlbumPicture = FacebookLogic.FetchLogic.FetchSelectedAlbumPicture(listBox1.SelectedItem.ToString());
                if (selectedAlbumPicture != null)
                {
                    pictureBoxFetchItems.LoadAsync(selectedAlbumPicture);
                }
                else
                {
                    pictureBoxFetchItems.Image = pictureBoxFetchItems.ErrorImage;
                }
            }
        }

        private void getPosts()
        {
            List<string> userPostsList;

            listBox1.Items.Clear();
            pictureBoxFetchItems.Visible = false;

            userPostsList = FacebookLogic.FetchLogic.FetchUserPosts();

            foreach (string message in userPostsList)
            {
                if (message != null)
                {
                    listBox1.Items.Add(message);
                }
            }

            if (userPostsList.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve");
            }
        }
        private void getEvents()
        {
            List<String> userEventsList;

            listBox1.Items.Clear();
            listBox1.DisplayMember = "Name";
            userEventsList = FacebookLogic.FetchLogic.FetchEvents();

            foreach (string fbEvent in userEventsList)
            {
                listBox1.Items.Add(fbEvent);
            }

            if (userEventsList.Count == 0)
            {
                MessageBox.Show("No Events to retrieve");
            }
        }

        //private void displaySelectedGroup()
        //{
        //    if (listBoxGroups.SelectedItems.Count == 1)
        //    {
        //        Group selectedGroup = listBoxGroups.SelectedItem as Group;
        //        pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
        //    }
        //}

        private void getGroups()
        {
            List<string> userGroupsList = new List<string>();

            listBox1.Items.Clear();
            listBox1.DisplayMember = "Name";

            userGroupsList = FacebookLogic.FetchLogic.FetchUserGroupsNames();

            foreach (string group in userGroupsList)
            {
                listBox1.Items.Add(group);
            }

            if (userGroupsList.Count == 0)
            {
                MessageBox.Show("No groups to retrieve");
            }
        }

        private void getLikedPages()
        {
            List<string> userLikedPages = new List<string>();

            listBox1.Items.Clear();
            listBox1.DisplayMember = "Name";

            userLikedPages = FacebookLogic.FetchLogic.fetchLikedPages();

            foreach (string page in userLikedPages)
            {
                listBox1.Items.Add(page);
            }

            if (userLikedPages.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve");
            }
        }
    }
}
