using System;
using System.Collections;
using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.State = "Shire";
                address.StreetLine1 = "BagEnd";
                address.StreetLine2 = "Bangshot";
                address.City = "Hobbiton";
                address.Country = "MiddleEarth";
                address.PostalCode = "125";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                State = "Shire",
                StreetLine1 = "BagEnd",
                StreetLine2 = "Bangshot",
                City = "Hobbiton",
                Country = "MiddleEarth",
                PostalCode = "125",

            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                State = "Shire2",
                StreetLine1 = "BagEnd2",
                StreetLine2 = "Bangshot2",
                City = "Hobbiton2",
                Country = "MiddleEarth2",
                PostalCode = "1252",
            };
            addressList.Add(address);

            return addressList;
        }
    }
}