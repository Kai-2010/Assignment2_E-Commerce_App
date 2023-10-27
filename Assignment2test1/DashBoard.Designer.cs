namespace Assignment2test1
{
    partial class DashBoard
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
            communityForum = new Button();
            getNews = new Button();
            newsLinkLabel = new LinkLabel();
            logout = new Button();
            healthGoals = new LinkLabel();
            healthMetrics = new LinkLabel();
            nutritionInformation = new LinkLabel();
            modifyDetails = new LinkLabel();
            Title = new Label();
            SDGInformation = new LinkLabel();
            HealthGraph = new LinkLabel();
            SuspendLayout();
            // 
            // communityForum
            // 
            communityForum.Location = new Point(598, 12);
            communityForum.Name = "communityForum";
            communityForum.Size = new Size(141, 23);
            communityForum.TabIndex = 7;
            communityForum.Text = "Community Forum";
            communityForum.UseVisualStyleBackColor = true;
            communityForum.Click += communityForum_Click;
            // 
            // getNews
            // 
            getNews.Location = new Point(647, 136);
            getNews.Name = "getNews";
            getNews.Size = new Size(75, 23);
            getNews.TabIndex = 10;
            getNews.Text = "Get News";
            getNews.UseVisualStyleBackColor = true;
            getNews.Click += getNews_Click;
            // 
            // newsLinkLabel
            // 
            newsLinkLabel.AutoSize = true;
            newsLinkLabel.Location = new Point(12, 192);
            newsLinkLabel.MaximumSize = new Size(1000, 1000);
            newsLinkLabel.Name = "newsLinkLabel";
            newsLinkLabel.Size = new Size(0, 15);
            newsLinkLabel.TabIndex = 11;
            newsLinkLabel.LinkClicked += NewsLinkLabel_LinkClicked;
            // 
            // logout
            // 
            logout.Location = new Point(24, 12);
            logout.Margin = new Padding(2);
            logout.Name = "logout";
            logout.Size = new Size(74, 27);
            logout.TabIndex = 12;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // healthGoals
            // 
            healthGoals.AutoSize = true;
            healthGoals.Location = new Point(213, 75);
            healthGoals.Name = "healthGoals";
            healthGoals.Size = new Size(146, 15);
            healthGoals.TabIndex = 16;
            healthGoals.TabStop = true;
            healthGoals.Text = "More Info on Health Goals";
            healthGoals.LinkClicked += healthGoal_LinkClicked;
            // 
            // healthMetrics
            // 
            healthMetrics.AutoSize = true;
            healthMetrics.Location = new Point(-2, 75);
            healthMetrics.Name = "healthMetrics";
            healthMetrics.Size = new Size(198, 15);
            healthMetrics.TabIndex = 17;
            healthMetrics.TabStop = true;
            healthMetrics.Text = "More information on Health Metrics";
            healthMetrics.LinkClicked += healthMetrics_LinkClicked;
            // 
            // nutritionInformation
            // 
            nutritionInformation.AutoSize = true;
            nutritionInformation.Location = new Point(384, 75);
            nutritionInformation.Name = "nutritionInformation";
            nutritionInformation.Size = new Size(121, 15);
            nutritionInformation.TabIndex = 18;
            nutritionInformation.TabStop = true;
            nutritionInformation.Text = "Nutrition Information";
            nutritionInformation.LinkClicked += nutritionInformation_LinkClicked;
            // 
            // modifyDetails
            // 
            modifyDetails.AutoSize = true;
            modifyDetails.Location = new Point(542, 75);
            modifyDetails.Name = "modifyDetails";
            modifyDetails.Size = new Size(83, 15);
            modifyDetails.TabIndex = 19;
            modifyDetails.TabStop = true;
            modifyDetails.Text = "Modify Details";
            modifyDetails.LinkClicked += modifyDetails_LinkClicked;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(315, 13);
            Title.Name = "Title";
            Title.Size = new Size(39, 15);
            Title.TabIndex = 20;
            Title.Text = "Name";
            // 
            // SDGInformation
            // 
            SDGInformation.AutoSize = true;
            SDGInformation.LinkBehavior = LinkBehavior.HoverUnderline;
            SDGInformation.Location = new Point(213, 136);
            SDGInformation.Margin = new Padding(2, 0, 2, 0);
            SDGInformation.Name = "SDGInformation";
            SDGInformation.Size = new Size(249, 15);
            SDGInformation.TabIndex = 21;
            SDGInformation.TabStop = true;
            SDGInformation.Text = "Click here to get more information about SDG";
            SDGInformation.LinkClicked += SDGInformation_LinkClicked;
            // 
            // HealthGraph
            // 
            HealthGraph.AutoSize = true;
            HealthGraph.Location = new Point(664, 75);
            HealthGraph.Name = "HealthGraphLabel";
            HealthGraph.Size = new Size(114, 15);
            HealthGraph.TabIndex = 22;
            HealthGraph.TabStop = true;
            HealthGraph.Text = "Show Health Graphs";
            HealthGraph.LinkClicked += HealthGraph_LinkClicked;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(HealthGraph);
            Controls.Add(SDGInformation);
            Controls.Add(Title);
            Controls.Add(modifyDetails);
            Controls.Add(nutritionInformation);
            Controls.Add(healthMetrics);
            Controls.Add(healthGoals);
            Controls.Add(logout);
            Controls.Add(newsLinkLabel);
            Controls.Add(getNews);
            Controls.Add(communityForum);
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button communityForum;
        private Button getNews;
        private LinkLabel newsLinkLabel;
        private Button logout;
        private LinkLabel healthGoals;
        private LinkLabel healthMetrics;
        private LinkLabel nutritionInformation;
        private LinkLabel modifyDetails;
        private LinkLabel SDGInformation;
        private Label Title;
        private LinkLabel HealthGraph;
    }
}