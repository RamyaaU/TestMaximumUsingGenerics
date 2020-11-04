using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumUsingGenerics;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        /// TC 1.1 
        /// <summary>
        /// Given the int maximum number at first position returns maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        [TestMethod]
        [DataRow(9, 4, 1)]
        [DataRow(43, 32, 11)]
        public void Given_Int_Max_Number_At_First_Position_Return_Max(int firstValue, int secondValue, int thirdValue)
        {
            //Arrange
            int expected = firstValue;
            //Act
            int result = MaximumNumberCheck.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// TC 1.2
        /// <summary>
        /// Given the int maximum number at second position returns maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        [TestMethod]
        [DataRow(9, 23, 1)]
        [DataRow(43, 65, 11)]
        public void Given_Int_Max_Number_At_Second_Position_Return_Max(int firstValue, int secondValue, int thirdValue)
        {
            //Arrange
            int expected = secondValue;
            //Act
            int result = MaximumNumberCheck.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// TC 1.3 
        /// <summary>
        /// Given the int maximum number at third position returns maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        [TestMethod]
        [DataRow(9, 4, 43)]
        [DataRow(43, 32, 85)]
        public void Given_Int_Max_Number_At_Third_Position_Return_Max(int firstValue, int secondValue, int thirdValue)
        {
            //Arrange
            int expected = thirdValue;
            //Act
            int result = MaximumNumberCheck.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// TC 2.1 
        /// <summary>
        /// Given the float maximum number at first position returns maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        [TestMethod]
        [DataRow(9.4f, 4.1f, 1.01f)]
        [DataRow(43.7f, 32.52f, 11.9f)]
        public void Given_Float_Max_Number_At_First_Position_Return_Max(float firstValue, float secondValue, float thirdValue)
        {
            //Arrange
            float expected = firstValue;
            //Act
            float result = MaximumNumberCheck.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// TC 2.2
        /// <summary>
        /// Given the float maximum number at second position returns maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        [TestMethod]
        [DataRow(9.1f, 23.5f, 1.4f)]
        [DataRow(43.6f, 65.1f, 11.4f)]
        public void Given_Float_Max_Number_At_Second_Position_Return_Max(float firstValue, float secondValue, float thirdValue)
        {
            //Arrange
            float expected = secondValue;
            //Act
            float result = MaximumNumberCheck.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// TC 2.2
        /// <summary>
        /// Givens the float maximum number at third position return maximum.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <param name="thirdValue">The third value.</param>
        [TestMethod]
        [DataRow(9.6f, 4.3f, 43.6f)]
        [DataRow(43.1f, 32.3f, 85.9f)]
        public void Given_Float_Max_Number_At_Third_Position_Return_Max(float firstValue, float secondValue, float thirdValue)
        {
            //Arrange
            float expected = thirdValue;
            //Act
            float result = MaximumNumberCheck.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
       