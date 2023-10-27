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
				new DashBoard(loggedInCustomer).Show();
			}
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			Hide();
			new CommunityForum(loggedInCustomer).Show();
		}
	}
}
