using Newtonsoft.Json.Linq;
namespace Assignment2test1
{
    public partial class DashBoard : Form
    {
        Customer loggedInCustomer;
        
        public DashBoard(Customer loggedInCustomer)
        {
            InitializeComponent();
            this.loggedInCustomer = loggedInCustomer;
        }

        public void DashBoard_Load(object sender, EventArgs e)
        {
            Title.Text = "Welcome " + loggedInCustomer.firstName;
        }

        //Invokes the Community Forum form where posts and replies are displayed
        private void communityForum_Click(object sender, EventArgs e)
        {
            Hide();
            new CommunityForum(loggedInCustomer).Show();
        }
		//Invokes the API from newsapi.org from which top 15 headlines about health for australia is displayed
        //AN API Key is passed as a parameter in the API call. The API is called over https.
        //I had signed up on newsapi.org to get the API Key that i am using in the api call
		private async void getNews_Click(object sender, EventArgs e)
        {
            var apiUrl = "";
            int index = 0;
            // Make the API request
            HttpClient httpClient = new HttpClient();
            apiUrl = "https://newsapi.org/v2/top-headlines?category=health&country=au&apiKey=05fe7d29319f482285ce009395d39604";

            // Set the User-Agent header to simulate a web browser request
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            // Clear existing links
            newsLinkLabel.Links.Clear();
            using HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            try
            {
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    JObject responseData = JObject.Parse(responseContent);
                    var articles = responseData["articles"];
                    newsLinkLabel.Text = "";

                    // Add links to the LinkLabel. Maximum of 15 articles being displayed on the screen
                    for (int i = 0; i < 15; i++)
                    {
                        var article = articles[i];
                        var title = article["title"].ToString();
                        var url = article["url"].ToString();
                        index = newsLinkLabel.Text.Length;
                        var fullTitle = (i + 1).ToString() + " " + title + Environment.NewLine;
                        newsLinkLabel.Text += fullTitle;
                        newsLinkLabel.Links.Add(index, fullTitle.Length, url);
                    }
                }
                else
                {
                    newsLinkLabel.Text = "Failed to retrieve news data.";
                }
            }
            catch (HttpRequestException)
            {
                newsLinkLabel.Text = "Network error. Unable to connect to the API.";
            }
        }

        //This is invoked when a link in the above results is clicked by the user. If the link is a valid and well formed url, the link is opened up 
        private void NewsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            Boolean createUrl = Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult);
            if ((uriResult.Scheme == Uri.UriSchemeHttps || uriResult.Scheme == Uri.UriSchemeHttp) && createUrl == true)
            {
                System.Diagnostics.Process.Start("cmd", $"/c start {uriResult}");
            }
            else
            {
                // Handle the case where the URL is not a well-formed HTTP or HTTPS URL
                MessageBox.Show("Invalid or unsupported URL.");
            }
        }

		// This function takes teh user back to the login page
		private void logout_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();

        }
		// This function takes the user to the health goal page
		private void healthGoal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new HealthGoalsForm(loggedInCustomer).ShowDialog();
        }
		// This function takes the user to the health metrics page
		private void healthMetrics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new HealthMetrics(loggedInCustomer).ShowDialog();
        }
		// This function takes the user to the nutrition page
		private void nutritionInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new NutritionInformation(loggedInCustomer).ShowDialog();
        }

		// This function takes the user to the modify page
		private void modifyDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Modify(loggedInCustomer).Show();
        }
		// This function opens a url to display health information
		private void SDGInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://sdgs.un.org/goals";
            System.Diagnostics.Process.Start("cmd", $"/c start {url}");
        }
		// This function takes the user with health graphs
		private void HealthGraph_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new HealthGraphs(loggedInCustomer).ShowDialog();
        }
    }
}


