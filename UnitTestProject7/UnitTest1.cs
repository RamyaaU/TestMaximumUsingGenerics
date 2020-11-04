using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumUsingGenerics;

namespace UnitTestProject7
{
    [TestClass]
    public class UnitTest1
    {
        //TC 5.1
        /// <summary>
        /// Givens the integer array checks with generic returns maximum value.
        /// </summary>
        [TestMethod]
        public void Given_IntegerArray_Check_With_Generic_Return_MaxValue()
        {
            //Arrange
            int expected = 99;
            GenericMaximum<int> generic = new GenericMaximum<int>(new int[7] { 11, 22, 24, 45, 65, 86, 99 });
            //Act
            int actual = generic.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // TC 5.2
        /// <summary>
        /// Givens the float array check with generic return maximum value.
        /// </summary>
        [TestMethod]
        public void Given_FloatArray_Check_With_Generic_Return_MaxValue()
        {
            GenericMaximum<float> generic = new GenericMaximum<float>(new float[7] {87.03f, 1.2f, 4.9f, 26.01f, 10.5f, 16.4f, 88.9f });
            //Arrange
            float expected = 88.9f;
            //Act
            float actual = generic.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// TC 5.3
        /// <summary>
        /// Givens the string array check with generic return maximum value.
        /// </summary>
        public void Given_StringArray_Check_With_Generic_Return_MaxValue()
        {
            GenericMaximum<string> generic = new GenericMaximum<string>(new string[7] { "Apple", "Banana", "Guava", "Peach", "Orange", "Papaya", "Apricot" });
            //Arrange
            string expected = "Peach";
            //Act
            string actual = generic.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}