using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWithAccums_Raymond_Wannamaker
//Author: Raymond Wannamaker
//ID: 556586
//Date: Feb 19, 2023
//Goal Purpose of the Program: To create an application to calculate the width, height, and depth on the company truck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Public variables outside the Calculat Button
        //Declare accumulation variables
        int numOrders = 0;
        double totalCubicYards = 0;
        double costOfAll = 0;
        double totalCubicFeet = 0;
       
        private void calculatorButton_Click(object sender, EventArgs e)
        {

            //Declare constants
            const double cubicYardsPerCubicFoot = 1.0 / 27.0;
            const double pricePerCubicYard = 20.0;
            const double truckCapacityCubicYards = 4.0;

            double height = 0;
            double width = 0;
            double depth = 0;

            //Get the input values and try {} and catch {} statement for error message
            try
            {
                 height = double.Parse(heightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Height input is invalid, please enter a valid number.");
            }
            try
            {
                 width = double.Parse(widthTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Width input is invalid, please enter a valid number.");
            }
            try
            {
                depth = double.Parse(depthTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Depth input is invalid, please enter a valid number");
            }

            //Calcuate the cubic feet and cubic yards
            double cubicFeet = height* width * depth;
            double cubicYards = cubicFeet * cubicYardsPerCubicFoot;

            //Calcuate the cost
            double cost = cubicYards * pricePerCubicYard;

            //Accumulate order quantity/cost calculations
            numOrders++;
            totalCubicYards += cubicYards;
            totalCubicFeet += cubicFeet;
            costOfAll += cost;

            //Calcuate the Truck Capacity and Remaining Capacity
            double remainingCapacity = truckCapacityCubicYards - totalCubicYards;

            //Display the outputs for cubic feet, cubic yards, and price
            cubicFeetTextBox.Text = cubicFeet.ToString("n2");
            cubicYardsTextBox.Text = cubicYards.ToString("n2");
            priceTextBox.Text = cost.ToString("n2");

            //Display the accumulation calcuations
            numOfOrderTextBox.Text = numOrders.ToString();
            costOrderText.Text = costOfAll.ToString("C");
            cubicFeetAccum.Text = totalCubicFeet.ToString("n2");
            cubicYardsAccum.Text = totalCubicYards.ToString("n2");

            //Display the Truck Capacity and Remaining Capacity
            baseCapacityTextBox.Text = truckCapacityCubicYards.ToString("n2");
            cubicYardOrderTextBox.Text = totalCubicYards.ToString("n2");
            remainingCapacityTextBox.Text = remainingCapacity.ToString("n2");

            //Change the background color of Label for the Remaining Capacity
            if (remainingCapacity >= 0)
            {
                remainingCapacityTextBox.BackColor = System.Drawing.Color.LightGreen;
            }
            if (remainingCapacity <= 0)
            {
                remainingCapacityTextBox.BackColor = System.Drawing.Color.Yellow;
            }
            //Clear input fields
            heightTextBox.Clear();
            depthTextBox.Clear();
            widthTextBox.Clear();



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear all the fields and accumulators
            heightTextBox.Clear();
            depthTextBox.Clear();
            widthTextBox.Clear();
            cubicFeetTextBox.Clear();
            cubicYardsTextBox.Clear();
            priceTextBox.Clear();   
            numOfOrderTextBox.Clear();  
            costOrderText.Clear();  
            baseCapacityTextBox.Clear();
            cubicYardOrderTextBox.Clear();
            remainingCapacityTextBox.Clear();
            cubicYardsAccum.Clear();
            cubicFeetAccum.Clear();
        }
    }
}
