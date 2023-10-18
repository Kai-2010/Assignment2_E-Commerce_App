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
		List<Customer> listOfCustomers = new List<Customer>();
		string firstName;
		string lastName;
		string address;
		string email;
		string phoneNumber;
		int sex;
		string password;
		string repeatPassword;
		Customer loggedInCustomer;
		public Modify(Customer loggedInCustomer, List<Customer> listOfCustomers)
		{
			InitializeComponent();
			this.loggedInCustomer = loggedInCustomer;
			this.listOfCustomers = listOfCustomers;
		}
		private void Modify_Load(object sender, EventArgs e)
		{
			FN.Text = loggedInCustomer.firstName;
			LN.Text = loggedInCustomer.lastName;
			Email.Text = loggedInCustomer.email;
			phone.Text = loggedInCustomer.phoneNumber;
			Add.Text = loggedInCustomer.address;
			Password.Text = loggedInCustomer.password;
			RepeatPassword.Text = loggedInCustomer.password;
			gender.Text = loggedInCustomer.sex;
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.firstName = FN.Text;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.lastName = LN.Text;

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.email = Email.Text;

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.phoneNumber = phone.Text;

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.address = Add.Text;
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.password = Password.Text;

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{
			repeatPassword = RepeatPassword.Text;

		}
		private void textBox4_Leave(object sender, EventArgs e)
		{
			if (utility.phoneValidation(phone.Text) == false || utility.phoneValidation1(phone.Text) == false)
			{
				MessageBox.Show("Please enter a valid phone number");
				phone.Clear();
				phone.Focus();
			}
			else if (string.IsNullOrEmpty(phone.Text) == true)
			{
				MessageBox.Show("Please fill in your phone number");
				phone.Clear();
				phone.Focus();
			}
			else
			{
				loggedInCustomer.phoneNumber = phone.Text;
			}
		}
		private void textBox5_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Add.Text) == true)
			{
				MessageBox.Show("Please fill in your address");
				Add.Clear();
				Add.Focus();
			}
			else
			{
				loggedInCustomer.address = Add.Text;
			}
		}
		private void textBox6_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Password.Text) == true)
			{
				MessageBox.Show("Please fill in your password");
				Password.Clear();
				Password.Focus();
			}
			else if (utility.isPasswordValid(password) == false)
			{
				MessageBox.Show("Please fill a valid password");
				Password.Clear();
				Password.Focus();
			}
			else
			{
				loggedInCustomer.password = Password.Text;
			}
		}
		private void textBox7_Leave(object sender, EventArgs e)
		{
			if (Password.Text != RepeatPassword.Text)
			{
				MessageBox.Show("Reenter passwords. They are not matching");
				Password.Clear();
				RepeatPassword.Clear();
				Password.Focus();
			}
			else
			{
				repeatPassword = RepeatPassword.Text;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (Password.Text != RepeatPassword.Text)
			{
				MessageBox.Show("Reenter passwords. They are not matching");
				Password.Clear();
				RepeatPassword.Clear();
				Password.Focus();
			}
			else
			{
				Customer customerToUpdate = this.listOfCustomers.FirstOrDefault(c => c.email == loggedInCustomer.email);
				if (customerToUpdate != null)
				{
					customerToUpdate.firstName = loggedInCustomer.firstName;
					customerToUpdate.lastName = loggedInCustomer.lastName;
					customerToUpdate.address = loggedInCustomer.address;
					customerToUpdate.phoneNumber = loggedInCustomer.phoneNumber;
					customerToUpdate.password = loggedInCustomer.password;
					customerToUpdate.email = loggedInCustomer.email;
					customerToUpdate.sex = loggedInCustomer.sex;
					utility.saveCustomerDetails(this.listOfCustomers);
				}
			}
		}
	}
}



