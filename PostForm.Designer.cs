namespace Assignment2test1
{
	partial class PostForm
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
			postBox = new TextBox();
			Post = new Button();
			Title = new Label();
			Cancel = new Button();
			SuspendLayout();
			// 
			// postBox
			// 
			postBox.Location = new Point(71, 97);
			postBox.Multiline = true;
			postBox.Name = "postBox";
			postBox.Size = new Size(440, 90);
			postBox.TabIndex = 0;
			postBox.Text = "Enter Your Post";
			postBox.TextChanged += post_TextChanged;
			// 
			// Post
			// 
			Post.Location = new Point(436, 210);
			Post.Name = "Post";
			Post.Size = new Size(75, 23);
			Post.TabIndex = 1;
			Post.Text = "Post";
			Post.UseVisualStyleBackColor = true;
			Post.Click += post_Click;
			// 
			// Title
			// 
			Title.AutoSize = true;
			Title.Location = new Point(277, 28);
			Title.Name = "Title";
			Title.Size = new Size(102, 15);
			Title.TabIndex = 2;
			Title.Text = "Create a post here";
			// 
			// Cancel
			// 
			Cancel.Location = new Point(76, 218);
			Cancel.Name = "Cancel";
			Cancel.Size = new Size(75, 23);
			Cancel.TabIndex = 3;
			Cancel.Text = "Cancel";
			Cancel.UseVisualStyleBackColor = true;
			Cancel.Click += Cancel_Click;
			// 
			// PostForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Cancel);
			Controls.Add(Title);
			Controls.Add(Post);
			Controls.Add(postBox);
			Name = "PostForm";
			Text = "Post";
			Load += PostForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox postBox;
		private Button Post;
		private Label Title;
		private Button Cancel;
	}
}