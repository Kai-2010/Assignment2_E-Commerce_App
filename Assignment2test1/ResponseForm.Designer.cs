namespace Assignment2test1
{
	partial class ResponseForm
	{
		// Required designer variable.
		private System.ComponentModel.IContainer components = null;

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
			SubmitButton = new Button();
			SuspendLayout();
			// 
			// ResponseText
			// 
			ResponseText.Location = new Point(286, 57);
			ResponseText.Name = "ResponseText";
			ResponseText.Size = new Size(100, 23);
			ResponseText.TabIndex = 0;
			//ResponseText.TextChanged += ResponseText_TextChanged;
			// 
			// SubmitButton
			// 
			SubmitButton.Location = new Point(339, 150);
			SubmitButton.Name = "SubmitButton";
			SubmitButton.Size = new Size(75, 23);
			SubmitButton.TabIndex = 1;
			SubmitButton.Text = "Submit";
			SubmitButton.UseVisualStyleBackColor = true;
			SubmitButton.Click += SubmitButton_Click;
			// 
			// ResponseForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(SubmitButton);
			Controls.Add(ResponseText);
			Name = "ResponseForm";
			Text = "ResponseForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button SubmitButton;
	}
}