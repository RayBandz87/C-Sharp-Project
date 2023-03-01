namespace CalcWithAccums_Raymond_Wannamaker
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
            this.mulchCalcLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.calculatorButton = new System.Windows.Forms.Button();
            this.currentOrderBox = new System.Windows.Forms.GroupBox();
            this.allOrdersBox = new System.Windows.Forms.GroupBox();
            this.cubicFeetLabel = new System.Windows.Forms.Label();
            this.cubicYardsLabel = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.feetAllOrdersLabel = new System.Windows.Forms.Label();
            this.yardsAllOrdersLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.numOfAllLabel = new System.Windows.Forms.Label();
            this.baseCapLabel = new System.Windows.Forms.Label();
            this.orderSoFarLabel = new System.Windows.Forms.Label();
            this.remainingCapacity = new System.Windows.Forms.Label();
            this.baseCapacityTextBox = new System.Windows.Forms.TextBox();
            this.cubicYardOrderTextBox = new System.Windows.Forms.TextBox();
            this.remainingCapacityTextBox = new System.Windows.Forms.TextBox();
            this.cubicFeetTextBox = new System.Windows.Forms.TextBox();
            this.cubicYardsTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.cubicFeetAccum = new System.Windows.Forms.TextBox();
            this.cubicYardsAccum = new System.Windows.Forms.TextBox();
            this.costOrderText = new System.Windows.Forms.TextBox();
            this.numOfOrderTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.currentOrderBox.SuspendLayout();
            this.allOrdersBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mulchCalcLabel
            // 
            this.mulchCalcLabel.AutoSize = true;
            this.mulchCalcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulchCalcLabel.Location = new System.Drawing.Point(25, 17);
            this.mulchCalcLabel.Name = "mulchCalcLabel";
            this.mulchCalcLabel.Size = new System.Drawing.Size(142, 20);
            this.mulchCalcLabel.TabIndex = 0;
            this.mulchCalcLabel.Text = "Mulch Calculator";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(12, 48);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(79, 13);
            this.depthLabel.TabIndex = 1;
            this.depthLabel.Text = "Enter Depth (ft)";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 73);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(78, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Enter Width (ft)";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 101);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(81, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Enter Height (ft)";
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(101, 41);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(76, 20);
            this.depthTextBox.TabIndex = 4;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(101, 73);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(76, 20);
            this.widthTextBox.TabIndex = 5;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(101, 99);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(76, 20);
            this.heightTextBox.TabIndex = 6;
            // 
            // calculatorButton
            // 
            this.calculatorButton.Location = new System.Drawing.Point(12, 125);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(165, 27);
            this.calculatorButton.TabIndex = 7;
            this.calculatorButton.Text = "Calculator";
            this.calculatorButton.UseVisualStyleBackColor = true;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // currentOrderBox
            // 
            this.currentOrderBox.Controls.Add(this.priceTextBox);
            this.currentOrderBox.Controls.Add(this.cubicYardsTextBox);
            this.currentOrderBox.Controls.Add(this.cubicFeetTextBox);
            this.currentOrderBox.Controls.Add(this.cost);
            this.currentOrderBox.Controls.Add(this.cubicYardsLabel);
            this.currentOrderBox.Controls.Add(this.cubicFeetLabel);
            this.currentOrderBox.Location = new System.Drawing.Point(12, 169);
            this.currentOrderBox.Name = "currentOrderBox";
            this.currentOrderBox.Size = new System.Drawing.Size(210, 170);
            this.currentOrderBox.TabIndex = 8;
            this.currentOrderBox.TabStop = false;
            this.currentOrderBox.Text = "Current Order";
            // 
            // allOrdersBox
            // 
            this.allOrdersBox.Controls.Add(this.numOfOrderTextBox);
            this.allOrdersBox.Controls.Add(this.costOrderText);
            this.allOrdersBox.Controls.Add(this.cubicYardsAccum);
            this.allOrdersBox.Controls.Add(this.cubicFeetAccum);
            this.allOrdersBox.Controls.Add(this.numOfAllLabel);
            this.allOrdersBox.Controls.Add(this.costLabel);
            this.allOrdersBox.Controls.Add(this.yardsAllOrdersLabel);
            this.allOrdersBox.Controls.Add(this.feetAllOrdersLabel);
            this.allOrdersBox.Location = new System.Drawing.Point(238, 169);
            this.allOrdersBox.Name = "allOrdersBox";
            this.allOrdersBox.Size = new System.Drawing.Size(210, 170);
            this.allOrdersBox.TabIndex = 9;
            this.allOrdersBox.TabStop = false;
            this.allOrdersBox.Text = "Total of All Orders";
            // 
            // cubicFeetLabel
            // 
            this.cubicFeetLabel.AutoSize = true;
            this.cubicFeetLabel.Location = new System.Drawing.Point(8, 32);
            this.cubicFeetLabel.Name = "cubicFeetLabel";
            this.cubicFeetLabel.Size = new System.Drawing.Size(58, 13);
            this.cubicFeetLabel.TabIndex = 0;
            this.cubicFeetLabel.Text = "Cubic Feet";
            // 
            // cubicYardsLabel
            // 
            this.cubicYardsLabel.AutoSize = true;
            this.cubicYardsLabel.Location = new System.Drawing.Point(8, 66);
            this.cubicYardsLabel.Name = "cubicYardsLabel";
            this.cubicYardsLabel.Size = new System.Drawing.Size(64, 13);
            this.cubicYardsLabel.TabIndex = 1;
            this.cubicYardsLabel.Text = "Cubic Yards";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(6, 95);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(57, 13);
            this.cost.TabIndex = 2;
            this.cost.Text = "@ $  Price";
            // 
            // feetAllOrdersLabel
            // 
            this.feetAllOrdersLabel.AutoSize = true;
            this.feetAllOrdersLabel.Location = new System.Drawing.Point(16, 32);
            this.feetAllOrdersLabel.Name = "feetAllOrdersLabel";
            this.feetAllOrdersLabel.Size = new System.Drawing.Size(112, 13);
            this.feetAllOrdersLabel.TabIndex = 1;
            this.feetAllOrdersLabel.Text = "Cubic Feet (All Orders)";
            // 
            // yardsAllOrdersLabel
            // 
            this.yardsAllOrdersLabel.AutoSize = true;
            this.yardsAllOrdersLabel.Location = new System.Drawing.Point(10, 66);
            this.yardsAllOrdersLabel.Name = "yardsAllOrdersLabel";
            this.yardsAllOrdersLabel.Size = new System.Drawing.Size(118, 13);
            this.yardsAllOrdersLabel.TabIndex = 2;
            this.yardsAllOrdersLabel.Text = "Cubic Yards (All Orders)";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(46, 95);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(82, 13);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "Cost (All Orders)";
            // 
            // numOfAllLabel
            // 
            this.numOfAllLabel.AutoSize = true;
            this.numOfAllLabel.Location = new System.Drawing.Point(33, 122);
            this.numOfAllLabel.Name = "numOfAllLabel";
            this.numOfAllLabel.Size = new System.Drawing.Size(95, 13);
            this.numOfAllLabel.TabIndex = 4;
            this.numOfAllLabel.Text = "Numbers of Orders";
            // 
            // baseCapLabel
            // 
            this.baseCapLabel.AutoSize = true;
            this.baseCapLabel.Location = new System.Drawing.Point(12, 360);
            this.baseCapLabel.Name = "baseCapLabel";
            this.baseCapLabel.Size = new System.Drawing.Size(65, 26);
            this.baseCapLabel.TabIndex = 10;
            this.baseCapLabel.Text = "Truck Base \r\nCapacity";
            this.baseCapLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orderSoFarLabel
            // 
            this.orderSoFarLabel.AutoSize = true;
            this.orderSoFarLabel.Location = new System.Drawing.Point(178, 360);
            this.orderSoFarLabel.Name = "orderSoFarLabel";
            this.orderSoFarLabel.Size = new System.Drawing.Size(79, 26);
            this.orderSoFarLabel.TabIndex = 11;
            this.orderSoFarLabel.Text = "Cubic Yards\r\nOrdered So Far";
            this.orderSoFarLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // remainingCapacity
            // 
            this.remainingCapacity.AutoSize = true;
            this.remainingCapacity.Location = new System.Drawing.Point(350, 360);
            this.remainingCapacity.Name = "remainingCapacity";
            this.remainingCapacity.Size = new System.Drawing.Size(98, 26);
            this.remainingCapacity.TabIndex = 12;
            this.remainingCapacity.Text = "Truck\'s Remaining \r\nCapacity";
            this.remainingCapacity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // baseCapacityTextBox
            // 
            this.baseCapacityTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.baseCapacityTextBox.Location = new System.Drawing.Point(83, 364);
            this.baseCapacityTextBox.Name = "baseCapacityTextBox";
            this.baseCapacityTextBox.Size = new System.Drawing.Size(68, 20);
            this.baseCapacityTextBox.TabIndex = 13;
            // 
            // cubicYardOrderTextBox
            // 
            this.cubicYardOrderTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.cubicYardOrderTextBox.Location = new System.Drawing.Point(263, 364);
            this.cubicYardOrderTextBox.Name = "cubicYardOrderTextBox";
            this.cubicYardOrderTextBox.Size = new System.Drawing.Size(68, 20);
            this.cubicYardOrderTextBox.TabIndex = 14;
            // 
            // remainingCapacityTextBox
            // 
            this.remainingCapacityTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.remainingCapacityTextBox.Location = new System.Drawing.Point(454, 364);
            this.remainingCapacityTextBox.Name = "remainingCapacityTextBox";
            this.remainingCapacityTextBox.Size = new System.Drawing.Size(68, 20);
            this.remainingCapacityTextBox.TabIndex = 15;
            // 
            // cubicFeetTextBox
            // 
            this.cubicFeetTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.cubicFeetTextBox.Location = new System.Drawing.Point(81, 29);
            this.cubicFeetTextBox.Name = "cubicFeetTextBox";
            this.cubicFeetTextBox.Size = new System.Drawing.Size(74, 20);
            this.cubicFeetTextBox.TabIndex = 3;
            // 
            // cubicYardsTextBox
            // 
            this.cubicYardsTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.cubicYardsTextBox.Location = new System.Drawing.Point(81, 63);
            this.cubicYardsTextBox.Name = "cubicYardsTextBox";
            this.cubicYardsTextBox.Size = new System.Drawing.Size(74, 20);
            this.cubicYardsTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.priceTextBox.Location = new System.Drawing.Point(81, 92);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(74, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // cubicFeetAccum
            // 
            this.cubicFeetAccum.BackColor = System.Drawing.SystemColors.Menu;
            this.cubicFeetAccum.Location = new System.Drawing.Point(130, 29);
            this.cubicFeetAccum.Name = "cubicFeetAccum";
            this.cubicFeetAccum.Size = new System.Drawing.Size(74, 20);
            this.cubicFeetAccum.TabIndex = 5;
            // 
            // cubicYardsAccum
            // 
            this.cubicYardsAccum.BackColor = System.Drawing.SystemColors.Menu;
            this.cubicYardsAccum.Location = new System.Drawing.Point(130, 63);
            this.cubicYardsAccum.Name = "cubicYardsAccum";
            this.cubicYardsAccum.Size = new System.Drawing.Size(74, 20);
            this.cubicYardsAccum.TabIndex = 6;
            // 
            // costOrderText
            // 
            this.costOrderText.BackColor = System.Drawing.SystemColors.Menu;
            this.costOrderText.Location = new System.Drawing.Point(130, 95);
            this.costOrderText.Name = "costOrderText";
            this.costOrderText.Size = new System.Drawing.Size(74, 20);
            this.costOrderText.TabIndex = 7;
            // 
            // numOfOrderTextBox
            // 
            this.numOfOrderTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.numOfOrderTextBox.Location = new System.Drawing.Point(130, 122);
            this.numOfOrderTextBox.Name = "numOfOrderTextBox";
            this.numOfOrderTextBox.Size = new System.Drawing.Size(74, 20);
            this.numOfOrderTextBox.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(154, 402);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(177, 26);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.remainingCapacityTextBox);
            this.Controls.Add(this.cubicYardOrderTextBox);
            this.Controls.Add(this.baseCapacityTextBox);
            this.Controls.Add(this.remainingCapacity);
            this.Controls.Add(this.orderSoFarLabel);
            this.Controls.Add(this.baseCapLabel);
            this.Controls.Add(this.allOrdersBox);
            this.Controls.Add(this.currentOrderBox);
            this.Controls.Add(this.calculatorButton);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.mulchCalcLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.currentOrderBox.ResumeLayout(false);
            this.currentOrderBox.PerformLayout();
            this.allOrdersBox.ResumeLayout(false);
            this.allOrdersBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mulchCalcLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button calculatorButton;
        private System.Windows.Forms.GroupBox currentOrderBox;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label cubicYardsLabel;
        private System.Windows.Forms.Label cubicFeetLabel;
        private System.Windows.Forms.GroupBox allOrdersBox;
        private System.Windows.Forms.Label numOfAllLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label yardsAllOrdersLabel;
        private System.Windows.Forms.Label feetAllOrdersLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox cubicYardsTextBox;
        private System.Windows.Forms.TextBox cubicFeetTextBox;
        private System.Windows.Forms.TextBox numOfOrderTextBox;
        private System.Windows.Forms.TextBox costOrderText;
        private System.Windows.Forms.TextBox cubicYardsAccum;
        private System.Windows.Forms.TextBox cubicFeetAccum;
        private System.Windows.Forms.Label baseCapLabel;
        private System.Windows.Forms.Label orderSoFarLabel;
        private System.Windows.Forms.Label remainingCapacity;
        private System.Windows.Forms.TextBox baseCapacityTextBox;
        private System.Windows.Forms.TextBox cubicYardOrderTextBox;
        private System.Windows.Forms.TextBox remainingCapacityTextBox;
        private System.Windows.Forms.Button clearButton;
    }
}

