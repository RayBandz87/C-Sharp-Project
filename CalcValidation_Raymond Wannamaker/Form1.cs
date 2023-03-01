using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcValidation_Raymond_Wannamaker
//Author: Raymond Wannamaker
//ID: 556586
//Date: February 17, 2023
//Goal-Purpose of the Program: Based on the input and output requirements for the Excel Spreadsheet for
//CalcValidation Excel, construct an application. The program's output can be 
//compared by running the same input through both the C# program and the 
//Excel spreadsheet to check whether they produce the same results.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Set the variables for steps, distance, time, and calories
                int steps = int.Parse(textBoxSteps.Text);
                double distance = steps * 0.0004734848485;
                int time = (int)(steps / 1000.0 * 10.0);
                double calories = steps * 0.05;

                //Calculate the variables to display the results
                labelDistance.Text = distance.ToString("F2") + " miles";
                labelTime.Text = time.ToString() + " minutes";
                labelCalories.Text = calories.ToString("F0") + " calories";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number of steps. ");
                return;
            }
        }

        private void buttonClaer_Click(object sender, EventArgs e)
        {
            //Clear textbox and labels text
            textBoxSteps.Text= string.Empty;
            labelDistance.Text= string.Empty;
            labelTime.Text= string.Empty;
            labelCalories.Text= string.Empty;
        }
    }
}
