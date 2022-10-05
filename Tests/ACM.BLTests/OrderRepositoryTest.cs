using ACM.BL;

namespace ACM.BLTests
{
    public class OrderRepositoryTest
    {
        [Test]
        public void RetrieveValid()
        {
            //Arrange
            var orderRep = new OrderRepository();
            var expected = new Order(14)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0))
        };
            //Act
            var actual = orderRep.Retrieve(14);
            //Assert
            Assert.That(actual.OrderDate, Is.EqualTo(expected.OrderDate));
        }
    }
}
 