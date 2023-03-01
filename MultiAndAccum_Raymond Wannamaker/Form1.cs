using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAndAccum_Raymond_Wannamaker
//Author: Raymond Wannamaker
//ID: 556586
//Date: March 1 2023
//Goal Purpose of the Program: Make a computer program that will add the current calculated result to the running total of the results to date and show the updated running total.
{
    public partial class Form1 : Form
    {
        //Declare a variable to store the running total
        double runningTotal = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double num1, num2, ans;

            //Parse the text in the input fields to doubles
            if((Double.TryParse(num1TextBox.Text, out num1)) && (Double.TryParse(num2TextBox.Text, out num2)))
            {

                //Perform the multiplication operation
                ans = num1 * num2;

                //Add the result to the running total
                runningTotal += ans;

                //Set the background color of the running total label based on its value
                if (runningTotal < 0)
                {
                    runningTotalTextBox.BackColor = Color.Orange;
                }
                else
                {
                    runningTotalTextBox.BackColor = Color.Blue;
                }

                //Display the result of the multiplication and the running total
                multiTextBox.Text = ans.ToString();
                runningTotalTextBox.Text = runningTotal.ToString();
            }
            else
            {
                //Display an error message if the input fields contain non-numeric values
                MessageBox.Show("Please enter numeric value ONLY.");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Reset the running total and clear all input and output fields
            runningTotal= 0;
            runningTotalTextBox.BackColor = default(Color);
            runningTotalTextBox.Text = "";
            multiTextBox.Text = "";
            num1TextBox.Text = "";
            num2TextBox.Text = "";
        }
    }
}
