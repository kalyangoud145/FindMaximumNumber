using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumNumber;

namespace FindMaxNumberMSTest
{
    [TestClass]
    public class MSTest
    {
        ///TC 1.1
        /// <summary>
        /// Givens the integer to find maximum integer given maximum int value at first position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Integer_ToFindMaximumInteger_Given_MaximumIntValueAtFirstPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            int expected = 10;
            //Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(10, 9, 8);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///TC 1.2
        /// <summary>
        /// Givens the integer to find maximum integer ,maximum number at second position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Integer_ToFindMaximumInteger_MaximumNumber_AtSecondPosition_ReturnExpectedValue()
        {
            //Arrange
            int expected = 10;
            //Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(7, 10, 8);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
