using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Calculator
{
    public partial class FormCalculator : Form
    {
        bool isCalculatorPowerOn = false;
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

        private void buttonArithmetic_Click(object sender, EventArgs e)
        {
            Button arithmeticButton = (Button)sender;
            textBoxResult.Text += arithmeticButton.Text + this.textBoxNumbers.Text;
            textBoxNumbers.Text = "0";
        }
    }
}
