using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Assignment2test1
{

	public partial class PostForm : Form
	{
		string post;
		Customer loggedInCustomer;
		List<Customer> listOfCustomers = new List<Customer>();
		public PostForm(Customer loggedInCustomer)
		{
			InitializeComponent();
			this.loggedInCustomer = loggedInCustomer;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			post = textBox1.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			System.IO.File.AppendAllText(string.Format("post - Copy - Copy.txt"), (string.Format("\n"+post)));
			DialogResult dialogResult = MessageBox.Show("Post something else", "Post Content", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				textBox1.Clear();
				textBox1.Focus();
				post = textBox1.Text;
			}
			else
			{
				this.Close();
				new DashBoard(loggedInCustomer,listOfCustomers).Show();
			}
		}

		private void Form6_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
			new CommunityForum(loggedInCustomer, listOfCustomers).Show();
		}

		private void PostForm_Load(object sender, EventArgs e)
		{

		}
	}
}
