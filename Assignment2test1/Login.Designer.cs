namespace Assignment2test1
{
	partial class Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			label1 = new Label();
			label2 = new Label();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(413, 60);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(413, 115);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 1;
			textBox2.UseSystemPasswordChar = true;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// button1
			// 
			button1.Location = new Point(319, 163);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "Submit";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(429, 163);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "Sign Up";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(319, 65);
			label1.Name = "label1";
			label1.Size = new Size(65, 15);
			label1.TabIndex = 4;
			label1.Text = "Email";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(319, 123);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 5;
			label2.Text = "Password";
			// 
			// Login
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(693, 386);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Login";
			Text = "Login";
			//Load += Login_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private Button button2;
		private Label label1;
		private Label label2;
	}
}
