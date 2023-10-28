using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Assignment2test1
{
    public partial class HealthGraphs : Form
    {
        HealthInfo healthInfo;
        public HealthGraphs(Customer customer)
        {
            InitializeComponent();
            healthInfo = HealthInfo.LoadInfo(customer.firstName + customer.lastName + "Health.txt");
            loadGraphs();
        }

        private void loadGraphs()
        {
            if (healthInfo != null)
            {
                foreach (DialyHealth health in healthInfo.lWeight)
                {
                    WeightGraph.Series["Weight"].Points.AddXY(DateTime.Parse(health.RecordTime), health.Goal);
                }

                foreach (DialyHealth health in healthInfo.lHeartRate)
                {
                    HeartRateGraph.Series["Heart Rate"].Points.AddXY(DateTime.Parse(health.RecordTime), health.Goal);
                }

                foreach (DialyHealth health in healthInfo.lBloodPressure)
                {
                    BloodPressureGraph.Series["Blood Pressure"].Points.AddXY(DateTime.Parse(health.RecordTime), health.Goal);
                }

                foreach (DialyHealth health in healthInfo.lCalorie)
                {
                    CalorieGraph.Series["Calories"].Points.AddXY(DateTime.Parse(health.RecordTime), health.Goal);
                }

                foreach (DialyExerciseInfo dailyExercise in healthInfo.lExercise)
                {
                    foreach (DialyExerciseInfo.Exercise exercise in dailyExercise.dailyExer)
                    {
                        int index = ExerciseGraph.Series["Exercise"].Points.AddY(exercise.Amount);
                        ExerciseGraph.Series["Exercise"].Points[index].Label = exercise.Type + " " + dailyExercise.RecordTime;
                    }
                }

                foreach (DataPoint p in ExerciseGraph.Series["Exercise"].Points)
                {
                    p.Label += "\n(#PERCENT)";
                }
            }
        }
    }
}
