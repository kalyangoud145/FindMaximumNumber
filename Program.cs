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
            int intOutput = new MaximumNumberCheck.GenricMaximum<int>(1, 2, 3).MaxMethod();
            Console.WriteLine("Maximum of three integers: "+intOutput);
            float floatOutput = new MaximumNumberCheck.GenricMaximum<float>(1.1f, 2.3f, 3.6f).MaxMethod();
            Console.WriteLine("Maximum of three float numbers: "+floatOutput);
            string stringOutput = new MaximumNumberCheck.GenricMaximum<string>("Apple", "Ball", "Gun").MaxMethod();
            Console.WriteLine("Maximum of three strings: " + stringOutput);
        }
    }
}
