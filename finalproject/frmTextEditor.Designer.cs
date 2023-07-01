
namespace finalproject
{
    partial class frmTextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.none = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.messagetoolStripStatusLabel = new System.Windows.Forms.Label();
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.tbxMain = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.none,
            this.editMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.none;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1051, 37);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            // 
            // none
            // 
            this.none.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.none.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.none.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(54, 29);
            this.none.Text = "&File";
            this.none.ToolTipText = "File Function";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::finalproject.Properties.Resources.text_editor1;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.ToolTipText = "To Create New  File";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::finalproject.Properties.Resources.folder;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.ToolTipText = "To Open  File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveToolStripMenuItem.Image = global::finalproject.Properties.Resources.diskette1;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "To Save File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::finalproject.Properties.Resources.floppy_disk;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.ToolTipText = "To Save As File";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(220, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.exitToolStripMenuItem.Text = "&Close";
            this.exitToolStripMenuItem.ToolTipText = "To Exit App";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator7});
            this.editMenu.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(58, 29);
            this.editMenu.Text = "&Edit";
            this.editMenu.ToolTipText = "Text Operation";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(215, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::finalproject.Properties.Resources.cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.ToolTipText = "To Cut Text";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::finalproject.Properties.Resources.copy1;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.ToolTipText = "To Copy Text";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::finalproject.Properties.Resources.paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.ToolTipText = "To Paste Text";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(215, 6);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.helpMenu.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(65, 29);
            this.helpMenu.Text = "&Help";
            this.helpMenu.ToolTipText = "Need Help";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(161, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "About Developer & App";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem1.Text = "&About";
            // 
            // messagetoolStripStatusLabel
            // 
            this.messagetoolStripStatusLabel.AutoSize = true;
            this.messagetoolStripStatusLabel.Location = new System.Drawing.Point(245, 9);
            this.messagetoolStripStatusLabel.Name = "messagetoolStripStatusLabel";
            this.messagetoolStripStatusLabel.Size = new System.Drawing.Size(0, 25);
            this.messagetoolStripStatusLabel.TabIndex = 3;
            this.toolTip.SetToolTip(this.messagetoolStripStatusLabel, "Current File Details");
            // 
            // lblFileStatus
            // 
            this.lblFileStatus.AutoSize = true;
            this.lblFileStatus.Location = new System.Drawing.Point(204, 12);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(0, 25);
            this.lblFileStatus.TabIndex = 4;
            this.toolTip.SetToolTip(this.lblFileStatus, "Current File Details");
            // 
            // tbxMain
            // 
            this.tbxMain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMain.Location = new System.Drawing.Point(0, 37);
            this.tbxMain.Multiline = true;
            this.tbxMain.Name = "tbxMain";
            this.tbxMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxMain.Size = new System.Drawing.Size(1051, 460);
            this.tbxMain.TabIndex = 2;
            this.tbxMain.TextChanged += new System.EventHandler(this.tbxMain_TextChanged);
            // 
            // frmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1051, 497);
            this.Controls.Add(this.lblFileStatus);
            this.Controls.Add(this.messagetoolStripStatusLabel);
            this.Controls.Add(this.tbxMain);
            this.Controls.Add(this.menuStrip);
            this.Name = "frmTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreZeeX Editor";
            this.toolTip.SetToolTip(this, "text editor form");
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem none;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.TextBox tbxMain;
        private System.Windows.Forms.Label messagetoolStripStatusLabel;
        private System.Windows.Forms.Label lblFileStatus;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}