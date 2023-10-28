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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthMetrics));
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
            label1.Location = new Point(47, 31);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad3);
            groupBox1.Controls.Add(rad2);
            groupBox1.Controls.Add(rad1);
            groupBox1.Location = new Point(47, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 333);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Health Type";
            // 
            // rad3
            // 
            rad3.AutoSize = true;
            rad3.Location = new Point(40, 243);
            rad3.Name = "rad3";
            rad3.Size = new Size(139, 32);
            rad3.TabIndex = 2;
            rad3.TabStop = true;
            rad3.Text = "HeartRate";
            rad3.UseVisualStyleBackColor = true;
            rad3.CheckedChanged += rad3_CheckedChanged;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(40, 160);
            rad2.Name = "rad2";
            rad2.Size = new Size(181, 32);
            rad2.TabIndex = 1;
            rad2.TabStop = true;
            rad2.Text = "BloodPressure";
            rad2.UseVisualStyleBackColor = true;
            rad2.CheckedChanged += rad2_CheckedChanged;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(40, 75);
            rad1.Name = "rad1";
            rad1.Size = new Size(110, 32);
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
            dgv.Location = new Point(358, 98);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 72;
            dgv.RowTemplate.Height = 36;
            dgv.Size = new Size(476, 320);
            dgv.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(898, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // HealthMetrics
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 447);
            Controls.Add(pictureBox1);
            Controls.Add(dgv);
            Controls.Add(groupBox1);
            Controls.Add(label1);
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