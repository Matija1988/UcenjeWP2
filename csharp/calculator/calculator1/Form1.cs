using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Calculator : Form
    {

        private Rectangle btnFor1;
        private Rectangle btnFor2;
        private Rectangle btnFor3;
        private Rectangle btnFor4;
        private Rectangle btnFor5;
        private Rectangle btnFor6;
        private Rectangle btnFor7;
        private Rectangle btnFor8;
        private Rectangle btnFor9;
        private Rectangle btnFor0;
        private Rectangle buttonToAdd;
        private Rectangle buttonToSubtract;
        private Rectangle buttonToMultiply;
        private Rectangle buttonToDivide;
        private Rectangle buttonForModulus;
        private Rectangle buttonForEquals;
        private Rectangle buttonForReciprocal;
        private Rectangle buttonToSqare;
        private Rectangle buttonToRoot;
        private Rectangle buttonForPosNeg;
        private Rectangle buttonToClearCurrent;
        private Rectangle buttonToClear;
        private Rectangle buttonForBackspace;
        private Rectangle buttonForDecimal;
        private Rectangle displayLabel;
        private Size originalFormSize;


        string first = "";
        string second = "";
        char function;
        double result = 0;
        string userInput = string.Empty;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            btnFor1 =
                new Rectangle
                    (btnFor1.Location.X, btnFor1.Location.Y, btnFor1.Width, btnFor1.Height);
            btnFor2 =
                new Rectangle
                    (btnFor2.Location.X, btnFor2.Location.Y, btnFor2.Width, btnFor2.Height);
            btnFor3 =
                new Rectangle
                    (btnFor3.Location.X, btnFor3.Location.Y, btnFor3.Width, btnFor3.Height);
            btnFor4 =
                new Rectangle
                    (btnFor4.Location.X, btnFor4.Location.Y, btnFor4.Width, btnFor4.Height);
            btnFor5 =
                new Rectangle
                    (btnFor5.Location.X, btnFor5.Location.Y, btnFor5.Width, btnFor5.Height);
            btnFor6 =
                new Rectangle
                    (btnFor6.Location.X, btnFor6.Location.Y, btnFor6.Width, btnFor6.Height);
            btnFor7 =
                new Rectangle
                    (btnFor7.Location.X, btnFor7.Location.Y, btnFor7.Width, btnFor7.Height);
            btnFor8 =
                new Rectangle
                    (btnFor8.Location.X, btnFor8.Location.Y, btnFor8.Width, btnFor8.Height);
            btnFor9 =
                new Rectangle
                    (btnFor9.Location.X, btnFor9.Location.Y, btnFor9.Width, btnFor9.Height);
            btnFor0 =
                new Rectangle
                    (btnFor0.Location.X, btnFor0.Location.Y, btnFor0.Width, btnFor0.Height);

            buttonToAdd =
                new Rectangle
                    (buttonToAdd.Location.X, buttonToAdd.Location.Y, buttonToAdd.Width, buttonToAdd.Height);

            buttonToSubtract =
                new Rectangle
                    (buttonToSubtract.Location.X, buttonToSubtract.Location.Y, buttonToSubtract.Width, buttonToSubtract.Height);

            buttonToMultiply =
                new Rectangle
                    (buttonToMultiply.Location.X, buttonToMultiply.Location.Y, buttonToMultiply.Width, buttonToMultiply.Height);

            buttonToDivide =
                new Rectangle
                    (buttonToDivide.Location.X, buttonToDivide.Location.Y, buttonToDivide.Width, buttonToDivide.Height);

            buttonForModulus =
                new Rectangle
                    (buttonForModulus.Location.X, buttonForModulus.Location.Y, buttonForModulus.Width, buttonForModulus.Height);

            buttonToDivide =
                new Rectangle
                    (buttonForEquals.Location.X, buttonForEquals.Location.Y, buttonForEquals.Width, buttonForEquals.Height);

            buttonForReciprocal =
                new Rectangle
                    (buttonForReciprocal.Location.X, buttonForReciprocal.Location.Y, buttonForReciprocal.Width,
                    buttonForReciprocal.Height);

            buttonToSqare =
                new Rectangle
                    (buttonToSqare.Location.X, buttonToSqare.Location.Y, buttonToSqare.Width, buttonToSqare.Height);

            buttonToRoot =
                new Rectangle
                    (buttonToRoot.Location.X, buttonToRoot.Location.Y, buttonToRoot.Width, buttonToRoot.Height);

            buttonForPosNeg =
                new Rectangle
                    (buttonForPosNeg.Location.X, buttonForPosNeg.Location.Y, buttonForPosNeg.Width, buttonForPosNeg.Height);

            buttonToClearCurrent =
                new Rectangle
                    (buttonToClearCurrent.Location.X, buttonToClearCurrent.Location.Y, buttonToClearCurrent.Width,
                buttonToClearCurrent.Height);

            buttonToClear =
                new Rectangle
                    (buttonToClear.Location.X, buttonToClear.Location.Y, buttonToClear.Width, buttonToClear.Height);

            buttonForBackspace =
                new Rectangle
                    (buttonForBackspace.Location.X, buttonForBackspace.Location.Y, buttonForBackspace.Width,
                    buttonForBackspace.Height);

            buttonForDecimal =
                new Rectangle
                    (buttonForDecimal.Location.X, buttonForDecimal.Location.Y, buttonForDecimal.Width, buttonForDecimal.Height);

            displayLabel =
                new Rectangle
                    (displayLabel.Location.X, displayLabel.Location.Y, displayLabel.Width, displayLabel.Height);

        }


        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(btnFor1, button1);
            resizeControl(btnFor2, button2);
            resizeControl(btnFor3, button3);
            resizeControl(btnFor4, button4);
            resizeControl(btnFor5, button5);
            resizeControl(btnFor6, button6);
            resizeControl(btnFor7, button7);
            resizeControl(btnFor8, button8);
            resizeControl(btnFor9, button9);
            resizeControl(btnFor0, btn0);
            resizeControl(buttonToAdd, btnAdd);
            resizeControl(buttonToSubtract, btnSubtract);
            resizeControl(buttonToMultiply, btnMultiply);
            resizeControl(buttonToDivide, btnDivide);
            resizeControl(buttonForReciprocal, btnReciprocal);
            resizeControl(buttonToSqare, btnSqr);
            resizeControl(buttonToRoot, btnRoot);
            resizeControl(buttonForPosNeg, btnToggleNeg);
            resizeControl(buttonForModulus, btnPrecentage);
            resizeControl(buttonForDecimal, btnDecimal);
            resizeControl(buttonForBackspace, btnBackspace);
            resizeControl(buttonToClearCurrent, btnCE);
            resizeControl(buttonToClear, btnC);
            resizeControl(buttonForEquals, btnEquals);
            resizeControl(displayLabel, lblDisplay);



        }

        private void resizeControl(Rectangle controlRectangle, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(controlRectangle.X * xAxis);
            int newYPosition = (int)(controlRectangle.Y * yAxis);

            int newWidth = (int)(controlRectangle.Width * xAxis);
            int newHeight = (int)(controlRectangle.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "1";
            lblDisplay.Text += userInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "2";
            lblDisplay.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "3";
            lblDisplay.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "4";
            lblDisplay.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "5";
            lblDisplay.Text += userInput;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "6";
            lblDisplay.Text += userInput;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "7";
            lblDisplay.Text += userInput;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "8";
            lblDisplay.Text += userInput;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "9";
            lblDisplay.Text += userInput;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "0";
            lblDisplay.Text += userInput;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += ".";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            function = '=';
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '+') {

                result = firstNum + secondNum;
                lblDisplay.Text = result.ToString();

            } else if (function == '-') {

                result = secondNum - firstNum;
                lblDisplay.Text = result.ToString();

            } else if (function == '*') {

                if (firstNum == 0 || secondNum == 0) {

                    result = 0;
                    lblDisplay.Text = result.ToString();

                } else {

                    result += firstNum * secondNum;
                    lblDisplay.Text = result.ToString();

                }

            } else if (function == '/') {

                if (firstNum == 0 || secondNum == 0)
                {
                    result = 0;
                    lblDisplay.Text = result.ToString();
                }
                else {

                    result += secondNum / firstNum;
                    lblDisplay.Text = result.ToString();
                }
                
            
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            function = '√';
            first = userInput;
            userInput = "";
        }

            
        private void btnSqr_Click(object sender, EventArgs e)
        {
            function = '²';
            first = userInput;
            userInput = "";
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            function = 'R';
            first = userInput;
            userInput = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            function = 'C';
            first = "";
            second = "";
            userInput = "";
            result = 0;
            lblDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            function = 'E';
        }

        private void btnPrecentage_Click(object sender, EventArgs e)
        {
            function = '%';
            first = userInput;
            userInput = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            function = 'B';
        }

        private void btnToggleNeg_Click(object sender, EventArgs e)
        {
            function = 'n';
            first = userInput;
            userInput = "";
        }

    }
}
