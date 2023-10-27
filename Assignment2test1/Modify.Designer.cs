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
			label9 = new Label();
			heartAttackCheckBox = new CheckBox();
			diabetesCheckBox = new CheckBox();
			chronicDiseaseCheckBox = new CheckBox();
			otherCheckBox = new CheckBox();
			SuspendLayout();
			// 
			// FN
			// 
			FN.Location = new Point(340, 34);
			FN.Name = "FN";
			FN.ReadOnly = true;
			FN.Size = new Size(273, 23);
			FN.TabIndex = 0;
			FN.TabStop = false;
			// 
			// LN
			// 
			LN.Location = new Point(340, 63);
			LN.Name = "LN";
			LN.ReadOnly = true;
			LN.Size = new Size(273, 23);
			LN.TabIndex = 1;
			LN.TabStop = false;
			// 
			// Email
			// 
			Email.Location = new Point(340, 92);
			Email.Name = "Email";
			Email.ReadOnly = true;
			Email.Size = new Size(273, 23);
			Email.TabIndex = 2;
			Email.TabStop = false;
			// 
			// phone
			// 
			phone.Location = new Point(340, 122);
			phone.Name = "phone";
			phone.Size = new Size(100, 23);
			phone.TabIndex = 3;
			// 
			// Add
			// 
			Add.Location = new Point(340, 151);
			Add.Name = "Add";
			Add.Size = new Size(273, 23);
			Add.TabIndex = 4;
			// 
			// Password
			// 
			Password.Location = new Point(340, 183);
			Password.Name = "Password";
			Password.Size = new Size(100, 23);
			Password.TabIndex = 5;
			Password.UseSystemPasswordChar = true;
			// 
			// RepeatPassword
			// 
			RepeatPassword.Location = new Point(340, 212);
			RepeatPassword.Name = "RepeatPassword";
			RepeatPassword.Size = new Size(100, 23);
			RepeatPassword.TabIndex = 6;
			RepeatPassword.UseSystemPasswordChar = true;
			// 
			// Submit
			// 
			Submit.Location = new Point(657, 407);
			Submit.Name = "Submit";
			Submit.Size = new Size(75, 23);
			Submit.TabIndex = 7;
			Submit.Text = "Submit";
			Submit.UseVisualStyleBackColor = true;
			Submit.Click += submit_Click;
			// 
			// gender
			// 
			gender.Location = new Point(340, 255);
			gender.Name = "gender";
			gender.ReadOnly = true;
			gender.Size = new Size(43, 23);
			gender.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(257, 36);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(64, 15);
			label1.TabIndex = 9;
			label1.Text = "First Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(258, 122);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(41, 15);
			label2.TabIndex = 10;
			label2.Text = "Phone";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(257, 95);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(36, 15);
			label3.TabIndex = 11;
			label3.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(257, 67);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(63, 15);
			label4.TabIndex = 12;
			label4.Text = "Last Name";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(258, 151);
			label5.Margin = new Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new Size(49, 15);
			label5.TabIndex = 13;
			label5.Text = "Address";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(252, 186);
			label6.Margin = new Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new Size(57, 15);
			label6.TabIndex = 14;
			label6.Text = "Password";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(233, 226);
			label7.Margin = new Padding(2, 0, 2, 0);
			label7.Name = "label7";
			label7.Size = new Size(96, 15);
			label7.TabIndex = 15;
			label7.Text = "Repeat Password";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(254, 263);
			label8.Margin = new Padding(2, 0, 2, 0);
			label8.Name = "label8";
			label8.Size = new Size(45, 15);
			label8.TabIndex = 16;
			label8.Text = "Gender";
			// 
			// Cancel
			// 
			Cancel.Location = new Point(42, 407);
			Cancel.Margin = new Padding(2);
			Cancel.Name = "Cancel";
			Cancel.Size = new Size(83, 24);
			Cancel.TabIndex = 17;
			Cancel.Text = "Cancel";
			Cancel.UseVisualStyleBackColor = true;
			Cancel.Click += Cancel_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label9.Location = new Point(350, 9);
			label9.Name = "label9";
			label9.Size = new Size(45, 15);
			label9.TabIndex = 18;
			label9.Text = "Details";
			// 
			// heartAttackCheckBox
			// 
			heartAttackCheckBox.AutoSize = true;
			heartAttackCheckBox.Location = new Point(340, 298);
			heartAttackCheckBox.Name = "heartAttackCheckBox";
			heartAttackCheckBox.Size = new Size(92, 19);
			heartAttackCheckBox.TabIndex = 19;
			heartAttackCheckBox.Text = "Heart Attack";
			heartAttackCheckBox.UseVisualStyleBackColor = true;
			// 
			// diabetesCheckBox
			// 
			diabetesCheckBox.AutoSize = true;
			diabetesCheckBox.Location = new Point(340, 323);
			diabetesCheckBox.Name = "diabetesCheckBox";
			diabetesCheckBox.Size = new Size(71, 19);
			diabetesCheckBox.TabIndex = 20;
			diabetesCheckBox.Text = "Diabetes";
			diabetesCheckBox.UseVisualStyleBackColor = true;
			// 
			// chronicDiseaseCheckBox
			// 
			chronicDiseaseCheckBox.AutoSize = true;
			chronicDiseaseCheckBox.Location = new Point(340, 348);
			chronicDiseaseCheckBox.Name = "chronicDiseaseCheckBox";
			chronicDiseaseCheckBox.Size = new Size(110, 19);
			chronicDiseaseCheckBox.TabIndex = 21;
			chronicDiseaseCheckBox.Text = "Chronic Disease";
			chronicDiseaseCheckBox.UseVisualStyleBackColor = true;
			// 
			// otherCheckBox
			// 
			otherCheckBox.AutoSize = true;
			otherCheckBox.Location = new Point(340, 373);
			otherCheckBox.Name = "otherCheckBox";
			otherCheckBox.Size = new Size(56, 19);
			otherCheckBox.TabIndex = 22;
			otherCheckBox.Text = "Other";
			otherCheckBox.UseVisualStyleBackColor = true;
			// 
			// Modify
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 450);
			Controls.Add(otherCheckBox);
			Controls.Add(chronicDiseaseCheckBox);
			Controls.Add(diabetesCheckBox);
			Controls.Add(heartAttackCheckBox);
			Controls.Add(label9);
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
			Name = "Modify";
			Text = "Modify";
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
		private Label label9;
		private CheckBox heartAttackCheckBox;
		private CheckBox diabetesCheckBox;
		private CheckBox chronicDiseaseCheckBox;
		private CheckBox otherCheckBox;
	}
}