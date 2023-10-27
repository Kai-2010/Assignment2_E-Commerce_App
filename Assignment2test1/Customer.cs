using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2test1
{
	public class Customer
	{
		public int CustomerId { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string address { get; set; }
		public string email { get; set; }
		public string phoneNumber { get; set; }
		public string password { get; set; }
		public string gender { get; set; }
        public bool heartAttack { get; set; }
        public bool diabetes { get; set; }
        public bool chronicDisease { get; set; }
        public bool other { get; set; }

        public Customer(string inputFirstName, string inputLastName, string inputAddress, string inputEmail, string inputPhoneNumber, string inputPassword, string inputGender, bool inputHealthCondition1,
			bool inputHealthCondition2, bool inputHealthCondition3, bool inputHealthCondition4)
		{
			firstName = inputFirstName;
			lastName = inputLastName;
			address = inputAddress;
			phoneNumber = inputPhoneNumber;
			email = inputEmail;
			gender = inputGender;
			password = inputPassword;
            heartAttack = inputHealthCondition1;
            diabetes = inputHealthCondition2;
            chronicDisease = inputHealthCondition3;
            other = inputHealthCondition4;
        }
        public Customer()
        {
        }
    }
}
