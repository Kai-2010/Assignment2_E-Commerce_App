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
		List<Customer> listOfCustomers = new List<Customer>();
		private bool validateInput = true;

		public Registration(List<Customer> listOfCustomers)
		{
			InitializeComponent();
			this.listOfCustomers = listOfCustomers;

		}

		public void Form2_Load(object sender, EventArgs e)
		{
		}

		private void textBox1_Leave(object sender, EventArgs e)
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
		private void textBox2_Leave(object sender, EventArgs e)
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
		private void textBox3_Leave(object sender, EventArgs e)
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
		private void textBox4_Leave(object sender, EventArgs e)
		{
			if (utility.phoneValidation(phoneNumber.Text) == false || utility.phoneValidation1(phoneNumber.Text) == false)
			{
				MessageBox.Show("Please enter a valid phone number");
				phoneNumber.Clear();
				phoneNumber.Focus();
			}
			else if (string.IsNullOrEmpty(phoneNumber.Text) == true)
			{
				MessageBox.Show("Please fill in your phone number");
				phoneNumber.Clear();
				phoneNumber.Focus();
			}
		}
		private void textBox5_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(address.Text) == true)
			{
				MessageBox.Show("Please fill in your address");
				address.Clear();
				address.Focus();
			}
		}
		private void textBox6_Leave(object sender, EventArgs e)
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
		private void textBox7_Leave(object sender, EventArgs e)
		{
			if (password.Text != repeatPassword.Text)
			{
				MessageBox.Show("Reenter passwords. They are not matching");
				password.Clear();
				repeatPassword.Clear();
				password.Focus();
			}
		}

		private void button1_Click(object sender, EventArgs e)
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
					Customer newCustomer = new Customer(email.Text, password.Text, firstName.Text, lastName.Text, address.Text, phoneNumber.Text, gender);
					listOfCustomers.Add(newCustomer);
					utility.saveCustomerDetails(listOfCustomers);
					MessageBox.Show("New Customer created successfully", $"Your Login ID is : {email.Text}", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					this.Close();
					new Login().Show();
				}

			}
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
			validateInput = false;
			this.Close();
			new Login().Show();
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

	}
}
