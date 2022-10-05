using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        //Retrieve one customer
        public Customer Retrieve (int customerId)
        {
            // instnace of the Customer class
            // pass in the requested id
            Customer customer = new Customer(customerId);

            // code that retrieves the defined customer

            // temporary hard-coded values to return
            if (customerId == 1)
            {
                customer.EmailAdress = "dimov@gmail.com";
                customer.LastName = "Dimov";
                customer.FirstName = "Denislav";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
