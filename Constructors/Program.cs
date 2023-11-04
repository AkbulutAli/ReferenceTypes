namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="Ali Sefa",LastName="AKBULUT",City="Kayseri" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            
            Customer customer2 = new Customer (2, "Ibrahim", "AKBULUT", "Istanbul");

            Console.WriteLine (customer2.FirstName);
           
        }

        static void Method (int id, string firstName, string lastName, string city)
        {

        }
    }
    class Customer
    {
        //default constructor
        public Customer()
        {
            
        }
        
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}