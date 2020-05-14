using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursionsProject
{
    public partial class Form1 : Form
    {
        int inputNumber;
        int totalNumber;
        int recursive;
        int nonRecursive;

        public Form1()
        {
            InitializeComponent();
        }

        private void fibonnaciButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "")
            {
                outputLabel.Text = "Please enter a valid number.";
            }
            else
            {
                inputNumber = Convert.ToInt32(inputTextBox.Text);
                recursive = recursiveFibonnaci(inputNumber);
                nonRecursive = nonRecursiveFibonnaci(inputNumber);

                if (recursive == nonRecursive)
                {
                    //In order to get the right suffix to the number
                    if (inputNumber % 10 == 1)
                    {
                        outputLabel.Text = "The " + inputNumber + "st number in the fibonnaci sequence is " + recursive + ".";
                    }
                    else if (inputNumber % 10 == 2)
                    {
                        outputLabel.Text = "The " + inputNumber + "nd number in the fibonnaci sequence is " + recursive + ".";
                    }
                    else if (inputNumber % 10 == 3)
                    {
                        outputLabel.Text = "The " + inputNumber + "rd number in the fibonnaci sequence is " + recursive + ".";
                    }
                    else
                    {
                        outputLabel.Text = "The " + inputNumber + "th number in the fibonnaci sequence is " + recursive + ".";
                    }

                    //Because english is weird
                    if (inputNumber == 11 || inputNumber == 12 || inputNumber == 13)
                    {
                        outputLabel.Text = "The " + inputNumber + "th number in the fibonnaci sequence is " + recursive + ".";
                    }
                }
                else
                {
                    outputLabel.Text = "Something went wrong.";
                } 
            }
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "")
            {
                outputLabel.Text = "Please enter a valid number.";
            }
            else
            {
                inputNumber = Convert.ToInt32(inputTextBox.Text);
                totalNumber = Sum(inputNumber);

                outputLabel.Text = "The sum of all values up to " + inputNumber + " is " + totalNumber + ".";
            }
        }

        public int recursiveFibonnaci(int n)
        {
            switch (n)
            {
                case 0:
                    return 0;

                case 1:
                    return 1;

                default:
                    return recursiveFibonnaci((n - 2)) + recursiveFibonnaci((n - 1));
            }
        }

        public int nonRecursiveFibonnaci(int n)
        {
            int a = 1;
            int b = 1;
            int c;
            int count = 2;

            while (count < n)
            {
                c = b;
                b = a + b;
                a = c;
                count++;
            }

            return b;
        }

        public int Sum(int n)
        {
            int totalSum = 0;

            while (n > 0)
            {
                totalSum = totalSum + n;
                n = n - 1;
            }
            return totalSum;
        }
    }
}