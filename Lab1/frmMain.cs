using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int inputValue;

            inputValue = ValidateDecimal(txtAttendeesEntry.Text);
            if (inputValue > 0)
            {
                lbxAttendeesList.Items.Add(inputValue);
                totalAttendees += inputValue;
                averageAttendees = (totalAttendees / time);
                lblAverageAttendees.Text = "Average Per Hour: " + averageAttendees.ToString();
                time += 1;
                lblHour.Text = "Time:" + time + "pm";

                {
                    lblAverageAttendees.Text = "Average Per Hour at 10 pm:" + averageAttendees.ToString();
                }





            }
            //error message box
            else if (time > 10)
            {

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
            txtAttendeesEntry.Focus();
            lblAverageAttendees.Text = "";
            time = 0;
            lblHour.Text = "Time:" + time + "pm";
            averageAttendees = 0;
            totalAttendees = 0;

        }


    }
    #endregion
}