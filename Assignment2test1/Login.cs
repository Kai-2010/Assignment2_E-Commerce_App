using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Collections.Generic;

namespace Assignment2test1
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
            Customer customer;
            using (var context = new HealthContext())
            {
                customer = context.Customers.FirstOrDefault(c => c.email == textBox1.Text && c.password == textBox2.Text);
            }
            if (customer != null)
            {
                Hide();
                new DashBoard(customer).Show();
            }
            else
            {
                MessageBox.Show("Incorrect email or password.", "Error", MessageBoxButtons.OK);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Registration().Show();
        }
    }
}

