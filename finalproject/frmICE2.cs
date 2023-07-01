// TODO: comment Header
//Prerakkumar Patel
//100846056
// git :    https://github.com/prerakkumarpatel/Solution1/tree/master/ICE2_DiseaseCases
// TODO: add regions to organize your code

using System;
using System.Windows.Forms;

namespace ICE2
{
    public partial class frmICE2 : Form
    {
        #region mainconstructor  
        //main constructor
        public frmICE2()
        {
            InitializeComponent();
        }

        #endregion

        #region global variable  

        // Global Variables
        Label[] weekDays;
        TextBox[] infections;
        
        const int NUMBEROFDAYS = 7;
        #endregion


        #region UI Events
        /// <summary>
        /// function when form load which use to set days according to date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize the weekdays label array and populate with the appropriate labels
            weekDays = new Label[] { lblDay1, lblDay2, lblDay3, lblDay4, lblDay5, lblDay6, lblDay7 };

            // TODO: initialize the infections textbox array and populate with the appropriate textboxes
            infections = new TextBox[] { txtDay1, txtDay2, txtDay3, txtDay4, txtDay5, txtDay6, txtDay7 };
            // populate the week day name labels with the actual names.
            SetDayNames();

            // TODO: Create the method to set the form defaults called SetDefaults and uncomment out the line below.
            // The date picker should default to the current date and the infection textboxes should be empty.
            // review the SetDayNames() method for a hint how to do this.
            SetDefaults();
        }
        // TODO: Add an event (ValueChanged) to the DateTimePicker control such
        // that the weekday names are updated to match the chosen date. Note: the custom
        // method to enter the names is already created, just call it.

        /// <summary>
        /// function when date is changed and to change days according to it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpStartingDate_ValueChanged(object sender, EventArgs e)
        {
            SetDayNames();
        }

        /// <summary>
        /// when calculate button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateInfections())     // input validation function
            {
                Double averageInfection;
                Double totalInfection = 0;
                Double inputVal = 0;
                //TODO: Using a loop, calculate the average
                // Hint, int.Parse() should work as your validation should have already tested it using TryParse
                foreach (TextBox txtInfection in infections)   
                {
                    Double.TryParse(txtInfection.Text, out inputVal);
                    totalInfection = totalInfection + inputVal;


                }
                averageInfection = totalInfection / 7;
                lblDailyAverage.Text = averageInfection.ToString();
                averageInfection = 0;
            }
            else                                      //error message when wrong input
            {
                MessageBox.Show("Calculations can not be performed as one or more validations have failed");
            }

        }

        /// <summary>
        /// reset button to reset fields 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            // TODO: Create the method to set the form defaults called SetDefaults and uncomment out the line below.
            SetDefaults();
        }
        /// <summary>
        /// Exit button function to exit app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
              this.Close();
        }
        #endregion
        #region Custom function
        private void SetDayNames()
        {
            for (int day = 1; day <= 7; day++)
            {
                //TODO: review the below line to see if you can figure out how it works!
                weekDays[day - 1].Text = (dtpStartingDate.Value.AddDays(day - 1)).DayOfWeek.ToString();
            }
        }

        private bool ValidateInfections()
        {
            bool retVal = true;
            Double infection;
            //TODO: complete this function such that if any of the infection
            //textboxes are not numeric then validation fails.  It is expected to do
            //this in a modular way (i.e. looping, rather than using the textbox names.)
            foreach (TextBox txt  in infections)
                {
                
                  if(!Double.TryParse(txt.Text, out infection))
                    { retVal = false;
                    }
                }

            return retVal;
        }
        private void SetDefaults()
        {
            foreach (TextBox txtInfection in infections)
            {
                txtInfection.Text = "";

            }
            
            lblDailyAverage.Text = "0";
            dtpStartingDate.Value = DateTime.Now;
            SetDayNames();
        }

        #endregion



    }
}
