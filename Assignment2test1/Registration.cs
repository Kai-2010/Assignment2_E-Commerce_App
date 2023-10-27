namespace Assignment2test1
{
	public partial class Registration : Form
	{
		// Global variables that will be used in the program
		string gender = "";// blank string used to keep track of the gender entered by the user

		public Registration()
		{
			InitializeComponent();

		}

		// First attempts to return a customer from the database using the text in the email and password text boxes.
		// Then verifies that all the text boxes have valid inputs by checking if an error message was generated (shows the message if true).
		// Then if a customer was returned from the database (i.e. customer already exists), the registration is rejected.
        // Finally, if else, a new customer is created and added to the database, then the user is returned to the login page.
		private void submit_Click(object sender, EventArgs e)
		{
            Customer customer;
            string errorMessage = verifyAll();

            using (var context = new HealthContext())
            {
                customer = context.Customers.FirstOrDefault(c => c.email == email.Text);
            }
      
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
            }
            else if (customer != null)
            {
                MessageBox.Show("Email Id is not available", "Please enter another email Id", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                email.Clear();
                email.Focus();
            }
            else
            {
                customer = new Customer(firstName.Text, lastName.Text, address.Text, email.Text, phoneNumber.Text, password.Text, gender, heartAttackCheckBox.Checked, diabetesCheckBox.Checked, chronicDiseaseCheckBox.Checked, otherCheckBox.Checked);
                MessageBox.Show("New Customer created successfully", $"Your Login ID is : {email.Text}", MessageBoxButtons.OK);
                utility.addCustomer(customer);
                this.Close();
                new Login().Show();
            }
        }

        //Calls all the verification methods in one method, returns an error message (will be blank if verified successfully).
        private string verifyAll()
        {
            string errorMessage = "";
            errorMessage = verifyFirstName(errorMessage);
            errorMessage = verifyLastName(errorMessage);
            errorMessage = verifyEmail(errorMessage);
            errorMessage = verifyPhone(errorMessage);
            errorMessage = verifyAddress(errorMessage);
            errorMessage = verifyPassword(errorMessage);
            errorMessage = verifyGender(errorMessage);
            return errorMessage;
        }

        // The method is used to verify the first name of a user.
        // When called, a method from the utility class is used to validate the first name, adding an error message to the string if invalid.
        // A second check is completed to ensure the user does not leave the textBox blank, also adding an error message to the string if invalid.
        // The method then returns an empty string if valid, or error message if invalid.
        private string verifyFirstName(string errorMessage)
        {
            if (utility.isNameValid(firstName.Text) == false)
            {
                errorMessage += "Please enter a valid First Name\n";
                firstName.Clear();
            }
            else if (string.IsNullOrEmpty(firstName.Text))
            {
                errorMessage += "Please fill in your first name\n";
                firstName.Clear();
            }
            return errorMessage;
        }

        // The method is used to verify the last name of a user.
        // When called, a method from the utility class is used to validate the last name, adding an error message to the string if invalid.
        // A second check is completed to ensure the user does not leave the textBox blank, also adding an error message to the string if invalid.
        // The method then returns an empty string if valid, or error message if invalid.
        private string verifyLastName(string errorMessage)
        {
            if (utility.isNameValid(lastName.Text) == false)
            {
                errorMessage += "Please enter a valid Last Name\n";
                lastName.Clear();
            }
            else if (string.IsNullOrEmpty(lastName.Text))
            {
                errorMessage += "Please fill in your last name\n";
                lastName.Clear();
            }
            return errorMessage;
        }

        // The method is used to verify the email of a user.
        // When called, a method from the utility class is used to validate the email, adding an error message to the string if invalid.
        // A second check is completed to ensure the user does not leave the textBox blank, also adding an error message to the string if invalid.
        // The method then returns an empty string if valid, or error message if invalid.
        private string verifyEmail(string errorMessage)
        {
            if (utility.isEmailValid(email.Text) == false)
            {
                errorMessage += "Please enter a valid email\n";
                email.Clear();
            }
            else if (string.IsNullOrEmpty(email.Text))
            {
                errorMessage += "Please fill in your email\n";
                email.Clear();
            }
            return errorMessage;
        }

        // The method is used to verify the phone number of a user.
        // When called, a method from the utility class is used to validate the phone number, adding an error message to the string if invalid.
        // A second check is completed to ensure the user does not leave the textBox blank, also adding an error message to the string if invalid.
        // The method then returns an empty string if valid, or error message if invalid.
        private string verifyPhone(string errorMessage)
        {
            if (utility.phoneValidation(phoneNumber.Text) == false || utility.phoneValidation1(phoneNumber.Text) == false)
            {
                errorMessage += "Please enter a valid phone number\n";
                phoneNumber.Clear();
            }
            else if (string.IsNullOrEmpty(phoneNumber.Text))
            {
                errorMessage += "Please fill in your phone number\n";
                phoneNumber.Clear();
            }
            return errorMessage;
        }

        // The method is used to verify the address of a user.
        // When called, a check is completed to ensure the user does not leave the textBox blank, adding an error message to the string if invalid.
        // The method then returns an empty string if valid, or error message if invalid.
        private string verifyAddress(string errorMessage)
        {
            if (string.IsNullOrEmpty(address.Text))
            {
                errorMessage += "Please fill in your address\n";
                address.Clear();
            }
            return errorMessage;
        }

        // The method is used to verify the password of a user.
        // When called, a method from the utility class is used to validate the password, adding an error message to the string if invalid.
        // A second check is completed to ensure the user does not leave the textBox blank, also adding an error message to the string if invalid.
        // A third check compares that password and repeat password text boxes and generates an error message if they do not match.
        // The method then returns an empty string if valid, or error message if invalid.
        private string verifyPassword(string errorMessage)
        {
            if (string.IsNullOrEmpty(password.Text))
            {
                errorMessage += "Please fill in your password\n";
                password.Clear();
                repeatPassword.Clear();
            }
            else if (utility.isPasswordValid(password.Text) == false)
            {
                errorMessage += "Please fill a valid password\n";
                password.Clear();
                repeatPassword.Clear();
            }
            else if (password.Text != repeatPassword.Text)
            {
                errorMessage += "Reenter passwords. They are not matching\n";
                password.Clear();
                repeatPassword.Clear();
            }
            return errorMessage;
        }

        // The method is used to verify the gender of a user.
        // When called, a check is completed to ensure the user does not leave the gender options blank, adding an error message to the string if invalid.
        // The method then returns an empty string if valid, or error message if invalid.
        private string verifyGender(string errorMessage)
        {
            if (string.IsNullOrEmpty(gender))
            {
                errorMessage += "Please select a gender\n";
            }
            return errorMessage;
        }
        // used to track the gender of the user
        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			gender = "M";
		}
		// used to track the gender of the user
		private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			gender = "F";
		}
		// used to track the gender of the user
		private void preferNotToSayRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			gender = "P";
		}

		// Cancels registration and sends the user back to the login page.
		private void Cancel_Click(object sender, EventArgs e)
		{
			Hide();
			new Login().Show();
		}
	}
}
