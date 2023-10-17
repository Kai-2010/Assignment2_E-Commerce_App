using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2test1
{
	public class baseEntity
	{
		public int sex;
		public string firstName, lastName, address, email, phoneNumber;
		public string password;

		// this method checks if the id is 5 digits and less than 8 digits.
		// it breaks the information stored in the respective files into the the individual attributes of the baseEntity class
		// if all the details are populated successfully the method returns true

		public Boolean entityExists(string email)
		{
			
				string[] accountInfo = File.ReadAllLines($"{email}.txt").ToArray();
				try
				{
					this.email = accountInfo[0];
				this.firstName = accountInfo[1];
				this.lastName = accountInfo[2];
				this.address = accountInfo[3];
				this.phoneNumber = accountInfo[4];
				this.sex= Convert.ToInt32(accountInfo[5]);

					// invokes the appointment constructor
					// checks to to see if the length of the accountInfo array is greater than 3 ie there are appointments present.
					// This is required as both the patient and doctors can have multiple appointments

					if (accountInfo.Length > 3)
					{
						for (int i = 3; i < accountInfo.Length; i++)
						{
							string[] apptDetails = accountInfo[i].Split('|');
							//appointmentList.Add(new Appointment(apptDetails[0], apptDetails[1], apptDetails[2]));
						}
					}
					return true;
				}
				catch (Exception ex) when (ex is IndexOutOfRangeException || ex is FormatException)
				{
					return false;
				}
			
			return false;
		}
		// This method is called from the patient and doctor class to save appointment details to the file
		public void saveDetails()
		{
			string stringAppointmentBlock = "";
			/*
			for (int i = 0; i < appointmentList.Count; i++)
			{
				stringAppointmentBlock = stringAppointmentBlock + appointmentList[i].doctorID + "|" + appointmentList[i].patientID + "|" + appointmentList[i].description + "\n";
			}
			*/

			System.IO.File.WriteAllText(string.Format($"{email}.txt"), string.Format($"{email}|{firstName}|{lastName}|{address}|{phoneNumber}|{sex}"));
		}
	
	}
}
