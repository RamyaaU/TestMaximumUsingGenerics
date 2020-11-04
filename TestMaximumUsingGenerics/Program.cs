using System;

namespace TestMaximumUsingGenerics
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to MaximumTest using Generics!");
            int[] intArray = { 112, 344, 432, 555, 678, 888, 911, 999 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78, 4.10, 3.29, 5.87, 6.21 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333", "55", "999" , "444"};
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}
