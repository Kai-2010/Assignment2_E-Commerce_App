namespace Assignment2test1
{
	partial class Modify
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
			FN = new TextBox();
			LN = new TextBox();
			Email = new TextBox();
			phone = new TextBox();
			Add = new TextBox();
			Password = new TextBox();
			RepeatPassword = new TextBox();
			button1 = new Button();
			gender = new TextBox();
			SuspendLayout();
			// 
			// FN
			// 
			FN.Location = new Point(486, 57);
			FN.Margin = new Padding(4, 5, 4, 5);
			FN.Name = "FN";
			FN.ReadOnly = true;
			FN.Size = new Size(141, 31);
			FN.TabIndex = 0;
			FN.TextChanged += textBox1_TextChanged;
			// 
			// LN
			// 
			LN.Location = new Point(486, 105);
			LN.Margin = new Padding(4, 5, 4, 5);
			LN.Name = "LN";
			LN.ReadOnly = true;
			LN.Size = new Size(141, 31);
			LN.TabIndex = 1;
			LN.TextChanged += textBox2_TextChanged;
			// 
			// Email
			// 
			Email.Location = new Point(486, 153);
			Email.Margin = new Padding(4, 5, 4, 5);
			Email.Name = "Email";
			Email.Size = new Size(141, 31);
			Email.TabIndex = 2;
			Email.TextChanged += textBox3_TextChanged;
			// 
			// phone
			// 
			phone.Location = new Point(486, 208);
			phone.Margin = new Padding(4, 5, 4, 5);
			phone.Name = "phone";
			phone.Size = new Size(141, 31);
			phone.TabIndex = 3;
			phone.TextChanged += textBox4_TextChanged;
			// 
			// Add
			// 
			Add.Location = new Point(486, 257);
			Add.Margin = new Padding(4, 5, 4, 5);
			Add.Name = "Add";
			Add.Size = new Size(141, 31);
			Add.TabIndex = 4;
			Add.TextChanged += textBox5_TextChanged;
			// 
			// Password
			// 
			Password.Location = new Point(486, 305);
			Password.Margin = new Padding(4, 5, 4, 5);
			Password.Name = "Password";
			Password.Size = new Size(141, 31);
			Password.TabIndex = 5;
			Password.TextChanged += textBox6_TextChanged;
			// 
			// RepeatPassword
			// 
			RepeatPassword.Location = new Point(486, 373);
			RepeatPassword.Margin = new Padding(4, 5, 4, 5);
			RepeatPassword.Name = "RepeatPassword";
			RepeatPassword.Size = new Size(141, 31);
			RepeatPassword.TabIndex = 6;
			RepeatPassword.TextChanged += textBox7_TextChanged;
			// 
			// button1
			// 
			button1.Location = new Point(357, 152);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(107, 38);
			button1.TabIndex = 7;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// gender
			// 
			gender.Location = new Point(486, 438);
			gender.Margin = new Padding(4, 5, 4, 5);
			gender.Name = "gender";
			gender.ReadOnly = true;
			gender.Size = new Size(141, 31);
			gender.TabIndex = 8;
			// 
			// Modify
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1143, 750);
			Controls.Add(gender);
			Controls.Add(button1);
			Controls.Add(RepeatPassword);
			Controls.Add(Password);
			Controls.Add(Add);
			Controls.Add(phone);
			Controls.Add(Email);
			Controls.Add(LN);
			Controls.Add(FN);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Modify";
			Text = "Modify";
			Load += Modify_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox FN;
		private TextBox LN;
		private TextBox Email;
		private TextBox phone;
		private TextBox Add;
		private TextBox Password;
		private TextBox RepeatPassword;
		private Button button1;
		private TextBox gender;
	}
}