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

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
         
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
         
    //    public Order Retrieve(int orderId)
    //    {
    //        return new Order();
    //    }
        
    //    public List<Order> Retrieve()
    //    {
    //        return new List<Order>();
    //    }

    //    public bool Save()
    //    {
    //        return true;
    //    }
    }
}
