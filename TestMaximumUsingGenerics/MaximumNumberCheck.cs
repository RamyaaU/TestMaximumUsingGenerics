using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumUsingGenerics
{
    /// <summary>
    /// Given 3 integer numbers, to find the maximum among three
    /// Used integer object and compareto method to fin max no
    /// </summary>
    public class MaximumNumberCheck
    {
        /// <summary>
        /// Maximums the integer number.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        /// <exception cref="Exception">All three values are same!</exception>
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
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
            throw new Exception("All three values are same!");
        }
    }
}
