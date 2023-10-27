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
		public DashBoard(Customer loggedInCustomer)
		{
			InitializeComponent();
			this.loggedInCustomer = loggedInCustomer;
		}
		public void DashBoard_Load(object sender, EventArgs e)
		{
			Title.Text = "Welcome " + loggedInCustomer.firstName;
		}

		private void communityForum_Click(object sender, EventArgs e)
		{
			Hide();
			new CommunityForum(loggedInCustomer).Show();
		}

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

					// Add links to the LinkLabel. Maximum of 15 articles
					for (int i = 0; i < 15; i++)
					{
						var article = articles[i];
						var title = article["title"].ToString();
						var url = article["url"].ToString();
						index = newsLinkLabel.Text.Length;
						var fullTitle = (i+1).ToString()+" "+title + Environment.NewLine;
						newsLinkLabel.Text +=fullTitle;
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

		private void logout_Click(object sender, EventArgs e)
		{
			Hide();
			new Login().Show();

		}

		private void submit_Click(object sender, EventArgs e)
		{
			Hide();
			new Modify(loggedInCustomer).Show();
		}

		private void healthGoal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new HealthGoalsForm(loggedInCustomer).ShowDialog();
		}

		private void healthMetrics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new HealthMetrics(loggedInCustomer).ShowDialog();
		}

		private void nutritionInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new NutritionInformation(loggedInCustomer).ShowDialog();
		}

		private void modifyDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			new Modify(loggedInCustomer).Show();
		}

		private void SDGInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string url = "https://sdgs.un.org/goals";
			System.Diagnostics.Process.Start("cmd", $"/c start {url}");
		}
	}
}


