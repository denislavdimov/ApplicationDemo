namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
            //ProductId = 123456;
        }

        public Product(int productId)
        {
            ProductId = productId;   
        }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

        //public Product Retrieve(int productId )
        //{
        //    return new Product();
        //}
        
        //public List<Product> Retrieve()
        //{
        //    return new List<Product>();
        //}

        //public bool Save()
        //{
        //    return true;
        //}
    }
}
