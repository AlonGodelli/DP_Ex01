using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;
using BasicFacebookFeatures;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_LoggedInUser = LogicManagment.Instance;
            bool isLogInSucceeded = LogicManagment.boolLoginResult;
            userBindingSource.DataSource = m_LoggedInUser;

            if (isLogInSucceeded == true)
            {
                this.ClientSize = new System.Drawing.Size(1050, 715);
                this.CenterToScreen();
                buttonLogin.Text = $"Logged in as {FacebookLogic.FetchLogic.FetchUserName(m_LoggedInUser)}";
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogicManagment.Logout();
            buttonLogin.Text = "Login";
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            string selection = this.comboBox1.Text;
            listBox1.Items.Clear();
            new Thread(() =>
            {
                switch (selection)
                {
                    case "Posts":
                        getPosts();
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
            }).Start();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                PostParameters postParams;
                postParams.PostType = (ePostType)Enum.Parse(typeof(ePostType), postTypeComboBox.SelectedItem.ToString());
                postParams.Text = this.postTextBox.Text;
                postParams.ImgUrl = this.imageUrlTextbox.Text;
                postParams.LinkUrl = this.linkUrlTextBox.Text;
                CreatePost.CreateNewPost(postParams, m_LoggedInUser);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't post");
            }
        }

        private void listBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.Text)
            {
                case "Posts":
                    break;
                case "Albums":
                    displaySelectedAlbum();
                    break;
                case "Events":
                    break;
                case "Groups":
                    break;
                case "Liked Pages":
                    displaySelectedLikedPage();
                    break;
                default:
                    break;
            }
        }

        private void getAlbums()
        {
            List<string> userAlbumsList = new List<string>();

            userAlbumsList = FacebookLogic.FetchLogic.FetchAlbumsNames(m_LoggedInUser);

            foreach (string albumName in userAlbumsList)
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add(albumName); }));
            }

            if (userAlbumsList.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve");
            }
        }

        private void displaySelectedAlbum()
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                string selectedAlbumPicture = FacebookLogic.FetchLogic.FetchSelectedAlbumPicture(listBox1.SelectedItem.ToString(), m_LoggedInUser);
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

        private void displaySelectedLikedPage()
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                string selectedLikedPagePicture = FacebookLogic.FetchLogic.FetchSelectedLikedPage(listBox1.SelectedItem.ToString(), m_LoggedInUser);
                if (selectedLikedPagePicture != null)
                {
                    pictureBoxFetchItems.LoadAsync(selectedLikedPagePicture);
                }
                else
                {
                    pictureBoxFetchItems.Image = pictureBoxFetchItems.ErrorImage;
                }
            }
        }

        private void getPosts()
        {
            IEnumerable<string> userPostsList;

            userPostsList = FacebookLogic.FetchLogic.FetchUserPosts(m_LoggedInUser);
            foreach (string message in userPostsList)
            {
                listBox1.Invoke(new Action(() =>
                {
                    if (message != null)
                    {
                        listBox1.Items.Add(message);
                    }
                }));
            }

            //if ((int)(userPostsList.Count) == 0)
            //{
            //    MessageBox.Show("No Posts to retrieve");
            //}
        }

        private void getMostPopularPost()
        {
            Post mostPopularPost = null;
            try
            {
                popularPostListBox.Invoke(new Action(() =>
                    {
                        popularPostListBox.Invoke(new Action(() =>
                        {
                            mostPopularPost = FacebookLogic.FetchLogic.FetchMostPopularPost(m_LoggedInUser);
                        }));

                        if (mostPopularPost != null)
                        {
                            popularPostListBox.Items.Add($"Post: {mostPopularPost.Message}");
                            popularPostListBox.Items.Add($"# of Comments: {mostPopularPost.Comments.Count}");
                        }
                        else
                        {
                            MessageBox.Show("No Posts to retrieve");
                        }
                    }

                ));
            }
            catch (Exception)
            {
                MessageBox.Show("No Posts to retrieve");
            }
        }

        private void getYearlyPostActivityStats()
        {
            IDictionary<string, int> postCountByYear = null;
            postCountByYear = FacebookLogic.FetchLogic.FetchPostActivityStatistic(m_LoggedInUser);
            int fromYear = 2009;

            if (postCountByYear != null)
            {
                chart1.Invoke(new Action(() =>
                {
                    foreach (DataPoint dataPoint in chart1.Series[0].Points)
                    {
                        chart1.ChartAreas[0].RecalculateAxesScale();
                        dataPoint.AxisLabel = fromYear.ToString();
                        dataPoint.YValues[0] = postCountByYear[fromYear.ToString()];
                        fromYear++;
                    }

                    this.chart1.Titles[0].Text = $"# of Posts Per Year ({FacebookLogic.FetchLogic.FetchUserName(m_LoggedInUser)})";
                }));
            }
            else
            {
                MessageBox.Show("No Posts to retrieve");
            }
        }

        private void getEvents()
        {
            List<string> userEventsList;

            userEventsList = FacebookLogic.FetchLogic.FetchEvents(m_LoggedInUser);

            foreach (string fbEvent in userEventsList)
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add(fbEvent); }));
            }

            if (userEventsList.Count == 0)
            {
                MessageBox.Show("No Events to retrieve");
            }
        }

        private void getGroups()
        {
            List<string> userGroupsList = new List<string>();

            userGroupsList = FacebookLogic.FetchLogic.FetchUserGroupsNames(m_LoggedInUser);
            foreach (string group in userGroupsList)
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add(group); }));
            }

            if (userGroupsList.Count == 0)
            {
                MessageBox.Show("No groups to retrieve");
            }
        }

        private void getLikedPages()
        {
            List<string> userLikedPages = new List<string>();

            userLikedPages = FacebookLogic.FetchLogic.FetchLikedPages(m_LoggedInUser);
            foreach (string page in userLikedPages)
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add(page); }));
            }

            if (userLikedPages.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve");
            }
        }

        private void popularPostFetchButton_Click(object sender, EventArgs e)
        {
            new Thread(() => { FacebookLogic.FetchLogic.FetchMostPopularPost(m_LoggedInUser); getMostPopularPost(); }).Start();
        }

        private void statsFetchButton_Click(object sender, EventArgs e)
        {
            new Thread(getYearlyPostActivityStats).Start();
        }

        private void user_eRelationshipStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void localeTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void localeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void localeTextBox_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void imageLargePictureBox_Click(object sender, EventArgs e)
        {
        }

        private void postTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            submitButton.Enabled = true;
            submitButton.Text = "Submit";
            switch (postTypeComboBox.SelectedItem)
            {
                case "Image":
                    imageUrlTextbox.Enabled = true;
                    linkUrlTextBox.Enabled = false;
                    linkUrlTextBox.Clear();
                    break;
                case "Link":
                    linkUrlTextBox.Enabled = true;
                    imageUrlTextbox.Enabled = false;
                    imageUrlTextbox.Clear();
                    break;
                default:
                    imageUrlTextbox.Enabled = false;
                    imageUrlTextbox.Clear();
                    linkUrlTextBox.Enabled = false;
                    linkUrlTextBox.Clear();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkUrlTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
