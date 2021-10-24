using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		String name;
		int empId;
		String address;
		long mobileno;
		String mailid;
		String qualification;
		DateTime joiningDate;
		public void employeeDetails()
		{
			Console.WriteLine("Please Enter your Choices:");
			Console.WriteLine("1.Entering the Details 2.Displaying the Details");
			int x = Convert.ToInt32(Console.ReadLine());
			switch (x)
			{

				case 1:
					Console.WriteLine("Enter your EmpId :");
					empId = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter your Name :");
					name = Console.ReadLine();
					Console.WriteLine("Enter your Address :");
					address = Console.ReadLine();
					Console.WriteLine("Enter your MobileNo :");
					mobileno = Convert.ToInt64(Console.ReadLine());
					Console.WriteLine("Enter your MailId :");
					mailid = Console.ReadLine();
					Console.WriteLine("Enter your Qualification :");
					qualification = Console.ReadLine();
					Console.WriteLine("Enter Joining Date :");
					joiningDate = DateTime.Parse(Console.ReadLine());
					Console.Read();
					break;
				case 2:
					Console.WriteLine(name);
					Console.WriteLine(empId);
					Console.WriteLine(address);
					Console.WriteLine(mobileno);
					Console.WriteLine(mailid);
					Console.WriteLine(qualification);
					Console.WriteLine(joiningDate.ToString("dd-MM-yyyy"));
					break;
				default:
					System.Environment.Exit(0);
					break;

			}

		}
		static void Main(string[] args)
		{
			Program p1 = new Program();
			p1.employeeDetails();


		}
	}
}
