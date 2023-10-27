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
			richTextBox1 = new RichTextBox();
			post = new Label();
			cancel = new Button();
			SuspendLayout();
			// 
			// ResponseText
			// 
			ResponseText.Location = new Point(210, 226);
			ResponseText.Multiline = true;
			ResponseText.Name = "ResponseText";
			ResponseText.Size = new Size(338, 76);
			ResponseText.TabIndex = 0;
			// 
			// SubmitButton
			// 
			SubmitButton.Location = new Point(696, 402);
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
			label1.Location = new Point(319, 199);
			label1.Name = "label1";
			label1.Size = new Size(93, 15);
			label1.TabIndex = 2;
			label1.Text = "Type a Response";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(324, 8);
			label2.Name = "label2";
			label2.Size = new Size(92, 15);
			label2.TabIndex = 3;
			label2.Text = "Response Form";
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(222, 65);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(312, 96);
			richTextBox1.TabIndex = 4;
			richTextBox1.Text = "";
			// 
			// post
			// 
			post.AutoSize = true;
			post.Location = new Point(355, 37);
			post.Name = "post";
			post.Size = new Size(30, 15);
			post.TabIndex = 5;
			post.Text = "Post";
			// 
			// cancel
			// 
			cancel.Location = new Point(60, 402);
			cancel.Name = "cancel";
			cancel.Size = new Size(75, 23);
			cancel.TabIndex = 6;
			cancel.Text = "Cancel";
			cancel.UseVisualStyleBackColor = true;
			cancel.Click += cancel_Click;
			// 
			// ResponseForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 450);
			Controls.Add(cancel);
			Controls.Add(post);
			Controls.Add(richTextBox1);
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
		private RichTextBox richTextBox1;
		private Label post;
		private Button cancel;
	}
}