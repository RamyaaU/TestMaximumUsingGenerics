using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumUsingGenerics;

namespace UnitTestProject5
{
    [TestClass]
    public class UnitTest1
    {
        /// Refactor - 2 TC 3.1.1
        /// <summary>
        /// Givens the integer array check with generic return maximum value.
        /// </summary>
        [TestMethod]
        public void Given_IntegerArray_Check_With_Generic_Return_MaxValue()
        {
            //Arrange
            int expected = 99;
            GenericMaximum<int> generic = new GenericMaximum<int>(new int[5] { 24, 45, 65, 86, 99 });
            //Act
            int actual = generic.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// Refactor - 2 TC 3.1.2
        /// <summary>
        /// Given the float array check with generic return maximum value.
        /// </summary>
        [TestMethod]
        public void Given_FloatArray_Check_With_Generic_Return_MaxValue()
        {
            GenericMaximum<float> generic = new GenericMaximum<float>(new float[3] { 10.5f, 16.4f, 88.9f });
            //Arrange
            float expected = 88.9f;
            //Act
            float actual = generic.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// Refactor - 3 TC 3.1.3
        /// <summary>
        /// Givens the string array check with generic return maximum value.
        /// </summary>
        [TestMethod]
        public void Given_StringArray_Check_With_Generic_Return_MaxValue()
        { 
            GenericMaximum<string> generic = new GenericMaximum<string>(new string[4] { "Apple", "Banana", "Guava", "Peach" });
            //Arrange
            string expected = "Peach";
            //Act
            string actual = generic.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
