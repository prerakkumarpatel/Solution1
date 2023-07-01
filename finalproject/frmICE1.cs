/*
 * Name:        Zeel Sutariya
 * Student ID:  100846187   
 * Date:        May 12, 2022
 * Title:       ICE 01 - You are Awesome
 * GitHub:      https://github.com/Zeel-Sutariya/NETD2202_Assessments
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

namespace ICE01
{
    public partial class frmICE1 : Form
    {
        /// <summary>
        /// Main function to start program (Constructor)
        /// </summary>
        public frmICE1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event: Clicking ont he Yes button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, Zeel is awesome eh!");
            this.Close();
        }

        /// <summary>
        /// Event: Hovering over the No button 
        /// (moving it so they can not enter)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_MouseHover(object sender, EventArgs e)
        {
            if (btnNo.Left == 262)
            {
                btnNo.Left += 100;
            }
            else
            {
                btnNo.Left -= 100;
            }
        }

        /// <summary>
        /// Event: Clicking the no button using tab and enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Too bad, you are Very wrong!");
        }
    }
}
