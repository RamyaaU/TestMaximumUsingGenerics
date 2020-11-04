using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumUsingGenerics
{
    /// <summary>
    /// Generic class where datatype is defined
    /// in generic class, whenever a compare to method is defined,
    /// it's defining interface-IComparable neeeds to be inherited.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericMaximum<T> where T : IComparable
    {
        //declaring variables of generic type
        public T firstValue, secondValue, thirdValue;

        /// <summary>
        /// parameter constructor to initialize variables
        /// Initializes a new instance of the <see cref="GenricMaximum{T}"/> class.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        /// <summary>
        /// MaxValue is used to find out max by using generics, any data type can be provided
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

        /// <summary>
        /// method used to Sort numbers.
        /// </summary>
        /// <param name="inputNumbers">The input numbers.</param>
        /// <returns></returns>

        //defining variable for generic type
        public T[] value;

        /// <summary>
        /// parameter constructor to initialize variables 
        /// Initializes a new instance of the <see cref="GenericMaximum{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }

        /// <summary>
        /// used to sort a array which is created due to declaration of params
        /// Sorts the specified values.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        /// <summary>
        /// Adds the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        void add(params int[] a)
        {

        }

        /// <summary>
        /// Maximums the value by sorting array 
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[sorted_values.Length - 1];
        }

        /// <summary>
        /// Stores the max value on max variable and returns it
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        /// <summary>
        /// Stores the max value on max variable and prints it
        /// </summary>
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
