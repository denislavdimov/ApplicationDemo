using ACM.BL;

namespace ACM.BLTests
{
    public class CustomerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullNameValidTest()     
        {
            //Arrange
            var customer = new Customer
            {
                FirstName = "Denislav",
                LastName = "Dimov"
            };
            string expected = "Dimov, Denislav";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.That(actual, Is.EqualTo(expected)); ;
        }

        [Test]
        public void FullNameFirstNameEmptyTest()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Dimov"
            };
            string expected = "Dimov";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.That(actual, Is.EqualTo(expected)); ;
        }

        [Test]
        public void FullNameLastNameEmptyTest()
        {
            //Arrange
            var customer = new Customer
            {
                FirstName = "Denislav"
            };
            string expected = "Denislav";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.That(actual, Is.EqualTo(expected)); ;
        }

        [Test]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer
            {
                FirstName = "Gosho"
            };
            Customer.InstanceCount += 1;
            var c2 = new Customer
            {
                FirstName = "Petkan"
            };
            Customer.InstanceCount += 1;
            var c3 = new Customer
            {
                FirstName = "Frodo"
            };
            Customer.InstanceCount += 1;
            //Act

            //Assert
            Assert.That(Customer.InstanceCount, Is.EqualTo(3)); ;
        }

        [Test]
        public void ValidateValidTest()
        {
            //Arrange
            var customer = new Customer()
            {
                LastName = "Dimov",
                EmailAdress = "denkata@gmail.com"
            };
            var expected = true;
            //Act
            var actual = customer.Validate();
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ValidateInValidTest()
        {
            //Arrange
            var customer = new Customer()
            {
                //LastName = "Dimov",
                EmailAdress = "denkata@gmail.com"
            };
            var expected = false;
            //Act
            var actual = customer.Validate();
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}