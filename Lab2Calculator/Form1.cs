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
        bool isCalculatorPowerOn = false;
        double FirstNumber;
        string Operation;
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

/*        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            Button addButton = (Button)sender;
            SendKeys.Send("{ADD}");
            Operation = "+";

        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            Button subButton = (Button)sender;
            SendKeys.Send("{SUBTRACT}");
            Operation = "-";

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            Button mulButton = (Button)sender;
            SendKeys.Send("{MULTIPLY}");
            Operation = "*";

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            Button divButton = (Button)sender;
            SendKeys.Send("{DIVIDE}");
            Operation = "/";

        }*/

/*        private void buttonModulo_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxNumbers.Text);
            textBoxNumbers.Text = "";
            //Button modButton = (Button)sender;
            //SendKeys.Send("{REMAINDER}");
            Operation = "%";

        }*/

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
                            memory += Convert.ToDouble(textBoxNumbers.Text);
                        }
                    } else
                    {
                        memory += Convert.ToDouble(textBoxNumbers.Text);
                    }
                }


            }
        }
    }
}
