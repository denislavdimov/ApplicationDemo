using ACM.BL;

namespace ACM.BLTests
{
    public class ProductRepositoryTest
    {
        [Test]
        public void RetrieveValid()
        {
            //Arrange
            var productRep = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Some Product Name",
                ProductDescription = "Some Product Description",
                CurrentPrice = 19.99M
        };
            //Act
            var actual = productRep.Retrieve(2);
            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(expected.ProductId, Is.EqualTo(actual.ProductId));
                Assert.That(expected.ProductName, Is.EqualTo(actual.ProductName));
                Assert.That(expected.ProductDescription, Is.EqualTo(actual.ProductDescription));
                Assert.That(expected.CurrentPrice, Is.EqualTo(actual.CurrentPrice));
            });

        }
    }
}
 