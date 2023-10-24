using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System;



namespace Assignment2test1
{
	public partial class DashBoard : Form
	{
		Customer loggedInCustomer;
		List<Customer> listOfCustomers = new List<Customer>();
		public DashBoard(Customer loggedInCustomer, List<Customer> listOfCustomers)
		{
			InitializeComponent();
			this.loggedInCustomer = loggedInCustomer;
			this.listOfCustomers = listOfCustomers;
		}
		public void DashBoard_Load(object sender, EventArgs e)
		{
			Title.Text = "Welcome " + loggedInCustomer.firstName;
		}

		private void communityForum_Click(object sender, EventArgs e)
		{
			Hide();
			new CommunityForum(loggedInCustomer, listOfCustomers).Show();
		}

		private async void getNews_Click(object sender, EventArgs e)
		{
			// Make the API request
			var apiUrl = "";
						
			HttpClient httpClient = new HttpClient();
			apiUrl = "https://newsapi.org/v2/top-headlines?category=health&country=au&apiKey=05fe7d29319f482285ce009395d39604";
			
			// Set the User-Agent header to simulate a web browser request
			httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
			// Clear existing links
			newsLinkLabel.Links.Clear();
			using HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
			// Clear existing links
			newsLinkLabel.Links.Clear();
			try
				{
					if (response.IsSuccessStatusCode)
					{
						var responseContent = await response.Content.ReadAsStringAsync();

						// Parse the JSON response
						JObject responseData = JObject.Parse(responseContent);

						// Extract the articles
						JArray articles = responseData["articles"] as JArray;
					newsLinkLabel.Text = "";

					

						// Add links to the LinkLabel
						for (int i = 0; i < 10; i++)
						{
							var article = articles[i];
							var title = article["title"].ToString();
							var url = article["url"].ToString();

							// Ensure that the title length does not exceed the maximum allowable length
							if (title.Length > Int32.MaxValue)
							{
								title = title.Substring(0, (int)Int32.MaxValue); // Truncate the title if it's too long
							}

							int startIndex = newsLinkLabel.Text.Length;
							var fullTitle = (i+1).ToString()+" "+title + Environment.NewLine;
							newsLinkLabel.Text +=fullTitle;

							// Check if the calculated parameters will not result in an overflow
							if ((startIndex >= 0) && (fullTitle.Length >= 0) && (url.Length >= 0))
							{
								newsLinkLabel.Links.Add(startIndex, fullTitle.Length, url);
							}
							else
							{
								// Handle the case where parameters are too large
								MessageBox.Show("The link parameters are too large to add to the LinkLabel.");
							}
							response.Content.Dispose();
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

		private void NewsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string url = e.Link.LinkData as string;
			if (Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
			{
				//System.Diagnostics.Process.Start(uriResult.ToString());
				System.Diagnostics.Process.Start("cmd", $"/c start {uriResult.ToString()}");
			}
			else
			{
				// Handle the case where the URL is not a well-formed HTTP or HTTPS URL
				MessageBox.Show("Invalid or unsupported URL.");
			}
		}

		private void logout_Click(object sender, EventArgs e)
		{
			Hide();
			new Login().Show();

		}

		private void submit_Click(object sender, EventArgs e)
		{
			Hide();
			new Modify(loggedInCustomer, listOfCustomers).Show();
		}

		private void healthGoal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			new HealthGoalsForm().Show();
		}

		private void healthMetrics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			new HealthMetrics().Show();
		}

		private void nutritionInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Hide(); 
			new NutritionInformation().Show();
		}

		private void modifyDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			new Modify(loggedInCustomer, listOfCustomers).Show();
		}

		private void SDGInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string url = "https://sdgs.un.org/goals";
			System.Diagnostics.Process.Start("cmd", $"/c start {url}");
		}
	}
}


