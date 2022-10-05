namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int OrderItemId { get; private set; }

         
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
         
        public OrderItem Retrieve(int orderId)
        {
            return new OrderItem();
        }
        
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
