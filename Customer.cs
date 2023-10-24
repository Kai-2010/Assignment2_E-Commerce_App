using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2test1
{
	public class Customer
	{
		public string firstName, lastName, address, email, phoneNumber, password, gender,healthCondition1, healthCondition2, healthCondition3, healthCondition4;

		public Customer(string inputEmail,string inputPassword,string inputFirstName, string inputLastName, string inputPhoneNumber, string inputAddress, string inputGender,string inputHealthCondition1,
			string inputHealthCondition2, string inputHealthCondition3, string inputHealthCondition4)
		{
			firstName = inputFirstName;
			lastName = inputLastName;
			address = inputAddress;
			phoneNumber = inputPhoneNumber;
			email = inputEmail;
			gender = inputGender;
			password = inputPassword;
			healthCondition1 = inputHealthCondition1;
			healthCondition2 = inputHealthCondition2;
			healthCondition3 = inputHealthCondition3;
			healthCondition4 = inputHealthCondition4;
		}
		public Customer()
		{
			email = "";
		}
	}
}
