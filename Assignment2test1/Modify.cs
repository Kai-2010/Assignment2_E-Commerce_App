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
			textBox1.Text = loggedInCustomer.firstName;
			textBox2.Text = loggedInCustomer.lastName;
			textBox3.Text = loggedInCustomer.email;
			textBox4.Text = loggedInCustomer.phoneNumber;
			textBox5.Text = loggedInCustomer.address;
			textBox6.Text = loggedInCustomer.password;
			textBox7.Text = loggedInCustomer.password;
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.firstName = textBox1.Text;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.lastName = textBox2.Text;

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.email = textBox3.Text;

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.phoneNumber = textBox4.Text;

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.address = textBox5.Text;
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			loggedInCustomer.password = textBox6.Text;

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{
			repeatPassword = textBox7.Text;

		}
		private void textBox4_Leave(object sender, EventArgs e)
		{
			if (utility.phoneValidation(textBox4.Text) == false || utility.phoneValidation1(textBox4.Text) == false)
			{
				MessageBox.Show("Please enter a valid phone number");
				textBox4.Clear();
				textBox4.Focus();
			}
			else if (string.IsNullOrEmpty(textBox4.Text) == true)
			{
				MessageBox.Show("Please fill in your phone number");
				textBox4.Clear();
				textBox4.Focus();
			}
			else
			{
				loggedInCustomer.phoneNumber = textBox4.Text;
			}
		}
		private void textBox5_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox5.Text) == true)
			{
				MessageBox.Show("Please fill in your address");
				textBox5.Clear();
				textBox5.Focus();
			}
			else
			{
				loggedInCustomer.address = textBox5.Text;
			}
		}
		private void textBox6_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox6.Text) == true)
			{
				MessageBox.Show("Please fill in your password");
				textBox6.Clear();
				textBox6.Focus();
			}
			else if (utility.isPasswordValid(password) == false)
			{
				MessageBox.Show("Please fill a valid password");
				textBox6.Clear();
				textBox6.Focus();
			}
			else
			{
				loggedInCustomer.password = textBox6.Text;
			}
		}
		private void textBox7_Leave(object sender, EventArgs e)
		{
			if (textBox6.Text != textBox7.Text)
			{
				MessageBox.Show("Reenter passwords. They are not matching");
				textBox6.Clear();
				textBox7.Clear();
				textBox6.Focus();
			}
			else
			{
				repeatPassword = textBox7.Text;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox6.Text != textBox7.Text)
			{
				MessageBox.Show("Reenter passwords. They are not matching");
				textBox6.Clear();
				textBox7.Clear();
				textBox6.Focus();
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



