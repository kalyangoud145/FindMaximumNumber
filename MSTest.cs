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
        /// Givens the integer to find maximum integer given maximum int value at Third position should return expected value.
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
        /// <summary>
        /// Givens the negative float to find maximum integers should return expected value.
        /// </summary>
        /// TC 2.4
        [TestMethod]
        public void Given_NegativeFloat_ToFindMaximumIntegers_Should_Return_ExpectedValue()
        {
            //Arrange
            float expected = -7.02f;
            //Act
            float actual = MaximumNumberCheck.MaximumFloatNumber(-7.02f, -15.05f, -80.03f);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Givens the two equal negative float numbers to find maximum integers should return expected value.
        /// </summary>
        /// TC 2.5
        [TestMethod]
        public void Given_TwoEqualNegativeFloatNumbers_ToFindMaximumIntegers_Should_Return_ExpectedValue()
        {
            //Arrange
            float expected = -7.0f;
            //Act
            float actual = MaximumNumberCheck.MaximumFloatNumber(-7.0f, -7.0f, -80.02f);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///TC 2.6
        /// <summary>
        /// Givens all float numbers are equal to find maximum value should return all values are equal exception.
        /// </summary>
        [TestMethod]
        public void Given_AllFloatNumbersAreEqual_ToFindMaximumValue_Should_Return_AllValuesAreEqual_Exception()
        {
            try
            {
                //Act
                float actual = MaximumNumberCheck.MaximumFloatNumber(-7, -7, -7);
            }
            catch (Exception e)
            {
                //Arrange
                string expected = "All three values are same";
                //Assert
                Assert.AreEqual(expected, e.Message);
            }
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
        ///TC 3.2
        /// <summary>
        /// Givens the String  values to find maximum  ,given maximum string value at second position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_String_ToFindMaximumOfStringValue_Given_MaximumStringValueAtSecondPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            string expected = "monkey";
            //Act
            string actual = MaximumNumberCheck.MaximumOfGivenStrings("cat", "monkey", "goat");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        ///TC 3.3
        /// <summary>
        /// Givens the String  values to find maximum  ,given maximum string value at third position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_String_ToFindMaximumOfStringValue_Given_MaximumStringValueAtThirdPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            string expected = "kiwi";
            //Act
            string actual = MaximumNumberCheck.MaximumOfGivenStrings("apple", "guava", "kiwi");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// TC 3.4
        /// <summary>
        /// Givens the strings to find maximum value given all strings are equal should thow exception.
        /// </summary>
        [TestMethod]
        public void Given_Strings_ToFindMaximumValue_Given_AllStringsAreEqual_Should_ThowException()
        {
            try
            {
                //Act
                string actual = MaximumNumberCheck.MaximumOfGivenStrings("apple", "apple", "apple");
            }
            catch (Exception e)
            {
                string expected = "All three values are same";
                Assert.AreEqual(expected, e.Message);
            }
        }
        //TC 3.5
        /// <summary>
        /// Givens the string to find maximum of string value given two strings are same should return expected value.
        /// </summary>
        [TestMethod]
        public void Given_String_ToFindMaximumOfStringValue_Given_TwoStringsAreSame_Should_ReturnExpectedValue()
        {
            //Arrange
            string expected = "KIWI";
            //Act
            string actual = MaximumNumberCheck.MaximumOfGivenStrings("KIWI", "GUAVA", "KIWI");
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}