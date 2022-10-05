using ACM.BL;

namespace ACM.BLTests
{
    public class CustomerRepositoryTest
    {
        [Test]
        public void RetrieveValid()
        {
            //Arrange
            var customerRep = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "dimov@gmail.com",
                LastName = "Dimov",
                FirstName = "Denislav"
        };
            //Act
            var actual = customerRep.Retrieve(1);
            //Assert
            //Assert.That(actual, Is.EqualTo(expected));
            Assert.That(expected.CustomerId, Is.EqualTo(actual.CustomerId));
            Assert.That(expected.EmailAdress, Is.EqualTo(actual.EmailAdress));
            Assert.That(expected.LastName, Is.EqualTo(actual.LastName));
            Assert.That(expected.FirstName, Is.EqualTo(actual.FirstName));
        }

    }
}
 