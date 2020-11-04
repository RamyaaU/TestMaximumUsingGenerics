using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumUsingGenerics;

namespace UnitTestProject1
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
    }
}