using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumNumber;
using System;

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
        ///TC 1.3
        /// <summary>
        /// Givens the integer to find maximum integer given maximum int value at first position should return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Integer_ToFindMaximumInteger_Given_MaximumIntValueAtThirdPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            int expected = 80;
            //Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(7, 15, 80);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///TC 1.4
        /// <summary>
        /// Givens the negative integers to find maximum of integers should return expected value.
        /// </summary>
        [TestMethod]
        public void Given_NegativeIntegers_ToFindMaximumIntegers_Should_Return_ExpectedValue()
        {
            //Arrange
            int expected = -7;
            //Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(-7, -15, -80);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///TC 1.5
        /// <summary>
        /// Givens the two equal negative integers to find maximum integers should return expected value.
        /// </summary>
        [TestMethod]
        public void Given_TwoEqualNegativeIntegers_ToFindMaximumIntegers_Should_Return_ExpectedValue()
        {
            //Arrange
            int expected = -7;
            //Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(-7, -7, -80);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///TC 1.6
        /// <summary>
        /// Givens all integers are equal to find maximum value should return all values are equal exception.
        /// </summary>
        [TestMethod]
        public void Given_AllIntegersAreEqual_ToFindMaximumValue_Should_Return_AllValuesAreEqual_Exception()
        {
            try
            {

                //Act
                int actual = MaximumNumberCheck.MaximumIntegerNumber(-7, -7, -7);
            }
            catch (Exception e)
            {
                //Arrange
                string expected = "All three values are same";
                //Assert
                Assert.AreEqual(expected, e.Message);

            }

        }

    }
}
