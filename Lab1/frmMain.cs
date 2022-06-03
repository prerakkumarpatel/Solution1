
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
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion


        #region constant and variable
        Double averageAttendees = 0;
        Double totalAttendees = 0;
        int time = 1;
        
        #endregion

        #region UI events

        #endregion
        #region function

        private int ValidateDecimal(string inputString)
        {
            int retVal = 0;

            int.TryParse(inputString, out retVal);

            return retVal;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Double inputValue;

            inputValue = ValidateDecimal(txtAttendeesEntry.Text);
          if (inputValue >0 && time < 10)
            { 
                lbxAttendeesList.Items.Add(inputValue);
                totalAttendees += inputValue;
                averageAttendees = Math.Round((totalAttendees /time),2);
                lblAverageAttendees.Text = "Average Per Hour:"+ averageAttendees.ToString();
                time += 1;
                lblHour.Text = "Time:" + time + "pm";
                txtAttendeesEntry.Clear();



            }

            else if(time >= 10)
                {
                MessageBox.Show("You reached 10 pm And Event is done and average attendees are :"+averageAttendees);
                if (MessageBox.Show("Are you sure you want to exit?","Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }else
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

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit?",
                    "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            };
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
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
