
namespace ICE3
{
    partial class frmICE3Calculate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNumX = new System.Windows.Forms.Label();
            this.lblNumY = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(146, 191);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 34);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNumX
            // 
            this.lblNumX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumX.Location = new System.Drawing.Point(104, 54);
            this.lblNumX.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblNumX.Name = "lblNumX";
            this.lblNumX.Size = new System.Drawing.Size(23, 50);
            this.lblNumX.TabIndex = 1;
            this.lblNumX.Text = "X";
            // 
            // lblNumY
            // 
            this.lblNumY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumY.Location = new System.Drawing.Point(284, 54);
            this.lblNumY.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblNumY.Name = "lblNumY";
            this.lblNumY.Size = new System.Drawing.Size(23, 50);
            this.lblNumY.TabIndex = 2;
            this.lblNumY.Text = "Y";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(58, 107);
            this.nudX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(96, 31);
            this.nudX.TabIndex = 1;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(244, 107);
            this.nudY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(96, 31);
            this.nudY.TabIndex = 2;
            // 
            // frmCalculate
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 306);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.lblNumY);
            this.Controls.Add(this.lblNumX);
            this.Controls.Add(this.btnCalculate);
            this.MaximumSize = new System.Drawing.Size(469, 362);
            this.MinimumSize = new System.Drawing.Size(469, 362);
            this.Name = "frmCalculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculate ";
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNumX;
        private System.Windows.Forms.Label lblNumY;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
    }
}

