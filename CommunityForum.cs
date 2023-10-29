namespace Assignment2test1
{
	public partial class CommunityForum : Form
	{
		Customer loggedInCustomer;
		List<Post> postsAndReplies = new List<Post>();

		public CommunityForum(Customer loggedInCustomer)
		{
			InitializeComponent();
			this.loggedInCustomer = loggedInCustomer;
		}
		// When the form loads, the list of previously saved posts are read from a text file along with the replies and added to a List
		// Each of the post is added to a new textbox
		// A flow panel layout is used to ensure the textboxes are dynamic and based on the number of posts
		public void posts_Load(object sender, EventArgs e)
		{
			//Each line in the file has the post and related replies
			string[] posts = utility.readPosts();
			string replyBoxText = "";
			
			for (int i = 0; i < posts.Length; i++)
			{
				replyBoxText = "";
				postsAndReplies.Add(new Post(posts[i]));

				// Add a TextBox for the post
				TextBox postBox = new TextBox()
				{
					Multiline = true,
					ScrollBars = ScrollBars.Vertical,
					Width = 200,
					Height = 60
				};

				if (postsAndReplies.Count > 0)
				{
					postBox.Text = postsAndReplies[i].post;
				}
				else
				{
					postBox.Text = "";
				}

				flowLayoutPanel1.Controls.Add(postBox);

				//Add a TextBox for the replies of the post
				TextBox replyBox = new TextBox
				{
					Multiline = true,
					ScrollBars = ScrollBars.Vertical,
					Width = 500,
					Height = 60
				};
				// For each post, checking there are replies and add it to the text box
				for (int ii = 0; ii < postsAndReplies[i].replies.Count; ii++)
				{
					replyBoxText = replyBoxText + (ii + 1).ToString() + ". " + postsAndReplies[i].replies[ii] + Environment.NewLine;
				}
					replyBox.Text = replyBoxText;
					replyBox.Dock = DockStyle.Fill;
					flowLayoutPanel1.Controls.Add(replyBox);
				
				// Add a "Reply" button for each post and set the tag for the same
				Button replyButton = new Button();
				replyButton.Text = "Reply";
				replyButton.Tag = i;
				replyButton.Click += ReplyButton_Click;
				flowLayoutPanel1.Controls.Add(replyButton);
			}
		}

		// Allows the user add their reply to a post
		private void ReplyButton_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;
			int postIndex = (int)clickedButton.Tag;
			List<string> contentToSave = new List<string>();
			string contentToSaveString = "";
			// Open a dialog for composing the reply
			using (ResponseForm responseForm = new ResponseForm(postsAndReplies[postIndex]))
			{
				if (responseForm.ShowDialog() == DialogResult.OK)
				{
					// Get the reply text from the response Form
					string replyText = responseForm.replyString;
					
						// The reply is appended the list created at the time of loading the form
						// The List is then saved to the text file with a pipe separator
						// The user is redirected to the dashboard
						postsAndReplies[postIndex].replies.Add(replyText);

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
						File.WriteAllLines("post.txt", contentToSave);
						Hide();
						new DashBoard(loggedInCustomer).Show();
				}
			}
		}
		// The method takes the user to the new page where where they can add a new post
		private void newPost_Click_1(object sender, EventArgs e)
		{
			Hide();
			new PostForm(loggedInCustomer, postsAndReplies).Show();
		}

		// When the Cancel button is clicked, this method takes the user back to the dashboard
		private void Cancel_Click_1(object sender, EventArgs e)
		{
			Hide();
			new DashBoard(loggedInCustomer).Show();
		}
	}
}
