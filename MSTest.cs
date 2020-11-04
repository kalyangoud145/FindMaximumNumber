using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumNumber;

namespace FindMaxNumberMSTest
{
    [TestClass]
    public class MSTest
    {
        ///Tc 1.1
        /// <summary>
        /// Givens the integer  to find maximum integer return Expected value
        /// </summary>
        [TestMethod]
        public void Given_Integer_ToFindMaximumInteger_ReturnExpectedValue()
        {
            //Arrange
            int expected = 10;
            //Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(10, 9, 8);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
