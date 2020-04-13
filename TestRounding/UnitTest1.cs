using NUnit.Framework;
using RoudingNumber;

namespace TestRounding
{
    [TestFixture]
    public class Tests
    {
        Program testRoundNumber;
        [SetUp]
        public void Setup()
        {
            testRoundNumber = new Program();
        }

        [TestCase]
        public void TestRoundingUp10()
        {
            // Arrange
            double number = 1.83;
            double number1 = 1.87;
            double spnumber = 1.85;
            double number2 = 1.835;
            double expected = 1.9;

            // Act
            // Rounding up number near to 10
            var roundingNumberTo10 = testRoundNumber.RoundingUpToNearest10(number);
            var roundingNumber1To10 = testRoundNumber.RoundingUpToNearest10(number1);
            var roundingNumber2To10 = testRoundNumber.RoundingUpToNearest10(number2);
            var roundingNumberSepecTo10 = testRoundNumber.RoundingUpToNearest10(spnumber);

            // Assert
            // Rounding up number near to 10
            Assert.AreEqual(roundingNumberTo10, expected);
            Assert.AreEqual(roundingNumber1To10, expected);
            Assert.AreEqual(roundingNumber2To10, expected);
            Assert.AreEqual(roundingNumberSepecTo10, expected);

        }

        [TestCase]
        public void TestRoundingDown10()
        {
            // Arrange
            double number = 1.83;
            double number1 = 1.87;
            double number2 = 1.835;
            double number3 = 1.8932131313;
            double spnumber = 1.85;
            double expected = 1.8;

            // Act
            // Rounding up number near to 10
            var roundingNumberTo10 = testRoundNumber.RoundingDownNearest10(number);
            var roundingNumber1To10 = testRoundNumber.RoundingDownNearest10(number1);
            var roundingNumber2To10 = testRoundNumber.RoundingDownNearest10(number2);
            var roundingNumber3To10 = testRoundNumber.RoundingDownNearest10(number3);
            var roundingNumberSpecTo10 = testRoundNumber.RoundingDownNearest10(spnumber);

            // Assert
            // Rounding up number near to 10
            Assert.AreEqual(roundingNumberTo10, expected);
            Assert.AreEqual(roundingNumber1To10, expected);
            Assert.AreEqual(roundingNumber2To10, expected);
            Assert.AreEqual(roundingNumber3To10, expected);
            Assert.AreEqual(roundingNumberSpecTo10, expected);

        }

        [TestCase]
        public void TestRoundingUpOrDown10()
        {
            // Arrange
            double number = 1.83;
            double number1 = 1.87;
            double number2 = 1.835;
            double number3 = 1.8932131313;
            double spNumber = 1.85;
            double expected = 1.80;
            double expected1 = 1.9;

            // Act
            // Rounding up number near to 10
            var roundingNumberTo10 = testRoundNumber.RoundingUpAndDownNearest10(number);
            var roundingNumber1To10 = testRoundNumber.RoundingUpAndDownNearest10(number1);
            var roundingNumber2To10 = testRoundNumber.RoundingUpAndDownNearest10(number2);
            var roundingNumber3To10 = testRoundNumber.RoundingUpAndDownNearest10(number3);
            var roundingSpNumber = testRoundNumber.RoundingUpAndDownNearest10(spNumber);

            // Assert
            // Rounding up number near to 10
            Assert.AreEqual(roundingNumberTo10, expected);
            Assert.AreEqual(roundingNumber1To10, expected1);
            Assert.AreEqual(roundingNumber2To10, expected);
            Assert.AreEqual(roundingNumber3To10, expected1);
            Assert.AreEqual(roundingSpNumber, expected1);

        }

        [TestCase]
        public void TestRoundingUp5()
        {
            // Arrange
            double number = 1.83;
            double number1 = 1.87;
            double number2 = 1.835;
            double number3 = 1.83567587876;
            double spnumber = 1.85;
            double expected = 1.85;
            double expected1 = 1.9;

            // Act
            // Rounding up number near to 5
            var roundingNumberTo5 = testRoundNumber.RoundingUpToNearest5(number);
            var roundingNumber1To5 = testRoundNumber.RoundingUpToNearest5(number1);
            var roundingNumber2To5 = testRoundNumber.RoundingUpToNearest5(number2);
            var roundingNumber3To5 = testRoundNumber.RoundingUpToNearest5(number3);
            var roundingSp = testRoundNumber.RoundingUpToNearest5(spnumber);

            //Rounding up number near to 10
            Assert.AreEqual(roundingNumberTo5, expected);
            Assert.AreEqual(roundingNumber1To5, expected1);
            Assert.AreEqual(roundingNumber2To5, expected);
            Assert.AreEqual(roundingNumber3To5, expected);
            Assert.AreEqual(roundingSp, expected);
        }
        
        [TestCase]
        public void TestRoundingDown5()
        {
            // Arrange
            double number = 1.83;
            double number1 = 1.87;
            double number2 = 1.835;
            double number3 = 1.83567587876;
            double spnumber = 1.85;
            double expected = 1.80;
            double expected1 = 1.85;

            // Act
            // Rounding up number near to 5
            var roundingNumberTo5 = testRoundNumber.RoundingDownNearest5(number);
            var roundingNumber1To5 = testRoundNumber.RoundingDownNearest5(number1);
            var roundingNumber2To5 = testRoundNumber.RoundingDownNearest5(number2);
            var roundingNumber3To5 = testRoundNumber.RoundingDownNearest5(number3);
            var roundingSpNumber = testRoundNumber.RoundingDownNearest5(spnumber);

            //Rounding up number near to 10
            Assert.AreEqual(roundingNumberTo5, expected);
            Assert.AreEqual(roundingNumber1To5, expected1);
            Assert.AreEqual(roundingNumber2To5, expected);
            Assert.AreEqual(roundingNumber3To5, expected);
            Assert.AreEqual(roundingSpNumber, expected1);
        }

        [TestCase]
        public void TestRoundingUpOrDown5()
        {
            // Arrange
            double number = 1.81;
            double number1 = 1.83;
            double number2 = 1.87;
            double number3 = 1.88;
            double spnumber = 1.85;

            double expected = 1.80;
            double expected1 = 1.85;
            double expected2 = 1.9;

            // Act
            // Rounding up number near to 5
            var roundingNumberTo5 = testRoundNumber.RoundingUpAndDownNearest5(number);
            var roundingNumber1To5 = testRoundNumber.RoundingUpAndDownNearest5(number1);
            var roundingNumber2To5 = testRoundNumber.RoundingUpAndDownNearest5(number2);
            var roundingNumber3To5 = testRoundNumber.RoundingUpAndDownNearest5(number3);
            var roundingSpNumber = testRoundNumber.RoundingUpAndDownNearest5(spnumber);

            //Rounding up number near to 10
            Assert.AreEqual(roundingNumberTo5, expected);
            Assert.AreEqual(roundingNumber1To5, expected1);
            Assert.AreEqual(roundingNumber2To5, expected1);
            Assert.AreEqual(roundingNumber3To5, expected2);
            Assert.AreEqual(roundingSpNumber, expected1);
        }
    }
}