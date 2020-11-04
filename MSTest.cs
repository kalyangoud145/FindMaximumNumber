using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumNumber;

namespace FindMaxNumberMSTest
{
    [TestClass]
    public class MSTest
    {
        ///TC 3.4
        /// <summary>
        /// Givens the integer to find maximum integer given maximum int value at first position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Integer_ToFindMaximumIntegerUsingGenericClass_Given_MaximumIntValueAtFirstPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            int expected = 10;
            //Act
            int intOutput = new MaximumNumberCheck.GenricMaximum<int>(10, 2, 3).MaxMethod();
            //Assert
            Assert.AreEqual(expected, intOutput);
        }
        ///TC 3.5
        /// <summary>
        /// Givens the float to find maximum float given maximum float value at first position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Float_ToFindMaximumFloatUsingGenericClass_Given_MaximumFloatValueAtFirstPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            float expected = 10.20f;
            //Act
            float floatOutput = new MaximumNumberCheck.GenricMaximum<float>(10.20f, 2.3f, 8.5f).MaxMethod();
            //Assert
            Assert.AreEqual(expected, floatOutput);
        }
        ///TC 3.6
        /// <summary>
        /// Givens the string to find maximum string given maximum string value at first position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Stirng_ToFindMaximumStringUsingGenericClass_Given_MaximumStringValueAtFirstPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            string expected = "Spicy";
            //Act
            string stringOutput = new MaximumNumberCheck.GenricMaximum<string>("Spicy", "Apple", "Bowl").MaxMethod();
            //Assert
            Assert.AreEqual(expected, stringOutput);
        }
    }
}