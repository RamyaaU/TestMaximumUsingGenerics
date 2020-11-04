using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumUsingGenerics
{
    /// <summary>
    /// Class for checking maximum value of given inputs
    /// using compareto method and by using integer object method
    /// </summary>
    public class MaximumNumberCheck
    {
        /// <summary>
        /// finds the Maximum integer among 3 integers
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        /// <exception cref="Exception">All three values are same!</exception>
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            //CompareTo method is used to compare two numbers
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

        /// <summary>
        /// finds the Maximum float number among 3 numbers
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        /// <returns></returns>
        /// <exception cref="Exception">All three values are same!</exception>
        public static float MaximumFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            //CompareTo method is used to compare two numbers
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

        public static string MaximumStringValue(string firstValue, string secondValue, string thirdValue)
        {
            //CompareTo is used to compare two strings 
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