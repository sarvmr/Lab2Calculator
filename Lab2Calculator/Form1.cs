using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Source: https://www.c-sharpcorner.com
/// </summary>
namespace Lab2Calculator
{
    /// <summary>
    /// Lab 2 Calculator Application
    /// Authors: Samuel Tjahjadi A00978466 & Sarvenaz Mohammadi A01158178
    /// Date: January 18, 2023
    /// Source: n/a
    /// </summary>
    public partial class FormCalculator : Form
    {
        char[] validOperationSymbols = new char[] {'+', '-', '*', '/'};
        bool isCalculatorPowerOn = false;
        double FirstNumber;
        double LastNumber;
        string Operation;
        string operationSymbol;

        double memory;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.Text == "Off")
            {
                buttonOnOff.Text = "On";
                isCalculatorPowerOn = true;

            } else
            {
                buttonOnOff.Text = "Off";
                isCalculatorPowerOn = false;
            }
        }



        /// <summary>
        /// Appends the clicked digit button to the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDigit_Click(object sender, EventArgs e)
        {
            if (isCalculatorPowerOn)
            {
                Button buttonDigit = (Button)sender;
                SendKeys.Send(buttonDigit.Text);
                if (textBoxNumbers.Text == "0")
                {
                    textBoxNumbers.Text = "";
                }
                this.textBoxNumbers.Text += buttonDigit.Text;
            }
        }



        /// <summary>
        /// Erase all data. Work in progress.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text = "0";
            textBoxResult.Text = "";
        }

        /// <summary>
        /// Removes a digit at the head of the string of digits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (textBoxNumbers.Text.Length > 0 & isCalculatorPowerOn & textBoxNumbers.Text != "0")
            {
                textBoxNumbers.Text = textBoxNumbers.Text.Substring(1, textBoxNumbers.Text.Length - 1);
            }
            if (textBoxNumbers.Text == "") // If user backspaces all digits, append 0 to empty string.
            {
                textBoxNumbers.Text = "0";
            }
        }

        /// <summary>
        /// Detects which arithmetic button was called and executes that arithmetic operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonArithmetic_Click(object sender, EventArgs e)
        {
            if (isCalculatorPowerOn)
            {
                var isNumeric = int.TryParse(textBoxNumbers.Text, out _);
                if (isNumeric)
                {
                    FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
                    textBoxNumbers.Text = "";

                }
                Button arithmeticButton = (Button)sender;
                Operation = arithmeticButton.Text;

                if (arithmeticButton.Text == "+")
                {
                    SendKeys.Send("{ADD}");
                }
                else if (arithmeticButton.Text == "-")
                {
                    SendKeys.Send("{SUBTRACT}");
                }
                else if (arithmeticButton.Text == "*")
                {
                    SendKeys.Send("{MULTIPLY}");
                }
                else if (arithmeticButton.Text == "/")
                {
                    SendKeys.Send("{DIVIDE}");
                }
                else if (arithmeticButton.Text == "%")
                {
                    SendKeys.Send("{MOD}");
                }
            }

        }
        /// <summary>
        /// function of "1/x" button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReverse_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);

            if (FirstNumber == 0)
            {
                textBoxResult.Text = "Cannot divide by zero";

            }
            else
            {
                double Result = 1.0 / FirstNumber;
                textBoxResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }           

        }
        /// <summary>
        /// function of "sqrt" button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            if (textBoxNumbers.Text == "")
            {
                FirstNumber = Convert.ToDouble(textBoxResult.Text);
            }
            if (FirstNumber < 0)
            {
                textBoxResult.Text = "No square root for negative numbers";

            }
            else
            {
                double Result = Math.Sqrt(FirstNumber);
                textBoxResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
                textBoxNumbers.Text = "";
            }
        }

        /// <summary>
        /// function of "x^2" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPowerTwo_Click(object sender, EventArgs e)
        {
           
            if (textBoxNumbers.Text == "")
            {
                FirstNumber = Convert.ToDouble(textBoxResult.Text);
            } else
            {
                FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            }
            double Result = Math.Pow(FirstNumber , 2.0);
                textBoxResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            textBoxNumbers.Text = "";
        }
        

        /// <summary>
        /// this function activates when pressing 
        /// the equal button on the calculator form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBoxNumbers.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBoxResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBoxResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBoxResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBoxResult.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBoxResult.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "%")
            {
                if (SecondNumber == 0)
                {
                    textBoxResult.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber % SecondNumber);
                    textBoxResult.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            textBoxNumbers.Text = "";
        }

        /// <summary>
        /// Memory Store puts the number on the display into the memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMemoryFunctions_Click(object sender, EventArgs e)
        {
            if (isCalculatorPowerOn)
            {
                Button memoryButton = (Button)sender;
                if (memoryButton.Text == "MS") // Memory Store: Stores number into memory
                {
                    if (textBoxNumbers.Text == "") 
                    {
                        if (textBoxResult.Text != "")
                        {
                            memory = Convert.ToDouble(textBoxResult.Text);
                        }
                    } else
                    {
                        memory = Convert.ToDouble(textBoxNumbers.Text);
                    }
                }
                else if (memoryButton.Text == "MR") //  Memory Recall: Displays memory onto screen
                {
                    textBoxNumbers.Text = Convert.ToString(memory);
                }
                else if (memoryButton.Text == "MC") // Memory Clear: Clears memory
                {
                    memory = 0;
                } else if (memoryButton.Text == "M+") // Memory Plus: Adds number to the memory
                {
                    if (textBoxNumbers.Text == "")
                    {
                        if (textBoxResult.Text != "")
                        {
                            memory += Convert.ToDouble(textBoxResult.Text);
                        }
                    } else
                    {
                        memory += Convert.ToDouble(textBoxNumbers.Text);
                    }
                }


            }
        }

        private void buttonSignChange_Click(object sender, EventArgs e)
        {
            if (isCalculatorPowerOn)
            {
                if (textBoxNumbers.Text != "")
                {
                    textBoxNumbers.Text = Convert.ToString(-1.0 * Convert.ToDouble(textBoxNumbers.Text));
                } else if (textBoxResult.Text != "")
                {
                    textBoxResult.Text = Convert.ToString(-1.0 * Convert.ToDouble(textBoxResult.Text));

                }
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (isCalculatorPowerOn)
            {
                textBoxNumbers.Text = "0";
            }
        }

        /// <summary>
        /// this function reads numbers and four main operations from keyboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isCalculatorPowerOn)
            {
                ///checks if the input is only numbers
                if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
                {
                    e.Handled = true;
                    /// if first time typing or after pressing operation buttons, clears the text box
                    if (textBoxNumbers.Text == "0" || textBoxNumbers.Text == "+" || textBoxNumbers.Text == "-"
                    || textBoxNumbers.Text == "*" || textBoxNumbers.Text == "/")
                    {
                        textBoxNumbers.Text = "";
                    }
                    textBoxNumbers.Text += e.KeyChar;

                    FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
                }
                /// checks if you are doing the main operations
                else if (validOperationSymbols.Contains(e.KeyChar))
                {
                    textBoxNumbers.Text = e.KeyChar.ToString();
                    operationSymbol = textBoxNumbers.Text;
                    LastNumber = FirstNumber;
                }
                ///what happens after pressing Enter
                if (e.KeyChar == (char)Keys.Return)
                {
                    switch (operationSymbol)
                    {
                        case "+":
                            textBoxResult.Text = Convert.ToString(FirstNumber + LastNumber);
                            break;

                        case "-":
                            textBoxResult.Text = Convert.ToString(LastNumber - FirstNumber);
                            break;

                        case "*":
                            textBoxResult.Text = Convert.ToString(FirstNumber * LastNumber);
                            break;

                        case "/":

                            if (FirstNumber != 0)
                            {
                                textBoxResult.Text = Convert.ToString(LastNumber / FirstNumber);

                            }
                            else textBoxResult.Text = "Cannot divide by zero";
                            break;


                        default:
                            break;

                    }
                }
            }
        }
    }
}




