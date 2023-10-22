using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;



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
            label5.Text = "Welcome " + loggedInCustomer.firstName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new CommunityForum(loggedInCustomer).Show();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            // Make the API request
            var apiUrl = "";
            apiUrl = "https://newsapi.org/v2/everything?q=bitcoin&apiKey=05fe7d29319f482285ce009395d39604";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();

                        // Parse the JSON response
                        JObject responseData = JObject.Parse(responseContent);

                        // Extract the articles
                        JArray articles = responseData["articles"] as JArray;

                        // Clear existing links
                        linkLabel1.Links.Clear();

                        // Add links to the LinkLabel
                        for (int i = 0; i < 3; i++)
                        {
                            var article = articles[i];
                            var title = article["title"].ToString();
                            var url = article["url"].ToString();

                            // Ensure that the title length does not exceed the maximum allowable length
                            if (title.Length > Int32.MaxValue)
                            {
                                title = title.Substring(0, (int)Int32.MaxValue); // Truncate the title if it's too long
                            }

                            int startIndex = linkLabel1.Text.Length;
                            var fullTitle = title + Environment.NewLine;
                            linkLabel1.Text += fullTitle;

                            // Check if the calculated parameters will not result in an overflow
                            if ((startIndex >= 0) && (fullTitle.Length >= 0) && (url.Length >= 0))
                            {
                                linkLabel1.Links.Add(startIndex, fullTitle.Length, url);
                            }
                            else
                            {
                                // Handle the case where parameters are too large
                                MessageBox.Show("The link parameters are too large to add to the LinkLabel.");
                            }
                        }
                    }
                    else
                    {
                        linkLabel1.Text = "Failed to retrieve news data.";
                    }
                }
                catch (HttpRequestException)
                {
                    linkLabel1.Text = "Network error. Unable to connect to the API.";
                }
            }
        }

        private void NewsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                System.Diagnostics.Process.Start(uriResult.ToString());
            }
            else
            {
                // Handle the case where the URL is not a well-formed HTTP or HTTPS URL
                MessageBox.Show("Invalid or unsupported URL.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            new Modify(loggedInCustomer, listOfCustomers).Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new HealthGoalsForm(loggedInCustomer).ShowDialog();
            Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new HealthMetrics(loggedInCustomer).ShowDialog();
            Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide(); ;
            new NutritionInformation(loggedInCustomer).ShowDialog();
            Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Modify(loggedInCustomer, listOfCustomers).Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://sdgs.un.org/goals";
            System.Diagnostics.Process.Start("cmd", $"/c start {url}");
        }
    }
}


