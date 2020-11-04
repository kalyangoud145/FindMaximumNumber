using System;

namespace FindMaximumNumber
{
    /// <summary>
    /// Main class for implementation
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 16 };
            float[] floatArray = { 1.1f, 2.3f, 3.6f, 42.3f, 156.36f };
            string[] stringArray = { "Happy", "Egg", "Lot", "Mercedes" };
            new MaximumNumberCheck.GenericMaximum<int>(intArray).PrintMax();
            new MaximumNumberCheck.GenericMaximum<float>(floatArray).PrintMax();
            new MaximumNumberCheck.GenericMaximum<string>(stringArray).PrintMax();
        }
    }
}
