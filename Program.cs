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
            int intOutput = MaximumNumberCheck.MaximumIntegerNumber(80, 40, 20);
            Console.WriteLine("The maximum integer number is: " + intOutput);
            float floatOutput = MaximumNumberCheck.MaximumFloatNumber(101.523f, 150.325f, 100.625f);
            Console.WriteLine("The maximum float number is: " + floatOutput);
            string stringOutput = MaximumNumberCheck.MaximumOfGivenStrings("Apple", "bananna", "Peach");
            Console.WriteLine("The maximum of Strings  is: " + stringOutput);
        }
    }
}
