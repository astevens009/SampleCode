using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindSquareRoot_WF
{
    public partial class SquareRootMainForm : Form
    {
        public SquareRootMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double root = 0;
            bool isRoot;

            double originalNum = double.Parse(txtOriginalNumber.Text);

            // Step 1: Guess - find a number when multiplied by itself is less than or
            //                  equal to the original number
            double guess = FindRoot(originalNum);
            //double avg = 0.0;
            // TEST
            //Console.WriteLine("My best guess is: {0}", guess);

            do
            {
                // Step 2: Divide
                double result = originalNum / guess;

                //NOTES: If the "guess" is the exact square root of the 
                //       original number no need to continue...
                if (result == guess)
                {
                    isRoot = true;
                    root = guess;
                    break;
                }

                // Step 3: Average; the average becomes the new "guess"
                guess = (result + guess) / 2;

                // Step 4: Check the average to see if when it's multiplied 
                //          by itself it equals the original number
                isRoot = CheckGuess(guess, originalNum);
                root = guess;

            } while (!isRoot);

            txtRoot.Text = root.ToString();
        }

        private static bool CheckGuess(double avg, double originalNum)
        {
            bool isRtNum = Math.Round(avg * avg) == originalNum;

            return isRtNum;
        }

        private static double FindRoot(double originalNum)
        {
            double root = 0;
            int test = 0;
            int count = 1;

            while (test <= originalNum)
            {
                test = count * count;
                root = count - 1;
                count++;
            }

            return root;
        }
    }
}
