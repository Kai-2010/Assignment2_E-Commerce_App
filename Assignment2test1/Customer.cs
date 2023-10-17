using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2test1
{
	public class Customer
	{
		public string firstName, lastName, address, email, phoneNumber, password, sex;

		public Customer(string inputEmail,string inputPassword,string inputFirstName, string inputLastName, string inputAddress, string inputPhoneNumber,string inputSex)
		{
			firstName = inputFirstName;
			lastName = inputLastName;
			address = inputAddress;
			phoneNumber = inputPhoneNumber;
			email = inputEmail;
			sex = inputSex;
			password = inputPassword;
		}
		public Customer()
		{
			email = "";
		}
	}
}
