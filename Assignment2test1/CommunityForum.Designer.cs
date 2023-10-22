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
			label1.Location = new Point(326, 3);
			label1.Name = "label1";
			label1.Size = new Size(140, 15);
			label1.TabIndex = 6;
			label1.Text = "Community Forum Posts";
			// 
			// button1
			// 
			button1.Location = new Point(860, 461);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 7;
			button1.Text = "New Post";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// button2
			// 
			button2.Location = new Point(3, 461);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 8;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// panel2
			// 
			panel2.AutoScroll = true;
			panel2.Controls.Add(button2);
			panel2.Controls.Add(button1);
			panel2.Controls.Add(label1);
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
			Text = "Form5";
			Load += Form5_Load;
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