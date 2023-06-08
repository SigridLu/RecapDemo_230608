using System;
namespace test
{
	public class Employee
	{
		
		public Employee(string name)
		{
			Console.WriteLine(name);
		}
	}

	public class FullTime : Employee {

		public FullTime():base("smith")
		{
			Console.WriteLine("Derived class");
		}
	}
}

