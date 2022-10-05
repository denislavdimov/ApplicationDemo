using ACM.BL;

namespace ACM.BLTests
{
    public class ProductTests
    {
        [Test]
        public void ValidateValidTest()
        {
            //Arrange
            var product = new Product()
            {
                ProductName = "SomeCoolName",
                CurrentPrice = (decimal?)19.99
            };
            var expected = true;
            //Act
            var actual = product.Validate();
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ValidateProductNameEmptyTest()
        {
            //Arrange
            var product = new Product()
            {
                //ProductName = "SomeCoolName",
                CurrentPrice = (decimal?)19.99
            };
            var expected = false;
            //Act
            var actual = product.Validate();
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ValidateCurrentPriceEmptyTest()
        {
            //Arrange
            var product = new Product()
            {
                ProductName = "SomeCoolName",
                //CurrentPrice = (decimal?)19.99
            };
            var expected = false;
            //Act
            var actual = product.Validate();
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
