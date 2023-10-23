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
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			panel2 = new Panel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(466, 5);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(209, 25);
			label1.TabIndex = 6;
			label1.Text = "Community Forum Posts";
			// 
			// button1
			// 
			button1.Location = new Point(1229, 768);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(107, 38);
			button1.TabIndex = 7;
			button1.Text = "New Post";
			button1.UseVisualStyleBackColor = true;
			button1.Click +=Submit_Click_1;
			// 
			// button2
			// 
			button2.Location = new Point(4, 768);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(107, 38);
			button2.TabIndex = 8;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += Cancel_Click_1;
			// 
			// panel2
			// 
			panel2.AutoScroll = true;
			panel2.Controls.Add(button2);
			panel2.Controls.Add(button1);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(3, 20);
			panel2.Margin = new Padding(4, 5, 4, 5);
			panel2.Name = "panel2";
			panel2.Size = new Size(1340, 812);
			panel2.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			flowLayoutPanel1.Location = new Point(3, 55);
			flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(1321, 723);
			flowLayoutPanel1.TabIndex = 9;
			// 
			// CommunityForum
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			AutoSize = true;
			ClientSize = new Size(1406, 852);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(panel2);
			Margin = new Padding(4, 5, 4, 5);
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
		private Label label1;
		private Button button1;
		private Button button2;
		private Panel panel2;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}