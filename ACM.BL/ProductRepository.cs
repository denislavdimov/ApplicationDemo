namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieve one product
        public Product Retrieve (int productId)
        {
            // instnace of the Product class
            // pass in the requested id
            Product product = new Product(productId);

            // code that retrieves the defined product

            // temporary hard-coded values to return
            if (productId == 2)
            {
                product.ProductName = "Some Product Name";
                product.ProductDescription = "Some Product Description";
                product.CurrentPrice = 19.99M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}
