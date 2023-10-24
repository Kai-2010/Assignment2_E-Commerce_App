namespace Assignment2test1
{
	public partial class Registration : Form
	{
		// Global variables that will be used in the program
		string gender = "";// blank string used to keep track of the gender entered by the user
		const string Male = "M";// const is used because the value should not be changed anywhere in the program
		const string Female = "F";// const is used because the value should not be changed anywhere in the program
		const string Other = "P";// const is used because the value should not be changed anywhere in the program
		const string heartAttack = "H";// const is used because the value should not be changed anywhere in the program
		const string diabetes = "D";// const is used because the value should not be changed anywhere in the program
		const string chronicDisease = "C";// const is used because the value should not be changed anywhere in the program
		const string other = "O";// const is used because the value should not be changed anywhere in the program

		List<Customer> listOfCustomers = new List<Customer>();// used to 
		private bool validateInput = true;
		string healthCondition1;
		string healthCondition2;
		string healthCondition3;
		string healthCondition4;

		public Registration(List<Customer> listOfCustomers)
		{
			InitializeComponent();
			this.listOfCustomers = listOfCustomers;

		}
		// The method is used to capture the first name of an user
		// After the user has left the firstName textBox a method from the utility class is used to validate the first Name
		// A second check is completed to ensure the user does not leave the textBox blank
		// validateInput is used to check if the cancel button is clicked on or not. This will ensure that if the cancel button is clicked the validations for the 
		// firstName textBox is not executed
		private void firstName_Leave(object sender, EventArgs e)
		{
			if (validateInput)
			{
				if (utility.isNameValid(firstName.Text) == false)
				{
					MessageBox.Show("Please enter a valid First Name");
					firstName.Clear();
					firstName.Focus();

				}
				else if (string.IsNullOrEmpty(firstName.Text) == true)
				{

					MessageBox.Show("Please fill in your First Name");
					firstName.Clear();
					firstName.Focus();
				}
			}
		}
		private void lastName_Leave(object sender, EventArgs e)
		{
			if (utility.isNameValid(lastName.Text) == false)
			{
				MessageBox.Show("Please enter a valid Last Name");
				lastName.Clear();
				lastName.Focus();

			}
			else if (string.IsNullOrEmpty(firstName.Text) == true)
			{

				MessageBox.Show("Please fill in your Last Name");
				lastName.Clear();
				lastName.Focus();
			}
		}
		private void email_Leave(object sender, EventArgs e)
		{
			if (utility.isEmailValid(email.Text) == false)
			{
				MessageBox.Show("Please enter a valid email");
				email.Clear();
				email.Focus();
			}
			else if (string.IsNullOrEmpty(email.Text) == true)
			{
				MessageBox.Show("Please fill in your email");
				email.Clear();
				email.Focus();
			}
		}
		private void phoneNumber_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(phoneNumber.Text))
			{
				MessageBox.Show("Please fill in your phone number");
				phoneNumber.Clear();
				phoneNumber.Focus();
			}

			else if (utility.phoneValidation(phoneNumber.Text) == false || utility.phoneValidation1(phoneNumber.Text) == false)
			{
				MessageBox.Show("Please enter a valid phone number");
				phoneNumber.Clear();
				phoneNumber.Focus();
			}
		}
		private void address_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(address.Text) == true)
			{
				MessageBox.Show("Please fill in your address");
				address.Clear();
				address.Focus();
			}
		}
		private void password_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(password.Text) == true)
			{
				MessageBox.Show("Please fill in your password");
				password.Clear();
				password.Focus();
			}
			else if (utility.isPasswordValid(password.Text) == false)
			{
				MessageBox.Show("Please fill a valid password");
				password.Clear();
				password.Focus();
			}
		}
		private void repeatPassword_Leave(object sender, EventArgs e)
		{
			if (password.Text != repeatPassword.Text)
			{
				MessageBox.Show("Reenter passwords. They are not matching");
				password.Clear();
				repeatPassword.Clear();
				password.Focus();
			}
		}

		private void submit_Click(object sender, EventArgs e)
		{
			if (password.Text != repeatPassword.Text)
			{
				MessageBox.Show("Reenter passwords. They are not matching");
				password.Clear();
				repeatPassword.Clear();
				password.Focus();
			}
			else
			{
				if (listOfCustomers.Any(Customer => Customer.email == email.Text) == true)
				{
					MessageBox.Show("Email Id is not available", "Please enter another email Id", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					email.Clear();
					email.Focus();
				}
				else
				{
					Customer newCustomer = new Customer(email.Text, password.Text, firstName.Text, lastName.Text, phoneNumber.Text, address.Text, gender, healthCondition1, healthCondition2, healthCondition3, healthCondition4);
					listOfCustomers.Add(newCustomer);
					utility.saveCustomerDetails(listOfCustomers);
					MessageBox.Show("New Customer created successfully", $"Your Login ID is : {email.Text}", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					Hide();
					new Login().Show();
				}

			}
		}


		private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			gender = Male;
		}

		private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			gender = Female;
		}

		private void preferNotToSayRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			gender = Other;
		}

		

		private void heartAttackCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (heartAttackCheckBox.Checked)
			{
				healthCondition1 = heartAttack;
			}
			else
			{
				healthCondition1 = "";
			}
		}

		private void diabetesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (diabetesCheckBox.Checked)
			{
				healthCondition2 = diabetes;
			}
			else
			{
				healthCondition2 = "";
			}
		}

		private void chronicDiseaseCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (chronicDiseaseCheckBox.Checked)
			{
				healthCondition3 = chronicDisease;
			}
			else
			{
				healthCondition3 = "";
			}
		}

		private void other_CheckedChanged(object sender, EventArgs e)
		{
			if (otherCheckBox.Checked)
			{
				healthCondition4 = other;
			}
			else
			{
				healthCondition4 = "";
			}
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			validateInput = false;
			Hide();
			new Login().Show();
		}
	}
}
