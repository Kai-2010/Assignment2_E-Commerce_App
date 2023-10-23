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
			label1 = new Label();
			label2 = new Label();
			SuspendLayout();
			// 
			// ResponseText
			// 
			ResponseText.Location = new Point(193, 69);
			ResponseText.Multiline = true;
			ResponseText.Name = "ResponseText";
			ResponseText.Size = new Size(338, 76);
			ResponseText.TabIndex = 0;
			// 
			// SubmitButton
			// 
			SubmitButton.Location = new Point(434, 177);
			SubmitButton.Name = "SubmitButton";
			SubmitButton.Size = new Size(75, 23);
			SubmitButton.TabIndex = 1;
			SubmitButton.Text = "Submit";
			SubmitButton.UseVisualStyleBackColor = true;
			SubmitButton.Click += SubmitButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(319, 51);
			label1.Name = "label1";
			label1.Size = new Size(93, 15);
			label1.TabIndex = 2;
			label1.Text = "Type a Response";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(324, 8);
			label2.Name = "label2";
			label2.Size = new Size(88, 15);
			label2.TabIndex = 3;
			label2.Text = "Response Form";
			// 
			// ResponseForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(SubmitButton);
			Controls.Add(ResponseText);
			Name = "ResponseForm";
			Text = "ResponseForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button SubmitButton;
		private Label label1;
		private Label label2;
	}
}