/*Prerakkumar Patel
 * Lab 2
 * GPA calculator
 * https://github.com/prerakkumarpatel/Solution1
 * 
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab2
{
    
    public partial class frmMain : Form
    {  
        #region load  and initialization 
        //global variable
        double[] GPAScore = { 0, 0, 0, 0, 0, 0 ,0};
        double[] GPA = { 0, 0, 0, 0, 0, 0,0 };
        public frmMain()
        {
            //initialize the form
            InitializeComponent();
            lblAverageGrade.Text = "";
            lblAverageGradePoint.Text = "";
            // i tried a lot to connect below list with combobox but i cant 
            List<string> subjects = new List<string> { "Choose Default", "NETD", "OOP", "WEBD", "SYSD", "LINUX" };
            


        }
        /// <summary>
        /// array of textboxes and labels
        /// </summary>
        TextBox[] GradeTextboxes;
        Label[] GPALabels;

        /// <summary>
        /// things during form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            foreach (Label l in GPALabels)
            {
                l.Text = "";
            }
        }
            #endregion

        
        #region UI events
        /// <summary>
        /// calculate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total = 0;
            double totalGPA = 0;
            double averageGradeScore;
            double averageGPA ;
            foreach ( double G in GPAScore )
            {
                total = total + G;
            }
            averageGradeScore = Math.Round(total / 6, 2,MidpointRounding.ToEven) ; //rounding to appropriate format
            lblAverageGrade.Text = averageGradeScore.ToString();
            foreach (double G in GPA)
            {
                totalGPA = totalGPA + G;
            }
            averageGPA = Math.Round(totalGPA / 6, 2, MidpointRounding.ToEven);

            lblAverageGradePoint.Text = averageGPA.ToString();
        }
        /// <summary>
        /// reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();      ///set to default state
        }
        /// <summary>
        /// exit buuton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();   //exit
        }
        #endregion
        #region custom function
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
        /// <summary>
        /// validator function that validate range
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static Boolean isInRange( string input)
        {
            double min = 0;
            double max = 100;
            double number;
            if (double.TryParse(input, out number))
            {
                return min <= number && number <= max;
                
            }
            return false;
        }
        
        #endregion

        #region Leave Functions
        /// <summary>
        /// leave function for text boxes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxInputGrade6_Leave(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (isInRange(tbxInputGrade6.Text))
            {
                lblError.Text = "";
                lblGPA6.Text= GetGrade(tbxInputGrade6.Text);
                double.TryParse(tbxInputGrade6.Text, out GPAScore[6]);
                double.TryParse(lblGPA6.Text, out GPA[6]);

            }
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade6.SelectAll();
                tbxInputGrade6.Text = "0";
            }


        }

        private void tbxInputGrade5_Leave(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (isInRange(tbxInputGrade5.Text))
            {
                lblError.Text = "";
                lblGPA5.Text = GetGrade(tbxInputGrade5.Text);
                double.TryParse(tbxInputGrade5.Text, out GPAScore[5]);
                double.TryParse(lblGPA5.Text, out GPA[5]);
            }
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade5.SelectAll();
                tbxInputGrade5.Text = "0";
            }

        }

        private void tbxInputGrade4_Leave(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (isInRange(tbxInputGrade4.Text))
            {
                lblError.Text = "";
                lblGPA4.Text = GetGrade(tbxInputGrade4.Text);
                double.TryParse(tbxInputGrade4.Text, out GPAScore[4]);
                double.TryParse(lblGPA4.Text, out GPA[4]);
            }
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade4.SelectAll();
                tbxInputGrade4.Text = "0";

            }

        }

        private void tbxInputGrade3_Leave(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (isInRange(tbxInputGrade3.Text))
            {
                lblError.Text = "";
                lblGPA3.Text = GetGrade(tbxInputGrade3.Text);
                double.TryParse(tbxInputGrade3.Text, out GPAScore[3]);
                double.TryParse(lblGPA3.Text, out GPA[3]);

            }
            else
            { 
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade3.SelectAll();
                tbxInputGrade3.Text = "0";

            }
           
        }

        private void tbxInputGrade2_Leave(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (isInRange(tbxInputGrade2.Text))
            {
                lblError.Text = "";
                lblGPA2.Text = GetGrade(tbxInputGrade2.Text);
                double.TryParse(tbxInputGrade2.Text, out GPAScore[2]);
                double.TryParse(lblGPA2.Text, out GPA[2]);
            }
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade2.SelectAll();
                tbxInputGrade2.Text = "0";
            }

        }




        private void tbxInputGrade1_Leave(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (isInRange(tbxInputGrade1.Text))
            {
                lblError.Text = "";
                lblGPA1.Text = GetGrade(tbxInputGrade1.Text);
                double.TryParse(tbxInputGrade1.Text, out GPAScore[1]);
                double.TryParse(lblGPA1.Text, out GPA[1]);
            }
            else
            {
                lblError.Text = " Please Enter valid grade between 1 to 100 ";
                tbxInputGrade1.SelectAll();
                tbxInputGrade1.Text = "0";
            }



        }
        #endregion
        #region GetGrade function
        /// <summary>
        /// get grade function to get GPA for each grade score
        /// </summary>
        /// <param name="inputGrade"></param>
        /// <returns></returns>
        private string GetGrade(string inputGrade)

        {
            double grade;
            double.TryParse(inputGrade, out grade);
            
            // Declare an array for the given scores for the grades.
            int[] gradeArray = { 0, 50, 55, 60, 65, 70, 75, 80, 85, 90 };
            // Declare an array for the given grades that connected to the numeric grades above.
            double[] GPAArray = { 0,1.0,1.5,2.0,2.5,3.0,3.5,4.0,4.5,5.0};
            // This string will return the values.
            double GPA = 0;

            // Count through each index of the grade array.
            for (int index = 0; index < gradeArray.Length; index++)
            {

                // If the current grade is above the numeric grade, assign it the corresponding letter grade.
                if (grade >= gradeArray[index])
                {
                    GPA = GPAArray[index];
                }

                // This will end loop early.
                

            }
            string str = GPA.ToString();
            return str;
        }
        #endregion
    }
}
