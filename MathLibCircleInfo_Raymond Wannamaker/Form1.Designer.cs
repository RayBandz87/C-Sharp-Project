namespace MathLibCircleInfo_Raymond_Wannamaker
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
            this.inputRadiusLable = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.diameterLable = new System.Windows.Forms.Label();
            this.circumferenceLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtCircumference = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputRadiusLable
            // 
            this.inputRadiusLable.AutoSize = true;
            this.inputRadiusLable.Location = new System.Drawing.Point(28, 23);
            this.inputRadiusLable.Name = "inputRadiusLable";
            this.inputRadiusLable.Size = new System.Drawing.Size(145, 13);
            this.inputRadiusLable.TabIndex = 0;
            this.inputRadiusLable.Text = "Enter the Radius of the Circle";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(31, 52);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(141, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(33, 86);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(138, 30);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // diameterLable
            // 
            this.diameterLable.AutoSize = true;
            this.diameterLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diameterLable.Location = new System.Drawing.Point(175, 149);
            this.diameterLable.Name = "diameterLable";
            this.diameterLable.Size = new System.Drawing.Size(69, 19);
            this.diameterLable.TabIndex = 3;
            this.diameterLable.Text = "Diameter";
            // 
            // circumferenceLabel
            // 
            this.circumferenceLabel.AutoSize = true;
            this.circumferenceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circumferenceLabel.Location = new System.Drawing.Point(175, 191);
            this.circumferenceLabel.Name = "circumferenceLabel";
            this.circumferenceLabel.Size = new System.Drawing.Size(102, 19);
            this.circumferenceLabel.TabIndex = 4;
            this.circumferenceLabel.Text = "Circumference";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(175, 230);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(39, 19);
            this.areaLabel.TabIndex = 5;
            this.areaLabel.Text = "Area";
            // 
            // txtDiameter
            // 
            this.txtDiameter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDiameter.Location = new System.Drawing.Point(291, 148);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(135, 20);
            this.txtDiameter.TabIndex = 6;
            // 
            // txtCircumference
            // 
            this.txtCircumference.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCircumference.Location = new System.Drawing.Point(291, 190);
            this.txtCircumference.Name = "txtCircumference";
            this.txtCircumference.Size = new System.Drawing.Size(135, 20);
            this.txtCircumference.TabIndex = 7;
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtArea.Location = new System.Drawing.Point(291, 231);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(135, 20);
            this.txtArea.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 296);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCircumference);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.circumferenceLabel);
            this.Controls.Add(this.diameterLable);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.inputRadiusLable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputRadiusLable;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label diameterLable;
        private System.Windows.Forms.Label circumferenceLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtCircumference;
        private System.Windows.Forms.TextBox txtArea;
    }
}

