using DIO.AvaCloud.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DIO.AvaCloud.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullName_Test_Is_Valid()
        {
            //Arrange
            Customer customer = new Customer()
            {
                FirstName = "Icaro",
                LastName = "Milet"
            };

            string expected = "Icaro Milet";

            //Act
            string result = customer.FullName;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Lastname_Is_Empty()
        {

            //Arrange
            Customer customer = new Customer()
            {
                FirstName = "Icaro"
            };

            string expected = "Icaro";

            //Act
            string result = customer.FullName;

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
