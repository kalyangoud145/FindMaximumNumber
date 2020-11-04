using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumNumber;

namespace FindMaxNumberMSTest
{
    [TestClass]
    public class MSTest
    {
        ///TC 5.1
        /// <summary>
        /// Givens the integer array to find maximum integer, given maximum int value at first position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Integer_ToFindMaximumIntegerUsingGenericClassExtentedMaxMethod_Given_MaximumIntValueAtFirstPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            int[] intArray = { 30, 20, 10 };
            int expected = 30;
            //Act
            MaximumNumberCheck.GenericMaximum<int> find = new MaximumNumberCheck.GenericMaximum<int>(intArray);
            int actual = find.MaxValue();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Givens the float array to find maximum float value, using generic class extented maximum method given maximum float value at first position should return expected value.
        /// </summary>
        [TestMethod]
        public void Given_Float_ToFindMaximumFloatUsingGenericClassExtentedMaxMethod_Given_MaximumFloatValueAtFirstPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            float[] floatArray = { 190.1f, 2.3f, 3.6f, 42.3f, 156.36f };
            float expected = 190.1f;
            //Act
            MaximumNumberCheck.GenericMaximum<float> find = new MaximumNumberCheck.GenericMaximum<float>(floatArray);
            float actual = find.MaxValue();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        ///TC 5.3
        /// <summary>
        /// Givens the string array to find maximum string ,given maximum string value at first position return expected value.
        /// </summary>
        [TestMethod]
        public void Given_StirngArray_ToFindMaximumStringUsingGenericClassExtentedMaxMethod_Given_MaximumStringValueAtFirstPosition_Should_ReturnExpectedValue()
        {
            //Arrange
            string[] stringArray = { "Mercedes", "Happy", "Egg", "Lot", "Audi" };
            string expected = "Mercedes";
            //Act
            MaximumNumberCheck.GenericMaximum<string> find = new MaximumNumberCheck.GenericMaximum<string>(stringArray);
            string stringOutput = find.MaxValue();
            //Assert
            Assert.AreEqual(expected, stringOutput);
        }
    }
}