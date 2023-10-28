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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			userNameEntry = new TextBox();
			passwordEntry = new TextBox();
			submit = new Button();
			signUp = new Button();
			userName = new Label();
			Password = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// userNameEntry
			// 
			userNameEntry.Location = new Point(515, 60);
			userNameEntry.Name = "userNameEntry";
			userNameEntry.Size = new Size(126, 23);
			userNameEntry.TabIndex = 0;
			// 
			// passwordEntry
			// 
			passwordEntry.Location = new Point(515, 105);
			passwordEntry.Name = "passwordEntry";
			passwordEntry.Size = new Size(126, 23);
			passwordEntry.TabIndex = 1;
			passwordEntry.UseSystemPasswordChar = true;
			// 
			// submit
			// 
			submit.Location = new Point(543, 163);
			submit.Name = "submit";
			submit.Size = new Size(75, 23);
			submit.TabIndex = 2;
			submit.Text = "Submit";
			submit.UseVisualStyleBackColor = true;
			submit.Click += submit_Click;
			// 
			// signUp
			// 
			signUp.Location = new Point(388, 163);
			signUp.Name = "signUp";
			signUp.Size = new Size(75, 23);
			signUp.TabIndex = 3;
			signUp.Text = "Sign Up";
			signUp.UseVisualStyleBackColor = true;
			signUp.Click += signUp_Click;
			// 
			// userName
			// 
			userName.AutoSize = true;
			userName.Location = new Point(388, 63);
			userName.Name = "userName";
			userName.Size = new Size(65, 15);
			userName.TabIndex = 4;
			userName.Text = "User Name";
			// 
			// Password
			// 
			Password.AutoSize = true;
			Password.Location = new Point(388, 105);
			Password.Name = "Password";
			Password.Size = new Size(57, 15);
			Password.TabIndex = 5;
			Password.Text = "Password";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(382, 362);
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// Login
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(693, 386);
			Controls.Add(pictureBox1);
			Controls.Add(Password);
			Controls.Add(userName);
			Controls.Add(signUp);
			Controls.Add(submit);
			Controls.Add(passwordEntry);
			Controls.Add(userNameEntry);
			Name = "Login";
			Text = "Login";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox userNameEntry;
		private TextBox passwordEntry;
		private Button submit;
		private Button signUp;
		private Label userName;
		private Label Password;
		private PictureBox pictureBox1;
	}
}
