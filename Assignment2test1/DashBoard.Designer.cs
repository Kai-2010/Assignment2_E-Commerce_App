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
			label5 = new Label();
			SDGInformation = new LinkLabel();
			SuspendLayout();
			// 
			// communityForum
			// 
			communityForum.Location = new Point(854, 20);
			communityForum.Margin = new Padding(4, 5, 4, 5);
			communityForum.Name = "communityForum";
			communityForum.Size = new Size(201, 38);
			communityForum.TabIndex = 7;
			communityForum.Text = "Community Forum";
			communityForum.UseVisualStyleBackColor = true;
			communityForum.Click += communityForum_Click;
			// 
			// getNews
			// 
			getNews.Location = new Point(923, 313);
			getNews.Margin = new Padding(4, 5, 4, 5);
			getNews.Name = "getNews";
			getNews.Size = new Size(107, 38);
			getNews.TabIndex = 10;
			getNews.Text = "Get News";
			getNews.UseVisualStyleBackColor = true;
			getNews.Click += getNews_Click;
			// 
			// newsLinkLabel
			// 
			newsLinkLabel.AutoSize = true;
			newsLinkLabel.Location = new Point(17, 320);
			newsLinkLabel.Margin = new Padding(4, 0, 4, 0);
			newsLinkLabel.MaximumSize = new Size(1429, 1667);
			newsLinkLabel.Name = "newsLinkLabel";
			newsLinkLabel.Size = new Size(127, 25);
			newsLinkLabel.TabIndex = 11;
			newsLinkLabel.TabStop = true;
			newsLinkLabel.Text = "NewsLinkLabel";
			newsLinkLabel.LinkClicked += NewsLinkLabel_LinkClicked;
			// 
			// logout
			// 
			logout.Location = new Point(34, 20);
			logout.Name = "logout";
			logout.Size = new Size(106, 45);
			logout.TabIndex = 12;
			logout.Text = "Logout";
			logout.UseVisualStyleBackColor = true;
			logout.Click += button6_Click;
			// 
			// healthGoals
			// 
			healthGoals.AutoSize = true;
			healthGoals.Location = new Point(304, 125);
			healthGoals.Margin = new Padding(4, 0, 4, 0);
			healthGoals.Name = "healthGoals";
			healthGoals.Size = new Size(222, 25);
			healthGoals.TabIndex = 16;
			healthGoals.TabStop = true;
			healthGoals.Text = "More Info on Health Goals";
			healthGoals.LinkClicked += linkLabel2_LinkClicked;
			// 
			// healthMetrics
			// 
			healthMetrics.AutoSize = true;
			healthMetrics.Location = new Point(-3, 125);
			healthMetrics.Margin = new Padding(4, 0, 4, 0);
			healthMetrics.Name = "healthMetrics";
			healthMetrics.Size = new Size(296, 25);
			healthMetrics.TabIndex = 17;
			healthMetrics.TabStop = true;
			healthMetrics.Text = "More information on Health Metrics";
			healthMetrics.LinkClicked += linkLabel3_LinkClicked;
			// 
			// nutritionInformation
			// 
			nutritionInformation.AutoSize = true;
			nutritionInformation.Location = new Point(549, 125);
			nutritionInformation.Margin = new Padding(4, 0, 4, 0);
			nutritionInformation.Name = "nutritionInformation";
			nutritionInformation.Size = new Size(181, 25);
			nutritionInformation.TabIndex = 18;
			nutritionInformation.TabStop = true;
			nutritionInformation.Text = "Nutrition Information";
			nutritionInformation.LinkClicked += linkLabel4_LinkClicked;
			// 
			// modifyDetails
			// 
			modifyDetails.AutoSize = true;
			modifyDetails.Location = new Point(774, 125);
			modifyDetails.Margin = new Padding(4, 0, 4, 0);
			modifyDetails.Name = "modifyDetails";
			modifyDetails.Size = new Size(127, 25);
			modifyDetails.TabIndex = 19;
			modifyDetails.TabStop = true;
			modifyDetails.Text = "Modify Details";
			modifyDetails.LinkClicked += linkLabel5_LinkClicked;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(450, 22);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(59, 25);
			label5.TabIndex = 20;
			label5.Text = "Name";
			// 
			// SDGInformation
			// 
			SDGInformation.AutoSize = true;
			SDGInformation.LinkBehavior = LinkBehavior.HoverUnderline;
			SDGInformation.Location = new Point(304, 227);
			SDGInformation.Name = "SDGInformation";
			SDGInformation.Size = new Size(377, 25);
			SDGInformation.TabIndex = 21;
			SDGInformation.TabStop = true;
			SDGInformation.Text = "Click here to get more information about SDG";
			SDGInformation.LinkClicked += linkLabel6_LinkClicked;
			// 
			// DashBoard
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1143, 750);
			Controls.Add(SDGInformation);
			Controls.Add(label5);
			Controls.Add(modifyDetails);
			Controls.Add(nutritionInformation);
			Controls.Add(healthMetrics);
			Controls.Add(healthGoals);
			Controls.Add(logout);
			Controls.Add(newsLinkLabel);
			Controls.Add(getNews);
			Controls.Add(communityForum);
			Margin = new Padding(4, 5, 4, 5);
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
		private Label label5;
		private LinkLabel SDGInformation;
	}
}