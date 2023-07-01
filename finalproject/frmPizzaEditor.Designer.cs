
namespace lab3
{
    partial class frmPizzaEditor
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsSpicy = new System.Windows.Forms.CheckBox();
            this.chkIsPickup = new System.Windows.Forms.CheckBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.chkIsPremium = new System.Windows.Forms.CheckBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dtpOrderOn = new System.Windows.Forms.DateTimePicker();
            this.lblBorn = new System.Windows.Forms.Label();
            this.cboPizzaType = new System.Windows.Forms.ComboBox();
            this.lblPizzaType = new System.Windows.Forms.Label();
            this.txtOrderOf = new System.Windows.Forms.TextBox();
            this.lblOrderOf = new System.Windows.Forms.Label();
            this.nudOrder = new System.Windows.Forms.NumericUpDown();
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ttpEditor = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkIsSpicy);
            this.groupBox1.Controls.Add(this.chkIsPickup);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.chkIsPremium);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.dtpOrderOn);
            this.groupBox1.Controls.Add(this.lblBorn);
            this.groupBox1.Controls.Add(this.cboPizzaType);
            this.groupBox1.Controls.Add(this.lblPizzaType);
            this.groupBox1.Controls.Add(this.txtOrderOf);
            this.groupBox1.Controls.Add(this.lblOrderOf);
            this.groupBox1.Controls.Add(this.nudOrder);
            this.groupBox1.Controls.Add(this.lblOrder);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(639, 446);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit";
            // 
            // chkIsSpicy
            // 
            this.chkIsSpicy.AutoSize = true;
            this.chkIsSpicy.Location = new System.Drawing.Point(148, 412);
            this.chkIsSpicy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIsSpicy.Name = "chkIsSpicy";
            this.chkIsSpicy.Size = new System.Drawing.Size(80, 29);
            this.chkIsSpicy.TabIndex = 8;
            this.chkIsSpicy.Text = "Spicy";
            this.ttpEditor.SetToolTip(this.chkIsSpicy, "need spice");
            this.chkIsSpicy.UseVisualStyleBackColor = true;
            // 
            // chkIsPickup
            // 
            this.chkIsPickup.AutoSize = true;
            this.chkIsPickup.Location = new System.Drawing.Point(148, 334);
            this.chkIsPickup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIsPickup.Name = "chkIsPickup";
            this.chkIsPickup.Size = new System.Drawing.Size(90, 29);
            this.chkIsPickup.TabIndex = 6;
            this.chkIsPickup.Text = "Pickup";
            this.ttpEditor.SetToolTip(this.chkIsPickup, "need pickup");
            this.chkIsPickup.UseVisualStyleBackColor = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(148, 295);
            this.nudQuantity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(180, 31);
            this.nudQuantity.TabIndex = 5;
            this.ttpEditor.SetToolTip(this.nudQuantity, "How many you need");
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkIsPremium
            // 
            this.chkIsPremium.AutoSize = true;
            this.chkIsPremium.Location = new System.Drawing.Point(148, 373);
            this.chkIsPremium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIsPremium.Name = "chkIsPremium";
            this.chkIsPremium.Size = new System.Drawing.Size(109, 29);
            this.chkIsPremium.TabIndex = 7;
            this.chkIsPremium.Text = "Premium";
            this.ttpEditor.SetToolTip(this.chkIsPremium, "need premium");
            this.chkIsPremium.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(30, 295);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 25);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // dtpOrderOn
            // 
            this.dtpOrderOn.Location = new System.Drawing.Point(148, 221);
            this.dtpOrderOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpOrderOn.MinDate = new System.DateTime(2022, 7, 19, 0, 0, 0, 0);
            this.dtpOrderOn.Name = "dtpOrderOn";
            this.dtpOrderOn.Size = new System.Drawing.Size(232, 31);
            this.dtpOrderOn.TabIndex = 4;
            this.ttpEditor.SetToolTip(this.dtpOrderOn, "when you want");
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Location = new System.Drawing.Point(30, 231);
            this.lblBorn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(82, 25);
            this.lblBorn.TabIndex = 6;
            this.lblBorn.Text = "OrderOn";
            // 
            // cboPizzaType
            // 
            this.cboPizzaType.FormattingEnabled = true;
            this.cboPizzaType.Location = new System.Drawing.Point(148, 164);
            this.cboPizzaType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPizzaType.Name = "cboPizzaType";
            this.cboPizzaType.Size = new System.Drawing.Size(172, 33);
            this.cboPizzaType.TabIndex = 3;
            this.ttpEditor.SetToolTip(this.cboPizzaType, "Type of pizza you want");
            // 
            // lblPizzaType
            // 
            this.lblPizzaType.AutoSize = true;
            this.lblPizzaType.Location = new System.Drawing.Point(30, 169);
            this.lblPizzaType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPizzaType.Name = "lblPizzaType";
            this.lblPizzaType.Size = new System.Drawing.Size(93, 25);
            this.lblPizzaType.TabIndex = 4;
            this.lblPizzaType.Text = "Pizza Type";
            // 
            // txtOrderOf
            // 
            this.txtOrderOf.Location = new System.Drawing.Point(148, 100);
            this.txtOrderOf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderOf.Name = "txtOrderOf";
            this.txtOrderOf.Size = new System.Drawing.Size(142, 31);
            this.txtOrderOf.TabIndex = 2;
            this.ttpEditor.SetToolTip(this.txtOrderOf, "Your Name");
            // 
            // lblOrderOf
            // 
            this.lblOrderOf.AutoSize = true;
            this.lblOrderOf.Location = new System.Drawing.Point(30, 105);
            this.lblOrderOf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderOf.Name = "lblOrderOf";
            this.lblOrderOf.Size = new System.Drawing.Size(83, 25);
            this.lblOrderOf.TabIndex = 2;
            this.lblOrderOf.Text = "Order Of";
            // 
            // nudOrder
            // 
            this.nudOrder.Location = new System.Drawing.Point(148, 39);
            this.nudOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOrder.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudOrder.Name = "nudOrder";
            this.nudOrder.Size = new System.Drawing.Size(121, 31);
            this.nudOrder.TabIndex = 1;
            this.ttpEditor.SetToolTip(this.nudOrder, "Order Numer");
            this.nudOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(30, 41);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(58, 25);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Order";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(13, 490);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 71);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.ttpEditor.SetToolTip(this.btnReset, "reset all details of your pizza");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(547, 490);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 71);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.ttpEditor.SetToolTip(this.btnSave, "perfect just cllick and your pizza will be ready ");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Editor
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(668, 575);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(690, 631);
            this.MinimumSize = new System.Drawing.Size(690, 631);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIsPremium;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DateTimePicker dtpOrderOn;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.ComboBox cboPizzaType;
        private System.Windows.Forms.Label lblPizzaType;
        private System.Windows.Forms.TextBox txtOrderOf;
        private System.Windows.Forms.Label lblOrderOf;
        private System.Windows.Forms.NumericUpDown nudOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.CheckBox chkIsSpicy;
        private System.Windows.Forms.CheckBox chkIsPickup;
        private System.Windows.Forms.ToolTip ttpEditor;
    }
}