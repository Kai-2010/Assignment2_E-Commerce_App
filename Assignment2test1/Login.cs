using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Collections.Generic;

namespace Assignment2test1
{
	public partial class Login : Form
	{
		List<Customer> listOfCustomers = new List<Customer>();
		Customer newCustomer = new Customer();
		public Login()
		{
			InitializeComponent();
		}

		public void Login_Load(object sender, EventArgs e)
		{
			string[] customerFile = utility.readLoginFile();
			for (int ii = 0; ii < customerFile.Length; ii++)
			{
				string[] personalDetails = customerFile[ii].Split('|');
				listOfCustomers.Add(new Customer(personalDetails[0], personalDetails[1], personalDetails[2], personalDetails[3], personalDetails[4], personalDetails[5], personalDetails[6], personalDetails[7], personalDetails[8], personalDetails[9], personalDetails[10]));
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool loginSuccessful = false;
			Customer newCustomer = new Customer();
			for (int i = 0; i < listOfCustomers.Count; i++)
			{
				if (textBox1.Text == listOfCustomers[i].email && textBox2.Text == listOfCustomers[i].password)
				{
					loginSuccessful = true;
					newCustomer = listOfCustomers[i];
					break;
				}
			}

			if (loginSuccessful)
			{
				Hide();
				new DashBoard(newCustomer, listOfCustomers).Show();
			}
			else
			{
				MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK);
				textBox1.Clear();
				textBox2.Clear();
				textBox1.Focus();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Hide();
			new Registration(listOfCustomers).Show();
		}
	}
}

