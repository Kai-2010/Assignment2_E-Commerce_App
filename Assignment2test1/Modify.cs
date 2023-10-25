using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            gender.Text = loggedInCustomer.sex;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string errorMessage = verifyAll();
            Customer customer;

            using (var context = new HealthContext())
            {
                customer = context.Customers.FirstOrDefault(c => c.email == Email.Text);
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
            }
            else if (customer != null && Email.Text != loggedInCustomer.email)
            {
                MessageBox.Show("Email Id is not available", "Please enter another email Id", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Email.Text = loggedInCustomer.email;
                Email.Focus();
            }
            else
            {
                loggedInCustomer.email = Email.Text;
                loggedInCustomer.phoneNumber = phone.Text;
                loggedInCustomer.address = Add.Text;
                loggedInCustomer.password = Password.Text;
                utility.updateCustomer(loggedInCustomer);
                Close();
                new DashBoard(loggedInCustomer).Show();
            }
        }

        private string verifyAll()
        {
            string errorMessage = "";
            errorMessage = verifyEmail(errorMessage);
            errorMessage = verifyPhone(errorMessage);
            errorMessage = verifyAddress(errorMessage);
            errorMessage = verifyPassword(errorMessage);
            return errorMessage;
        }

        private string verifyEmail(string errorMessage)
        {
            if (utility.isEmailValid(Email.Text) == false)
            {
                errorMessage += "Please enter a valid email\n";
                Email.Text = loggedInCustomer.email;
            }
            else if (string.IsNullOrEmpty(Email.Text))
            {
                errorMessage += "Please fill in your email\n";
                Email.Text = loggedInCustomer.email;
            }
            return errorMessage;
        }

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

        private string verifyAddress(string errorMessage)
        {
            if (string.IsNullOrEmpty(Add.Text))
            {
                errorMessage += "Please fill in your address\n";
                Add.Text = loggedInCustomer.address;
            }
            return errorMessage;
        }

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

        private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
			new DashBoard(loggedInCustomer).Show();
		}
	}
}



