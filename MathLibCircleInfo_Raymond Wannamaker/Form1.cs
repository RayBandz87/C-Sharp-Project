using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathLibCircleInfo_Raymond_Wannamaker
//Author: Raymond Wannamaker 
//ID: 556586
//Date: Feb 23, 2033
//Goal Purpose of the Program: Create a prgram to Calcuate the Radius of circle to determine the diameter, circumference and area.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variable declaration
            string radius;
            double r;

            //Input the Radius in txtRadius TextBox
            radius = txtRadius.Text;

            //Use the TryParse() to validate the string is double or not
            if (double.TryParse(radius, out r))
            {
                r = double.Parse(radius);

                //Calculate the Diameter
                txtDiameter.Text = string.Format("{0:0.00}", r * 2);

                //Calculate the Circumference
                txtCircumference.Text = string.Format("{0:0.00}", 2 * Math.PI * r);

                //Calculate the Area
                txtArea.Text = string.Format("{0:0.00}", Math.PI * r * r);
            }
            else
            {
                //Error Message for incorrect value input
                MessageBox.Show("Invalid input. Please enter a valid numeric value for the radius");
            }
            }
        }
    }

