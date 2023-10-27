using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;

namespace Assignment2test1
{

	public partial class Modify : Form
	{
		Customer loggedInCustomer;
		public Modify(Customer loggedInCustomer)
		{
            InitializeComponent();
            this.loggedInCustomer = loggedInCustomer;
            FN.Text = loggedInCustomer.firstName;
            LN.Text = loggedInCustomer.lastName;
            Email.Text = loggedInCustomer.email;
            phone.Text = loggedInCustomer.phoneNumber;
            Add.Text = loggedInCustomer.address;
            Password.Text = loggedInCustomer.password;
            RepeatPassword.Text = loggedInCustomer.password;
            gender.Text = loggedInCustomer.gender;
            heartAttackCheckBox.Checked = loggedInCustomer.heartAttack;
            diabetesCheckBox.Checked = loggedInCustomer.diabetes;
            chronicDiseaseCheckBox.Checked = loggedInCustomer.chronicDisease;
            otherCheckBox.Checked = loggedInCustomer.other;
        }

        // Verifies that all the text boxes have valid inputs by checking if an error message was generated (shows the message if true).
        // If validated successfully, the details of the customer are modified and changes are saved to the database, then the user is returned to the dashboard.
        private void submit_Click(object sender, EventArgs e)
        {
            string errorMessage = verifyAll();

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                loggedInCustomer.phoneNumber = phone.Text;
                loggedInCustomer.address = Add.Text;
                loggedInCustomer.password = Password.Text;
                loggedInCustomer.heartAttack = heartAttackCheckBox.Checked;
                loggedInCustomer.diabetes = diabetesCheckBox.Checked;
                loggedInCustomer.chronicDisease = chronicDiseaseCheckBox.Checked;
                loggedInCustomer.other = otherCheckBox.Checked;
                utility.updateCustomer(loggedInCustomer);
                Close();
                new DashBoard(loggedInCustomer).Show();
            }
        }

        //Calls all the verification methods in one method, returns an error message (will be blank if verified successfully).
        private string verifyAll()
        {
            string errorMessage = "";
            errorMessage = verifyPhone(errorMessage);
            errorMessage = verifyAddress(errorMessage);
            errorMessage = verifyPassword(errorMessage);
            return errorMessage;
        }

        // The method is used to verify the phone number of a user.
        // When called, a method from the utility class is used to validate the phone number, adding an error message to the string if invalid.
        // A second check is completed to ensure the user does not leave the textBox blank, also adding an error message to the string if invalid.
        // The method then returns an empty string if valid, or error message if invalid.
        private string verifyPhone(string errorMessage)
        {
            if (utility.phoneValidation(phone.Text) == false || utility.phoneValidation1(phone.Text) == false)
            {
                errorMessage += "Please enter a valid phone number\n";
                phone.Text = loggedInCustomer.phoneNumber;
            }
            else if (string.IsNullOrEmpty(phone.Text))
            {
                errorMessage += "Please fill in your phone number\n";
                phone.Text = loggedInCustomer.phoneNumber;
            }
            return errorMessage;
        }

        // The method is used to verify the address of a user.
        // When called, a check is completed to ensure the user does not leave the textBox blank, adding an error message to the string if invalid.
        // The method then returns an empty string if valid, or error message if invalid.
        private string verifyAddress(string errorMessage)
        {
            if (string.IsNullOrEmpty(Add.Text))
            {
                errorMessage += "Please fill in your address\n";
                Add.Text = loggedInCustomer.address;
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
            if (string.IsNullOrEmpty(Password.Text))
            {
                errorMessage += "Please fill in your password\n";
                Password.Text = loggedInCustomer.password;
            }
            else if (utility.isPasswordValid(Password.Text) == false)
            {
                errorMessage += "Please fill a valid password\n";
                Password.Text = loggedInCustomer.password;
            }
            else if (Password.Text != RepeatPassword.Text)
            {
                errorMessage += "Reenter passwords. They are not matching\n";
                Password.Text = loggedInCustomer.password;
                RepeatPassword.Text = loggedInCustomer.password;
            }
            return errorMessage;
        }

        // Cancels registration and sends the user back to the dashboard.
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new DashBoard(loggedInCustomer).Show();
        }
    }
}



