namespace Assignment2test1
{
	partial class CommunityForum
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
			title = new Label();
			newPost = new Button();
			cancel = new Button();
			panel2 = new Panel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// title
			// 
			title.AutoSize = true;
			title.Location = new Point(326, 3);
			title.Name = "title";
			title.Size = new Size(140, 15);
			title.TabIndex = 6;
			title.Text = "Community Forum Posts";
			// 
			// newPost
			// 
			newPost.Location = new Point(860, 461);
			newPost.Name = "newPost";
			newPost.Size = new Size(75, 23);
			newPost.TabIndex = 7;
			newPost.Text = "New Post";
			newPost.UseVisualStyleBackColor = true;
			newPost.Click += Submit_Click_1;
			// 
			// cancel
			// 
			cancel.Location = new Point(3, 461);
			cancel.Name = "cancel";
			cancel.Size = new Size(75, 23);
			cancel.TabIndex = 8;
			cancel.Text = "Cancel";
			cancel.UseVisualStyleBackColor = true;
			cancel.Click += Cancel_Click_1;
			// 
			// panel2
			// 
			panel2.AutoScroll = true;
			panel2.Controls.Add(cancel);
			panel2.Controls.Add(newPost);
			panel2.Controls.Add(title);
			panel2.Location = new Point(2, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(938, 487);
			panel2.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			flowLayoutPanel1.Location = new Point(2, 33);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(925, 434);
			flowLayoutPanel1.TabIndex = 9;
			// 
			// CommunityForum
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			AutoSize = true;
			ClientSize = new Size(984, 511);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(panel2);
			Name = "CommunityForum";
			Text = "Posts";
			Load += posts_Load;
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private TextBox textBox2;
		private Panel panel1;
		private Label title;
		private Button newPost;
		private Button cancel;
		private Panel panel2;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}