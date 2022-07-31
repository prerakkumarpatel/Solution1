
namespace lab4
{
    partial class About
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Enabled = false;
            this.txtInfo.Location = new System.Drawing.Point(95, 57);
            this.txtInfo.MaximumSize = new System.Drawing.Size(469, 157);
            this.txtInfo.MinimumSize = new System.Drawing.Size(469, 157);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(469, 157);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "Name : Prerakkumar Patel\r\nStudent Id : 100846056\r\nApplication Detail : It is abou" +
    "t the pizza shop order\r\n management and tracking app which can add , remove \r\nan" +
    "d edit order  of customer .\r\n\r\n";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(651, 260);
            this.Controls.Add(this.txtInfo);
            this.MaximumSize = new System.Drawing.Size(673, 316);
            this.MinimumSize = new System.Drawing.Size(673, 316);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
    }
}