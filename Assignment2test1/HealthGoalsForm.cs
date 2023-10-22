using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2test1
{
    public partial class HealthGoalsForm : Form
    {
        Customer loggedInCustomer;
        HealthInfo loggedInHealth = null;
        string fname = "";

        public HealthGoalsForm(Customer loggedInCustomer)
        {
            InitializeComponent();

            this.loggedInCustomer = loggedInCustomer;
        }

        private void HealthGoalsForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Hi, " + loggedInCustomer.firstName + " " + loggedInCustomer.lastName + ", Welcome to the Health Management Module";
            fname = loggedInCustomer.firstName + loggedInCustomer.lastName + "Health.txt";

            //if not exist ,add a new record
            loggedInHealth = HealthInfo.LoadInfo(fname);
            if (loggedInHealth == null)
            {
                loggedInHealth = new HealthInfo();
                loggedInHealth.name = loggedInCustomer.firstName + "," + loggedInCustomer.lastName;
                loggedInHealth.email = loggedInCustomer.email;
            }

            rad1.Checked = true;
            txtb2.Text = DateTime.Now.ToShortDateString();
        }

        //check if has exist record
        public int FindRecord(List<DialyHealth> info, string date)
        {
            for (int i = 0; i < info.Count; i++)
            {
                if (info[i].RecordTime == date)
                {
                    return i;
                }
            }
            return -1;
        }

        //set show status
        public void setStatus(List<DialyHealth> info)
        {
            cbb.Items.Clear();
            for (int i = 0; i < info.Count; i++)
            {
                cbb.Items.Add(info[i].RecordTime);
            }
            if (cbb.Items.Count > 0)
                cbb.SelectedIndex = 0;
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            if (loggedInHealth == null)
            {
                return;
            }
            if (rad1.Checked)
            {
                txtb1.Text = "";
                setStatus(loggedInHealth.lWeight);
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
                txtb1.Text = "";
                setStatus(loggedInHealth.lBloodPressure);
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
                txtb1.Text = "";
                setStatus(loggedInHealth.lHeartRate);
            }
        }

        //show goal
        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cbb.SelectedIndex;
            if (rad1.Checked)
            {
                txtb1.Text = loggedInHealth.lWeight[ind].Goal.ToString();
            }
            else if (rad2.Checked)
            {
                txtb1.Text = loggedInHealth.lBloodPressure[ind].Goal.ToString();
            }
            else if (rad3.Checked)
            {
                txtb1.Text = loggedInHealth.lHeartRate[ind].Goal.ToString();
            }
        }

        //update goal
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = cbb.SelectedIndex;
                if (ind < 0)
                {
                    MessageBox.Show("Invalid record date");
                    return;
                }

                if (rad1.Checked)
                {
                    loggedInHealth.lWeight[ind].Goal = double.Parse(txtb1.Text);
                }
                else if (rad2.Checked)
                {
                    loggedInHealth.lBloodPressure[ind].Goal = double.Parse(txtb1.Text);
                }
                else if (rad3.Checked)
                {
                    loggedInHealth.lHeartRate[ind].Goal = double.Parse(txtb1.Text);
                }

                HealthInfo.SaveInfo(loggedInHealth, fname);
                MessageBox.Show("Update success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //record new goal
        private void btn_record_Click(object sender, EventArgs e)
        {
            try
            {
                DialyHealth di;
                if (rad1.Checked)
                {
                    int ind = FindRecord(loggedInHealth.lWeight, txtb2.Text);
                    if (ind == -1)
                    {
                        di = new DialyHealth(txtb2.Text, double.Parse(txtb3.Text));
                        loggedInHealth.lWeight.Add(di);
                    }
                    else
                    {
                        loggedInHealth.lWeight[ind].Goal = double.Parse(txtb3.Text);
                    }

                    setStatus(loggedInHealth.lWeight);
                }
                else if (rad2.Checked)
                {
                    int ind = FindRecord(loggedInHealth.lBloodPressure, txtb2.Text);
                    if (ind == -1)
                    {
                        di = new DialyHealth(txtb2.Text, double.Parse(txtb3.Text));
                        loggedInHealth.lBloodPressure.Add(di);
                    }
                    else
                    {
                        loggedInHealth.lBloodPressure[ind].Goal = double.Parse(txtb3.Text);
                    }

                    setStatus(loggedInHealth.lBloodPressure);
                }
                else if (rad3.Checked)
                {
                    int ind = FindRecord(loggedInHealth.lHeartRate, txtb2.Text);
                    if (ind == -1)
                    {
                        di = new DialyHealth(txtb2.Text, double.Parse(txtb3.Text));
                        loggedInHealth.lHeartRate.Add(di);
                    }
                    else
                    {
                        loggedInHealth.lHeartRate[ind].Goal = double.Parse(txtb3.Text);
                    }

                    setStatus(loggedInHealth.lHeartRate);
                }

                txtb3.Text = "";
                HealthInfo.SaveInfo(loggedInHealth, fname);
                MessageBox.Show("Record success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
