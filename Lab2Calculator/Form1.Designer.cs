namespace Lab2Calculator
{
    partial class FormCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.groupBoxDigits = new System.Windows.Forms.GroupBox();
            this.buttonSignChange = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxArithmeticOperators = new System.Windows.Forms.GroupBox();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonDivisionByX = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonSubstraction = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.groupBoxMemoryModes = new System.Windows.Forms.GroupBox();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.groupBoxMemoryOperators = new System.Windows.Forms.GroupBox();
            this.pictureBoxMathImage = new System.Windows.Forms.PictureBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxDigits.SuspendLayout();
            this.groupBoxArithmeticOperators.SuspendLayout();
            this.groupBoxMemoryModes.SuspendLayout();
            this.groupBoxMemoryOperators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMathImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDigits
            // 
            this.groupBoxDigits.Controls.Add(this.buttonSignChange);
            this.groupBoxDigits.Controls.Add(this.buttonDecimal);
            this.groupBoxDigits.Controls.Add(this.button0);
            this.groupBoxDigits.Controls.Add(this.button9);
            this.groupBoxDigits.Controls.Add(this.button8);
            this.groupBoxDigits.Controls.Add(this.button7);
            this.groupBoxDigits.Controls.Add(this.button6);
            this.groupBoxDigits.Controls.Add(this.button5);
            this.groupBoxDigits.Controls.Add(this.button4);
            this.groupBoxDigits.Controls.Add(this.button3);
            this.groupBoxDigits.Controls.Add(this.button2);
            this.groupBoxDigits.Controls.Add(this.button1);
            this.groupBoxDigits.Location = new System.Drawing.Point(9, 122);
            this.groupBoxDigits.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDigits.Name = "groupBoxDigits";
            this.groupBoxDigits.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDigits.Size = new System.Drawing.Size(140, 204);
            this.groupBoxDigits.TabIndex = 0;
            this.groupBoxDigits.TabStop = false;
            // 
            // buttonSignChange
            // 
            this.buttonSignChange.Location = new System.Drawing.Point(92, 154);
            this.buttonSignChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSignChange.Name = "buttonSignChange";
            this.buttonSignChange.Size = new System.Drawing.Size(38, 41);
            this.buttonSignChange.TabIndex = 11;
            this.buttonSignChange.Text = "-/+";
            this.buttonSignChange.UseVisualStyleBackColor = true;
            this.buttonSignChange.Click += new System.EventHandler(this.buttonSignChange_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDecimal.Location = new System.Drawing.Point(50, 154);
            this.buttonDecimal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(38, 41);
            this.buttonDecimal.TabIndex = 10;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(8, 154);
            this.button0.Margin = new System.Windows.Forms.Padding(2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(38, 41);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(92, 108);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(38, 41);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(50, 108);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 41);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 108);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(92, 63);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 63);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 63);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // groupBoxArithmeticOperators
            // 
            this.groupBoxArithmeticOperators.Controls.Add(this.buttonSquare);
            this.groupBoxArithmeticOperators.Controls.Add(this.buttonMod);
            this.groupBoxArithmeticOperators.Controls.Add(this.buttonAddition);
            this.groupBoxArithmeticOperators.Controls.Add(this.buttonDivision);
            this.groupBoxArithmeticOperators.Controls.Add(this.buttonDivisionByX);
            this.groupBoxArithmeticOperators.Controls.Add(this.buttonSqrt);
            this.groupBoxArithmeticOperators.Controls.Add(this.buttonSubstraction);
            this.groupBoxArithmeticOperators.Controls.Add(this.buttonMultiplication);
            this.groupBoxArithmeticOperators.Location = new System.Drawing.Point(165, 122);
            this.groupBoxArithmeticOperators.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxArithmeticOperators.Name = "groupBoxArithmeticOperators";
            this.groupBoxArithmeticOperators.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxArithmeticOperators.Size = new System.Drawing.Size(105, 204);
            this.groupBoxArithmeticOperators.TabIndex = 1;
            this.groupBoxArithmeticOperators.TabStop = false;
            // 
            // buttonSquare
            // 
            this.buttonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSquare.Location = new System.Drawing.Point(54, 154);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(38, 41);
            this.buttonSquare.TabIndex = 19;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonPowerTwo_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(54, 63);
            this.buttonMod.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(38, 41);
            this.buttonMod.TabIndex = 15;
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonArithmetic_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Location = new System.Drawing.Point(12, 154);
            this.buttonAddition.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(38, 41);
            this.buttonAddition.TabIndex = 18;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.buttonArithmetic_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(12, 16);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(38, 41);
            this.buttonDivision.TabIndex = 12;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonArithmetic_Click);
            // 
            // buttonDivisionByX
            // 
            this.buttonDivisionByX.Location = new System.Drawing.Point(54, 108);
            this.buttonDivisionByX.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDivisionByX.Name = "buttonDivisionByX";
            this.buttonDivisionByX.Size = new System.Drawing.Size(38, 41);
            this.buttonDivisionByX.TabIndex = 17;
            this.buttonDivisionByX.Text = "1/x";
            this.buttonDivisionByX.UseVisualStyleBackColor = true;
            this.buttonDivisionByX.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Location = new System.Drawing.Point(54, 16);
            this.buttonSqrt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(38, 41);
            this.buttonSqrt.TabIndex = 13;
            this.buttonSqrt.Text = "sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonSubstraction
            // 
            this.buttonSubstraction.Location = new System.Drawing.Point(12, 108);
            this.buttonSubstraction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubstraction.Name = "buttonSubstraction";
            this.buttonSubstraction.Size = new System.Drawing.Size(38, 41);
            this.buttonSubstraction.TabIndex = 16;
            this.buttonSubstraction.Text = "-";
            this.buttonSubstraction.UseVisualStyleBackColor = true;
            this.buttonSubstraction.Click += new System.EventHandler(this.buttonArithmetic_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(12, 63);
            this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(38, 41);
            this.buttonMultiplication.TabIndex = 14;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonArithmetic_Click);
            // 
            // groupBoxMemoryModes
            // 
            this.groupBoxMemoryModes.Controls.Add(this.buttonMPlus);
            this.groupBoxMemoryModes.Controls.Add(this.buttonMS);
            this.groupBoxMemoryModes.Controls.Add(this.buttonMR);
            this.groupBoxMemoryModes.Controls.Add(this.buttonMC);
            this.groupBoxMemoryModes.Location = new System.Drawing.Point(166, 60);
            this.groupBoxMemoryModes.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMemoryModes.Name = "groupBoxMemoryModes";
            this.groupBoxMemoryModes.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMemoryModes.Size = new System.Drawing.Size(174, 57);
            this.groupBoxMemoryModes.TabIndex = 2;
            this.groupBoxMemoryModes.TabStop = false;
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.Location = new System.Drawing.Point(130, 11);
            this.buttonMPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(38, 41);
            this.buttonMPlus.TabIndex = 15;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMemoryFunctions_Click);
            // 
            // buttonMS
            // 
            this.buttonMS.Location = new System.Drawing.Point(88, 11);
            this.buttonMS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(38, 41);
            this.buttonMS.TabIndex = 14;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = true;
            this.buttonMS.Click += new System.EventHandler(this.buttonMemoryFunctions_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.Location = new System.Drawing.Point(46, 11);
            this.buttonMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(38, 41);
            this.buttonMR.TabIndex = 13;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMemoryFunctions_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Location = new System.Drawing.Point(4, 11);
            this.buttonMC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(38, 41);
            this.buttonMC.TabIndex = 12;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMemoryFunctions_Click);
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(9, 32);
            this.textBoxNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.ReadOnly = true;
            this.textBoxNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNumbers.Size = new System.Drawing.Size(332, 20);
            this.textBoxNumbers.TabIndex = 3;
            this.textBoxNumbers.Text = "0";
            this.textBoxNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonOnOff.Location = new System.Drawing.Point(59, 76);
            this.buttonOnOff.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(38, 30);
            this.buttonOnOff.TabIndex = 4;
            this.buttonOnOff.Text = "Off";
            this.buttonOnOff.UseVisualStyleBackColor = true;
            this.buttonOnOff.Click += new System.EventHandler(this.buttonOnOff_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(9, 63);
            this.buttonC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(38, 41);
            this.buttonC.TabIndex = 12;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.Location = new System.Drawing.Point(9, 108);
            this.buttonBackSpace.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(38, 41);
            this.buttonBackSpace.TabIndex = 13;
            this.buttonBackSpace.Text = "<-";
            this.buttonBackSpace.UseVisualStyleBackColor = true;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(9, 154);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(38, 41);
            this.buttonEquals.TabIndex = 14;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(9, 16);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(38, 41);
            this.buttonCE.TabIndex = 15;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // groupBoxMemoryOperators
            // 
            this.groupBoxMemoryOperators.Controls.Add(this.buttonEquals);
            this.groupBoxMemoryOperators.Controls.Add(this.buttonCE);
            this.groupBoxMemoryOperators.Controls.Add(this.buttonBackSpace);
            this.groupBoxMemoryOperators.Controls.Add(this.buttonC);
            this.groupBoxMemoryOperators.Location = new System.Drawing.Point(281, 122);
            this.groupBoxMemoryOperators.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMemoryOperators.Name = "groupBoxMemoryOperators";
            this.groupBoxMemoryOperators.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMemoryOperators.Size = new System.Drawing.Size(58, 204);
            this.groupBoxMemoryOperators.TabIndex = 6;
            this.groupBoxMemoryOperators.TabStop = false;
            // 
            // pictureBoxMathImage
            // 
            this.pictureBoxMathImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMathImage.BackgroundImage")));
            this.pictureBoxMathImage.Location = new System.Drawing.Point(9, 347);
            this.pictureBoxMathImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMathImage.Name = "pictureBoxMathImage";
            this.pictureBoxMathImage.Size = new System.Drawing.Size(331, 140);
            this.pictureBoxMathImage.TabIndex = 7;
            this.pictureBoxMathImage.TabStop = false;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(9, 10);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxResult.Size = new System.Drawing.Size(332, 20);
            this.textBoxResult.TabIndex = 8;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 507);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.pictureBoxMathImage);
            this.Controls.Add(this.groupBoxMemoryOperators);
            this.Controls.Add(this.buttonOnOff);
            this.Controls.Add(this.textBoxNumbers);
            this.Controls.Add(this.groupBoxMemoryModes);
            this.Controls.Add(this.groupBoxArithmeticOperators);
            this.Controls.Add(this.groupBoxDigits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormCalculator";
            this.ShowIcon = false;
            this.Text = "Math Calculator";
            this.groupBoxDigits.ResumeLayout(false);
            this.groupBoxArithmeticOperators.ResumeLayout(false);
            this.groupBoxMemoryModes.ResumeLayout(false);
            this.groupBoxMemoryOperators.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMathImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDigits;
        private System.Windows.Forms.GroupBox groupBoxArithmeticOperators;
        private System.Windows.Forms.GroupBox groupBoxMemoryModes;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.GroupBox groupBoxMemoryOperators;
        private System.Windows.Forms.PictureBox pictureBoxMathImage;
        public System.Windows.Forms.Button buttonOnOff;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBoxNumbers;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button0;
        public System.Windows.Forms.Button buttonAddition;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button buttonEquals;
        public System.Windows.Forms.TextBox textBoxResult;
        public System.Windows.Forms.Button buttonSquare;
        public System.Windows.Forms.Button buttonMod;
        public System.Windows.Forms.Button buttonDivision;
        public System.Windows.Forms.Button buttonDivisionByX;
        public System.Windows.Forms.Button buttonSqrt;
        public System.Windows.Forms.Button buttonSubstraction;
        public System.Windows.Forms.Button buttonMultiplication;
        public System.Windows.Forms.Button buttonSignChange;
        public System.Windows.Forms.Button buttonDecimal;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
    }
}

