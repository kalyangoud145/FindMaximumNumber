using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FindMaximumNumber
{
    /// <summary>
    /// Class for checking maximum value of given inputs
    /// </summary>
    public class MaximumNumberCheck
    {
        /// <summary>
        /// Generic class for finding maximum value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class GenricMaximum<T> where T : IComparable
        {
            public T firstValue, secondValue, thirdValue;
            /// <summary>
            /// Initializes a new instance of the <see cref="GenricMaximum{T}"/> class.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            public GenricMaximum(T firstValue, T secondValue, T thirdValue)
            {
                this.firstValue = firstValue;
                this.secondValue = secondValue;
                this.thirdValue = thirdValue;
            }
            /// <summary>
            /// Logic for finding Maximum value.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            /// <returns></returns>
            /// <exception cref="Exception">All three values are same</exception>
            public static T MaxValue(T firstValue, T secondValue, T thirdValue)
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return thirdValue;
                }

                throw new Exception("All three values are same");
            }
            /// Returns maximum value
            public T MaxMethod()
            {
                T max = GenricMaximum<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
                return max;
            }
        }
    }
}
