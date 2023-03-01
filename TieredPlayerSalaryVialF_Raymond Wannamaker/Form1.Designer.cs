namespace TieredPlayerSalaryVialF_Raymond_Wannamaker
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
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.numOfHitsLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hitsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mvpCheckBox = new System.Windows.Forms.CheckBox();
            this.allStarCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.leadingPlayerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(24, 17);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Player Name";
            // 
            // numOfHitsLabel
            // 
            this.numOfHitsLabel.AutoSize = true;
            this.numOfHitsLabel.Location = new System.Drawing.Point(14, 46);
            this.numOfHitsLabel.Name = "numOfHitsLabel";
            this.numOfHitsLabel.Size = new System.Drawing.Size(77, 13);
            this.numOfHitsLabel.TabIndex = 1;
            this.numOfHitsLabel.Text = "Number of Hits";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(97, 14);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(128, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // hitsTextBox
            // 
            this.hitsTextBox.Location = new System.Drawing.Point(97, 43);
            this.hitsTextBox.Name = "hitsTextBox";
            this.hitsTextBox.Size = new System.Drawing.Size(128, 20);
            this.hitsTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salaryLabel);
            this.groupBox1.Controls.Add(this.leadingPlayerLabel);
            this.groupBox1.Location = new System.Drawing.Point(71, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // mvpCheckBox
            // 
            this.mvpCheckBox.AutoSize = true;
            this.mvpCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.mvpCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvpCheckBox.Location = new System.Drawing.Point(123, 77);
            this.mvpCheckBox.Name = "mvpCheckBox";
            this.mvpCheckBox.Size = new System.Drawing.Size(52, 17);
            this.mvpCheckBox.TabIndex = 5;
            this.mvpCheckBox.Text = "MVP";
            this.mvpCheckBox.UseVisualStyleBackColor = false;
            // 
            // allStarCheckBox
            // 
            this.allStarCheckBox.AutoSize = true;
            this.allStarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allStarCheckBox.Location = new System.Drawing.Point(123, 100);
            this.allStarCheckBox.Name = "allStarCheckBox";
            this.allStarCheckBox.Size = new System.Drawing.Size(67, 17);
            this.allStarCheckBox.TabIndex = 6;
            this.allStarCheckBox.Text = "All Star";
            this.allStarCheckBox.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(97, 126);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(127, 36);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Salary";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(97, 168);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 36);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(26, 73);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 0;
            this.salaryLabel.Text = "Salary";
            // 
            // leadingPlayerLabel
            // 
            this.leadingPlayerLabel.AutoSize = true;
            this.leadingPlayerLabel.Location = new System.Drawing.Point(26, 37);
            this.leadingPlayerLabel.Name = "leadingPlayerLabel";
            this.leadingPlayerLabel.Size = new System.Drawing.Size(36, 13);
            this.leadingPlayerLabel.TabIndex = 9;
            this.leadingPlayerLabel.Text = "Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 438);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.allStarCheckBox);
            this.Controls.Add(this.mvpCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hitsTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numOfHitsLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label numOfHitsLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox hitsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox mvpCheckBox;
        private System.Windows.Forms.CheckBox allStarCheckBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label leadingPlayerLabel;
    }
}

