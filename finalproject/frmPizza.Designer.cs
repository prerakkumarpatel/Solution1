
namespace lab3 { 

    partial class frmPizza
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPizzaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpicy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPremium = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPickup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.BackgroundColor = System.Drawing.Color.Black;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrder,
            this.colOrderOf,
            this.colPizzaType,
            this.colOrderOn,
            this.colQuantity,
            this.colSpicy,
            this.colPremium,
            this.colPickup});
            this.dgvOrders.Location = new System.Drawing.Point(18, 65);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrders.MaximumSize = new System.Drawing.Size(957, 498);
            this.dgvOrders.MinimumSize = new System.Drawing.Size(957, 498);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrders.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgvOrders.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvOrders.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.dgvOrders.RowTemplate.Height = 25;
            this.dgvOrders.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.ShowEditingIcon = false;
            this.dgvOrders.Size = new System.Drawing.Size(957, 498);
            this.dgvOrders.TabIndex = 5;
            this.dgvOrders.VirtualMode = true;
            // 
            // colOrder
            // 
            this.colOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrder.DataPropertyName = "Order";
            this.colOrder.FillWeight = 60F;
            this.colOrder.HeaderText = "Order";
            this.colOrder.MinimumWidth = 6;
            this.colOrder.Name = "colOrder";
            this.colOrder.ReadOnly = true;
            this.colOrder.ToolTipText = "Order Number";
            this.colOrder.Width = 70;
            // 
            // colOrderOf
            // 
            this.colOrderOf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrderOf.DataPropertyName = "OrderOf";
            this.colOrderOf.FillWeight = 60F;
            this.colOrderOf.HeaderText = "Order Of";
            this.colOrderOf.MinimumWidth = 6;
            this.colOrderOf.Name = "colOrderOf";
            this.colOrderOf.ReadOnly = true;
            this.colOrderOf.ToolTipText = "Customer Name";
            this.colOrderOf.Width = 80;
            // 
            // colPizzaType
            // 
            this.colPizzaType.DataPropertyName = "PizzaType";
            this.colPizzaType.FillWeight = 80F;
            this.colPizzaType.HeaderText = "Pizza Type";
            this.colPizzaType.MinimumWidth = 6;
            this.colPizzaType.Name = "colPizzaType";
            this.colPizzaType.ReadOnly = true;
            this.colPizzaType.ToolTipText = "Type of Pizza";
            this.colPizzaType.Width = 98;
            // 
            // colOrderOn
            // 
            this.colOrderOn.DataPropertyName = "OrderOn";
            this.colOrderOn.FillWeight = 600F;
            this.colOrderOn.HeaderText = "Order On";
            this.colOrderOn.MinimumWidth = 6;
            this.colOrderOn.Name = "colOrderOn";
            this.colOrderOn.ReadOnly = true;
            this.colOrderOn.ToolTipText = "Order Date & Time";
            this.colOrderOn.Width = 600;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.FillWeight = 1F;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.ToolTipText = "Number Of Pizza";
            this.colQuantity.Width = 6;
            // 
            // colSpicy
            // 
            this.colSpicy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSpicy.DataPropertyName = "IsSpicy";
            this.colSpicy.FillWeight = 70F;
            this.colSpicy.HeaderText = "Spicy";
            this.colSpicy.MinimumWidth = 8;
            this.colSpicy.Name = "colSpicy";
            this.colSpicy.ReadOnly = true;
            this.colSpicy.Width = 70;
            // 
            // colPremium
            // 
            this.colPremium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPremium.DataPropertyName = "IsPremium";
            this.colPremium.FillWeight = 70F;
            this.colPremium.HeaderText = "Premium";
            this.colPremium.MinimumWidth = 8;
            this.colPremium.Name = "colPremium";
            this.colPremium.ReadOnly = true;
            this.colPremium.Width = 70;
            // 
            // colPickup
            // 
            this.colPickup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPickup.DataPropertyName = "IsPickup";
            this.colPickup.FillWeight = 70F;
            this.colPickup.HeaderText = "Pickup";
            this.colPickup.MinimumWidth = 8;
            this.colPickup.Name = "colPickup";
            this.colPickup.ReadOnly = true;
            this.colPickup.Width = 70;
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitleBar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleBar.ForeColor = System.Drawing.Color.Black;
            this.lblTitleBar.Location = new System.Drawing.Point(1, 1);
            this.lblTitleBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleBar.MaximumSize = new System.Drawing.Size(1436, 59);
            this.lblTitleBar.MinimumSize = new System.Drawing.Size(1436, 59);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(1436, 59);
            this.lblTitleBar.TabIndex = 3;
            this.lblTitleBar.Text = "Pizza Shop";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(775, 591);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(200, 48);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "&Add New";
            this.ttp.SetToolTip(this.btnAddNew, "to add pizzza");
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(29, 591);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 48);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remo&ve";
            this.ttp.SetToolTip(this.btnRemove, " to remove pizza");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(402, 591);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 48);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.ttp.SetToolTip(this.btnReset, "To remove pizza");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(402, 649);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 48);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "A&bout";
            this.ttp.SetToolTip(this.btnAbout, "to get program info");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalproject.Properties.Resources.pizzaback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnRemove;
            this.ClientSize = new System.Drawing.Size(1540, 705);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblTitleBar);
            this.Controls.Add(this.dgvOrders);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1562, 761);
            this.MinimumSize = new System.Drawing.Size(1562, 761);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Shop";
            this.Activated += new System.EventHandler(this.RefreshForm);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPizzaType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSpicy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPremium;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPickup;
    }
}

