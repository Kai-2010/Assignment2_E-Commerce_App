namespace Assignment2test1
{

	public partial class PostForm : Form
	{
		Customer loggedInCustomer;
		List<Customer> listOfCustomers = new List<Customer>();
		List<Post> postsAndReplies = new List<Post>();
		Post newPost = new Post();
		//The method is invoked on loading the form
		public PostForm(Customer loggedInCustomer, List<Post> postsAndReplies)
		{
			InitializeComponent();
			this.loggedInCustomer = loggedInCustomer;
			this.postsAndReplies= postsAndReplies;
		}
		
		// The method saves the post written by the user to the newPost object
		private void post_TextChanged(object sender, EventArgs e)
		{
			newPost.post = postBox.Text;
		}
		
		// The method saves the post to the postAndReplies List and then saves the same to the "post.txt" file
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
			File.WriteAllLines("post.txt",contentToSave);
			MessageBox.Show("Message successfully posted");
			Hide();
			new DashBoard(loggedInCustomer).Show();
		}

		// The method takes the user back to the community forum page when the user clicks on the cancel button
		private void Cancel_Click(object sender, EventArgs e)
		{
			Hide();
			new CommunityForum(loggedInCustomer).Show();
		}
	}
}
