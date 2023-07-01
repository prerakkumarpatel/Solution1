
namespace ICE01
{
    partial class frmICE1
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
            this.lblQuote = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuote
            // 
            this.lblQuote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuote.ForeColor = System.Drawing.Color.White;
            this.lblQuote.Location = new System.Drawing.Point(53, 30);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(303, 93);
            this.lblQuote.TabIndex = 0;
            this.lblQuote.Text = "According to a May 2022 survey, it is known that Zeel is awesome.\r\n\r\nDo you agree" +
    " with this statement?";
            this.lblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(53, 146);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(94, 29);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "&Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNo.Location = new System.Drawing.Point(262, 146);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(94, 29);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            this.btnNo.MouseHover += new System.EventHandler(this.btnNo_MouseHover);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(404, 207);
            this.ControlBox = false;
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblQuote);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeel is Awesome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}

