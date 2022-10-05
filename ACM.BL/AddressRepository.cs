using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        //Retrieve one customer
        public Address Retrieve (int addressid)
        {
            // instnace of the Customer class
            // pass in the requested id
            Address address = new Address(addressid);

            // code that retrieves the defined customer

            // temporary hard-coded values to return
            if (addressid == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bulgaria 3";
                address.StreetLine2 = "Pok-a";
                address.City = "Dgrad";
                address.State = "Hsk";
                address.Country = "Middle Earth";
                address.PostalCode = "6400";
            }
            return address;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
