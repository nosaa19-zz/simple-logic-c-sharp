using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCode.Service;
using SimpleCode.Domain;

namespace SimpleCodeTest
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            SimpleServices simples = new SimpleServices();

            //Arrage
            string expected = simples.ReverseString("lorem ipsum");

            //Act
            string actual = "muspi merol";

            //Assert
            Assert.AreEqual(expected, actual, "The ReverseString Method Not Correct");
        }
    }
}
