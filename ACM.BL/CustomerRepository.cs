namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
           
            if (customerId==1)
            {
                customer.EmailAddress = "fbagins@hobbit.me ";
                customer.FirstName = "Frodo";
                customer.LastName = "Bagins";
            }

            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}