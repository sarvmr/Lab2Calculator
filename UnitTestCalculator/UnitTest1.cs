using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab2Calculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        private FormCalculator calculator;

        [TestInitialize]
        public void TestSetup()
        {
            // This method will be called before each test case is executed.
            // We create a new instance of the calculator form before each test case.
            calculator = new FormCalculator();
        }

        [TestMethod]
        public void TestAddition()
        {
            double actualResult = FormCalculator.calculateResult("+", 2, 3);
            Assert.AreEqual(5, actualResult);
        }

        [TestMethod]
        public void TestDivision()
        {
            double actualResult = FormCalculator.calculateResult("/", 10, 2);
            Assert.AreEqual(5, actualResult);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            double actualResult = FormCalculator.calculateResult("*", 2, 3);
            Assert.AreEqual(6, actualResult);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            double actualResult = FormCalculator.calculateResult("-", 2, 3);
            Assert.AreEqual(-1, actualResult);
        }

        [TestMethod]
        public void TestModulus()
        {
            double actualResult = FormCalculator.calculateResult("%", 10, 3);
            Assert.AreEqual(1, actualResult);
        }

        [TestMethod]
        public void TestCannotDivideByZero()
        {
            String exceptionMessage = null;
            try
            {
                FormCalculator.calculateResult("/", 2, 0);
            } catch (Exception ex)
            {
                exceptionMessage = ex.Message;
            }
            Assert.AreEqual("Cannot divide by zero", exceptionMessage);
        }

        [TestMethod]
        public void TestCannotDivideByZeroUsingModulus()
        {
            String exceptionMessage = null;
            try
            {
                FormCalculator.calculateResult("%", 2, 0);
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;
            }
            Assert.AreEqual("Cannot divide by zero", exceptionMessage);
        }

        [TestMethod]
        public void TestPowerTwoFromResultField()
        {
            double actualResult = FormCalculator.powerTwo("", "6");
            Assert.AreEqual(36, actualResult);
        }

        [TestMethod]
        public void TestPowerTwoFromNumberField()
        {
            double actualResult = FormCalculator.powerTwo("7", "6");
            Assert.AreEqual(49, actualResult);
        }

        
    }
}
