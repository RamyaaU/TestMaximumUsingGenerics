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
            int MaximumInt = MaximumNumberCheck.MaximumIntegerNumber(30, 20, 10);
            Console.WriteLine("Maximum integer value is : " + MaximumInt);
            float MaximumFloat = MaximumNumberCheck.MaximumFloatNumber(111.2f, 22.45f, 78.56f);
            Console.WriteLine("Maximum float value is : " + MaximumFloat);
        }
    }
}
