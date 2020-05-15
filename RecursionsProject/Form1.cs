using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace RecursionsProject
{
    public partial class Form1 : Form
    {
        //ints
        int inputNumber;
        int totalNumber;
        int recursive;
        int nonRecursive;

        //stopwatches
        Stopwatch recursiveWatch = new Stopwatch();
        Stopwatch nonRecursiveWatch = new Stopwatch();
        Stopwatch sumWatch = new Stopwatch();

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

                recursiveWatch.Start();
                recursive = recursiveFibonnaci(inputNumber);
                recursiveWatch.Stop();

                nonRecursiveWatch.Start();
                nonRecursive = nonRecursiveFibonnaci(inputNumber);
                nonRecursiveWatch.Stop();

                //turning them into timespan objects
                TimeSpan recursiveElapsed = recursiveWatch.Elapsed; 
                TimeSpan nonRecursiveElapsed = nonRecursiveWatch.Elapsed;

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

                outputLabel.Text += "\n" + "Recursive took " + Convert.ToString(recursiveElapsed.TotalMilliseconds) + " millisecond(s).";
                outputLabel.Text += "\n" + "Non recursive took " + Convert.ToString(nonRecursiveElapsed.TotalMilliseconds) + " millisecond(s).";

                recursiveWatch.Reset();
                nonRecursiveWatch.Reset();
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

                sumWatch.Start();
                totalNumber = Sum(inputNumber);
                sumWatch.Stop();

                //turning that into a timespan object
                TimeSpan sumElapsed = sumWatch.Elapsed;

                outputLabel.Text = "The sum of all values up to " + inputNumber + " is " + totalNumber + ".";
                outputLabel.Text += "\n" + "That took " + Convert.ToString(sumElapsed.TotalMilliseconds) + " millisecond(s).";
                sumWatch.Reset();
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
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return (n + Sum(n - 1));
            }
        }
    }
}