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
			flowLayoutPanel1 = new FlowLayoutPanel();
			Submit = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(326, 9);
			label1.Name = "label1";
			label1.Size = new Size(140, 15);
			label1.TabIndex = 0;
			label1.Text = "Community Forum Posts";
			// 
			// button1
			// 
			button1.Location = new Point(725, 422);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "New Post";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(-2, 422);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 4;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(-2, 27);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(802, 389);
			flowLayoutPanel1.TabIndex = 5;
			// 
			// Submit
			// 
			Submit.Location = new Point(411, 426);
			Submit.Name = "Submit";
			Submit.Size = new Size(75, 23);
			Submit.TabIndex = 6;
			Submit.Text = "Submit";
			Submit.UseVisualStyleBackColor = true;
			// 
			// CommunityForum
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Submit);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			Name = "CommunityForum";
			Text = "Form5";
			Load += Form5_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button button1;
		private TextBox textBox2;
		private Panel panel1;
		private Button button2;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button Submit;
	}
}