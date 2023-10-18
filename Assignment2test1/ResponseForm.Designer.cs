namespace Assignment2test1
{
	partial class ResponseForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ResponseText = new TextBox();
			SuspendLayout();
			// 
			// ResponseText
			// 
			ResponseText.Location = new Point(286, 57);
			ResponseText.Name = "ResponseText";
			ResponseText.Size = new Size(100, 23);
			ResponseText.TabIndex = 0;
			// 
			// ResponseForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(ResponseText);
			Name = "ResponseForm";
			Text = "ResponseForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox ResponseText;
	}
}