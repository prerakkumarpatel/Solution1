/*
 * Name:        Zeel Sutariya
 * Student ID:  100846187   
 * Date:        June 18, 2022
 * Title:       Lab 2 - GradePointA Calculator
 * GitHub:      https://github.com/Zeel-Sutariya/NETD2202_Assessments/blob/master/Lab%202/frmMain.cs
 */
#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Lab2
{
    public partial class frmLab2 : Form
    {
        #region Main
        /// <summary>
        /// This is the main function
        /// </summary>
        public frmLab2()
        {
            InitializeComponent();
        }
        #endregion

        #region Global Variable

        //array of dropdown box
        ComboBox[] Courses;
        double[] myarray = new double[] { 2.3, 2.4, 2.5, 2.6};

        // array of textbox
        TextBox[] NumericGrades;

        // array of labels
        Label[] GradePoint;
        #endregion

        #region form load
        /// <summary>
        /// initializing the arrays as the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //initialize the Dropdown boxes
            Courses = new ComboBox[]
            {
                drpCourse1, drpCourse2, drpCourse3, drpCourse4, drpCourse5, drpCourse6
            };

            // initialize the textboxes
            NumericGrades = new TextBox[]
            {
                txtNumericGrades1, txtNumericGrades2, txtNumericGrades3, txtNumericGrades4, txtNumericGrades5, txtNumericGrades6
            };

            //initialize the Labels
            GradePoint = new Label[]
            {
                lblGradePoint1, lblGradePoint2, lblGradePoint3, lblGradePoint4, lblGradePoint5, lblGradePoint6
            };

            // Adding dropdown options
            for(int i=0; i<Courses.Length; i++)
            {
                Courses[i].Items.Add("- Choose Course -");
                Courses[i].Items.Add("NETD");
                Courses[i].Items.Add("WEBD");
                Courses[i].Items.Add("OOP");
                Courses[i].Items.Add("LINU");
                Courses[i].Items.Add("GNED");
                Courses[i].Items.Add("SYDE");
                this.Courses[i].Text = "- Choose Course -";
            }
        }
        #endregion
        
        #region Custom Methods

        #region SetDefault
        /// <summary>
        /// Setting all the values to deafult
        /// </summary>
        private void SetDefault()
        {
            // reseting the dropdown box
            foreach (ComboBox cb in Courses)
            {
                cb.Text = "- Choose Couse -";
            }
            // reserting the textboxes
            foreach (TextBox tb in NumericGrades)
            {
                tb.Text = string.Empty;
            }
            // reseting the lables
            foreach (Label lb in GradePoint)
            {
                lb.Text = string.Empty;
            }

            // reseting the answer labels
            lblAnswer1.Text = string.Empty;
            lblAnswer2.Text = string.Empty;
        }
        #endregion

        #region ValidateGradePoints
        /// <summary>
        /// Checking whether the inputs are valid or not 
        /// </summary>
        /// <returns></returns>
        private bool ValidateGradePoints()
        {
            int val = -999;
            // default return value = false
            bool retVal = false;
            foreach(TextBox tb in NumericGrades)
            {
                // check if the string is empty or not
                if(tb.Text != string.Empty)
                {
                    //check if the input is integer or not
                    if(int.TryParse(tb.Text, out val))
                    {
                        //checking if the input is between 0 and 100 or not
                        if(val >= 0 && val <= 100)
                        {
                            // change the return value to true
                            retVal = true;
                        }
                        else
                        {
                            // if it's not in range
                            // select all the text
                            tb.SelectAll();
                            // focus the text
                            tb.Focus();
                            // display an error in messagebox
                            MessageBox.Show("Input must be between 0-100!");
                        }
                    }
                    else
                    {
                        // if it's not an number
                        // select all the text
                        tb.SelectAll();
                        // focus the text
                        tb.Focus();
                        // make return value false
                        retVal = false;
                    }
                }
                else 
                {
                    // if the textboxes are empty, inputting it to value 0
                    tb.Text = Convert.ToString(0);
                }
            }
            return retVal;
        }
        #endregion

        #region CalculateGradePoints
        /// <summary>
        /// Calculating the grade points
        /// </summary>
        private void CalculateGradePoints()
        {
            double val = -999;
            for(int i=0; i<NumericGrades.Length; i++)
            {
                // checking if the input is an double or not
                if (double.TryParse(NumericGrades[i].Text, out val))
                {
                    // update the grade point value according to the numeric grade values
                    if (Convert.ToDouble(NumericGrades[i].Text) >= 90 && Convert.ToDouble(NumericGrades[i].Text) <= 100)
                    {
                        GradePoint[i].Text = Convert.ToString(5);
                    }
                    else if (Convert.ToDouble(NumericGrades[i].Text) >= 85 && Convert.ToDouble(NumericGrades[i].Text) < 90)
                    {
                        GradePoint[i].Text = Convert.ToString(4.5);
                    }
                    else if (Convert.ToDouble(NumericGrades[i].Text) >= 80 && Convert.ToDouble(NumericGrades[i].Text) < 85)
                    {
                        GradePoint[i].Text = Convert.ToString(4);
                    }
                    else if (Convert.ToDouble(NumericGrades[i].Text) >= 75 && Convert.ToDouble(NumericGrades[i].Text) < 80)
                    {
                        GradePoint[i].Text = Convert.ToString(3.5);
                    }
                    else if (Convert.ToDouble(NumericGrades[i].Text) >= 70 && Convert.ToDouble(NumericGrades[i].Text) < 75)
                    {
                        GradePoint[i].Text = Convert.ToString(3);
                    }
                    else if (Convert.ToDouble(NumericGrades[i].Text) >= 65 && Convert.ToDouble(NumericGrades[i].Text) < 70)
                    {
                        GradePoint[i].Text = Convert.ToString(2.5);
                    }
                    else if (Convert.ToDouble(NumericGrades[i].Text) >= 60 && Convert.ToDouble(NumericGrades[i].Text) < 65)
                    {
                        GradePoint[i].Text = Convert.ToString(2);
                    }
                    else if (Convert.ToDouble(NumericGrades[i].Text) >= 55 && Convert.ToDouble(NumericGrades[i].Text) < 60)
                    {
                        GradePoint[i].Text = Convert.ToString(1.5);
                    }
                    else if (Convert.ToDouble(NumericGrades[i].Text) >= 50 && Convert.ToDouble(NumericGrades[i].Text) < 55)
                    {
                        GradePoint[i].Text = Convert.ToString(1);
                    }
                    else if (Convert.ToDouble(NumericGrades[i].Text) < 50)
                    {
                        GradePoint[i].Text = Convert.ToString(0);
                    }
                }
                else
                {
                    // not an number
                    // select all the text
                    NumericGrades[i].SelectAll();
                    // focus the text
                    NumericGrades[i].Focus();
                    // display an error message in message box
                    MessageBox.Show("Input Must be Numeric!", "Invalid Input");
                }
            }
        }
        #endregion

        #region CalculateAnswer1
        /// <summary>
        /// Calculating the average numeric grade
        /// </summary>
        private void CalculateAnswer1()
        {
            double average = 0;
            double total = 0;
            for (int i=0; i< NumericGrades.Length; i++)
            {
                // adding all the numeric grades values in total
                total += Convert.ToDouble(NumericGrades[i].Text);
            }
            // calculate the average
            average = total / NumericGrades.Length;
            // display the average numeric grade in answer label 1
            lblAnswer1.Text = Convert.ToString(average);
        }
        #endregion

        #region CalculateAnswer2
        /// <summary>
        /// Calculating the overall GradePointA
        /// </summary>
        private void CalculateAnswer2()
        {
            double average = 0;
            double total = 0;
            for (int i = 0; i < GradePoint.Length; i++)
            {
                // adding all the Grade Point in total
                total += Convert.ToDouble(GradePoint[i].Text);
            }
            // Calculate the Average
            average = total / GradePoint.Length;
            // Display the overall GradePointA in answer 2 label
            lblAnswer2.Text = Convert.ToString(average);
        }
        #endregion

        #region TextFocusChanged
        /// <summary>
        /// if the text in texboxes change perfoem the following
        /// </summary>
        private void TextFocusChanged()
        {
            // check for the validation
            if (ValidateGradePoints())
            {
                // validation passed - calculate grade points
                CalculateGradePoints();
            }
            else
            {
                // validation falied - display error message
                MessageBox.Show("Input Must be numeric!!", "Invalid Input");
            }
        }
        #endregion

        #endregion

        #region Events

        #region Calculate Button
        /// <summary>
        /// Caluculating the grade points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateGradePoints())
            {
                // Calculate Grades
                CalculateGradePoints();

                // Calculate Numeric Average Grade Points
                CalculateAnswer1();
                 
                // Calculate Overall GradePointA 
                CalculateAnswer2();
            }
            else
            {
                // If the is not an number
                MessageBox.Show("Input Must be numeric!!");
            }
        }
        #endregion

        #region Reset Button
        /// <summary>
        /// Reseting all the values to the default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            // set eveything to default
            SetDefault();
        }
        #endregion

        #region Close Button
        /// <summary>
        /// To exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // ask for confirmation
            if (MessageBox.Show("Are you Sure?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //end application
                this.Close();
            }
        }
        #endregion

        #region lblAnswer1_TextChanged
        /// <summary>
        /// disabling/enabling the calculate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAnswer1_TextChanged(object sender, EventArgs e)
        {
            // Check if the answer1 label is empty or not
            if(lblAnswer1.Text == "")
            {
                // enable the calculate button if the label is empty
                btnCalculate.Enabled = true;
            }
            else
            {
                // disable the calculate button if the label is not empty
                btnCalculate.Enabled = false;
            }
        }
        #endregion

        #region txtNumericGrades6_Leave
        /// <summary>
        /// If the foucus of textboxes leaves then perform the following
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumericGrades6_Leave(object sender, EventArgs e)
        {
            // Calculate the grade points is the focus changes on any of the textboxes
            TextFocusChanged();
        }
        #endregion

        #region btnCalculate_EnabledChanged
        /// <summary>
        /// Disabling/enabling the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_EnabledChanged(object sender, EventArgs e)
        {
            // if the calculate button is enabled/disabled, enabling/disabling the textboxes
            if(btnCalculate.Enabled)
            {
                // if the calculate button is enabled
                // enable all the textboxes
                foreach (TextBox tb in NumericGrades)
                {
                    // enable the textboxes
                    tb.Enabled = true;
                }

                // enable all the dropdown boxes
                foreach (ComboBox cb in Courses)
                {
                    // enable the textboxes
                    cb.Enabled = true;
                }
            }
            else
            {
                // if the calculate button is disabled
                // disable the textboxes
                foreach (TextBox tb in NumericGrades)
                {
                    // disable the texboxes
                    tb.Enabled = false;
                }
                // disable all the dropdown boxes
                foreach (ComboBox cb in Courses)
                {
                    // disable the textboxes
                    cb.Enabled = false;
                
                }
            }
        }
        #endregion

        #endregion

        #region Dropdown 1
        /// <summary>
        /// if no course is selected in dropdown box though the grades are entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumericGrades1_Enter(object sender, EventArgs e)
        {
            if(Courses[0].SelectedIndex == 0)
            {
                Courses[0].Focus();
                MessageBox.Show("Please select a course!", "Course Selcetion");
            }
            else
            {
                NumericGrades[0].Focus();
            }
        }
        #endregion

        #region Dropdown 2
        /// <summary>
        /// if no course is selected in dropdown box though the grades are entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumericGrades2_Enter(object sender, EventArgs e)
        {
            if (Courses[1].SelectedIndex == 0)
            {
                Courses[1].Focus();
                MessageBox.Show("Please select a course!", "Course Selcetion");
            }
            else
            {
                NumericGrades[1].Focus();
            }
        }
        #endregion

        #region Dropdown 3
        /// <summary>
        /// if no course is selected in dropdown box though the grades are entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumericGrades3_Enter(object sender, EventArgs e)
        {
            if (Courses[2].SelectedIndex == 0)
            {
                Courses[2].Focus();
                MessageBox.Show("Please select a course!", "Course Selcetion");
            }
            else
            {
                NumericGrades[2].Focus();
            }
        }
        #endregion

        #region Dropdown 4
        /// <summary>
        /// if no course is selected in dropdown box though the grades are entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumericGrades4_Enter(object sender, EventArgs e)
        {
            if (Courses[3].SelectedIndex == 0)
            {
                Courses[3].Focus();
                MessageBox.Show("Please select a course!", "Course Selcetion");
            }
            else
            {
                NumericGrades[3].Focus();
            }
        }
        #endregion

        #region Dropdown 5
        /// <summary>
        /// if no course is selected in dropdown box though the grades are entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumericGrades5_Enter(object sender, EventArgs e)
        {
            if (Courses[4].SelectedIndex == 0)
            {
                Courses[4].Focus();
                MessageBox.Show("Please select a course!", "Course Selcetion");
            }
            else
            {
                NumericGrades[4].Focus();
            }
        }
        #endregion

        #region Dropdown 6
        /// <summary>
        /// if no course is selected in dropdown box though the grades are entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumericGrades6_Enter(object sender, EventArgs e)
        {
            if (Courses[5].SelectedIndex == 0)
            {
                Courses[5].Focus();
                MessageBox.Show("Please select a course!", "Course Selcetion");
            }
            else
            {
                NumericGrades[5].Focus();
            }
        }
        #endregion

        
    }
}
