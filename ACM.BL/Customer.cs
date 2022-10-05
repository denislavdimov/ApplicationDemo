namespace ACM.BL
{
    public class Customer
    {
        public Customer():this(0) // constructor chaining, '0' is a customerId parameter ->
                                  // default constructor calls the parameterized constructor
        {
                
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>(); // with this way accessing without a null value exception
        }

        public List<Address> AddressList { get; private set; } // null value exception
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public int CustomerId { get; private set; }
        public static int InstanceCount { get; set; }
        public string FullName
        {
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        ////Retrieve one customer
        //public Customer Retrieve(int customerId)
        //{
        //    return new Customer();
        //}
        
        ////Retrieve all customers
        //public List<Customer> Retrieve()
        //{
        //    return new List<Customer>();
        //}

        //Validate customer data
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;
            return isValid; 
        }

    }
} 