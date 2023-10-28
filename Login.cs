namespace Assignment2test1
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

        // When the user clicks on the submit button validations are done to see if all the required details are entered.
        // A linq query, based on the textbox entries by the user is used to traverse through the list of customers initialized from the HealthDB database
		// A check is done for the credentials match. If the credentials are matched, the dashboard is shown.
        // If the login is not successful an error message box is shown and prompts the user to reenter their details.
        private void submit_Click(object sender, EventArgs e)
		{
			Customer newCustomer;
			using (var context = new HealthContext())
			{
				newCustomer = context.Customers.FirstOrDefault(c => c.email == userNameEntry.Text && c.password == passwordEntry.Text);
			}
			if (newCustomer != null)
			{
				Hide();
				new DashBoard(newCustomer).Show();
			}
			else
			{
				MessageBox.Show("Incorrect email or password.", "Error", MessageBoxButtons.OK);
				userNameEntry.Clear();
				passwordEntry.Clear();
				userNameEntry.Focus();
			}
		}
			
		// Displays the Registration form when the signup button is clicked.
		// This is achieved by hiding the login form and displaying the registration form.
		private void signUp_Click(object sender, EventArgs e)
		{
			Hide();
			new Registration().Show();
		}
	}
}

