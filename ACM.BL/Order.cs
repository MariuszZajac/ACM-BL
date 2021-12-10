using System;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = !(OrderDate==null);
            return isValid;
        }
    }
}