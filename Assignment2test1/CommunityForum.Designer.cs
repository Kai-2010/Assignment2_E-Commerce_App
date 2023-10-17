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
			panel1 = new Panel();
			textBox1 = new TextBox();
			button3 = new Button();
			button2 = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(464, 53);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(209, 25);
			label1.TabIndex = 0;
			label1.Text = "Community Forum Posts";
			label1.Click += label1_Click;
			// 
			// button1
			// 
			button1.Location = new Point(1019, 692);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(107, 38);
			button1.TabIndex = 1;
			button1.Text = "New Post";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(button3);
			panel1.Location = new Point(17, 83);
			panel1.Margin = new Padding(4, 5, 4, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(1109, 560);
			panel1.TabIndex = 3;
			panel1.Paint += panel1_Paint;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(624, 44);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(150, 31);
			textBox1.TabIndex = 1;
			// 
			// button3
			// 
			button3.Location = new Point(437, 44);
			button3.Name = "button3";
			button3.Size = new Size(112, 34);
			button3.TabIndex = 0;
			button3.Text = "reply";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Location = new Point(23, 677);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(107, 38);
			button2.TabIndex = 4;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// CommunityForum
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1143, 750);
			Controls.Add(button2);
			Controls.Add(panel1);
			Controls.Add(button1);
			Controls.Add(label1);
			Margin = new Padding(4, 5, 4, 5);
			Name = "CommunityForum";
			Text = "Form5";
			Load += Form5_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button button1;
		private TextBox textBox2;
		private Panel panel1;
		private Button button2;
		private Button button3;
		private TextBox textBox1;
	}
}