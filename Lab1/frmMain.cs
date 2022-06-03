/*Name:Prerakkumar  * 
 * StudentId : 100846056
 * Date: June 1 2022
 *Purpose: group of interconnected logics that calculate average
 *Github:https://github.com/prerakkumarpatel/Solution1/
 */

using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmMain : Form
    {
        #region mainfunction
        /// <summary>
        /// main constructor function
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion


        #region constant and variable
        // variables and constants
        Double averageAttendees = 0;
        Double totalAttendees = 0;
        int time = 1;

        #endregion

        #region UI events
        /// <summary>
        /// Add Function that add attendees to the list of attendees 
        /// and calculate error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Double inputValue;

            inputValue = ValidateDecimal(txtAttendeesEntry.Text);
            if (inputValue > 0 && time <= 10)
            {
                lbxAttendeesList.Items.Add(inputValue);
                totalAttendees += inputValue;
                averageAttendees = Math.Round((totalAttendees / time), 2);
                lblAverageAttendees.Text = "Average Per Hour: " + averageAttendees.ToString();
                time += 1;
                lblHour.Text = "Time:" + time + "pm";
                if (time ==11)
                {
                    lblHour.Text = "Time:" + (time-1) + "pm";
                    lblAverageAttendees.Text = "Average Per Hour at 10 pm:" + averageAttendees.ToString();
                }
               
                txtAttendeesEntry.Clear();
                
            }
            //error message box
            else if (time > 10)
            {

                MessageBox.Show("You reached 10 pm And Event is done and average attendees are :" + averageAttendees);
                if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    SetDefaults();

                }

            }
            else

            {
                MessageBox.Show("Enter valid number of attendees");
                txtAttendeesEntry.SelectAll();
                txtAttendeesEntry.Focus();
            }



        }
        /// <summary>
        /// Function that close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit?",
                    "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            };
        }
        /// <summary>
        /// function that reset all field when reset button is pressed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        #endregion
        #region function
        /// <summary>
        /// Function that validate input 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private int ValidateDecimal(string inputString)
        {
            int retVal = 0;

            int.TryParse(inputString, out retVal);

            return retVal;
        }
        /// <summary>
        /// function that set all field to default state
        /// </summary>
        private void SetDefaults()
        {
            lbxAttendeesList.Items.Clear();
            txtAttendeesEntry.Clear();
            lbxAttendeesList.Text = "";
            txtAttendeesEntry.Focus();
            lblAverageAttendees.Text = ""; 
            time = 1;
            lblHour.Text = "Time:" + time + "pm";
            averageAttendees = 0;
            totalAttendees = 0;

        }
    }
    #endregion
}
