/*Prerakkumar Patel
 * 100846056
 * August 2 ,2022
 * lab4 text editor
 * github: https://github.com/prerakkumarpatel/Solution1/tree/master/lab4
 */
using System;
using System.Windows.Forms;
using System.IO;

namespace lab4
{
    /// <summary>
    /// main class
    /// </summary>
    public partial class frmMain : Form
    {
        #region global variables
        /// <summary>
        /// global variables
        /// </summary>
        private bool isFileAlreadySave;
        private bool isFileDirty;
        private string currentOpenFileName;
        private string currentOpenFilePath;
        private string clipboard;
        #endregion

        #region form initialization & form load
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// form load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void frmMain_Load(object sender, EventArgs e)
        {
            isFileDirty = false;
            isFileAlreadySave = false;
            messagetoolStripStatusLabel.Text = " Normal Text File ";
            currentOpenFileName = "";
            currentOpenFilePath = "";
        }
        #endregion

        #region  file menu 
        /// <summary>
        /// when new  file option  is created 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFileMethod();
        }
        
        private void newFileMethod()
        {
            if (isFileDirty)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes ? ", "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        save(currentOpenFilePath);
                        break;
                    case DialogResult.No:
                        clearScreen();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                clearScreen();
                isFileAlreadySave = false;
                currentOpenFileName = "";
                currentOpenFilePath = "";
            }
            messagetoolStripStatusLabel.Text = "New File is Created ";
        }
        /// <summary>
        /// save as is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentOpenFileName = saveFileDialog.FileName;
                currentOpenFilePath = Path.GetFullPath(currentOpenFileName);
                save(currentOpenFilePath);
            }
        }

        #region open
        /// <summary>
        /// open file is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileMethod();
        }
        private void OpenFileMethod()
        {   if (!isFileDirty)
            {
                OpenFileDialog openfiledialog = new OpenFileDialog();
                openfiledialog.Filter = "Text Files (*.txt)|*.txt";
                DialogResult result = openfiledialog.ShowDialog();
                if (result == DialogResult.OK)
                {

                    currentOpenFileName = openfiledialog.FileName;
                    currentOpenFilePath = Path.GetFullPath(currentOpenFileName);
                    if (Path.GetExtension(openfiledialog.FileName) == ".txt")
                    {
                        FileStream fs = new FileStream(currentOpenFileName, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        //Read the contents of the file into a stream
                        tbxMain.Text = sr.ReadToEnd();
                        sr.Close();
                        fs.Close();
                    }
                    this.Text = Path.GetFileName(openfiledialog.FileName) + " - Notepad by Prerak"; //file ka caption ma name dna jo b open kry
                    isFileAlreadySave = true;
                    isFileDirty = false;
                    lblFileStatus.Text = "";
                    messagetoolStripStatusLabel.Text = currentOpenFileName + " File is Opened !";
                }
            }else
            {
                if (isFileDirty)
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes ? ", "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            save(currentOpenFilePath);
                            break;
                        case DialogResult.No:
                            clearScreen();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                    }
                isFileAlreadySave = true;
                isFileDirty = false;
            }
        }
        /// <summary>
        /// exit is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region save file
        /// <summary>
        /// save is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileMethod();
        }

        private void SaveFileMethod()
        {
            if (isFileAlreadySave)
            {
                // Delete the file if it exists.
                if (File.Exists(currentOpenFilePath))
                {
                    messagetoolStripStatusLabel.Text = currentOpenFilePath;
                    File.Delete(currentOpenFilePath);
                    //Create the file.
                    save(currentOpenFilePath);
                }

            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentOpenFileName = saveFileDialog.FileName;
                    currentOpenFilePath = Path.GetFullPath(currentOpenFileName);
                    save(currentOpenFilePath);
                }
            }
        }
        /// <summary>
        ///  save function 
        /// </summary>
        /// <param name="path"></param>
        public void save(string path)
        {
            {
                FileStream fs = new FileStream(currentOpenFileName, FileMode.Create, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(tbxMain.Text, '\0');
                    sw.Close();
                    fs.Close();
                }
            }
            isFileDirty = false;
            lblFileStatus.Text = "";
            isFileAlreadySave = true;
            messagetoolStripStatusLabel.Text = currentOpenFileName + " File is Opened !";
        }
        #endregion

        #endregion

        #region Edit Menu
        /// <summary>
        /// when something is changed in textfile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void tbxMain_TextChanged(object sender, EventArgs e)
        {
            isFileDirty = true;
            lblFileStatus.Text = "*";
        }
        /// <summary>
        /// cut function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipboard = tbxMain.SelectedText;
            tbxMain.SelectedText = "";
            isFileDirty = true;
        }
        /// <summary>
        /// copy function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipboard = tbxMain.SelectedText;
            isFileDirty = true;
        }
        /// <summary>
        /// paste function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxMain.SelectedText = clipboard;
            isFileDirty = true;
        }
        #endregion
        #region
        /// <summary>
        /// help  about page 
        /// </summary>
        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                About frmAbout = new About();
                frmAbout.ShowDialog();
            
        }
        #endregion

        #region Custom Function
        /// <summary>
        /// to clear  the screen in textbox
        /// </summary>
        private void clearScreen()
        {
            tbxMain.Clear(); //
            isFileDirty = false;
        }
        #endregion
    }
}
