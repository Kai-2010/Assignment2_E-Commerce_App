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
		Customer loggedInCustomer;
		List<Customer> listOfCustomers = new List<Customer>();
		List<Post> postsAndReplies = new List<Post>();
		Post newPost = new Post();
		public PostForm(Customer loggedInCustomer, List<Post> postsAndReplies)
		{
			InitializeComponent();
			this.loggedInCustomer = loggedInCustomer;
			this.postsAndReplies= postsAndReplies;
		}

		private void post_TextChanged(object sender, EventArgs e)
		{
			newPost.post = postBox.Text;
		}

		private void post_Click(object sender, EventArgs e)
		{
			string contentToSaveString = "";
			List<string> contentToSave = new List<string>();
			//System.IO.File.AppendAllText(string.Format("post - Copy - Copy.txt"), (string.Format("\n"+post)));
			postsAndReplies.Add(newPost);
			for (int ii = 0; ii < postsAndReplies.Count; ii++)
			{
				contentToSaveString = "";
				contentToSaveString = contentToSaveString + postsAndReplies[ii].post;
				for (int iii = 0; iii < postsAndReplies[ii].replies.Count; iii++)
				{
					contentToSaveString = contentToSaveString + "|" + postsAndReplies[ii].replies[iii];
				}
				contentToSave.Add(contentToSaveString);	
			}
			File.WriteAllLines("post - Copy - Copy.txt",contentToSave);
			DialogResult dialogResult = MessageBox.Show("Post something else", "Post Content", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				postBox.Clear();
				postBox.Focus();
				newPost.post = postBox.Text;
			}
			else
			{
				Hide();
				new DashBoard(loggedInCustomer,listOfCustomers).Show();
			}
		}

		

		private void Cancel_Click(object sender, EventArgs e)
		{
			Hide();
			new CommunityForum(loggedInCustomer, listOfCustomers).Show();
		}

		private void PostForm_Load(object sender, EventArgs e)
		{

		}
	}
}
