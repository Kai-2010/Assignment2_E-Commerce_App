using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using static Assignment2test1.DialyExerciseInfo;

namespace Assignment2test1
{
    //dialy record info
    public class DialyHealth
    {
        public string RecordTime;
        public double Goal;

        public DialyHealth(string s = "", double d = 0)
        {
            RecordTime = s;
            Goal = d;
        }
    }

    public class DialyExerciseInfo
    {
        public class Exercise
        {
            public string Type;
            public double Amount;

            public Exercise(string s = "", double d = 0)
            {
                Type = s;
                Amount = d;
            }
        }

        public string RecordTime;
        public List<Exercise> dailyExer = new List<Exercise>();

        public DialyExerciseInfo(string s = "")
        {
            RecordTime = s;
        }
    }

    internal class HealthInfo
    {
        public string name;
        public string email;

        public List<DialyHealth> lWeight = new List<DialyHealth>();
        public List<DialyHealth> lBloodPressure = new List<DialyHealth>();  
        public List<DialyHealth> lHeartRate = new List<DialyHealth>();

        public List<DialyHealth> lCalorie = new List<DialyHealth>();

        public List<DialyExerciseInfo> lExercise = new List<DialyExerciseInfo>();

        public HealthInfo()
        {
            name = "";
            email = "";
        }

        public static HealthInfo LoadInfo(string fname)
        {
            HealthInfo HealthInfo = null;

            if (!File.Exists(fname))
                return HealthInfo;
            
            using (StreamReader sr = new StreamReader(fname))
            {
                string line = sr.ReadLine();
                if (line == null)
                {
                    return HealthInfo;
                }

                HealthInfo = new HealthInfo();

                string[] arr = line.Split('|');
                HealthInfo.name = arr[0];
                HealthInfo.email = arr[1];

                while ((line = sr.ReadLine()) != null)
                {
                    if (line == null)
                    {
                        return HealthInfo;
                    }

                    arr = line.Split('|');
                    if (arr[0] == "Weight")
                    {
                        for (int i = 1; i < arr.Length; i++)
                        {
                            string[] tem = arr[i].Split(' ');
                            HealthInfo.lWeight.Add(new DialyHealth(tem[0], double.Parse(tem[1])));
                        }
                    }
                    else if (arr[0] == "BloodPressure")
                    {
                        for (int i = 1; i < arr.Length; i++)
                        {
                            string[] tem = arr[i].Split(' ');
                            HealthInfo.lBloodPressure.Add(new DialyHealth(tem[0], double.Parse(tem[1])));
                        }
                    }
                    else if (arr[0] == "HeartRate")
                    {
                        for (int i = 1; i < arr.Length; i++)
                        {
                            string[] tem = arr[i].Split(' ');
                            HealthInfo.lHeartRate.Add(new DialyHealth(tem[0], double.Parse(tem[1])));
                        }
                    }
                    else if (arr[0] == "Calorie")
                    {
                        for (int i = 1; i < arr.Length; i++)
                        {
                            string[] tem = arr[i].Split(' ');
                            HealthInfo.lCalorie.Add(new DialyHealth(tem[0], double.Parse(tem[1])));
                        }
                    }
                    else if (arr[0] == "Exercise")
                    {
                        for (int i = 1; i < arr.Length; i++)
                        {
                            DialyExerciseInfo dinfo = new DialyExerciseInfo();

                            string[] tem = arr[i].Split(' ');
                            dinfo.RecordTime = tem[0];
                            for (int j = 1; j < tem.Length; j += 2) 
                            {
                                DialyExerciseInfo.Exercise exe = new DialyExerciseInfo.Exercise();
                                exe.Type = tem[j];
                                exe.Amount = double.Parse(tem[j + 1]);
                                dinfo.dailyExer.Add(exe);
                            }

                            HealthInfo.lExercise.Add(dinfo);
                        }
                    }
                }                
            }
            return HealthInfo;
        }

        public static void SaveInfo(HealthInfo info,string fname)
        {
            using (StreamWriter sw = new StreamWriter(fname))
            {
                sw.WriteLine(info.name + "|" + info.email);

                //save weight info
                sw.Write("Weight");
                for (int i = 0; i < info.lWeight.Count; i++)
                {
                    sw.Write("|" + info.lWeight[i].RecordTime + " " + info.lWeight[i].Goal);
                }
                sw.WriteLine();

                //save BloodPressure info
                sw.Write("BloodPressure");
                for (int i = 0; i < info.lBloodPressure.Count; i++)
                {
                    sw.Write("|" + info.lBloodPressure[i].RecordTime + " " + info.lBloodPressure[i].Goal);
                }
                sw.WriteLine();

                //save HeartRate info
                sw.Write("HeartRate");
                for (int i = 0; i < info.lHeartRate.Count; i++)
                {
                    sw.Write("|" + info.lHeartRate[i].RecordTime + " " + info.lHeartRate[i].Goal);
                }
                sw.WriteLine();

                //save Calorie info
                sw.Write("Calorie");
                for (int i = 0; i < info.lCalorie.Count; i++)
                {
                    sw.Write("|" + info.lCalorie[i].RecordTime + " " + info.lCalorie[i].Goal);
                }
                sw.WriteLine();

                //save Exercise info
                sw.Write("Exercise");
                for (int i = 0; i < info.lExercise.Count; i++)
                {
                    sw.Write("|" + info.lExercise[i].RecordTime);
                    for (int j = 0; j < info.lExercise[i].dailyExer.Count; j++)
                    {
                        sw.Write(" " + info.lExercise[i].dailyExer[j].Type + " " + info.lExercise[i].dailyExer[j].Amount);
                    }
                }
                sw.WriteLine();
            }
        }
    }
}
