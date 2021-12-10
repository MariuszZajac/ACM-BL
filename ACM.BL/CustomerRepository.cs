using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
           
            if (customerId==1)
            {
                customer.EmailAddress = "fbagins@hobbit.me ";
                customer.FirstName = "Frodo";
                customer.LastName = "Bagins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}