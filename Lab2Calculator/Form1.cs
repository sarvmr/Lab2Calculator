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
    public partial class FormCalculator : Form
    {
        char[] validOperationSymbols = new char[] {'+', '-', '*', '/'};
        bool isCalculatorPowerOn = false;
        double FirstNumber;
        double LastNumber;
        string Operation;
        string operationSymbol;

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
        /// function of "+" button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            Button addButton = (Button)sender;
            SendKeys.Send("{ADD}");
            Operation = "+";

        }
        /// <summary>
        /// function of "-" button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            Button subButton = (Button)sender;
            SendKeys.Send("{SUBTRACT}");
            Operation = "-";

        }
        /// <summary>
        /// function of "*" button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            Button mulButton = (Button)sender;
            SendKeys.Send("{MULTIPLY}");
            Operation = "*";

        }
        /// <summary>
        /// function of "/" button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            Button divButton = (Button)sender;
            SendKeys.Send("{DIVIDE}");
            Operation = "/";

        }
        /// <summary>
        /// function of "%" button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModulo_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            //Button modButton = (Button)sender;
            //SendKeys.Send("{REMAINDER}");
            Operation = "%";

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

            if (FirstNumber < 0)
            {
                textBoxResult.Text = "No square root for negative numbers";

            }
            else
            {
                double Result = Math.Sqrt(FirstNumber);
                textBoxResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }

        /// <summary>
        /// function of "x^2" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPowerTwo_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);

                double Result = Math.Pow(FirstNumber , 2.0);
                textBoxResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
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

