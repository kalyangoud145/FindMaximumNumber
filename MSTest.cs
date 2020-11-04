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
        ///TC 2.1
        /// <summary>
        /// Givens the float to find maximum flot ,given maximum flot value at first position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Float_ToFindMaximumFloat_Given_MaximumFloatValueAtFirstPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            float expected = 10.15f;
            //Act
            float actual = MaximumNumberCheck.MaximumFloatNumber(10.15f, 9.25f, 8.20f);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///TC 2.2
        /// <summary>
        /// Givens the float to find maximum flot, given maximum float value at Second position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Float_ToFindMaximumFloat_Given_MaximumFloatValueAtSecondPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            float expected = 79.25f;
            //Act
            float actual = MaximumNumberCheck.MaximumFloatNumber(10.15f, 79.25f, 8.20f);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///TC 2.3
        /// <summary>
        /// Givens the float to find maximum flot, given maximum float value at third position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Float_ToFindMaximumFloat_Given_MaximumFloatValueAtThirdPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            float expected = 86.20f;
            //Act
            float actual = MaximumNumberCheck.MaximumFloatNumber(10.15f, 79.25f, 86.20f);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///TC 3.1
        /// <summary>
        /// Givens the String  values to find maximum  ,given maximum string value at first position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_String_ToFindMaximumOfStringValue_Given_MaximumStringValueAtFirstPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            string expected = "pot";
            //Act
            string actual = MaximumNumberCheck.MaximumOfGivenStrings("pot", "apple", "ball");
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
