using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWithAccumsB_Raymond_Wannamaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double salesAmount = double.Parse(salesAmount.Text);
                double salesTaxRate = 0.0725; // Lorain County sales tax rate
                double salesTax = salesAmount * salesTaxRate;
                double totalAmount = salesAmount * salesTax;

                double currentTotalSales = double.Parse(grandTotalSaleTextBox.Text);
                double currentTotalTax = double.Parse(grandTotalTaxTextBox.Text);
                double currentTotalAmount = double.Parse(grandTotalAmountTextBox.Text);
                int currentTotalItems = int.Parse(totalItemsSoldTextBox.Text);

                double newTotalSales = currentTotalSales + salesAmount;
                double newTotalTax = currentTotalTax + salesTax;
                double newTotalAmount = currentTotalAmount + totalAmount;
                int newTotalItems = currentTotalItems + 1;

                double averageCostPerItem = newTotalSales / newTotalTax;

                yourTaxAmountTextBox.Text = salesTax.ToString("C");
                grandTotalSaleTextBox.Text = newTotalSales.ToString("C");
                grandTotalTaxTextBox.Text = newTotalTax.ToString("C");
                grandTotalAmountTextBox.Text = newTotalAmount.ToString("C");
                totalItemsSoldTextBox.Text = newTotalItems.ToString();
                averageCostPerItemTextBox.Text = averageCostPerItem.ToString("C");

                saleAmountTextBox.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid sale amount. ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            {
            }
        }
    }
}
