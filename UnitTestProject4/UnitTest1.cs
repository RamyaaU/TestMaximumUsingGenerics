using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumUsingGenerics;

namespace UnitTestProject4
{
    /// <summary>
    /// This test class is implemented using generic method
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// Refactor-1 TC 3.1.1
        /// <summary>
        /// Given the int maximum number at first position return maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        [TestMethod]
        [DataRow(98, 78, 48)]
        public void Given_Int_Max_Number_At_First_Position_Return_Max(int firstValue, int secondValue, int thirdValue)
        {
            //Arrange
            int expected = firstValue;
            //Act
            int result = MaximumNumberCheck.GenricMaximum<int>.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// Refactor-1 TC - 3.1.2
        /// <summary>
        /// Given the float maximum number at second position return maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        [TestMethod]
        [DataRow(43.6f, 65.1f, 11.4f)]
        public void Given_Float_Max_Number_At_Second_Position_Return_Max(float firstValue, float secondValue, float thirdValue)
        {
            //Arrange
            float expected = secondValue;
            //Act
            float result = MaximumNumberCheck.GenricMaximum<float>.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// Refactor-1 TC - 3.1.3
        /// <summary>
        /// Given the string maximum value at third position return maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        [TestMethod]
        [DataRow("Banana", "Apple", "Peach")]
        public void Given_String_Max_value_At_Third_Position_Return_Max(string firstValue, string secondValue, string thirdValue)
        {
            //Arrange
            string expected = thirdValue;
            //Act
            string result = MaximumNumberCheck.GenricMaximum<string>.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
