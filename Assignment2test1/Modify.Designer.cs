namespace Assignment2test1
{
	partial class Modify
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			textBox6 = new TextBox();
			textBox7 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(340, 34);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(340, 63);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 1;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(340, 92);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 2;
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(340, 125);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 23);
			textBox4.TabIndex = 3;
			textBox4.TextChanged += textBox4_TextChanged;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(340, 154);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(100, 23);
			textBox5.TabIndex = 4;
			textBox5.TextChanged += textBox5_TextChanged;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(340, 183);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(100, 23);
			textBox6.TabIndex = 5;
			textBox6.TextChanged += textBox6_TextChanged;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(340, 224);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(100, 23);
			textBox7.TabIndex = 6;
			textBox7.TextChanged += textBox7_TextChanged;
			// 
			// button1
			// 
			button1.Location = new Point(250, 91);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 7;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Modify
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(textBox7);
			Controls.Add(textBox6);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Modify";
			Text = "Modify";
			Load += Modify_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox textBox6;
		private TextBox textBox7;
		private Button button1;
	}
}