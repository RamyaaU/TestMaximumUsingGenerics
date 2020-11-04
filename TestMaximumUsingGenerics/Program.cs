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
            int MaximumInt = MaximumNumberCheck.GenricMaximum<int>.MaxValue(64, 54, 44);
            Console.WriteLine("Maximum integer value is : " + MaximumInt);
            float MaximumFloat = MaximumNumberCheck.GenricMaximum<float>.MaxValue(94.11f, 14.78f, 24.36f);
            Console.WriteLine("Maximum float value is : " + MaximumFloat);
            string MaximumString = MaximumNumberCheck.GenricMaximum<string>.MaxValue("Apple" , "Banana", "Peach");
            Console.WriteLine("Maximum string value is : " + MaximumString);
        }
    }
}
