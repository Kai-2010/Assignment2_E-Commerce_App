using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Assignment2test1
{
	public partial class Registration : Form
	{
		string gender;

		public Registration()
		{
			InitializeComponent();

		}

		public void Form2_Load(object sender, EventArgs e)
		{
		}
        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer;
            using (var context = new HealthContext())
            {
                customer = context.Customers.FirstOrDefault(c => c.email == email.Text);
            }
            string errorMessage = verifyAll();
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
                customer = new Customer(email.Text, password.Text, firstName.Text, lastName.Text, address.Text, phoneNumber.Text, gender, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                MessageBox.Show("New Customer created successfully", $"Your Login ID is : {email.Text}", MessageBoxButtons.OK);
                utility.addCustomer(customer);
                this.Close();
                new Login().Show();
            }
        }

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

        private string verifyFirstName(string errorMessage)
        {
            if (string.IsNullOrEmpty(firstName.Text))
            {
                errorMessage += "Please fill in your first name\n";
                firstName.Clear();
            }
            return errorMessage;
        }

        private string verifyLastName(string errorMessage)
        {
            if (string.IsNullOrEmpty(lastName.Text))
            {
                errorMessage += "Please fill in your last name\n";
                lastName.Clear();
            }
            return errorMessage;
        }

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

        private string verifyAddress(string errorMessage)
        {
            if (string.IsNullOrEmpty(address.Text))
            {
                errorMessage += "Please fill in your address\n";
                address.Clear();
            }
            return errorMessage;
        }

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

        private string verifyGender(string errorMessage)
        {
            if (string.IsNullOrEmpty(gender))
            {
                errorMessage += "Please select a gender\n";
            }
            return errorMessage;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			gender = "M";
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			gender = "F";
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			gender = "P";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
			new Login().Show();
		}
	}
}
