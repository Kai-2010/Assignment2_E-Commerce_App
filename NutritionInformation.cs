using static Assignment2test1.DialyExerciseInfo;

namespace Assignment2test1
{
    public partial class NutritionInformation : Form
    {
        Customer loggedInCustomer;
        HealthInfo loggedInHealth = null;
        string fname = "";

        public NutritionInformation(Customer loggedInCustomer)
        {
            InitializeComponent();

            this.loggedInCustomer = loggedInCustomer;
        }

        private void NutritionInformation_Load(object sender, EventArgs e)
        {
            label1.Text = "Hi, " + loggedInCustomer.firstName + " " + loggedInCustomer.lastName + ", Welcome to the Nutrition and Exercise Monitoring Module";
            fname = loggedInCustomer.firstName + loggedInCustomer.lastName + "Health.txt";

            //if not exist ,add a new record
            loggedInHealth = HealthInfo.LoadInfo(fname);
            if (loggedInHealth == null)
            {
                loggedInHealth = new HealthInfo();
                loggedInHealth.name = loggedInCustomer.firstName + "," + loggedInCustomer.lastName;
                loggedInHealth.email = loggedInCustomer.email;
            }

            //load latest weight
            if (loggedInHealth.lWeight.Count > 0)
            {
                txtb1.Text = loggedInHealth.lWeight[loggedInHealth.lWeight.Count - 1].Goal.ToString();
            }

            //current datetime
            txtb5.Text = DateTime.Now.ToShortDateString();
            txtb7.Text = DateTime.Now.ToShortDateString();

            //set grid
            SetGrid(loggedInHealth.lCalorie);

            //set combobox
            SetStatus();
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

        public int FindRecord(List<DialyExerciseInfo> info, string date)
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

        public int FindRecord(List<Exercise> info, string type)
        {
            for (int i = 0; i < info.Count; i++)
            {
                if (info[i].Type == type)
                {
                    return i;
                }
            }
            return -1;
        }

        //set grid value
        private void SetGrid(List<DialyHealth> info)
        {
            while (dgv1.Columns.Count > 0)
            {
                dgv1.Columns.RemoveAt(0);
            }

            DataGridViewTextBoxColumn acCode = new DataGridViewTextBoxColumn();
            acCode.Name = "Date";
            acCode.HeaderText = "Date";
            dgv1.Columns.Add(acCode);

            acCode = new DataGridViewTextBoxColumn();
            acCode.Name = "Caloric";
            acCode.HeaderText = "Caloric";
            dgv1.Columns.Add(acCode);

            for (int i = 0; i < info.Count; i++)
            {
                dgv1.Rows.Add(info[i].RecordTime, info[i].Goal);
            }
        }

        private void SetGrid(List<Exercise> info)
        {
            while (dgv2.Columns.Count > 0)
            {
                dgv2.Columns.RemoveAt(0);
            }

            DataGridViewTextBoxColumn acCode = new DataGridViewTextBoxColumn();
            acCode.Name = "Exercise Type";
            acCode.HeaderText = "Exercise Type";
            dgv2.Columns.Add(acCode);

            acCode = new DataGridViewTextBoxColumn();
            acCode.Name = "Exercise Duration";
            acCode.HeaderText = "Exercise Duration";
            dgv2.Columns.Add(acCode);

            double cnt = 0;
            int i;
            for (i = 0; i < info.Count; i++)
            {
                dgv2.Rows.Add(info[i].Type, info[i].Amount);
                cnt += info[i].Amount;
            }

            dgv2.Rows.Add("Total", cnt);
        }

        //set combobox
        private void SetStatus()
        {
            cbb.Items.Clear();
            for (int i = 0; i < loggedInHealth.lExercise.Count; i++)
            {
                cbb.Items.Add(loggedInHealth.lExercise[i].RecordTime);
            }

            if (cbb.Items.Count > 0)
                cbb.SelectedIndex = 0;
        }

        //cal bmi
        private void btn_CalBMI_Click(object sender, EventArgs e)
        {
            if (txtb1.Text == "")
            {
                MessageBox.Show("Please input your weight record first");
                return;
            }
            try
            {
                double weight = double.Parse(txtb1.Text);
                double height = double.Parse(txtb2.Text);
                double bmi = weight / height / height;

                txtb3.Text = bmi.ToString("0.00");
                if (bmi <= 18.5)
                {
                    txtb4.Text = "Underweight range";
                }
                else if (bmi <= 24.9)
                {
                    txtb4.Text = "Healthy weight range";
                }
                else if (bmi <= 29.9)
                {
                    txtb4.Text = "Overweight range";
                }
                else
                {
                    txtb4.Text = "Obese range";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //record caloric
        private void btn_RecordCaloric_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = FindRecord(loggedInHealth.lCalorie, txtb5.Text);
                if (ind == -1)
                {
                    DialyHealth di = new DialyHealth(txtb5.Text, double.Parse(txtb6.Text));
                    loggedInHealth.lCalorie.Add(di);
                }
                else
                {
                    loggedInHealth.lCalorie[ind].Goal += double.Parse(txtb6.Text);
                }

                txtb6.Text = "";
                SetGrid(loggedInHealth.lCalorie);
                HealthInfo.SaveInfo(loggedInHealth, fname);
                MessageBox.Show("Record success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //record exercise
        private void btn_RecordExercise_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtb8.Text == "" || txtb9.Text == "")
                {
                    MessageBox.Show("All textbox should input");
                    return;
                }

                int ind1 = FindRecord(loggedInHealth.lExercise, txtb7.Text);
                if (ind1 == -1)
                {
                    DialyExerciseInfo di = new DialyExerciseInfo(txtb7.Text);
                    Exercise exe = new Exercise(utility.RemoveWhitespace(txtb8.Text), double.Parse(txtb9.Text));
                    di.dailyExer.Add(exe);
                    loggedInHealth.lExercise.Add(di);
                }
                else
                {
                    int ind2 = FindRecord(loggedInHealth.lExercise[ind1].dailyExer, utility.RemoveWhitespace(txtb8.Text));
                    if (ind2 == -1)
                    {
                        Exercise exe = new Exercise(utility.RemoveWhitespace(txtb8.Text), double.Parse(txtb9.Text));
                        loggedInHealth.lExercise[ind1].dailyExer.Add(exe);
                    }
                    else
                    {
                        loggedInHealth.lExercise[ind1].dailyExer[ind2].Amount = double.Parse(txtb9.Text);
                    }
                }

                txtb8.Text = "";
                txtb9.Text = "";
                SetStatus();
                HealthInfo.SaveInfo(loggedInHealth, fname);
                MessageBox.Show("Record success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cbb.SelectedIndex;
            SetGrid(loggedInHealth.lExercise[ind].dailyExer);
        }
    }
}