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
			button2 = new Button();
			checkBox1 = new CheckBox();
			checkBox2 = new CheckBox();
			checkBox3 = new CheckBox();
			checkBox4 = new CheckBox();
			label8 = new Label();
			SuspendLayout();
			// 
			// firstName
			// 
			firstName.Location = new Point(211, 53);
			firstName.Name = "firstName";
			firstName.Size = new Size(100, 23);
			firstName.TabIndex = 0;
			// 
			// lastName
			// 
			lastName.Location = new Point(211, 82);
			lastName.Name = "lastName";
			lastName.Size = new Size(100, 23);
			lastName.TabIndex = 1;
			// 
			// email
			// 
			email.Location = new Point(211, 111);
			email.Name = "email";
			email.Size = new Size(100, 23);
			email.TabIndex = 2;
			// 
			// phoneNumber
			// 
			phoneNumber.Location = new Point(211, 140);
			phoneNumber.Name = "phoneNumber";
			phoneNumber.Size = new Size(100, 23);
			phoneNumber.TabIndex = 3;
			// 
			// address
			// 
			address.Location = new Point(211, 169);
			address.Name = "address";
			address.Size = new Size(100, 23);
			address.TabIndex = 4;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(113, 269);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(51, 19);
			radioButton1.TabIndex = 5;
			radioButton1.TabStop = true;
			radioButton1.Text = "Male";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(199, 269);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(63, 19);
			radioButton2.TabIndex = 6;
			radioButton2.TabStop = true;
			radioButton2.Text = "Female";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(295, 269);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(111, 19);
			radioButton3.TabIndex = 7;
			radioButton3.TabStop = true;
			radioButton3.Text = "Prefer not to say";
			radioButton3.UseVisualStyleBackColor = true;
			radioButton3.CheckedChanged += radioButton3_CheckedChanged;
			// 
			// button1
			// 
			button1.Location = new Point(282, 406);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 8;
			button1.Text = "Submit";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(127, 56);
			label1.Name = "label1";
			label1.Size = new Size(64, 15);
			label1.TabIndex = 9;
			label1.Text = "First Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(127, 86);
			label2.Name = "label2";
			label2.Size = new Size(63, 15);
			label2.TabIndex = 10;
			label2.Text = "Last Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(149, 114);
			label3.Name = "label3";
			label3.Size = new Size(36, 15);
			label3.TabIndex = 11;
			label3.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(149, 143);
			label4.Name = "label4";
			label4.Size = new Size(41, 15);
			label4.TabIndex = 12;
			label4.Text = "Phone";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(141, 172);
			label5.Name = "label5";
			label5.Size = new Size(49, 15);
			label5.TabIndex = 13;
			label5.Text = "Address";
			// 
			// password
			// 
			password.Location = new Point(211, 198);
			password.Name = "password";
			password.Size = new Size(100, 23);
			password.TabIndex = 14;
			password.UseSystemPasswordChar = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(134, 198);
			label6.Name = "label6";
			label6.Size = new Size(57, 15);
			label6.TabIndex = 15;
			label6.Text = "Password";
			// 
			// repeatPassword
			// 
			repeatPassword.Location = new Point(211, 227);
			repeatPassword.Name = "repeatPassword";
			repeatPassword.Size = new Size(100, 23);
			repeatPassword.TabIndex = 16;
			repeatPassword.UseSystemPasswordChar = true;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(95, 230);
			label7.Name = "label7";
			label7.Size = new Size(96, 15);
			label7.TabIndex = 17;
			label7.Text = "Repeat Password";
			// 
			// button2
			// 
			button2.Location = new Point(417, 408);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 27;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(107, 349);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(92, 19);
			checkBox1.TabIndex = 28;
			checkBox1.Text = "Heart Attack";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(225, 349);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(71, 19);
			checkBox2.TabIndex = 29;
			checkBox2.Text = "Diabetes";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			checkBox3.AutoSize = true;
			checkBox3.Location = new Point(319, 349);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new Size(110, 19);
			checkBox3.TabIndex = 30;
			checkBox3.Text = "Chronic Disease";
			checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			checkBox4.AutoSize = true;
			checkBox4.Location = new Point(447, 349);
			checkBox4.Name = "checkBox4";
			checkBox4.Size = new Size(56, 19);
			checkBox4.TabIndex = 31;
			checkBox4.Text = "Other";
			checkBox4.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(164, 306);
			label8.Name = "label8";
			label8.Size = new Size(162, 21);
			label8.TabIndex = 32;
			label8.Text = "Choose 1 if applicable";
			// 
			// Registration
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.AppWorkspace;
			ClientSize = new Size(800, 450);
			Controls.Add(label8);
			Controls.Add(checkBox4);
			Controls.Add(checkBox3);
			Controls.Add(checkBox2);
			Controls.Add(checkBox1);
			Controls.Add(button2);
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
		private Button button2;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox3;
		private CheckBox checkBox4;
		private Label label8;
	}
}