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
        public void TestOnOffButton()
        {
            // Ensure calculator is off at the beginning
            Assert.IsFalse(calculator.isCalculatorPowerOn);

            // Click the On/Off button to turn on the calculator
            calculator.buttonOnOff.PerformClick();

            // Check that the button text has changed to "On" and the calculator is now on
            Assert.AreEqual("On", calculator.buttonOnOff.Text);
            Assert.IsTrue(calculator.isCalculatorPowerOn);

            // Click the On/Off button to turn off the calculator
            calculator.buttonOnOff.PerformClick();

            // Check that the button text has changed back to "Off" and the calculator is now off
            Assert.AreEqual("Off", calculator.buttonOnOff.Text);
            Assert.IsFalse(calculator.isCalculatorPowerOn);
        }

        [TestMethod]
        public void TestDigitButtons()
        {
            // Ensure calculator is on
            calculator.isCalculatorPowerOn = true;

            // Click the "1" button
            calculator.button1.PerformClick();

            // Check that the number "1" has been appended to the text box
            Assert.AreEqual("1", calculator.textBoxNumbers.Text);

            // Click the "2" button
            calculator.button2.PerformClick();

            // Check that the number "2" has been appended to the text box
            Assert.AreEqual("12", calculator.textBoxNumbers.Text);
        }

        [TestMethod]
        public void TestArithmeticButtons()
        {
            // Ensure calculator is on
            calculator.isCalculatorPowerOn = true;

            // Enter the number 10
            calculator.button1.PerformClick();
            calculator.button0.PerformClick();

            // Click the "+" button
            calculator.buttonAddition.PerformClick();

            // Check that the operation symbol is "+"
            Assert.AreEqual("+", calculator.operationSymbol);

            // Enter the number 5
            calculator.button5.PerformClick();

            // Click the "=" button
            calculator.buttonEquals.PerformClick();

            // Check that the result is 15
            Assert.AreEqual("15", calculator.textBoxResult.Text);
        }

        [TestMethod]
        public void TestReverseButton()
        {
            // Ensure calculator is on
            calculator.isCalculatorPowerOn = true;

            // Enter the number 2
            calculator.button2.PerformClick();

            // Click the "1/x" button
            calculator.buttonDivisionByX.PerformClick();

            // Check that the result is 0.5
            Assert.AreEqual("0.5", calculator.textBoxResult.Text);
        }

        [TestMethod]
        public void TestSqrtButton()
        {
            // Ensure calculator is on
            calculator.isCalculatorPowerOn = true;

            // Enter the number 16
            calculator.button1.PerformClick();
            calculator.button6.PerformClick();

            // Click the "sqrt" button
            calculator.buttonSqrt.PerformClick();

            // Check that the result is 4
            Assert.AreEqual("4", calculator.textBoxResult.Text);
        }

        [TestMethod]
        public void TestPowerTwoButton()
        {


            // Ensure calculator is on
            calculator.isCalculatorPowerOn = true;

            // Enter the number 3
            calculator.button3.PerformClick();

            // Click the "x^2" button
            calculator.buttonSquare.PerformClick();

            // Check if the result is correct
            Assert.AreEqual("9", calculator.textBoxResult.Text);


        }
    }
}
