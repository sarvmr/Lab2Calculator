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
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.Text == "Off")
            {
                buttonOnOff.Text = "On";
            } else
            {
                buttonOnOff.Text = "Off";
            }
        }
    }
}
