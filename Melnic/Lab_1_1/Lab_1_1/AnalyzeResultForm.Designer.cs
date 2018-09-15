namespace Lab_1_1
{
    partial class AnalyzeResultForm
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
            this.mathematicalExpectationLabel = new System.Windows.Forms.Label();
            this.dispersionLabel = new System.Windows.Forms.Label();
            this.meanSquareDeviationLabel = new System.Windows.Forms.Label();
            this.circumstantialAttributeLabel = new System.Windows.Forms.Label();
            this.piDivideFourLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.aperiodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mathematicalExpectationLabel
            // 
            this.mathematicalExpectationLabel.AutoSize = true;
            this.mathematicalExpectationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mathematicalExpectationLabel.Location = new System.Drawing.Point(12, 20);
            this.mathematicalExpectationLabel.Name = "mathematicalExpectationLabel";
            this.mathematicalExpectationLabel.Size = new System.Drawing.Size(288, 25);
            this.mathematicalExpectationLabel.TabIndex = 0;
            this.mathematicalExpectationLabel.Text = "MathematicalExpectation (M) = ";
            // 
            // dispersionLabel
            // 
            this.dispersionLabel.AutoSize = true;
            this.dispersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dispersionLabel.Location = new System.Drawing.Point(12, 72);
            this.dispersionLabel.Name = "dispersionLabel";
            this.dispersionLabel.Size = new System.Drawing.Size(159, 25);
            this.dispersionLabel.TabIndex = 1;
            this.dispersionLabel.Text = "Dispersion (D) = ";
            // 
            // meanSquareDeviationLabel
            // 
            this.meanSquareDeviationLabel.AutoSize = true;
            this.meanSquareDeviationLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.meanSquareDeviationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meanSquareDeviationLabel.Location = new System.Drawing.Point(12, 127);
            this.meanSquareDeviationLabel.Name = "meanSquareDeviationLabel";
            this.meanSquareDeviationLabel.Size = new System.Drawing.Size(229, 25);
            this.meanSquareDeviationLabel.TabIndex = 2;
            this.meanSquareDeviationLabel.Text = "MeanSquareDeviation = ";
            // 
            // circumstantialAttributeLabel
            // 
            this.circumstantialAttributeLabel.AutoSize = true;
            this.circumstantialAttributeLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.circumstantialAttributeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circumstantialAttributeLabel.Location = new System.Drawing.Point(12, 179);
            this.circumstantialAttributeLabel.Name = "circumstantialAttributeLabel";
            this.circumstantialAttributeLabel.Size = new System.Drawing.Size(290, 25);
            this.circumstantialAttributeLabel.TabIndex = 3;
            this.circumstantialAttributeLabel.Text = "Circumstantial Attribute Value = ";
            // 
            // piDivideFourLabel
            // 
            this.piDivideFourLabel.AutoSize = true;
            this.piDivideFourLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.piDivideFourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.piDivideFourLabel.Location = new System.Drawing.Point(12, 230);
            this.piDivideFourLabel.Name = "piDivideFourLabel";
            this.piDivideFourLabel.Size = new System.Drawing.Size(78, 25);
            this.piDivideFourLabel.TabIndex = 4;
            this.piDivideFourLabel.Text = "Pi / 4 = ";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodLabel.Location = new System.Drawing.Point(10, 280);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(111, 25);
            this.periodLabel.TabIndex = 5;
            this.periodLabel.Text = "Priod (P) = ";
            // 
            // aperiodLabel
            // 
            this.aperiodLabel.AutoSize = true;
            this.aperiodLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aperiodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aperiodLabel.Location = new System.Drawing.Point(10, 332);
            this.aperiodLabel.Name = "aperiodLabel";
            this.aperiodLabel.Size = new System.Drawing.Size(134, 25);
            this.aperiodLabel.TabIndex = 6;
            this.aperiodLabel.Text = "APeriod (L) = ";
            // 
            // AnalyzeResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 392);
            this.Controls.Add(this.aperiodLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.piDivideFourLabel);
            this.Controls.Add(this.circumstantialAttributeLabel);
            this.Controls.Add(this.meanSquareDeviationLabel);
            this.Controls.Add(this.dispersionLabel);
            this.Controls.Add(this.mathematicalExpectationLabel);
            this.Name = "AnalyzeResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalyzeResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mathematicalExpectationLabel;
        private System.Windows.Forms.Label dispersionLabel;
        private System.Windows.Forms.Label meanSquareDeviationLabel;
        private System.Windows.Forms.Label circumstantialAttributeLabel;
        private System.Windows.Forms.Label piDivideFourLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label aperiodLabel;
    }
}