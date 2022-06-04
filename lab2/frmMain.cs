/*Prerakkumar Patel
 * Lab 2
 * GPA calculator
 * https://github.com/prerakkumarpatel/Solution1
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class frmMain : Form
    {
    public frmMain()
        {
            InitializeComponent();
            lblAverageGrade.Text = "";
            lblAverageGradePoint.Text = "";

        }
        TextBox[] GradeTextboxes;
        Label[] GPALabels;
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            GradeTextboxes = new TextBox[]
           {
                tbxInputGrade1, tbxInputGrade2, tbxInputGrade3, tbxInputGrade4, tbxInputGrade5, tbxInputGrade6
           };
            GPALabels = new Label[]
            {
                lblGPA1,lblGPA2,lblGPA3,lblGPA4,lblGPA5,lblGPA6
            };
        }
        #region UI events
        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        /// <summary>
        /// setdeafualt function to change everything back to default
        /// </summary>
        private void SetDefaults()
        {
            foreach (TextBox t in GradeTextboxes)
            {
                t.Clear();
            }
            foreach(Label l in GPALabels)
            {
                l.Text = "";
            }
            lblAverageGrade.Text = "";
            lblAverageGradePoint.Text = "";
        }
        

        public static Boolean isInRange( string input)
        {
            float min = 0;
            float max = 100;
            float number;
            if (float.TryParse(input, out number))
            {
                return min <= number && number <= max;
                
            }
            return false;
        }


        #region Leave Functions
        private void tbxInputGrade6_Leave(object sender, EventArgs e)
        {
            if (isInRange(tbxInputGrade6.Text))
                lblError.Text = "ERROR: YOU ARE AWESOME";
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade6.SelectAll();
                tbxInputGrade6.Text = "0";
            }


        }

        private void tbxInputGrade5_Leave(object sender, EventArgs e)
        {
            if (isInRange(tbxInputGrade5.Text))
                lblError.Text = "ERROR: YOU ARE AWESOME";
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade5.SelectAll();
                tbxInputGrade5.Text = "0";
            }

        }

        private void tbxInputGrade4_Leave(object sender, EventArgs e)
        {
            if (isInRange(tbxInputGrade4.Text))
                lblError.Text = "ERROR: YOU ARE AWESOME";
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade4.SelectAll();
                tbxInputGrade4.Text = "0";

            }

        }

        private void tbxInputGrade3_Leave(object sender, EventArgs e)
        {
            if (isInRange(tbxInputGrade3.Text))
                lblError.Text = "ERROR: YOU ARE AWESOME";
            else
            { 
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade3.SelectAll();
                tbxInputGrade3.Text = "0";

            }
           
        }

        private void tbxInputGrade2_Leave(object sender, EventArgs e)
        {
            if (isInRange(tbxInputGrade2.Text))
                lblError.Text = "ERROR: YOU ARE AWESOME";
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade2.SelectAll();
                tbxInputGrade2.Text = "0";
            }

        }




        private void tbxInputGrade1_Leave(object sender, EventArgs e)
        {
            if (isInRange(tbxInputGrade1.Text))
                lblError.Text = "ERROR: YOU ARE AWESOME";
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade1.SelectAll();
                tbxInputGrade1.Text = "0";
            }



        }
        #endregion
     }
}
