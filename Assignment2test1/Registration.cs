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
		string firstName;
		string lastName;
		string address;
		string email;
		string phoneNumber;
		string sex;
		string password;
		string repeatPassword;

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

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			lastName = textBox2.Text;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			firstName = textBox1.Text;

		}
		
		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (validateInput)
			{
				if (utility.isNameValid(textBox1.Text) == false)
				{
					MessageBox.Show("Please enter a valid First Name");
					textBox1.Clear();
					textBox1.Focus();

				}
				else if (string.IsNullOrEmpty(textBox1.Text) == true)
				{

					MessageBox.Show("Please fill in your First Name");
					textBox1.Clear();
					textBox1.Focus();
				}
				else
				{
					firstName = textBox1.Text;
				}
			}
		}
		private void textBox2_Leave(object sender, EventArgs e)
		{
			if (utility.isNameValid(textBox2.Text) == false)
			{
				MessageBox.Show("Please enter a valid Last Name");
				textBox2.Clear();
				textBox2.Focus();

			}
			else if (string.IsNullOrEmpty(textBox1.Text) == true)
			{

				MessageBox.Show("Please fill in your Last Name");
				textBox2.Clear();
				textBox2.Focus();
			}
			else
			{
				lastName = textBox2.Text;
			}
		}
		private void textBox3_Leave(object sender, EventArgs e)
		{
			if (utility.isEmailValid(textBox3.Text) == false)
			{
				MessageBox.Show("Please enter a valid email");
				textBox3.Clear();
				textBox3.Focus();
			}
			else if (string.IsNullOrEmpty(textBox3.Text) == true)
			{
				MessageBox.Show("Please fill in your email");
				textBox3.Clear();
				textBox3.Focus();
			}
			else
			{
				email = textBox3.Text;
			}
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
				phoneNumber = textBox4.Text;
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
				address = textBox5.Text;
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
				password = textBox6.Text;
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
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			email = textBox3.Text;
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			phoneNumber = textBox4.Text;
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			address = textBox5.Text;
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
				if (listOfCustomers.Any(Customer => Customer.email == email) == true)
				{
					MessageBox.Show("Email Id is not available", "Please enter another email Id", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					textBox3.Clear();
					textBox3.Focus();
				}
				else
				{
					Customer newCustomer = new Customer(email, password, firstName, lastName, address, phoneNumber, sex);
					listOfCustomers.Add(newCustomer);
					utility.saveCustomerDetails(listOfCustomers);
					MessageBox.Show("New Customer created successfully", $"Your Login ID is : {email}", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					this.Close();
					new Login().Show();
				}

			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			sex = "M";
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			sex = "F";
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			sex = "P";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			password = textBox6.Text;
		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{
			repeatPassword = textBox7.Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			validateInput = false;
			this.Close();
			new Login().Show();
		}
	}
}
