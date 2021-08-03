using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

namespace Roman_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Settings settings = new Settings(0,0,0,".",false);

        #region labels
        private void Form1_Load(object sender, EventArgs e) { }
        private void secondNumber_Click(object sender, EventArgs e) { }
        private void firstNumber_Click(object sender, EventArgs e) { }
        private void labelOP_Click(object sender, EventArgs e) { }
        private void labelEqual_Click(object sender, EventArgs e) { }
        private void labelAnswer_Click(object sender, EventArgs e) { }
        #endregion
        #region numbers
        private void buttonI_Click(object sender, EventArgs e)
        {
            if (settings.Two == false)
            {
                int first = settings.First;

                first += 1;
                settings.First = first;
                firstNumber.Text = settings.Math().ToString();
                settings.Count();
            }
            else
            {
                int second = settings.Second;

                second += 1;
                settings.Second = second;
                secondNumber.Text = settings.Math().ToString();
                settings.Count2();
            }
        }
        private void buttonV_Click(object sender, EventArgs e)
        {
            if (settings.Two == false)
            {
                int first = settings.First;

                first += 5;
                settings.First = first;
                firstNumber.Text = settings.Math().ToString();
                settings.Count();
            }
            else
            {
                int second = settings.Second;

                second += 5;
                settings.Second = second;
                secondNumber.Text = settings.Math().ToString();
                settings.Count2();
            }
        }
        private void buttonX_Click(object sender, EventArgs e)
        {
            if (settings.Two == false)
            {
                int first = settings.First;

                first += 10;
                settings.First = first;
                firstNumber.Text = settings.Math().ToString();
                settings.Count();
            }
            else
            {
                int second = settings.Second;

                second += 10;
                settings.Second = second;
                secondNumber.Text = settings.Math().ToString();
                settings.Count2();
            }
        }
        private void buttonL_Click(object sender, EventArgs e)
        {
            if (settings.Two == false)
            {
                int first = settings.First;

                first += 50;
                settings.First = first;
                firstNumber.Text = settings.Math().ToString();
                settings.Count();
            }
            else
            {
                int second = settings.Second;

                second += 50;
                settings.Second = second;
                secondNumber.Text = settings.Math().ToString();
                settings.Count2();
            }
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            if (settings.Two == false)
            {
                int first = settings.First;

                first += 100;
                settings.First = first;
                firstNumber.Text = settings.Math().ToString();
                settings.Count();
            }
            else
            {
                int second = settings.Second;

                second += 100;
                settings.Second = second;
                secondNumber.Text = settings.Math().ToString();
                settings.Count2();
            }
        }
        private void buttonD_Click(object sender, EventArgs e)
        {
            if (settings.Two == false)
            {
                int first = settings.First;

                first += 500;
                settings.First = first;
                firstNumber.Text = settings.Math().ToString();
                settings.Count();
            }
            else
            {
                int second = settings.Second;

                second += 500;
                settings.Second = second;
                secondNumber.Text = settings.Math().ToString();
                settings.Count2();
            }
        }
        private void buttonM_Click(object sender, EventArgs e)
        {
            if (settings.Two == false)
            {
                int first = settings.First;

                first += 1000;
                settings.First = first;
                firstNumber.Text = settings.Math().ToString();
                settings.Count();
            }
            else
            {
                int second = settings.Second;

                second += 1000;
                settings.Second = second;
                secondNumber.Text = settings.Math().ToString();
                settings.Count2();
            }
        }
        #endregion
        #region operators
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            labelOP.Text = "+";
            settings.Operator = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            labelOP.Text = "-";
            settings.Operator = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            labelOP.Text = "*";
            settings.Operator = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            labelOP.Text = "/";
            settings.Operator = "/";
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            int first = settings.First;
            int second = settings.Second;
            int third;
            string Operator = settings.Operator;
            settings.ans = true;

            if (Operator == "+")
            {
                third = first + second;
            }
            else if (Operator == "-")
            {
                third = first - second;
            }
            else if (Operator == "*")
            {
                third = first * second;
            }
            else if (Operator == "/")
            {
                third = first / second;
            }
            else
            {
                third = 1;
            }
            settings.Third = third;

            if (settings.Third > 0)
            {
                labelAnswer.Text = settings.Math().ToString();
            }
            else if (settings.Third < 0)
            {
                labelAnswer.Text = "-" + settings.Math4().ToString();
            }
            else
            {
                labelAnswer.Text = "0";
            }
            settings.ans = false;
        }
        #endregion
        #region other
        private void Switch_Click(object sender, EventArgs e)
        {
            if (settings.Two == false)
            {
                settings.Two = true;
                secondNumber.BorderStyle = BorderStyle.FixedSingle;
                firstNumber.BorderStyle = BorderStyle.None;
            }
            else
            {
                settings.Two = false;
                firstNumber.BorderStyle = BorderStyle.FixedSingle;
                secondNumber.BorderStyle = BorderStyle.None;
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            settings.First = 0;
            settings.Second = 0;
            settings.Third = 0;
            settings.M1 = 0;
            settings.M2 = 0;
            settings.M3 = 0;
            settings.M4 = 0;
            settings.M5 = 0;
            settings.M6 = 0;
            settings.M7 = 0;
            settings.M8 = 0;
            settings.Operator = ".";
            settings.Two = false;

            firstNumber.Text = ".";
            secondNumber.Text = ".";
            labelAnswer.Text = ".";
            labelOP.Text = ".";
        }
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            if (settings.Two == false)
            {
                if (settings.countM == 3)
                {
                    settings.First = settings.M2;
                    firstNumber.Text = settings.Math().ToString();
                    settings.countM = 2;
                }
                else if (settings.countM == 2)
                {
                    settings.First = settings.M1;
                    firstNumber.Text = settings.Math().ToString();
                    settings.countM = 1;
                }
                else if (settings.countM == 1)
                {
                    settings.First = settings.M4;
                    firstNumber.Text = settings.Math().ToString();
                    settings.countM = 0;
                }
                else
                {
                    settings.First = settings.M3;
                    firstNumber.Text = settings.Math().ToString();
                    settings.countM = 3;
                }
            }
            else
            {
                if (settings.countM2 == 3)
                {
                    settings.Second = settings.M6;
                    secondNumber.Text = settings.Math().ToString();
                    settings.countM2 = 2;
                }
                else if (settings.countM2 == 2)
                {
                    settings.Second = settings.M5;
                    secondNumber.Text = settings.Math().ToString();
                    settings.countM2 = 1;
                }
                else if (settings.countM2 == 1)
                {
                    settings.Second = settings.M8;
                    secondNumber.Text = settings.Math().ToString();
                    settings.countM2 = 0;
                }
                else
                {
                    settings.Second = settings.M7;
                    secondNumber.Text = settings.Math().ToString();
                    settings.countM2 = 3;
                }
            }
        }
        #endregion
    }
}
