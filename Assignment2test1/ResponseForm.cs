using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2test1
{
	public partial class ResponseForm : Form
	{
		public TextBox ResponseText;

		public ResponseForm()
		{
			InitializeComponent();

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
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
