namespace Assignment2test1
{
    partial class HealthMetrics
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
            dgv = new DataGridView();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad3);
            groupBox1.Controls.Add(rad2);
            groupBox1.Controls.Add(rad1);
            groupBox1.Location = new Point(25, 46);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(143, 178);
            groupBox1.TabIndex = 2;
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
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(193, 52);
            dgv.Margin = new Padding(2, 2, 2, 2);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 72;
            dgv.RowTemplate.Height = 36;
            dgv.Size = new Size(256, 171);
            dgv.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pic2;
            pictureBox1.Location = new Point(484, 52);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // HealthMetrics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 239);
            Controls.Add(pictureBox1);
            Controls.Add(dgv);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HealthMetrics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HealthMetrics";
            Load += HealthMetrics_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
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
        private DataGridView dgv;
        private PictureBox pictureBox1;
    }
}