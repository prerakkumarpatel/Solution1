
namespace ICE01
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(281, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCORDING TO MAY 22\r\n\r\nPRERAKKUMAR IS SUPERB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYes.Location = new System.Drawing.Point(194, 287);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(112, 34);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "&Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            this.btnYes.MouseHover += new System.EventHandler(this.btnYes_MouseHover);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNo.Location = new System.Drawing.Point(456, 287);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(112, 34);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}

