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
			Submit = new Button();
			gender = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			Cancel = new Button();
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
			FN.TextChanged += FN_TextChanged;
			// 
			// LN
			// 
			LN.Location = new Point(486, 105);
			LN.Margin = new Padding(4, 5, 4, 5);
			LN.Name = "LN";
			LN.ReadOnly = true;
			LN.Size = new Size(141, 31);
			LN.TabIndex = 1;
			LN.TextChanged += LN_TextChanged;
			// 
			// Email
			// 
			Email.Location = new Point(486, 153);
			Email.Margin = new Padding(4, 5, 4, 5);
			Email.Name = "Email";
			Email.Size = new Size(141, 31);
			Email.TabIndex = 2;
			Email.TextChanged += email_TextChanged;
			// 
			// phone
			// 
			phone.Location = new Point(486, 208);
			phone.Margin = new Padding(4, 5, 4, 5);
			phone.Name = "phone";
			phone.Size = new Size(141, 31);
			phone.TabIndex = 3;
			phone.TextChanged += phone_TextChanged;
			// 
			// Add
			// 
			Add.Location = new Point(486, 257);
			Add.Margin = new Padding(4, 5, 4, 5);
			Add.Name = "Add";
			Add.Size = new Size(141, 31);
			Add.TabIndex = 4;
			Add.TextChanged += Add_TextChanged;
			// 
			// Password
			// 
			Password.Location = new Point(486, 305);
			Password.Margin = new Padding(4, 5, 4, 5);
			Password.Name = "Password";
			Password.Size = new Size(141, 31);
			Password.TabIndex = 5;
			Password.TextChanged += password_TextChanged;
			// 
			// RepeatPassword
			// 
			RepeatPassword.Location = new Point(486, 373);
			RepeatPassword.Margin = new Padding(4, 5, 4, 5);
			RepeatPassword.Name = "RepeatPassword";
			RepeatPassword.Size = new Size(141, 31);
			RepeatPassword.TabIndex = 6;
			RepeatPassword.TextChanged += repeatPassword_TextChanged;
			// 
			// Submit
			// 
			Submit.Location = new Point(724, 505);
			Submit.Margin = new Padding(4, 5, 4, 5);
			Submit.Name = "Submit";
			Submit.Size = new Size(107, 38);
			Submit.TabIndex = 7;
			Submit.Text = "Submit";
			Submit.UseVisualStyleBackColor = true;
			Submit.Click += submit_Click;
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
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(367, 60);
			label1.Name = "firstName";
			label1.Size = new Size(97, 25);
			label1.TabIndex = 9;
			label1.Text = "First Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(367, 211);
			label2.Name = "phone";
			label2.Size = new Size(62, 25);
			label2.TabIndex = 10;
			label2.Text = "Phone";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(367, 159);
			label3.Name = "email";
			label3.Size = new Size(54, 25);
			label3.TabIndex = 11;
			label3.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(367, 111);
			label4.Name = "lastName";
			label4.Size = new Size(95, 25);
			label4.TabIndex = 12;
			label4.Text = "Last Name";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(367, 263);
			label5.Name = "address";
			label5.Size = new Size(77, 25);
			label5.TabIndex = 13;
			label5.Text = "Address";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(367, 326);
			label6.Name = "password";
			label6.Size = new Size(87, 25);
			label6.TabIndex = 14;
			label6.Text = "Password";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(333, 376);
			label7.Name = "repeatPassword";
			label7.Size = new Size(146, 25);
			label7.TabIndex = 15;
			label7.Text = "Repeat Password";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(357, 444);
			label8.Name = "gender";
			label8.Size = new Size(69, 25);
			label8.TabIndex = 16;
			label8.Text = "Gender";
			// 
			// Cancel
			// 
			Cancel.Location = new Point(344, 505);
			Cancel.Name = "Cancel";
			Cancel.Size = new Size(112, 34);
			Cancel.TabIndex = 17;
			Cancel.Text = "Cancel";
			Cancel.UseVisualStyleBackColor = true;
			Cancel.Click += Cancel_Click;
			// 
			// Modify
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1143, 750);
			Controls.Add(Cancel);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(gender);
			Controls.Add(Submit);
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
		private Button Submit;
		private TextBox gender;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Button Cancel;
	}
}