namespace Assignment2test1
{
    partial class HealthGraphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            WeightGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            HeartRateGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            BloodPressureGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ExerciseGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CalorieGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)WeightGraph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeartRateGraph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BloodPressureGraph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExerciseGraph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CalorieGraph).BeginInit();
            SuspendLayout();
            // 
            // WeightGraph
            // 
            chartArea1.Name = "ChartArea1";
            WeightGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            WeightGraph.Legends.Add(legend1);
            WeightGraph.Location = new Point(22, 26);
            WeightGraph.Name = "WeightGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            WeightGraph.Series.Add(series1);
            WeightGraph.Size = new Size(456, 300);
            WeightGraph.TabIndex = 0;
            WeightGraph.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title1.Name = "Title";
            title1.Text = "Weight(kg)";
            WeightGraph.Titles.Add(title1);
            // 
            // HeartRateGraph
            // 
            chartArea2.Name = "ChartArea1";
            HeartRateGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            HeartRateGraph.Legends.Add(legend2);
            HeartRateGraph.Location = new Point(547, 26);
            HeartRateGraph.Name = "HeartRateGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Heart Rate";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            HeartRateGraph.Series.Add(series2);
            HeartRateGraph.Size = new Size(424, 300);
            HeartRateGraph.TabIndex = 1;
            HeartRateGraph.Text = "chart1";
            title2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Heart Rate(BPM)";
            HeartRateGraph.Titles.Add(title2);
            // 
            // BloodPressureGraph
            // 
            chartArea3.Name = "ChartArea1";
            BloodPressureGraph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            BloodPressureGraph.Legends.Add(legend3);
            BloodPressureGraph.Location = new Point(22, 343);
            BloodPressureGraph.Name = "BloodPressureGraph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Blood Pressure";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            BloodPressureGraph.Series.Add(series3);
            BloodPressureGraph.Size = new Size(456, 300);
            BloodPressureGraph.TabIndex = 2;
            BloodPressureGraph.Text = "chart2";
            title3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title3.Name = "Title1";
            title3.Text = "Blood Pressure(mmHg averaged)";
            BloodPressureGraph.Titles.Add(title3);
            // 
            // ExerciseGraph
            // 
            chartArea4.Name = "ChartArea1";
            ExerciseGraph.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            ExerciseGraph.Legends.Add(legend4);
            ExerciseGraph.Location = new Point(275, 676);
            ExerciseGraph.Name = "ExerciseGraph";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Exercise";
            ExerciseGraph.Series.Add(series4);
            ExerciseGraph.Size = new Size(486, 380);
            ExerciseGraph.TabIndex = 4;
            ExerciseGraph.Text = "chart1";
            title4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title4.Name = "Title1";
            title4.Text = "Total Exercise(as %)";
            ExerciseGraph.Titles.Add(title4);
            // 
            // CalorieGraph
            // 
            chartArea5.Name = "ChartArea1";
            CalorieGraph.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            CalorieGraph.Legends.Add(legend5);
            CalorieGraph.Location = new Point(547, 343);
            CalorieGraph.Name = "CalorieGraph";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Calories";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            CalorieGraph.Series.Add(series5);
            CalorieGraph.Size = new Size(424, 300);
            CalorieGraph.TabIndex = 3;
            CalorieGraph.Text = "chart3";
            title5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title5.Name = "Title1";
            title5.Text = "Calories(Cal)";
            CalorieGraph.Titles.Add(title5);
            // 
            // HealthGraphs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 1088);
            Controls.Add(ExerciseGraph);
            Controls.Add(CalorieGraph);
            Controls.Add(BloodPressureGraph);
            Controls.Add(HeartRateGraph);
            Controls.Add(WeightGraph);
            Name = "HealthGraphs";
            Text = "HealthGraphs";
            ((System.ComponentModel.ISupportInitialize)WeightGraph).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeartRateGraph).EndInit();
            ((System.ComponentModel.ISupportInitialize)BloodPressureGraph).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExerciseGraph).EndInit();
            ((System.ComponentModel.ISupportInitialize)CalorieGraph).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart WeightGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart HeartRateGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart BloodPressureGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExerciseGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart CalorieGraph;
    }
}