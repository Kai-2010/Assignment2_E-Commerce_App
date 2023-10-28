namespace Assignment2test1
{
    partial class HealthGoalsForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            rad3 = new RadioButton();
            rad2 = new RadioButton();
            rad1 = new RadioButton();
            groupBox2 = new GroupBox();
            btn_update = new Button();
            txtb1 = new TextBox();
            label3 = new Label();
            cbb = new ComboBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btn_record = new Button();
            txtb3 = new TextBox();
            label5 = new Label();
            txtb2 = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad3);
            groupBox1.Controls.Add(rad2);
            groupBox1.Controls.Add(rad1);
            groupBox1.Location = new Point(18, 52);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(143, 172);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Health Type";
            // 
            // rad3
            // 
            rad3.AutoSize = true;
            rad3.Location = new Point(22, 130);
            rad3.Margin = new Padding(2, 2, 2, 2);
            rad3.Name = "rad3";
            rad3.Size = new Size(77, 19);
            rad3.TabIndex = 2;
            rad3.TabStop = true;
            rad3.Text = "HeartRate";
            rad3.UseVisualStyleBackColor = true;
            rad3.CheckedChanged += rad3_CheckedChanged;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(22, 86);
            rad2.Margin = new Padding(2, 2, 2, 2);
            rad2.Name = "rad2";
            rad2.Size = new Size(100, 19);
            rad2.TabIndex = 1;
            rad2.TabStop = true;
            rad2.Text = "BloodPressure";
            rad2.UseVisualStyleBackColor = true;
            rad2.CheckedChanged += rad2_CheckedChanged;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(22, 40);
            rad1.Margin = new Padding(2, 2, 2, 2);
            rad1.Name = "rad1";
            rad1.Size = new Size(63, 19);
            rad1.TabIndex = 0;
            rad1.TabStop = true;
            rad1.Text = "Weight";
            rad1.UseVisualStyleBackColor = true;
            rad1.CheckedChanged += rad1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_update);
            groupBox2.Controls.Add(txtb1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cbb);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(177, 52);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(246, 172);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Health Goal";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(20, 130);
            btn_update.Margin = new Padding(2, 2, 2, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(206, 21);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update Goal";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txtb1
            // 
            txtb1.Location = new Point(118, 85);
            txtb1.Margin = new Padding(2, 2, 2, 2);
            txtb1.Name = "txtb1";
            txtb1.Size = new Size(110, 23);
            txtb1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 88);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Goal:";
            // 
            // cbb
            // 
            cbb.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb.FormattingEnabled = true;
            cbb.Location = new Point(118, 38);
            cbb.Margin = new Padding(2, 2, 2, 2);
            cbb.Name = "cbb";
            cbb.Size = new Size(110, 23);
            cbb.TabIndex = 4;
            cbb.SelectedIndexChanged += cbb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Record Date:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_record);
            groupBox3.Controls.Add(txtb3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtb2);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(441, 52);
            groupBox3.Margin = new Padding(2, 2, 2, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 2, 2, 2);
            groupBox3.Size = new Size(232, 172);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Record Health Goal";
            // 
            // btn_record
            // 
            btn_record.Location = new Point(11, 130);
            btn_record.Margin = new Padding(2, 2, 2, 2);
            btn_record.Name = "btn_record";
            btn_record.Size = new Size(206, 21);
            btn_record.TabIndex = 8;
            btn_record.Text = "Record Goal";
            btn_record.UseVisualStyleBackColor = true;
            btn_record.Click += btn_record_Click;
            // 
            // txtb3
            // 
            txtb3.Location = new Point(110, 85);
            txtb3.Margin = new Padding(2, 2, 2, 2);
            txtb3.Name = "txtb3";
            txtb3.Size = new Size(110, 23);
            txtb3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 88);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 8;
            label5.Text = "Goal:";
            // 
            // txtb2
            // 
            txtb2.Location = new Point(110, 38);
            txtb2.Margin = new Padding(2, 2, 2, 2);
            txtb2.Name = "txtb2";
            txtb2.ReadOnly = true;
            txtb2.Size = new Size(110, 23);
            txtb2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 40);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 8;
            label4.Text = "Current Date:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pic1;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(18, 242);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 308);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // HealthGoalsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 561);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HealthGoalsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HealthGoalsForm";
            Load += HealthGoalsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rad3;
        private RadioButton rad2;
        private RadioButton rad1;
        private GroupBox groupBox2;
        private ComboBox cbb;
        private Label label2;
        private TextBox txtb1;
        private Label label3;
        private Button btn_update;
        private GroupBox groupBox3;
        private Label label4;
        private TextBox txtb2;
        private TextBox txtb3;
        private Label label5;
        private Button btn_record;
        private PictureBox pictureBox1;
    }
}