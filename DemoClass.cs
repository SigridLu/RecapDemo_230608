using System;
namespace test
{
    public interface ICustomer {
        void Validate();
    }

	class PrimeCustomer :ICustomer {
		public void Validate() {
			Console.WriteLine("Prime Customer");
		}
	}
	class GoldCustomer :ICustomer{
        public void Validate()
        {
            Console.WriteLine("Gold Customer");
        }
    }
	class SilverCustomer :ICustomer{
        public void Validate()
        {
            Console.WriteLine("Silver Customer");
        }
    }



	class CustomerFactory {
        // it will create the object of parent type

        Dictionary<string, ICustomer> customerCollections;
        public CustomerFactory()
        {
            customerCollections = new Dictionary<string, ICustomer>();
            customerCollections.Add("Prime", new PrimeCustomer());
            customerCollections.Add("Gold", new GoldCustomer());
            customerCollections.Add("Silver", new SilverCustomer());
        }

        public ICustomer GetObject(int choice)
        {
            switch (choice)
            {
                case (int) CustomerOption.Primecustomer:
                    return new PrimeCustomer();
                case (int) CustomerOption.GoldCustomer:
                    return new GoldCustomer();
                case (int) CustomerOption.SilverCustomer:
                    return new SilverCustomer();
                    
                default:
                    return null;
            }

        }


        public ICustomer GetObject2(string type)
        {
            return customerCollections[type];
        }

	}
}

