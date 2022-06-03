
namespace Lab1
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblAttendes = new System.Windows.Forms.Label();
            this.txtAttendeesEntry = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAverageAttendees = new System.Windows.Forms.Label();
            this.ttpMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.lbxAttendeesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(48, 37);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(101, 25);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "Time: 1 pm";
            this.ttpMainForm.SetToolTip(this.lblHour, "For Time ");
            // 
            // lblAttendes
            // 
            this.lblAttendes.AutoSize = true;
            this.lblAttendes.Location = new System.Drawing.Point(48, 99);
            this.lblAttendes.Name = "lblAttendes";
            this.lblAttendes.Size = new System.Drawing.Size(92, 25);
            this.lblAttendes.TabIndex = 1;
            this.lblAttendes.Text = "Attendees";
            this.ttpMainForm.SetToolTip(this.lblAttendes, "Enter Attendees Below");
            // 
            // txtAttendeesEntry
            // 
            this.txtAttendeesEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttendeesEntry.Location = new System.Drawing.Point(48, 141);
            this.txtAttendeesEntry.Name = "txtAttendeesEntry";
            this.txtAttendeesEntry.Size = new System.Drawing.Size(112, 31);
            this.txtAttendeesEntry.TabIndex = 2;
            this.txtAttendeesEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpMainForm.SetToolTip(this.txtAttendeesEntry, "Enter Number of Attendees For Above Hour");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.ttpMainForm.SetToolTip(this.btnAdd, "Button to Add Attendees");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(48, 386);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 34);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.ttpMainForm.SetToolTip(this.btnReset, "Reset Button");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(241, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.ttpMainForm.SetToolTip(this.btnExit, "Exit Button");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAverageAttendees
            // 
            this.lblAverageAttendees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageAttendees.Location = new System.Drawing.Point(48, 299);
            this.lblAverageAttendees.Name = "lblAverageAttendees";
            this.lblAverageAttendees.Size = new System.Drawing.Size(305, 65);
            this.lblAverageAttendees.TabIndex = 7;
            this.lblAverageAttendees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpMainForm.SetToolTip(this.lblAverageAttendees, "Average Attendees ");
            // 
            // lbxAttendeesList
            // 
            this.lbxAttendeesList.FormattingEnabled = true;
            this.lbxAttendeesList.ItemHeight = 25;
            this.lbxAttendeesList.Location = new System.Drawing.Point(205, 26);
            this.lbxAttendeesList.Name = "lbxAttendeesList";
            this.lbxAttendeesList.Size = new System.Drawing.Size(148, 254);
            this.lbxAttendeesList.TabIndex = 8;
            this.ttpMainForm.SetToolTip(this.lbxAttendeesList, "List Of Attendees");
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(365, 444);
            this.Controls.Add(this.lbxAttendeesList);
            this.Controls.Add(this.lblAverageAttendees);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAttendeesEntry);
            this.Controls.Add(this.lblAttendes);
            this.Controls.Add(this.lblHour);
            this.MaximumSize = new System.Drawing.Size(387, 500);
            this.MinimumSize = new System.Drawing.Size(387, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Hourly Attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblAttendes;
        private System.Windows.Forms.TextBox txtAttendeesEntry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip ttpMainForm;
        private System.Windows.Forms.Label lblAverageAttendees;
        private System.Windows.Forms.ListBox lbxAttendeesList;
    }
}

