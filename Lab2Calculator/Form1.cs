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
                this.textBoxNumbers.Text += buttonDigit.Text;
            }
        }
    }
}
