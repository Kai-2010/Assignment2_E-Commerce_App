using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment2test1
{
	public class utility
	{
		public static bool isNameValid(string Name)
		{
			Regex regex = new Regex(@"^[a-z A-Z]+$");
			return regex.IsMatch(Name);
		}
		public static bool isEmailValid(string email)
		{
			string regex = @"^[^@\s]+@[^@\s]+\.(com)$";
			return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
		}
		// This method ensures the phone number entered is only ten digits long. It returns true or false based on the result 
		public static Boolean phoneValidation(string phoneNumber)
		{
			if ((phoneNumber.Length != 10))
			{
				return false;
			}
			return true;
		}

		// This method checks to see if the phoneNumber is Australian or not
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

        public static void updateCustomer(Customer customer)
        {
            using (var context = new HealthContext())
            {
                var targetCustomer = context.Customers.Find(customer.CustomerId);
                targetCustomer.email = customer.email;
                targetCustomer.phoneNumber = customer.phoneNumber;
                targetCustomer.address = customer.address;
                targetCustomer.password = customer.password;
                context.SaveChanges();
            }
        }

        public static void addCustomer(Customer customer)
        {
            using (var context = new HealthContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

		public static void ensureDBCreated()
		{
			using (var context = new HealthContext())
			{
				//If no database detected
                if ((context.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists() == false)
				{
					//Create database
					context.Database.EnsureCreated();

                    //Add customers
					context.Customers.Add(new Customer("peter.pan@hotmail.com", "Password123", "Peter", "Pan", "12 Main Street", "0490564321", "M", true, true, true, true));
                    context.Customers.Add(new Customer("tammy@tammy.com", "123456", "Tammy", "Tammy", "12 A Street", "0456789010", "F", false, false, false, false));
                    context.Customers.Add(new Customer("yy@yy.com", "1234567aA*", "uyug", "ygug", "12 wat", "0424936302", "P", false, true, false, false));
                    context.Customers.Add(new Customer("test.test@gmail.com", "1234567Aa@", "test", "test", "12 Tea Street", "0490765432", "F", false, false, false, false));
                    context.Customers.Add(new Customer("bb@bb.com", "1234567aA#", "ghjgb", "ghhk", "12 wat", "0424936302", "M", false, false, false, false));
                    context.Customers.Add(new Customer("rr@ff.com", "1234567sS@", "gg", "gg", "111", "0435465734", "M", false, false, false, false));
                    context.Customers.Add(new Customer("t@t.com", "1234567Aa@", "tttt", "ttttt", "12 Main Street", "0490876543", "F", true, false, false, false));
                    context.Customers.Add(new Customer("lat.tal@tal.com", "1234567aA@", "lat", "tal", "12 runner", "0448349524", "M", false, false, false, true));
                    context.Customers.Add(new Customer("aaa@aaa.com", "1234567Aa@", "aaaa", "aaaa", "12 Wat", "0490373534", "F", false, false, false, false));

					//Save database changes
					context.SaveChanges();
                }

            }
		}

    }
}

