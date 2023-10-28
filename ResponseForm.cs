

namespace Assignment2test1
{
	public partial class ResponseForm : Form
	{
		List<Customer> listOfCustomers = new List<Customer>();
		Customer loggedInCustomer;
		public TextBox ResponseText;

		public ResponseForm(Post inputPost)
		{
			InitializeComponent();
			richTextBox1.Text = inputPost.post;

			// Create and configure the TextBox for user input
			TextBox ResponseText = new TextBox()
			{
				Multiline = true,
				Dock = DockStyle.Fill
			};
			this.Controls.Add(ResponseText);
		}

		public string replyString
		{
			get { return ResponseText.Text; }
			set { ResponseText.Text = value; }
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			// Handle the submission of the reply here
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

		private void cancel_Click(object sender, EventArgs e)
		{
			Hide();
			new CommunityForum(loggedInCustomer);
		}
	}
}
