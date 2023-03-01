using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingCalculator_Raymond_Wannamaker
//Author: Raymond Wannamaker 
//Date: March 1, 2023
//ID: 556586
//Goal Purpose of the Program: Develop a program to determine the shipping costs for a package with a defined weight in pounds going to a specified shipping "zone."
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Initialize the variables
            string zone;
            double weight;
            double totalPrice, weightCost, zoneCost = 0, perPoundCost;


            //Parse the weight input
            bool sucess = Double.TryParse(weightTextBox.Text, out weight);
            if (sucess && weight > 0)
            {
                //Parse the zone input
                if (zoneTextBox.Text != "")
                {
                    zone = zoneTextBox.Text;
                    zone = zone.ToUpper();
                    weightCost = weight * 18;
                    sucess = false;

                    //Determine the zone cost
                    switch (zone)
                    {
                        case "N":
                            zoneCost = 27.00;
                            sucess= true;
                            break;
                        case "S":
                            zoneCost= 36.00;
                            sucess= false;
                            break;
                        case "E":
                            zoneCost = 45.00;
                            sucess= true; 
                            break;
                        case "W":
                            zoneCost = 54.00;
                            sucess = true; 
                            break;
                        default:
                            MessageBox.Show("Please enter valid Shipping Zone ");
                            break;

                    }
                    if (sucess)
                    {
                        //Calculate total cost and per pound cost
                        totalPrice = zoneCost + weightCost;
                        if (totalPrice > 100)
                        {
                            totalPrice = 100.00;
                            labelCappedTextBox.Text = "CAPPED";
                        }
                        perPoundCost = totalPrice / weight;

                        //Display the results
                        labelPerPoundCostTextBox.Text = perPoundCost.ToString("C");
                        labelTotalCostTextBox.Text = totalPrice.ToString("C");
                        weightCostTextBox.Text = weightCost.ToString("C");
                        zoneCostTextBox.Text = zoneCost.ToString("C");

                    }
                }
                else
                {
                    MessageBox.Show("Shipping Zone can't be blank.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a numeric, positive value for Package Weight.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            weightCostTextBox.Text = string.Empty;
            zoneCostTextBox.Text = string.Empty;
            weightTextBox.Text = string.Empty;
            zoneTextBox.Text = string.Empty;
            labelTotalCostTextBox.Text = string.Empty;
            labelCappedTextBox.Text = string.Empty;
            labelPerPoundCostTextBox.Text = string.Empty;
        }
    }
}
