namespace Assignment2test1
{
	public partial class ResponseForm : Form
	{
		List<Customer> listOfCustomers = new List<Customer>();
		Customer loggedInCustomer;
		public TextBox ResponseText;
		// This function loads the post the user is typing a response for
		public ResponseForm(Post inputPost)
		{
			InitializeComponent();
			richTextBox1.Text = inputPost.post;

			// creates a text box for the user type their response
			TextBox ResponseText = new TextBox()
			{
				Multiline = true,
				Dock = DockStyle.Fill
			};
			this.Controls.Add(ResponseText);
		}
		// This function is used to save the response of the user 
		public string replyString
		{
			get { return ResponseText.Text; }
			set { ResponseText.Text = value; }
		}
		// This function submits the reply form and ensures the response text box is not blank
		private void SubmitButton_Click(object sender, EventArgs e)
		{
			if (ResponseText.Text != "")
			{
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show("Please type a reply", "Error", MessageBoxButtons.OK);
			}

		}
		// This function takes the user back to the community forum page
		private void cancel_Click(object sender, EventArgs e)
		{
			Hide();
			new CommunityForum(loggedInCustomer);
		}
	}
}
