using System;
namespace test
{
	public enum CustomerOption {

		Primecustomer =1,
		GoldCustomer ,
		SilverCustomer,
		BronzeCustomer

	}


	class Menu {

		public int PrintMenu(Type t) {
			string[] names = Enum.GetNames(t);
			int[] values = (int[]) Enum.GetValues(t);

			int length = names.Length;
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine("Press {0} for {1}", values[i], names[i]);
			}
			Console.Write("Enter Options => ");
			int choice = Convert.ToInt32(Console.ReadLine());
			return choice;
		}
	}
}

