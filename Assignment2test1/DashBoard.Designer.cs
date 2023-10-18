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
			button4 = new Button();
			button5 = new Button();
			linkLabel1 = new LinkLabel();
			button6 = new Button();
			linkLabel2 = new LinkLabel();
			linkLabel3 = new LinkLabel();
			linkLabel4 = new LinkLabel();
			linkLabel5 = new LinkLabel();
			label5 = new Label();
			linkLabel6 = new LinkLabel();
			SuspendLayout();
			// 
			// button4
			// 
			button4.Location = new Point(598, 12);
			button4.Name = "button4";
			button4.Size = new Size(141, 23);
			button4.TabIndex = 7;
			button4.Text = "Community Forum";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(646, 188);
			button5.Name = "button5";
			button5.Size = new Size(75, 23);
			button5.TabIndex = 10;
			button5.Text = "Get News";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(12, 192);
			linkLabel1.MaximumSize = new Size(1000, 1000);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(86, 15);
			linkLabel1.TabIndex = 11;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "NewsLinkLabel";
			linkLabel1.LinkClicked += NewsLinkLabel_LinkClicked;
			// 
			// button6
			// 
			button6.Location = new Point(24, 12);
			button6.Margin = new Padding(2, 2, 2, 2);
			button6.Name = "button6";
			button6.Size = new Size(74, 27);
			button6.TabIndex = 12;
			button6.Text = "Logout";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// linkLabel2
			// 
			linkLabel2.AutoSize = true;
			linkLabel2.Location = new Point(213, 75);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(146, 15);
			linkLabel2.TabIndex = 16;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "More Info on Health Goals";
			linkLabel2.LinkClicked += linkLabel2_LinkClicked;
			// 
			// linkLabel3
			// 
			linkLabel3.AutoSize = true;
			linkLabel3.Location = new Point(-2, 75);
			linkLabel3.Name = "linkLabel3";
			linkLabel3.Size = new Size(198, 15);
			linkLabel3.TabIndex = 17;
			linkLabel3.TabStop = true;
			linkLabel3.Text = "More information on Health Metrics";
			linkLabel3.LinkClicked += linkLabel3_LinkClicked;
			// 
			// linkLabel4
			// 
			linkLabel4.AutoSize = true;
			linkLabel4.Location = new Point(384, 75);
			linkLabel4.Name = "linkLabel4";
			linkLabel4.Size = new Size(121, 15);
			linkLabel4.TabIndex = 18;
			linkLabel4.TabStop = true;
			linkLabel4.Text = "Nutrition Information";
			linkLabel4.LinkClicked += linkLabel4_LinkClicked;
			// 
			// linkLabel5
			// 
			linkLabel5.AutoSize = true;
			linkLabel5.Location = new Point(542, 75);
			linkLabel5.Name = "linkLabel5";
			linkLabel5.Size = new Size(83, 15);
			linkLabel5.TabIndex = 19;
			linkLabel5.TabStop = true;
			linkLabel5.Text = "Modify Details";
			linkLabel5.LinkClicked += linkLabel5_LinkClicked;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(315, 13);
			label5.Name = "label5";
			label5.Size = new Size(38, 15);
			label5.TabIndex = 20;
			label5.Text = "label5";
			// 
			// linkLabel6
			// 
			linkLabel6.AutoSize = true;
			linkLabel6.LinkBehavior = LinkBehavior.HoverUnderline;
			linkLabel6.Location = new Point(213, 136);
			linkLabel6.Margin = new Padding(2, 0, 2, 0);
			linkLabel6.Name = "linkLabel6";
			linkLabel6.Size = new Size(249, 15);
			linkLabel6.TabIndex = 21;
			linkLabel6.TabStop = true;
			linkLabel6.Text = "Click here to get more information about SDG";
			linkLabel6.LinkClicked += linkLabel6_LinkClicked;
			// 
			// DashBoard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(linkLabel6);
			Controls.Add(label5);
			Controls.Add(linkLabel5);
			Controls.Add(linkLabel4);
			Controls.Add(linkLabel3);
			Controls.Add(linkLabel2);
			Controls.Add(button6);
			Controls.Add(linkLabel1);
			Controls.Add(button5);
			Controls.Add(button4);
			Name = "DashBoard";
			Text = "Form3";
			Load += DashBoard_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button button4;
		private Button button5;
		private LinkLabel linkLabel1;
		private Button button6;
		private LinkLabel linkLabel2;
		private LinkLabel linkLabel3;
		private LinkLabel linkLabel4;
		private LinkLabel linkLabel5;
		private Label label5;
		private LinkLabel linkLabel6;
	}
}