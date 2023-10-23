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
			label1 = new Label();
			Cancel = new Button();
			SuspendLayout();
			// 
			// postBox
			// 
			postBox.Location = new Point(101, 162);
			postBox.Margin = new Padding(4, 5, 4, 5);
			postBox.Multiline = true;
			postBox.Name = "postBox";
			postBox.Size = new Size(627, 147);
			postBox.TabIndex = 0;
			postBox.Text = "Enter Your Post";
			postBox.TextChanged += post_TextChanged;
			// 
			// Post
			// 
			Post.Location = new Point(623, 350);
			Post.Margin = new Padding(4, 5, 4, 5);
			Post.Name = "Post";
			Post.Size = new Size(107, 38);
			Post.TabIndex = 1;
			Post.Text = "Post";
			Post.UseVisualStyleBackColor = true;
			Post.Click += post_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(396, 47);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(156, 25);
			label1.TabIndex = 2;
			label1.Text = "Create a post here";
			// 
			// Cancel
			// 
			Cancel.Location = new Point(109, 363);
			Cancel.Margin = new Padding(4, 5, 4, 5);
			Cancel.Name = "Cancel";
			Cancel.Size = new Size(107, 38);
			Cancel.TabIndex = 3;
			Cancel.Text = "Cancel";
			Cancel.UseVisualStyleBackColor = true;
			Cancel.Click += Cancel_Click;
			// 
			// PostForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1143, 750);
			Controls.Add(Cancel);
			Controls.Add(label1);
			Controls.Add(Post);
			Controls.Add(postBox);
			Margin = new Padding(4, 5, 4, 5);
			Name = "PostForm";
			Text = "Post";
			Load += PostForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox postBox;
		private Button Post;
		private Label label1;
		private Button Cancel;
	}
}