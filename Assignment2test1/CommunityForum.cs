using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace Assignment2test1
{
	public partial class CommunityForum : Form
	{
		Customer loggedInCustomer;
		List<Customer> listOfCustomers = new List<Customer>();
		List<Post> postsAndReplies = new List<Post>();

		public CommunityForum(Customer loggedInCustomer, List<Customer> listOfCustomers)
		{
			InitializeComponent();
			this.loggedInCustomer = loggedInCustomer;
			this.listOfCustomers = listOfCustomers;
		}

		public void posts_Load(object sender, EventArgs e)
		{
			string[] posts = File.ReadAllLines("post - Copy - Copy.txt").ToArray();
			string replyBoxText = "";
			for (int i = 0; i < posts.Length; i++)
			{
				replyBoxText = "";
				postsAndReplies.Add(new Post(posts[i]));

				// Add a TextBox for the post
				TextBox postBox = new TextBox()
				{
					Multiline = true,   // Allow multiple lines of text
					ScrollBars = ScrollBars.Vertical,   // Display vertical scrollbars if needed
					Width = 200,
					Height = 60// Set the desired height
				};

				postBox.Text = postsAndReplies.Count > 0 ? postsAndReplies[i].post : ""; // Display the first reply as post text

				flowLayoutPanel1.Controls.Add(postBox);

				//Add a TextBox for the replies
				TextBox replyBox = new TextBox
				{
					Multiline = true,   // Allow multiple lines of text
					ScrollBars = ScrollBars.Vertical,   // Display vertical scrollbars if needed
					Width = 500,
					Height = 60// Set the desired height
				};

				for (int ii = 0; ii < postsAndReplies[i].replies.Count; ii++)
				{
					replyBoxText = replyBoxText + (ii + 1).ToString() + ". " + postsAndReplies[i].replies[ii] + Environment.NewLine;
				}
				if (replyBoxText.Count() > 0)
				{
					replyBox.Text = replyBoxText;
					flowLayoutPanel1.Controls.Add(replyBox);
				}

				// Add a "Reply" button for each post
				Button replyButton = new Button();
				replyButton.Text = "Reply";
				replyButton.Tag = i;
				replyButton.Click += ReplyButton_Click;
				flowLayoutPanel1.Controls.Add(replyButton);
			}
		}

		private void ReplyButton_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;
			int postIndex = (int)clickedButton.Tag;
			List<string> contentToSave = new List<string>();
			string contentToSaveString = "";
			// Open a dialog for composing a reply
			using (ResponseForm responseForm = new ResponseForm())
			{
				if (responseForm.ShowDialog() == DialogResult.OK)
				{
					// Get the reply text from the response Form
					string replyText = responseForm.replyString;
					// Save the reply text to the appropriate post in the data structure
					postsAndReplies[postIndex].replies.Add(replyText);

					for (int ii = 0; ii < postsAndReplies.Count; ii++)
					{
						contentToSaveString = "";
						contentToSaveString = contentToSaveString + postsAndReplies[ii].post;
						for (int iii = 0; iii < postsAndReplies[ii].replies.Count; iii++)
						{
							contentToSaveString = contentToSaveString + "|" + postsAndReplies[ii].replies[iii];
						}
						contentToSaveString += "\n";
						contentToSave.Add(contentToSaveString);
					}
					File.WriteAllLines("post - Copy - Copy.txt", contentToSave);
					Hide();
					new DashBoard(loggedInCustomer, listOfCustomers).Show();
				}
			}
		}

		private void Submit_Click_1(object sender, EventArgs e)
		{
			Hide();
			this.Close();
			new PostForm(loggedInCustomer, postsAndReplies).Show();
		}

		private void Cancel_Click_1(object sender, EventArgs e)
		{
			Hide();
			this.Close();
			new DashBoard(loggedInCustomer, listOfCustomers).Show();
		}
	}
}
