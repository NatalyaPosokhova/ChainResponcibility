using NUnit.Framework;
using TDD_Kata_Calc;

namespace TDD_KataTests
{
    public class Tests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TryAddEmptyStringShouldBeZeroTest()
        {
            var expected = 0;
            var actual = calculator.Add(string.Empty);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddOneNumShouldBeNumTest()
        {
            //Arrange
            var input = "1";
            var expected = 1;

            //Act
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddTwoNumShouldBeCorrectSumTest()
        {
            //Arrange
            var input = "1,10";
            var expected = 11;

            //Act
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        #region
        //[Test]
        //public void TryAddMoreThanTwoOperandShouldBeErrorTest()
        //{
        //    //Arrange
        //    var input = "7,8,9";
        //    var expected = -1;

        //    //Act
        //    var actual = calculator.Add(input);

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        #endregion

        [Test]
        public void TryAddLongStringShouldBeOverflowTest()
        {
            //Arrange
            var input = "100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000,1";
            var expected = -1;

            //Act
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddTwoNumWithSpaceShouldBeErrorTest()
        {
            //Arrange
            var input = "1 3";
            var expected = -1;

            //Act
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddTwoAlphabeticShouldBeErrorTest()
        {
            //Arrange
            var input = "a,1";
            var expected = -1;

            //Act
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddTwoNumDevidedCommaAndSpaceShouldBeErrorTest()
        {
            //Arrange
            var input = "1, 2";
            var expected = -1;

            //Act
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //////////////////////
        [Test]
        public void TryAddSlashNNumShouldBeSuccess()
        {
            //Arrange
            var input = "2\n7\n8";
            var expected = 17;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddSlashNAndCommaShouldBeSuccess()
        {
            //Arrange
            var input = "67\n88,\n99,\n100";
            var expected = 354;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddCommaAndSlashNShouldBeSuccess()
        {
            //Arrange
            var input = "2,\n5,6,\n7";
            var expected = 20;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddCommaAtTheEndShouldBeError()
        {
            //Arrange
            var input = "34,\n89,";
            var expected = -1;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddSlashNAtTheEndShouldBeError()
        {
            //Arrange
            var input = "2,4,5\n";
            var expected = -1;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddWrongSymbolShouldBeError()
        {
            //Arrange
            var input = "1,5%8\n9";
            var expected = -1;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddSpaceShouldBeError()
        {
            //Arrange
            var input = "23, \n33";
            var expected = -1;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddManyNumShouldBeSuccess()
        {
            //Arrange
            var input = "12,34\n56,\n78,77,3,2,76,90,11";
            var expected = 439;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddNegativeNumShouldBeSuccess()
        {
            //Arrange
            var input = "-12,-34\n56";
            var expected = 10;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /////////////////////
        [Test]
        public void TryAddNewDevidedSymbolShouldBeSuccess()
        {
            //Arrange
            var input = "//#\n1#2#3";
            var expected = 6;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddNewCommaSymbolShouldBeSuccess()
        {
            //Arrange
            var input = "//?\n5?67?89";
            var expected = 161;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddWrongBeginningSymbolShouldBeError()
        {
            //Arrange
            var input = "/#\n7#6#8";
            var expected = -1;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddWrongSlashNSymbolShouldBeError()
        {
            //Arrange
            var input = "//#\\n1#2#5";
            var expected = -1;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TryAddTwoDividedSymbolsShouldBeError()

        {
            //Arrange
            var input = "//##\n1##2##34";
            var expected = -1;

            //Actual
            var actual = calculator.Add(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}