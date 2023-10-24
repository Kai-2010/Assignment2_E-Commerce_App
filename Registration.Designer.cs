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
			maleRadioButton = new RadioButton();
			femaleRadioButton = new RadioButton();
			preferNotToSayRadioButton = new RadioButton();
			submit = new Button();
			FN = new Label();
			LN = new Label();
			mail = new Label();
			phone = new Label();
			add = new Label();
			password = new TextBox();
			pa = new Label();
			repeatPassword = new TextBox();
			RP = new Label();
			heartAttackCheckBox = new CheckBox();
			diabetesCheckBox = new CheckBox();
			chronicDiseaseCheckBox = new CheckBox();
			otherCheckBox = new CheckBox();
			label8 = new Label();
			Title = new Label();
			Cancel = new Button();
			SuspendLayout();
			// 
			// firstName
			// 
			firstName.AcceptsReturn = true;
			firstName.AcceptsTab = true;
			firstName.CausesValidation = false;
			firstName.Location = new Point(211, 53);
			firstName.Name = "firstName";
			firstName.Size = new Size(264, 23);
			firstName.TabIndex = 0;
			firstName.Leave += firstName_Leave;
			// 
			// lastName
			// 
			lastName.AcceptsReturn = true;
			lastName.AcceptsTab = true;
			lastName.Location = new Point(211, 82);
			lastName.Name = "lastName";
			lastName.Size = new Size(264, 23);
			lastName.TabIndex = 1;
			lastName.Leave += lastName_Leave;
			// 
			// email
			// 
			email.AcceptsReturn = true;
			email.AcceptsTab = true;
			email.Location = new Point(211, 111);
			email.Name = "email";
			email.Size = new Size(264, 23);
			email.TabIndex = 2;
			email.Leave += email_Leave;
			// 
			// phoneNumber
			// 
			phoneNumber.AcceptsReturn = true;
			phoneNumber.AcceptsTab = true;
			phoneNumber.Location = new Point(211, 140);
			phoneNumber.Name = "phoneNumber";
			phoneNumber.Size = new Size(100, 23);
			phoneNumber.TabIndex = 3;
			phoneNumber.Leave += phoneNumber_Leave;
			// 
			// address
			// 
			address.AcceptsReturn = true;
			address.AcceptsTab = true;
			address.Location = new Point(211, 169);
			address.Name = "address";
			address.Size = new Size(264, 23);
			address.TabIndex = 4;
			address.Leave += address_Leave;
			// 
			// maleRadioButton
			// 
			maleRadioButton.AutoSize = true;
			maleRadioButton.Location = new Point(113, 269);
			maleRadioButton.Name = "maleRadioButton";
			maleRadioButton.Size = new Size(51, 19);
			maleRadioButton.TabIndex = 5;
			maleRadioButton.TabStop = true;
			maleRadioButton.Text = "Male";
			maleRadioButton.UseVisualStyleBackColor = true;
			maleRadioButton.CheckedChanged += maleRadioButton_CheckedChanged;
			// 
			// femaleRadioButton
			// 
			femaleRadioButton.AutoSize = true;
			femaleRadioButton.Location = new Point(199, 269);
			femaleRadioButton.Name = "femaleRadioButton";
			femaleRadioButton.Size = new Size(63, 19);
			femaleRadioButton.TabIndex = 6;
			femaleRadioButton.TabStop = true;
			femaleRadioButton.Text = "Female";
			femaleRadioButton.UseVisualStyleBackColor = true;
			femaleRadioButton.CheckedChanged += femaleRadioButton_CheckedChanged;
			// 
			// preferNotToSayRadioButton
			// 
			preferNotToSayRadioButton.AutoSize = true;
			preferNotToSayRadioButton.Location = new Point(295, 269);
			preferNotToSayRadioButton.Name = "preferNotToSayRadioButton";
			preferNotToSayRadioButton.Size = new Size(111, 19);
			preferNotToSayRadioButton.TabIndex = 7;
			preferNotToSayRadioButton.TabStop = true;
			preferNotToSayRadioButton.Text = "Prefer not to say";
			preferNotToSayRadioButton.UseVisualStyleBackColor = true;
			preferNotToSayRadioButton.CheckedChanged += preferNotToSayRadioButton_CheckedChanged;
			// 
			// submit
			// 
			submit.Location = new Point(641, 406);
			submit.Name = "submit";
			submit.Size = new Size(75, 23);
			submit.TabIndex = 8;
			submit.Text = "Submit";
			submit.UseVisualStyleBackColor = true;
			submit.Click += submit_Click;
			// 
			// FN
			// 
			FN.AutoSize = true;
			FN.Location = new Point(127, 56);
			FN.Name = "FN";
			FN.Size = new Size(64, 15);
			FN.TabIndex = 9;
			FN.Text = "First Name";
			// 
			// LN
			// 
			LN.AutoSize = true;
			LN.Location = new Point(127, 86);
			LN.Name = "LN";
			LN.Size = new Size(63, 15);
			LN.TabIndex = 10;
			LN.Text = "Last Name";
			// 
			// mail
			// 
			mail.AutoSize = true;
			mail.Location = new Point(149, 114);
			mail.Name = "mail";
			mail.Size = new Size(36, 15);
			mail.TabIndex = 11;
			mail.Text = "Email";
			// 
			// phone
			// 
			phone.AutoSize = true;
			phone.Location = new Point(149, 143);
			phone.Name = "phone";
			phone.Size = new Size(41, 15);
			phone.TabIndex = 12;
			phone.Text = "Phone";
			// 
			// add
			// 
			add.AutoSize = true;
			add.Location = new Point(141, 172);
			add.Name = "add";
			add.Size = new Size(49, 15);
			add.TabIndex = 13;
			add.Text = "Address";
			// 
			// password
			// 
			password.AcceptsReturn = true;
			password.AcceptsTab = true;
			password.Location = new Point(211, 198);
			password.Name = "password";
			password.Size = new Size(100, 23);
			password.TabIndex = 14;
			password.UseSystemPasswordChar = true;
			password.Leave += password_Leave;
			// 
			// pa
			// 
			pa.AutoSize = true;
			pa.Location = new Point(134, 198);
			pa.Name = "pa";
			pa.Size = new Size(57, 15);
			pa.TabIndex = 15;
			pa.Text = "Password";
			// 
			// repeatPassword
			// 
			repeatPassword.AcceptsReturn = true;
			repeatPassword.AcceptsTab = true;
			repeatPassword.Location = new Point(211, 227);
			repeatPassword.Name = "repeatPassword";
			repeatPassword.Size = new Size(100, 23);
			repeatPassword.TabIndex = 16;
			repeatPassword.UseSystemPasswordChar = true;
			repeatPassword.Leave += repeatPassword_Leave;
			// 
			// RP
			// 
			RP.AutoSize = true;
			RP.Location = new Point(95, 230);
			RP.Name = "RP";
			RP.Size = new Size(96, 15);
			RP.TabIndex = 17;
			RP.Text = "Repeat Password";
			// 
			// heartAttackCheckBox
			// 
			heartAttackCheckBox.AutoSize = true;
			heartAttackCheckBox.Location = new Point(107, 349);
			heartAttackCheckBox.Name = "heartAttackCheckBox";
			heartAttackCheckBox.Size = new Size(92, 19);
			heartAttackCheckBox.TabIndex = 28;
			heartAttackCheckBox.Text = "Heart Attack";
			heartAttackCheckBox.UseVisualStyleBackColor = true;
			heartAttackCheckBox.CheckedChanged += heartAttackCheckBox_CheckedChanged;
			// 
			// diabetesCheckBox
			// 
			diabetesCheckBox.AutoSize = true;
			diabetesCheckBox.Location = new Point(225, 349);
			diabetesCheckBox.Name = "diabetesCheckBox";
			diabetesCheckBox.Size = new Size(71, 19);
			diabetesCheckBox.TabIndex = 29;
			diabetesCheckBox.Text = "Diabetes";
			diabetesCheckBox.UseVisualStyleBackColor = true;
			diabetesCheckBox.CheckedChanged += diabetesCheckBox_CheckedChanged;
			// 
			// chronicDiseaseCheckBox
			// 
			chronicDiseaseCheckBox.AutoSize = true;
			chronicDiseaseCheckBox.Location = new Point(319, 349);
			chronicDiseaseCheckBox.Name = "chronicDiseaseCheckBox";
			chronicDiseaseCheckBox.Size = new Size(110, 19);
			chronicDiseaseCheckBox.TabIndex = 30;
			chronicDiseaseCheckBox.Text = "Chronic Disease";
			chronicDiseaseCheckBox.UseVisualStyleBackColor = true;
			chronicDiseaseCheckBox.CheckedChanged += chronicDiseaseCheckBox_CheckedChanged;
			// 
			// otherCheckBox
			// 
			otherCheckBox.AutoSize = true;
			otherCheckBox.Location = new Point(447, 349);
			otherCheckBox.Name = "otherCheckBox";
			otherCheckBox.Size = new Size(56, 19);
			otherCheckBox.TabIndex = 31;
			otherCheckBox.Text = "Other";
			otherCheckBox.UseVisualStyleBackColor = true;
			otherCheckBox.CheckedChanged += other_CheckedChanged;
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
			// Title
			// 
			Title.AutoSize = true;
			Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Title.Location = new Point(291, 15);
			Title.Name = "Title";
			Title.Size = new Size(116, 15);
			Title.TabIndex = 33;
			Title.Text = "Registration Details";
			// 
			// Cancel
			// 
			Cancel.Location = new Point(83, 402);
			Cancel.Name = "Cancel";
			Cancel.Size = new Size(75, 23);
			Cancel.TabIndex = 34;
			Cancel.Text = "Cancel";
			Cancel.UseVisualStyleBackColor = true;
			Cancel.Click += Cancel_Click;
			// 
			// Registration
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 450);
			Controls.Add(Cancel);
			Controls.Add(Title);
			Controls.Add(label8);
			Controls.Add(otherCheckBox);
			Controls.Add(chronicDiseaseCheckBox);
			Controls.Add(diabetesCheckBox);
			Controls.Add(heartAttackCheckBox);
			Controls.Add(RP);
			Controls.Add(repeatPassword);
			Controls.Add(pa);
			Controls.Add(password);
			Controls.Add(add);
			Controls.Add(phone);
			Controls.Add(mail);
			Controls.Add(LN);
			Controls.Add(FN);
			Controls.Add(submit);
			Controls.Add(preferNotToSayRadioButton);
			Controls.Add(femaleRadioButton);
			Controls.Add(maleRadioButton);
			Controls.Add(address);
			Controls.Add(phoneNumber);
			Controls.Add(email);
			Controls.Add(lastName);
			Controls.Add(firstName);
			Name = "Registration";
			Text = "Registration";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox firstName;
		private TextBox lastName;
		private TextBox email;
		private TextBox phoneNumber;
		private TextBox address;
		private RadioButton maleRadioButton;
		private RadioButton femaleRadioButton;
		private RadioButton preferNotToSayRadioButton;
		private Button submit;
		private Label FN;
		private Label LN;
		private Label mail;
		private Label phone;
		private Label add;
		private TextBox password;
		private Label pa;
		private TextBox repeatPassword;
		private Label RP;
		private CheckBox heartAttackCheckBox;
		private CheckBox diabetesCheckBox;
		private CheckBox chronicDiseaseCheckBox;
		private CheckBox otherCheckBox;
		private Label label8;
		private Label Title;
		private Button Cancel;
	}
}