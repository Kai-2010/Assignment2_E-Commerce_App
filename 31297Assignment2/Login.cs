using System;
using System.Windows.Forms;
using System.IO;

namespace _31297Assignment2
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			int userType = 0;
			int ID = 0;
			bool loginSuccessful = false;
			string[] loginCredentials = readLoginFile();
			for (int i = 0; i < loginCredentials.Length; i++)
			{
				string loginCredential = loginCredentials[i];
				string[] separator = { "|", " " };
				string[] login = loginCredential.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				if (textBox1.Text == login[0] && textBox2.Text == login[1])
				{
					userType = int.Parse(login[2]);
					ID = Convert.ToInt32(login[0]);
					loginSuccessful = true;
				}
			}

			if (loginSuccessful)
			{
				MessageBox.Show("Success", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else 
			{ 
				MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		public static string[] readLoginFile()
		{

			string[] loginFile = System.IO.File.ReadAllLines("login.txt");
			return loginFile;
		}
	}
}
