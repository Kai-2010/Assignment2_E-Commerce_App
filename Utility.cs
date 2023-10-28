using System.Text.RegularExpressions;

namespace Assignment2test1
{
	public class utility
	{
		// The method ensures the first name and last name entered by the user only contains letter/strings
		public static bool isNameValid(string Name)
		{
			Regex regex = new Regex(@"^[a-z A-Z]+$");
			return regex.IsMatch(Name);
		}

		// The method ensures a valid email address tis entered. It checks that the @ symbol and .com is present
		public static bool isEmailValid(string email)
		{
			string regex = @"^[^@\s]+@[^@\s]+\.(com)$";
			return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
		}
		
		// The method ensures the phone number entered is only ten digits long. It returns true or false based on the result 
		public static Boolean phoneValidation(string phoneNumber)
		{
			if ((phoneNumber.Length != 10))
			{
				return false;
			}
			return true;
		}

		// The method checks to see if the phoneNumber is Australian or not
		// The phoneNumber string is converted to an integer so that the 1st digit can be matched to check if they start as 0 and 2nd digit is 4
		public static Boolean phoneValidation1(string phoneNumber)
		{
			int firstDigit = Convert.ToInt32(new string(phoneNumber[0], 1));
			int secondDigit = Convert.ToInt32(new string(phoneNumber[1], 1));

			if (firstDigit == 0 && secondDigit == 4)
			{
				return true;
			}
			return false;

		}
		// The method is used to check if  password is valid.
		// It checks if a password contains ten characters with one capital letter and one special character 
		public static Boolean isPasswordValid(string password)
		{
			string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?!.*\s).{10,}$";

			if (Regex.IsMatch(password, pattern))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		// The method takes in a pre-existing customer as a parameter and overwrites its details within the database.
        public static void updateCustomer(Customer customer)
        {
            using (var context = new HealthContext())
            {
                var targetCustomer = context.Customers.Find(customer.CustomerId);
				targetCustomer.firstName = customer.firstName;
				targetCustomer.lastName = customer.lastName;
                targetCustomer.email = customer.email;
                targetCustomer.phoneNumber = customer.phoneNumber;
                targetCustomer.address = customer.address;
                targetCustomer.password = customer.password;
                targetCustomer.heartAttack = customer.heartAttack;
                targetCustomer.diabetes = customer.diabetes;
                targetCustomer.chronicDisease = customer.chronicDisease;
                targetCustomer.other = customer.other;
                context.SaveChanges();
            }
        }

		// The method takes in a customer as a parameter and then adds it to the Customers entity in HealthDB.
        public static void addCustomer(Customer customer)
        {
            using (var context = new HealthContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

		//The med reads the posts and its replies to a String array and returns the array
		public static string [] readPosts()
		{
			string[] posts = File.ReadAllLines("post.txt").ToArray();
			return posts;
		}
    }
}