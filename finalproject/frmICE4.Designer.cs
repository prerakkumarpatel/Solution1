
namespace ICE4
{
    partial class frmICE4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmICE4));
            this.dgvClones = new System.Windows.Forms.DataGridView();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefective = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colHairColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEyeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkDefective = new System.Windows.Forms.CheckBox();
            this.btnSetEyeColour = new System.Windows.Forms.Button();
            this.lblEyeColour = new System.Windows.Forms.Label();
            this.lblSecondColourLabel = new System.Windows.Forms.Label();
            this.btnSetHairColour = new System.Windows.Forms.Button();
            this.lblHairColour = new System.Windows.Forms.Label();
            this.lblColour1Label = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.lblBorn = new System.Windows.Forms.Label();
            this.cboPlanets = new System.Windows.Forms.ComboBox();
            this.lblHomeWorld = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.nudDesignation = new System.Windows.Forms.NumericUpDown();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTitleBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesignation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClones
            // 
            this.dgvClones.AllowUserToAddRows = false;
            this.dgvClones.AllowUserToDeleteRows = false;
            this.dgvClones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClones.BackgroundColor = System.Drawing.Color.Black;
            this.dgvClones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesignation,
            this.colNickName,
            this.dataGridViewTextBoxColumn1,
            this.colBorn,
            this.dataGridViewTextBoxColumn2,
            this.colDefective,
            this.colHairColor,
            this.colEyeColor});
            this.dgvClones.Location = new System.Drawing.Point(18, 65);
            this.dgvClones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClones.MultiSelect = false;
            this.dgvClones.Name = "dgvClones";
            this.dgvClones.ReadOnly = true;
            this.dgvClones.RowHeadersVisible = false;
            this.dgvClones.RowHeadersWidth = 51;
            this.dgvClones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgvClones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.dgvClones.RowTemplate.Height = 25;
            this.dgvClones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClones.ShowEditingIcon = false;
            this.dgvClones.Size = new System.Drawing.Size(1277, 370);
            this.dgvClones.TabIndex = 1;
            this.dgvClones.VirtualMode = true;
            this.dgvClones.SelectionChanged += new System.EventHandler(this.Selected_Trooper);
            // 
            // colDesignation
            // 
            this.colDesignation.DataPropertyName = "Designation";
            this.colDesignation.HeaderText = "Designation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            this.colDesignation.Width = 125;
            // 
            // colNickName
            // 
            this.colNickName.DataPropertyName = "NickName";
            this.colNickName.HeaderText = "Nick Name";
            this.colNickName.MinimumWidth = 6;
            this.colNickName.Name = "colNickName";
            this.colNickName.ReadOnly = true;
            this.colNickName.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HomeWorld";
            this.dataGridViewTextBoxColumn1.HeaderText = "Home World";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // colBorn
            // 
            this.colBorn.DataPropertyName = "Born";
            this.colBorn.HeaderText = "Born";
            this.colBorn.MinimumWidth = 6;
            this.colBorn.Name = "colBorn";
            this.colBorn.ReadOnly = true;
            this.colBorn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn2.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // colDefective
            // 
            this.colDefective.DataPropertyName = "isDefective";
            this.colDefective.HeaderText = "Defective";
            this.colDefective.MinimumWidth = 6;
            this.colDefective.Name = "colDefective";
            this.colDefective.ReadOnly = true;
            this.colDefective.Width = 125;
            // 
            // colHairColor
            // 
            this.colHairColor.DataPropertyName = "HairColor";
            this.colHairColor.HeaderText = "Hair Colour";
            this.colHairColor.MinimumWidth = 6;
            this.colHairColor.Name = "colHairColor";
            this.colHairColor.ReadOnly = true;
            this.colHairColor.Width = 125;
            // 
            // colEyeColor
            // 
            this.colEyeColor.DataPropertyName = "EyeColor";
            this.colEyeColor.HeaderText = "Eye Colour";
            this.colEyeColor.MinimumWidth = 6;
            this.colEyeColor.Name = "colEyeColor";
            this.colEyeColor.ReadOnly = true;
            this.colEyeColor.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chkDefective);
            this.groupBox1.Controls.Add(this.btnSetEyeColour);
            this.groupBox1.Controls.Add(this.lblEyeColour);
            this.groupBox1.Controls.Add(this.lblSecondColourLabel);
            this.groupBox1.Controls.Add(this.btnSetHairColour);
            this.groupBox1.Controls.Add(this.lblHairColour);
            this.groupBox1.Controls.Add(this.lblColour1Label);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.dtpBorn);
            this.groupBox1.Controls.Add(this.lblBorn);
            this.groupBox1.Controls.Add(this.cboPlanets);
            this.groupBox1.Controls.Add(this.lblHomeWorld);
            this.groupBox1.Controls.Add(this.txtNickName);
            this.groupBox1.Controls.Add(this.lblNickName);
            this.groupBox1.Controls.Add(this.nudDesignation);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 475);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(639, 424);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit";
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(408, 340);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 71);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(522, 340);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 71);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkDefective
            // 
            this.chkDefective.AutoSize = true;
            this.chkDefective.Location = new System.Drawing.Point(148, 361);
            this.chkDefective.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDefective.Name = "chkDefective";
            this.chkDefective.Size = new System.Drawing.Size(111, 29);
            this.chkDefective.TabIndex = 17;
            this.chkDefective.Text = "Defective";
            this.chkDefective.UseVisualStyleBackColor = true;
            // 
            // btnSetEyeColour
            // 
            this.btnSetEyeColour.ForeColor = System.Drawing.Color.Black;
            this.btnSetEyeColour.Location = new System.Drawing.Point(550, 105);
            this.btnSetEyeColour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetEyeColour.Name = "btnSetEyeColour";
            this.btnSetEyeColour.Size = new System.Drawing.Size(64, 64);
            this.btnSetEyeColour.TabIndex = 16;
            this.btnSetEyeColour.Text = "Set";
            this.btnSetEyeColour.UseVisualStyleBackColor = true;
            this.btnSetEyeColour.Click += new System.EventHandler(this.btnSetEyeColour_Click);
            // 
            // lblEyeColour
            // 
            this.lblEyeColour.BackColor = System.Drawing.Color.Gray;
            this.lblEyeColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEyeColour.Location = new System.Drawing.Point(479, 105);
            this.lblEyeColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEyeColour.Name = "lblEyeColour";
            this.lblEyeColour.Size = new System.Drawing.Size(61, 64);
            this.lblEyeColour.TabIndex = 15;
            // 
            // lblSecondColourLabel
            // 
            this.lblSecondColourLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondColourLabel.Location = new System.Drawing.Point(359, 105);
            this.lblSecondColourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondColourLabel.Name = "lblSecondColourLabel";
            this.lblSecondColourLabel.Size = new System.Drawing.Size(111, 64);
            this.lblSecondColourLabel.TabIndex = 14;
            this.lblSecondColourLabel.Text = "Eye Colour";
            this.lblSecondColourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetHairColour
            // 
            this.btnSetHairColour.ForeColor = System.Drawing.Color.Black;
            this.btnSetHairColour.Location = new System.Drawing.Point(550, 31);
            this.btnSetHairColour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetHairColour.Name = "btnSetHairColour";
            this.btnSetHairColour.Size = new System.Drawing.Size(64, 64);
            this.btnSetHairColour.TabIndex = 13;
            this.btnSetHairColour.Text = "Set";
            this.btnSetHairColour.UseVisualStyleBackColor = true;
            this.btnSetHairColour.Click += new System.EventHandler(this.btnSetHairColour_Click);
            // 
            // lblHairColour
            // 
            this.lblHairColour.BackColor = System.Drawing.Color.Gray;
            this.lblHairColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHairColour.Location = new System.Drawing.Point(479, 31);
            this.lblHairColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHairColour.Name = "lblHairColour";
            this.lblHairColour.Size = new System.Drawing.Size(61, 64);
            this.lblHairColour.TabIndex = 12;
            // 
            // lblColour1Label
            // 
            this.lblColour1Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColour1Label.Location = new System.Drawing.Point(359, 31);
            this.lblColour1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColour1Label.Name = "lblColour1Label";
            this.lblColour1Label.Size = new System.Drawing.Size(109, 64);
            this.lblColour1Label.TabIndex = 11;
            this.lblColour1Label.Text = "Hair Colour";
            this.lblColour1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(148, 290);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(142, 31);
            this.txtUnit.TabIndex = 9;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(30, 295);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(44, 25);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(148, 221);
            this.dtpBorn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(232, 31);
            this.dtpBorn.TabIndex = 7;
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Location = new System.Drawing.Point(30, 231);
            this.lblBorn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(49, 25);
            this.lblBorn.TabIndex = 6;
            this.lblBorn.Text = "Born";
            // 
            // cboPlanets
            // 
            this.cboPlanets.FormattingEnabled = true;
            this.cboPlanets.Location = new System.Drawing.Point(148, 164);
            this.cboPlanets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPlanets.Name = "cboPlanets";
            this.cboPlanets.Size = new System.Drawing.Size(172, 33);
            this.cboPlanets.TabIndex = 5;
            // 
            // lblHomeWorld
            // 
            this.lblHomeWorld.AutoSize = true;
            this.lblHomeWorld.Location = new System.Drawing.Point(30, 169);
            this.lblHomeWorld.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomeWorld.Name = "lblHomeWorld";
            this.lblHomeWorld.Size = new System.Drawing.Size(114, 25);
            this.lblHomeWorld.TabIndex = 4;
            this.lblHomeWorld.Text = "Home World";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(148, 100);
            this.txtNickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(142, 31);
            this.txtNickName.TabIndex = 3;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(30, 105);
            this.lblNickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(98, 25);
            this.lblNickName.TabIndex = 2;
            this.lblNickName.Text = "Nick Name";
            // 
            // nudDesignation
            // 
            this.nudDesignation.Enabled = false;
            this.nudDesignation.Location = new System.Drawing.Point(148, 39);
            this.nudDesignation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDesignation.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDesignation.Name = "nudDesignation";
            this.nudDesignation.Size = new System.Drawing.Size(121, 31);
            this.nudDesignation.TabIndex = 1;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(30, 41);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(107, 25);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Designation";
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
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(1308, 59);
            this.lblTitleBar.TabIndex = 3;
            this.lblTitleBar.Text = "Clone Inventory";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmICE4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 930);
            this.Controls.Add(this.lblTitleBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClones);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1334, 986);
            this.MinimumSize = new System.Drawing.Size(1334, 986);
            this.Name = "frmICE4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Droid Factory";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesignation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPlanets;
        private System.Windows.Forms.Label lblHomeWorld;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.NumericUpDown nudDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.Button btnSetEyeColour;
        private System.Windows.Forms.Label lblEyeColour;
        private System.Windows.Forms.Label lblSecondColourLabel;
        private System.Windows.Forms.Button btnSetHairColour;
        private System.Windows.Forms.Label lblHairColour;
        private System.Windows.Forms.Label lblColour1Label;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkDefective;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDefective;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHairColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEyeColor;
    }
}

