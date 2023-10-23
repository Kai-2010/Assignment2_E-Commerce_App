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
			Password = new Label();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(590, 100);
			textBox1.Margin = new Padding(4, 5, 4, 5);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(141, 31);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(590, 192);
			textBox2.Margin = new Padding(4, 5, 4, 5);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(141, 31);
			textBox2.TabIndex = 1;
			textBox2.UseSystemPasswordChar = true;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// button1
			// 
			button1.Location = new Point(456, 272);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(107, 38);
			button1.TabIndex = 2;
			button1.Text = "Submit";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(613, 272);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(107, 38);
			button2.TabIndex = 3;
			button2.Text = "Sign Up";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(456, 108);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(99, 25);
			label1.TabIndex = 4;
			label1.Text = "User Name";
			// 
			// Password
			// 
			Password.AutoSize = true;
			Password.Location = new Point(456, 205);
			Password.Margin = new Padding(4, 0, 4, 0);
			Password.Name = "Password";
			Password.Size = new Size(87, 25);
			Password.TabIndex = 5;
			Password.Text = "Password";
			// 
			// Login
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(990, 643);
			Controls.Add(Password);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Login";
			Text = "Login";
			Load += Login_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private Button button2;
		private Label label1;
		private Label Password;
	}
}
