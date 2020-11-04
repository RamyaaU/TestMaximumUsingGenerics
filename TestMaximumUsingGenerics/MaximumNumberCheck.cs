using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumUsingGenerics
{
    public class MaximumNumberCheck
    {
        
        /// <summary>
        /// Generic class where datatype is defined
        /// in generic class, whenever a compare to method is defined,
        /// it's defining interface-IComparable neeeds to be inherited.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class GenricMaximum<T> where T : IComparable
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
            public GenricMaximum(T firstValue, T secondValue, T thirdValue)
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

            /// used to pass the values from parametrized constructor to MaxValue static method
            /// Returns maximum value
            public T MaxMethod()
            {
                T max = GenricMaximum<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
                return max;
            }
        }
    }
}
