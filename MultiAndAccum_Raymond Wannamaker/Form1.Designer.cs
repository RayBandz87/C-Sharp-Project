namespace MultiAndAccum_Raymond_Wannamaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mutliLabel = new System.Windows.Forms.Label();
            this.runningTotalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.multiTextBox = new System.Windows.Forms.TextBox();
            this.runningTotalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2:";
            // 
            // mutliLabel
            // 
            this.mutliLabel.AutoSize = true;
            this.mutliLabel.Location = new System.Drawing.Point(112, 215);
            this.mutliLabel.Name = "mutliLabel";
            this.mutliLabel.Size = new System.Drawing.Size(71, 13);
            this.mutliLabel.TabIndex = 2;
            this.mutliLabel.Text = "Multiplication:";
            // 
            // runningTotalLabel
            // 
            this.runningTotalLabel.AutoSize = true;
            this.runningTotalLabel.Location = new System.Drawing.Point(106, 273);
            this.runningTotalLabel.Name = "runningTotalLabel";
            this.runningTotalLabel.Size = new System.Drawing.Size(77, 13);
            this.runningTotalLabel.TabIndex = 3;
            this.runningTotalLabel.Text = "Running Total:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(103, 149);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 39);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(257, 149);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 39);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset All";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(204, 34);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(94, 20);
            this.num1TextBox.TabIndex = 6;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(204, 89);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(94, 20);
            this.num2TextBox.TabIndex = 7;
            // 
            // multiTextBox
            // 
            this.multiTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.multiTextBox.Location = new System.Drawing.Point(204, 215);
            this.multiTextBox.Name = "multiTextBox";
            this.multiTextBox.Size = new System.Drawing.Size(94, 20);
            this.multiTextBox.TabIndex = 8;
            // 
            // runningTotalTextBox
            // 
            this.runningTotalTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.runningTotalTextBox.Location = new System.Drawing.Point(204, 273);
            this.runningTotalTextBox.Name = "runningTotalTextBox";
            this.runningTotalTextBox.Size = new System.Drawing.Size(94, 20);
            this.runningTotalTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 332);
            this.Controls.Add(this.runningTotalTextBox);
            this.Controls.Add(this.multiTextBox);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.runningTotalLabel);
            this.Controls.Add(this.mutliLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mutliLabel;
        private System.Windows.Forms.Label runningTotalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.TextBox multiTextBox;
        private System.Windows.Forms.TextBox runningTotalTextBox;
    }
}

