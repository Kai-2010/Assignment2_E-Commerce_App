namespace Assignment2test1
{
	partial class Registration
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
			firstName = new TextBox();
			lastName = new TextBox();
			email = new TextBox();
			phoneNumber = new TextBox();
			address = new TextBox();
			radioButton1 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton3 = new RadioButton();
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			password = new TextBox();
			label6 = new Label();
			repeatPassword = new TextBox();
			label7 = new Label();
			checkedListBox2 = new CheckedListBox();
			checkedListBox3 = new CheckedListBox();
			checkedListBox4 = new CheckedListBox();
			checkedListBox1 = new CheckedListBox();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// firstName
			// 
			firstName.Location = new Point(301, 88);
			firstName.Margin = new Padding(4, 5, 4, 5);
			firstName.Name = "firstName";
			firstName.Size = new Size(141, 31);
			firstName.TabIndex = 0;
			//firstName.Leave += textBox1_Leave;
			// 
			// lastName
			// 
			lastName.Location = new Point(301, 137);
			lastName.Margin = new Padding(4, 5, 4, 5);
			lastName.Name = "lastName";
			lastName.Size = new Size(141, 31);
			lastName.TabIndex = 1;
			//lastName.Leave += textBox2_Leave;
			// 
			// email
			// 
			email.Location = new Point(301, 185);
			email.Margin = new Padding(4, 5, 4, 5);
			email.Name = "email";
			email.Size = new Size(141, 31);
			email.TabIndex = 2;
			//email.Leave += textBox3_Leave;
			// 
			// phoneNumber
			// 
			phoneNumber.Location = new Point(301, 233);
			phoneNumber.Margin = new Padding(4, 5, 4, 5);
			phoneNumber.Name = "phoneNumber";
			phoneNumber.Size = new Size(141, 31);
			phoneNumber.TabIndex = 3;
			//phoneNumber.Leave += textBox4_Leave;
			// 
			// address
			// 
			address.Location = new Point(301, 282);
			address.Margin = new Padding(4, 5, 4, 5);
			address.Name = "address";
			address.Size = new Size(141, 31);
			address.TabIndex = 4;
			//address.Leave += textBox5_Leave;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(161, 448);
			radioButton1.Margin = new Padding(4, 5, 4, 5);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(75, 29);
			radioButton1.TabIndex = 5;
			radioButton1.TabStop = true;
			radioButton1.Text = "Male";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(284, 448);
			radioButton2.Margin = new Padding(4, 5, 4, 5);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(93, 29);
			radioButton2.TabIndex = 6;
			radioButton2.TabStop = true;
			radioButton2.Text = "Female";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(421, 448);
			radioButton3.Margin = new Padding(4, 5, 4, 5);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(168, 29);
			radioButton3.TabIndex = 7;
			radioButton3.TabStop = true;
			radioButton3.Text = "Prefer not to say";
			radioButton3.UseVisualStyleBackColor = true;
			radioButton3.CheckedChanged += radioButton3_CheckedChanged;
			// 
			// button1
			// 
			button1.Location = new Point(403, 677);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(107, 38);
			button1.TabIndex = 8;
			button1.Text = "Submit";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(181, 93);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(97, 25);
			label1.TabIndex = 9;
			label1.Text = "First Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(181, 143);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(95, 25);
			label2.TabIndex = 10;
			label2.Text = "Last Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(181, 192);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(54, 25);
			label3.TabIndex = 11;
			label3.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(181, 238);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(62, 25);
			label4.TabIndex = 12;
			label4.Text = "Phone";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(181, 288);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(77, 25);
			label5.TabIndex = 13;
			label5.Text = "Address";
			// 
			// password
			// 
			password.Location = new Point(301, 323);
			password.Margin = new Padding(4, 5, 4, 5);
			password.Name = "password";
			password.Size = new Size(141, 31);
			password.TabIndex = 14;
			password.UseSystemPasswordChar = true;
			//password.Leave += textBox6_Leave;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(181, 328);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(87, 25);
			label6.TabIndex = 15;
			label6.Text = "Password";
			// 
			// repeatPassword
			// 
			repeatPassword.Location = new Point(301, 363);
			repeatPassword.Margin = new Padding(4, 5, 4, 5);
			repeatPassword.Name = "repeatPassword";
			repeatPassword.Size = new Size(141, 31);
			repeatPassword.TabIndex = 16;
			repeatPassword.UseSystemPasswordChar = true;
			//repeatPassword.Leave += textBox7_Leave;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(147, 370);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(146, 25);
			label7.TabIndex = 17;
			label7.Text = "Repeat Password";
			// 
			// checkedListBox2
			// 
			checkedListBox2.FormattingEnabled = true;
			checkedListBox2.Location = new Point(349, 515);
			checkedListBox2.Name = "checkedListBox2";
			checkedListBox2.Size = new Size(180, 32);
			checkedListBox2.TabIndex = 19;
			// 
			// checkedListBox3
			// 
			checkedListBox3.FormattingEnabled = true;
			checkedListBox3.Location = new Point(546, 515);
			checkedListBox3.Name = "checkedListBox3";
			checkedListBox3.Size = new Size(180, 32);
			checkedListBox3.TabIndex = 20;
			// 
			// checkedListBox4
			// 
			checkedListBox4.CheckOnClick = true;
			checkedListBox4.FormattingEnabled = true;
			checkedListBox4.Location = new Point(731, 515);
			checkedListBox4.Name = "checkedListBox4";
			checkedListBox4.Size = new Size(180, 32);
			checkedListBox4.TabIndex = 21;
			// 
			// checkedListBox1
			// 
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Location = new Point(147, 515);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(180, 32);
			checkedListBox1.TabIndex = 22;
			checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(161, 603);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(110, 25);
			label8.TabIndex = 23;
			label8.Text = "Heart Attack";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(359, 603);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(80, 25);
			label9.TabIndex = 24;
			label9.Text = "Diabities";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(546, 603);
			label10.Margin = new Padding(4, 0, 4, 0);
			label10.Name = "label10";
			label10.Size = new Size(135, 25);
			label10.TabIndex = 25;
			label10.Text = "Chronic disease";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(746, 603);
			label11.Margin = new Padding(4, 0, 4, 0);
			label11.Name = "label11";
			label11.Size = new Size(57, 25);
			label11.TabIndex = 26;
			label11.Text = "Other";
			// 
			// button2
			// 
			button2.Location = new Point(596, 680);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(107, 38);
			button2.TabIndex = 27;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Registration
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.AppWorkspace;
			ClientSize = new Size(1143, 750);
			Controls.Add(button2);
			Controls.Add(label11);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(checkedListBox1);
			Controls.Add(checkedListBox4);
			Controls.Add(checkedListBox3);
			Controls.Add(checkedListBox2);
			Controls.Add(label7);
			Controls.Add(repeatPassword);
			Controls.Add(label6);
			Controls.Add(password);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(radioButton3);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(address);
			Controls.Add(phoneNumber);
			Controls.Add(email);
			Controls.Add(lastName);
			Controls.Add(firstName);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Registration";
			Text = "Form2";
			Load += Form2_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox firstName;
		private TextBox lastName;
		private TextBox email;
		private TextBox phoneNumber;
		private TextBox address;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private RadioButton radioButton3;
		private Button button1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox password;
		private Label label6;
		private TextBox repeatPassword;
		private Label label7;
		private CheckedListBox checkedListBox2;
		private CheckedListBox checkedListBox3;
		private CheckedListBox checkedListBox4;
		private CheckedListBox checkedListBox1;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Button button2;
	}
}