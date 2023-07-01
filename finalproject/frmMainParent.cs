using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class frmMainParent : Form
    {
        private int childFormNumber = 1;
   

        public frmMainParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new frmTextEditor();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
            private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void lab1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Form childForm = new Lab1.frmLab1();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + childFormNumber++;
            childForm.Show();
        }

        private void lab2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Lab2.frmLab2();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + childFormNumber++;
            childForm.Show();
        }

        private void lab3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new lab3.frmPizza();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + childFormNumber++;
            childForm.Show();
        }

        private void iCE2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new ICE2.frmICE2();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + childFormNumber++;
            childForm.Show();
        }

        private void iCE1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new ICE01.frmICE1();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + childFormNumber++;
            childForm.Show();
        }

        private void iCE3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form childForm = new ICE3.frmICE3Calculate();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + childFormNumber++;
            childForm.Show();
        }

        private void iCE4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new ICE4.frmICE4();
            childForm.MdiParent = this;
            childForm.Text = childForm.Text + childFormNumber++;
            childForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainAbout About = new frmMainAbout();
            About.ShowDialog();
        }
    }
}

