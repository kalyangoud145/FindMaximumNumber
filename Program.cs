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
        }
    }
}
