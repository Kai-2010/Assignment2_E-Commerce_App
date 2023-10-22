using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2test1
{
    public partial class HealthMetrics : Form
    {
        Customer loggedInCustomer;
        HealthInfo loggedInHealth = null;
        string fname = "";

        public HealthMetrics(Customer loggedInCustomer)
        {
            InitializeComponent();

            this.loggedInCustomer = loggedInCustomer;
        }

        private void HealthMetrics_Load(object sender, EventArgs e)
        {
            label1.Text = "Hi, " + loggedInCustomer.firstName + " " + loggedInCustomer.lastName + ", Welcome to the Health Indicator Tracking Module";
            fname = loggedInCustomer.firstName + loggedInCustomer.lastName + "Health.txt";

            //if not exist , add a new record
            loggedInHealth = HealthInfo.LoadInfo(fname);
            if (loggedInHealth == null)
            {
                loggedInHealth = new HealthInfo();
                loggedInHealth.name = loggedInCustomer.firstName + "," + loggedInCustomer.lastName;
                loggedInHealth.email = loggedInCustomer.email;
            }

            rad1.Checked = true;
        }

        //set grid value
        private void SetGrid(List<DialyHealth> info)
        {
            while (dgv.Columns.Count > 0)
            {
                dgv.Columns.RemoveAt(0);
            }

            DataGridViewTextBoxColumn acCode = new DataGridViewTextBoxColumn();
            acCode.Name = "Date";
            acCode.HeaderText = "Date";
            dgv.Columns.Add(acCode);

            acCode = new DataGridViewTextBoxColumn();
            acCode.Name = "Goal";
            acCode.HeaderText = "Goal";
            dgv.Columns.Add(acCode);

            for (int i = 0; i < info.Count; i++)
            {
                dgv.Rows.Add(info[i].RecordTime, info[i].Goal);
            }
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            if (loggedInHealth == null)
            {
                return;
            }
            if (rad1.Checked)
            {
                SetGrid(loggedInHealth.lWeight);
            }
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (loggedInHealth == null)
            {
                return;
            }
            if (rad2.Checked)
            {
                SetGrid(loggedInHealth.lBloodPressure);
            }
        }

        private void rad3_CheckedChanged(object sender, EventArgs e)
        {
            if (loggedInHealth == null)
            {
                return;
            }
            if (rad3.Checked)
            {
                SetGrid(loggedInHealth.lHeartRate);
            }
        }
    }
}
