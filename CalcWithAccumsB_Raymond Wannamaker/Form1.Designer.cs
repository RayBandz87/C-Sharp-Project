namespace CalcWithAccumsB_Raymond_Wannamaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saleAmountLabel = new System.Windows.Forms.Label();
            this.saleAmountTextBox = new System.Windows.Forms.TextBox();
            this.yourTaxAmountLabel = new System.Windows.Forms.Label();
            this.taxAmountTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalSaleLabel = new System.Windows.Forms.Label();
            this.grandTotalSaleTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalTaxLabel = new System.Windows.Forms.Label();
            this.grandTotalTaxTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalAmountLabel = new System.Windows.Forms.Label();
            this.grandTotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.totalItemSold = new System.Windows.Forms.Label();
            this.averageCostPerItemLabel = new System.Windows.Forms.Label();
            this.totalItemsSoldTextBox = new System.Windows.Forms.TextBox();
            this.averageCostPerItemTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yourTaxAmountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saleAmountLabel
            // 
            this.saleAmountLabel.AutoSize = true;
            this.saleAmountLabel.Location = new System.Drawing.Point(30, 34);
            this.saleAmountLabel.Name = "saleAmountLabel";
            this.saleAmountLabel.Size = new System.Drawing.Size(100, 13);
            this.saleAmountLabel.TabIndex = 0;
            this.saleAmountLabel.Text = "Enter Sales Amount";
            // 
            // saleAmountTextBox
            // 
            this.saleAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleAmountTextBox.Location = new System.Drawing.Point(32, 60);
            this.saleAmountTextBox.Name = "saleAmountTextBox";
            this.saleAmountTextBox.Size = new System.Drawing.Size(97, 26);
            this.saleAmountTextBox.TabIndex = 1;
            // 
            // yourTaxAmountLabel
            // 
            this.yourTaxAmountLabel.AutoSize = true;
            this.yourTaxAmountLabel.Location = new System.Drawing.Point(30, 119);
            this.yourTaxAmountLabel.Name = "yourTaxAmountLabel";
            this.yourTaxAmountLabel.Size = new System.Drawing.Size(102, 26);
            this.yourTaxAmountLabel.TabIndex = 2;
            this.yourTaxAmountLabel.Text = "Your Tax Amount is:\r\n(@ 7.25%)";
            this.yourTaxAmountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taxAmountTextBox
            // 
            this.taxAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountTextBox.Location = new System.Drawing.Point(33, 148);
            this.taxAmountTextBox.Name = "taxAmountTextBox";
            this.taxAmountTextBox.Size = new System.Drawing.Size(96, 26);
            this.taxAmountTextBox.TabIndex = 3;
            // 
            // grandTotalSaleLabel
            // 
            this.grandTotalSaleLabel.AutoSize = true;
            this.grandTotalSaleLabel.Location = new System.Drawing.Point(183, 119);
            this.grandTotalSaleLabel.Name = "grandTotalSaleLabel";
            this.grandTotalSaleLabel.Size = new System.Drawing.Size(92, 13);
            this.grandTotalSaleLabel.TabIndex = 4;
            this.grandTotalSaleLabel.Text = "Grand Total Sales";
            // 
            // grandTotalSaleTextBox
            // 
            this.grandTotalSaleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalSaleTextBox.Location = new System.Drawing.Point(185, 148);
            this.grandTotalSaleTextBox.Name = "grandTotalSaleTextBox";
            this.grandTotalSaleTextBox.Size = new System.Drawing.Size(90, 26);
            this.grandTotalSaleTextBox.TabIndex = 5;
            // 
            // grandTotalTaxLabel
            // 
            this.grandTotalTaxLabel.AutoSize = true;
            this.grandTotalTaxLabel.Location = new System.Drawing.Point(182, 201);
            this.grandTotalTaxLabel.Name = "grandTotalTaxLabel";
            this.grandTotalTaxLabel.Size = new System.Drawing.Size(84, 13);
            this.grandTotalTaxLabel.TabIndex = 6;
            this.grandTotalTaxLabel.Text = "Grand Total Tax";
            // 
            // grandTotalTaxTextBox
            // 
            this.grandTotalTaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalTaxTextBox.Location = new System.Drawing.Point(186, 231);
            this.grandTotalTaxTextBox.Name = "grandTotalTaxTextBox";
            this.grandTotalTaxTextBox.Size = new System.Drawing.Size(89, 26);
            this.grandTotalTaxTextBox.TabIndex = 7;
            // 
            // grandTotalAmountLabel
            // 
            this.grandTotalAmountLabel.AutoSize = true;
            this.grandTotalAmountLabel.Location = new System.Drawing.Point(182, 276);
            this.grandTotalAmountLabel.Name = "grandTotalAmountLabel";
            this.grandTotalAmountLabel.Size = new System.Drawing.Size(135, 13);
            this.grandTotalAmountLabel.TabIndex = 8;
            this.grandTotalAmountLabel.Text = "Grand Total Amount to Pay";
            // 
            // grandTotalAmountTextBox
            // 
            this.grandTotalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalAmountTextBox.Location = new System.Drawing.Point(188, 305);
            this.grandTotalAmountTextBox.Name = "grandTotalAmountTextBox";
            this.grandTotalAmountTextBox.Size = new System.Drawing.Size(86, 26);
            this.grandTotalAmountTextBox.TabIndex = 9;
            // 
            // totalItemSold
            // 
            this.totalItemSold.AutoSize = true;
            this.totalItemSold.Location = new System.Drawing.Point(364, 119);
            this.totalItemSold.Name = "totalItemSold";
            this.totalItemSold.Size = new System.Drawing.Size(83, 13);
            this.totalItemSold.TabIndex = 10;
            this.totalItemSold.Text = "Total Items Sold";
            // 
            // averageCostPerItemLabel
            // 
            this.averageCostPerItemLabel.AutoSize = true;
            this.averageCostPerItemLabel.Location = new System.Drawing.Point(364, 225);
            this.averageCostPerItemLabel.Name = "averageCostPerItemLabel";
            this.averageCostPerItemLabel.Size = new System.Drawing.Size(91, 26);
            this.averageCostPerItemLabel.TabIndex = 11;
            this.averageCostPerItemLabel.Text = "Average Cost Per\r\nItem (Before Tax):";
            this.averageCostPerItemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalItemsSoldTextBox
            // 
            this.totalItemsSoldTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsSoldTextBox.Location = new System.Drawing.Point(358, 148);
            this.totalItemsSoldTextBox.Name = "totalItemsSoldTextBox";
            this.totalItemsSoldTextBox.Size = new System.Drawing.Size(89, 26);
            this.totalItemsSoldTextBox.TabIndex = 12;
            // 
            // averageCostPerItemTextBox
            // 
            this.averageCostPerItemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageCostPerItemTextBox.Location = new System.Drawing.Point(363, 273);
            this.averageCostPerItemTextBox.Name = "averageCostPerItemTextBox";
            this.averageCostPerItemTextBox.Size = new System.Drawing.Size(84, 26);
            this.averageCostPerItemTextBox.TabIndex = 13;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(162, 22);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(87, 36);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(162, 64);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 36);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your Tax Amount is\r\n(@7.25%)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yourTaxAmountTextBox
            // 
            this.yourTaxAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourTaxAmountTextBox.Location = new System.Drawing.Point(33, 237);
            this.yourTaxAmountTextBox.Name = "yourTaxAmountTextBox";
            this.yourTaxAmountTextBox.Size = new System.Drawing.Size(101, 26);
            this.yourTaxAmountTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.yourTaxAmountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.averageCostPerItemTextBox);
            this.Controls.Add(this.totalItemsSoldTextBox);
            this.Controls.Add(this.averageCostPerItemLabel);
            this.Controls.Add(this.totalItemSold);
            this.Controls.Add(this.grandTotalAmountTextBox);
            this.Controls.Add(this.grandTotalAmountLabel);
            this.Controls.Add(this.grandTotalTaxTextBox);
            this.Controls.Add(this.grandTotalTaxLabel);
            this.Controls.Add(this.grandTotalSaleTextBox);
            this.Controls.Add(this.grandTotalSaleLabel);
            this.Controls.Add(this.taxAmountTextBox);
            this.Controls.Add(this.yourTaxAmountLabel);
            this.Controls.Add(this.saleAmountTextBox);
            this.Controls.Add(this.saleAmountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saleAmountLabel;
        private System.Windows.Forms.TextBox saleAmountTextBox;
        private System.Windows.Forms.Label yourTaxAmountLabel;
        private System.Windows.Forms.TextBox taxAmountTextBox;
        private System.Windows.Forms.Label grandTotalSaleLabel;
        private System.Windows.Forms.TextBox grandTotalSaleTextBox;
        private System.Windows.Forms.Label grandTotalTaxLabel;
        private System.Windows.Forms.TextBox grandTotalTaxTextBox;
        private System.Windows.Forms.Label grandTotalAmountLabel;
        private System.Windows.Forms.TextBox grandTotalAmountTextBox;
        private System.Windows.Forms.Label totalItemSold;
        private System.Windows.Forms.Label averageCostPerItemLabel;
        private System.Windows.Forms.TextBox totalItemsSoldTextBox;
        private System.Windows.Forms.TextBox averageCostPerItemTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yourTaxAmountTextBox;
    }
}

