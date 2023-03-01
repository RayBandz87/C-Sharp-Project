namespace ShippingCalculator_Raymond_Wannamaker
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
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelZone = new System.Windows.Forms.Label();
            this.labelWeightCost = new System.Windows.Forms.Label();
            this.labelZoneCost = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.lblPerPoundCost = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.zoneTextBox = new System.Windows.Forms.TextBox();
            this.weightCostTextBox = new System.Windows.Forms.TextBox();
            this.zoneCostTextBox = new System.Windows.Forms.TextBox();
            this.labelTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.labelPerPoundCostTextBox = new System.Windows.Forms.TextBox();
            this.labelCappedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(67, 38);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(87, 13);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Package Weight";
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Location = new System.Drawing.Point(78, 70);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(76, 13);
            this.labelZone.TabIndex = 1;
            this.labelZone.Text = "Shipping Zone";
            // 
            // labelWeightCost
            // 
            this.labelWeightCost.AutoSize = true;
            this.labelWeightCost.Location = new System.Drawing.Point(86, 196);
            this.labelWeightCost.Name = "labelWeightCost";
            this.labelWeightCost.Size = new System.Drawing.Size(68, 13);
            this.labelWeightCost.TabIndex = 2;
            this.labelWeightCost.Text = "Weight Cost:";
            // 
            // labelZoneCost
            // 
            this.labelZoneCost.AutoSize = true;
            this.labelZoneCost.Location = new System.Drawing.Point(95, 234);
            this.labelZoneCost.Name = "labelZoneCost";
            this.labelZoneCost.Size = new System.Drawing.Size(59, 13);
            this.labelZoneCost.TabIndex = 3;
            this.labelZoneCost.Text = "Zone Cost:";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(52, 266);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(102, 13);
            this.labelTotalCost.TabIndex = 4;
            this.labelTotalCost.Text = "Total Shipping Cost:";
            // 
            // lblPerPoundCost
            // 
            this.lblPerPoundCost.AutoSize = true;
            this.lblPerPoundCost.Location = new System.Drawing.Point(26, 297);
            this.lblPerPoundCost.Name = "lblPerPoundCost";
            this.lblPerPoundCost.Size = new System.Drawing.Size(128, 13);
            this.lblPerPoundCost.TabIndex = 5;
            this.lblPerPoundCost.Text = "Shipping Cost Per Pound:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(59, 108);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(108, 34);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(189, 108);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 34);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(171, 35);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(87, 20);
            this.weightTextBox.TabIndex = 8;
            // 
            // zoneTextBox
            // 
            this.zoneTextBox.Location = new System.Drawing.Point(171, 70);
            this.zoneTextBox.Name = "zoneTextBox";
            this.zoneTextBox.Size = new System.Drawing.Size(87, 20);
            this.zoneTextBox.TabIndex = 9;
            // 
            // weightCostTextBox
            // 
            this.weightCostTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.weightCostTextBox.Location = new System.Drawing.Point(171, 189);
            this.weightCostTextBox.Name = "weightCostTextBox";
            this.weightCostTextBox.Size = new System.Drawing.Size(87, 20);
            this.weightCostTextBox.TabIndex = 10;
            // 
            // zoneCostTextBox
            // 
            this.zoneCostTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.zoneCostTextBox.Location = new System.Drawing.Point(171, 227);
            this.zoneCostTextBox.Name = "zoneCostTextBox";
            this.zoneCostTextBox.Size = new System.Drawing.Size(87, 20);
            this.zoneCostTextBox.TabIndex = 11;
            // 
            // labelTotalCostTextBox
            // 
            this.labelTotalCostTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.labelTotalCostTextBox.Location = new System.Drawing.Point(171, 259);
            this.labelTotalCostTextBox.Name = "labelTotalCostTextBox";
            this.labelTotalCostTextBox.Size = new System.Drawing.Size(87, 20);
            this.labelTotalCostTextBox.TabIndex = 12;
            // 
            // labelPerPoundCostTextBox
            // 
            this.labelPerPoundCostTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.labelPerPoundCostTextBox.Location = new System.Drawing.Point(171, 294);
            this.labelPerPoundCostTextBox.Name = "labelPerPoundCostTextBox";
            this.labelPerPoundCostTextBox.Size = new System.Drawing.Size(87, 20);
            this.labelPerPoundCostTextBox.TabIndex = 13;
            // 
            // labelCappedTextBox
            // 
            this.labelCappedTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.labelCappedTextBox.Location = new System.Drawing.Point(275, 259);
            this.labelCappedTextBox.Name = "labelCappedTextBox";
            this.labelCappedTextBox.Size = new System.Drawing.Size(66, 20);
            this.labelCappedTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 358);
            this.Controls.Add(this.labelCappedTextBox);
            this.Controls.Add(this.labelPerPoundCostTextBox);
            this.Controls.Add(this.labelTotalCostTextBox);
            this.Controls.Add(this.zoneCostTextBox);
            this.Controls.Add(this.weightCostTextBox);
            this.Controls.Add(this.zoneTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.lblPerPoundCost);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelZoneCost);
            this.Controls.Add(this.labelWeightCost);
            this.Controls.Add(this.labelZone);
            this.Controls.Add(this.labelWeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.Label labelWeightCost;
        private System.Windows.Forms.Label labelZoneCost;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label lblPerPoundCost;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox zoneTextBox;
        private System.Windows.Forms.TextBox weightCostTextBox;
        private System.Windows.Forms.TextBox zoneCostTextBox;
        private System.Windows.Forms.TextBox labelTotalCostTextBox;
        private System.Windows.Forms.TextBox labelPerPoundCostTextBox;
        private System.Windows.Forms.TextBox labelCappedTextBox;
    }
}

