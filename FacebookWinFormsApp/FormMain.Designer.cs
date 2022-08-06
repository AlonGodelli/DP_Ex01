namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "10,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "20,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "17,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "15,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "10,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fetchButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBoxFetchItems = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.popularPostFetchButton = new System.Windows.Forms.Button();
            this.popularPostListBox = new System.Windows.Forms.ListBox();
            this.statsListBox = new System.Windows.Forms.ListBox();
            this.statsFetchButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFetchItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLogin.Location = new System.Drawing.Point(17, 57);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(182, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLogout.Location = new System.Drawing.Point(17, 86);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(182, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Welcome to our Facebook app!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "df";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Posts",
            "Albums",
            "Events",
            "Groups",
            "Liked Pages"});
            this.comboBox1.Location = new System.Drawing.Point(507, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Please choose what to display:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(634, 290);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(75, 23);
            this.fetchButton.TabIndex = 56;
            this.fetchButton.Text = "Fetch";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(313, 335);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 173);
            this.listBox1.TabIndex = 57;
            this.listBox1.Click += new System.EventHandler(this.listBoxSelectedIndexChanged);
            // 
            // pictureBoxFetchItems
            // 
            this.pictureBoxFetchItems.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxFetchItems.Location = new System.Drawing.Point(596, 335);
            this.pictureBoxFetchItems.Name = "pictureBoxFetchItems";
            this.pictureBoxFetchItems.Size = new System.Drawing.Size(173, 173);
            this.pictureBoxFetchItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFetchItems.TabIndex = 58;
            this.pictureBoxFetchItems.TabStop = false;
            this.pictureBoxFetchItems.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "User Information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Write a post:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(395, 57);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(268, 115);
            this.postTextBox.TabIndex = 61;
            this.postTextBox.Text = "";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(587, 189);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 62;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.profilePicture.Location = new System.Drawing.Point(17, 124);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(183, 170);
            this.profilePicture.TabIndex = 63;
            this.profilePicture.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Special Features";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Most Popular Post";
            // 
            // popularPostFetchButton
            // 
            this.popularPostFetchButton.Location = new System.Drawing.Point(426, 624);
            this.popularPostFetchButton.Name = "popularPostFetchButton";
            this.popularPostFetchButton.Size = new System.Drawing.Size(75, 23);
            this.popularPostFetchButton.TabIndex = 66;
            this.popularPostFetchButton.Text = "Fetch";
            this.popularPostFetchButton.UseVisualStyleBackColor = true;
            this.popularPostFetchButton.Click += new System.EventHandler(this.popularPostFetchButton_Click);
            // 
            // popularPostListBox
            // 
            this.popularPostListBox.FormattingEnabled = true;
            this.popularPostListBox.Location = new System.Drawing.Point(313, 653);
            this.popularPostListBox.Name = "popularPostListBox";
            this.popularPostListBox.Size = new System.Drawing.Size(188, 95);
            this.popularPostListBox.TabIndex = 67;
            // 
            // statsListBox
            // 
            this.statsListBox.FormattingEnabled = true;
            this.statsListBox.Location = new System.Drawing.Point(787, 515);
            this.statsListBox.Name = "statsListBox";
            this.statsListBox.Size = new System.Drawing.Size(188, 95);
            this.statsListBox.TabIndex = 70;
            this.statsListBox.SelectedIndexChanged += new System.EventHandler(this.statsListBox_SelectedIndexChanged);
            // 
            // statsFetchButton
            // 
            this.statsFetchButton.Location = new System.Drawing.Point(694, 624);
            this.statsFetchButton.Name = "statsFetchButton";
            this.statsFetchButton.Size = new System.Drawing.Size(75, 23);
            this.statsFetchButton.TabIndex = 69;
            this.statsFetchButton.Text = "Fetch";
            this.statsFetchButton.UseVisualStyleBackColor = true;
            this.statsFetchButton.Click += new System.EventHandler(this.statsFetchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 629);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Yearly Statistics";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "numOfPosts";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(581, 653);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "numOfPosts";
            series1.Name = "Posts";
            dataPoint1.AxisLabel = "";
            dataPoint1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            dataPoint1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            dataPoint1.IsValueShownAsLabel = true;
            dataPoint1.Label = "";
            dataPoint1.LabelFormat = "";
            dataPoint1.LabelToolTip = "";
            dataPoint1.LegendText = "";
            dataPoint2.IsValueShownAsLabel = true;
            dataPoint3.IsValueShownAsLabel = true;
            dataPoint4.IsValueShownAsLabel = true;
            dataPoint5.IsValueShownAsLabel = true;
            dataPoint6.IsValueShownAsLabel = true;
            dataPoint7.IsValueShownAsLabel = true;
            dataPoint8.IsValueShownAsLabel = true;
            dataPoint9.AxisLabel = "";
            dataPoint9.IsValueShownAsLabel = true;
            dataPoint9.Label = "";
            dataPoint10.IsValueShownAsLabel = true;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(281, 206);
            this.chart1.TabIndex = 71;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "# of Posts Per Year";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 901);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.statsListBox);
            this.Controls.Add(this.statsFetchButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.popularPostListBox);
            this.Controls.Add(this.popularPostFetchButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxFetchItems);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFetchItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBoxFetchItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox postTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button popularPostFetchButton;
        private System.Windows.Forms.ListBox popularPostListBox;
        private System.Windows.Forms.ListBox statsListBox;
        private System.Windows.Forms.Button statsFetchButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

