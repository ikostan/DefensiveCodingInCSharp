namespace ACM.Win
{
    partial class PedometerWin
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textStepsGoal = new System.Windows.Forms.TextBox();
            this.textStepsToday = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(378, 27);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(103, 53);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Step Goal for Today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Steps Today:";
            // 
            // textStepsGoal
            // 
            this.textStepsGoal.Location = new System.Drawing.Point(203, 27);
            this.textStepsGoal.Name = "textStepsGoal";
            this.textStepsGoal.Size = new System.Drawing.Size(142, 20);
            this.textStepsGoal.TabIndex = 3;
            // 
            // textStepsToday
            // 
            this.textStepsToday.Location = new System.Drawing.Point(203, 60);
            this.textStepsToday.Name = "textStepsToday";
            this.textStepsToday.Size = new System.Drawing.Size(142, 20);
            this.textStepsToday.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(117, 115);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(265, 23);
            this.labelResult.TabIndex = 5;
            // 
            // PedometerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 170);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textStepsToday);
            this.Controls.Add(this.textStepsGoal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "PedometerWin";
            this.Text = "Pedometer Metrics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textStepsGoal;
        private System.Windows.Forms.TextBox textStepsToday;
        private System.Windows.Forms.Label labelResult;
    }
}