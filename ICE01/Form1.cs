/*Name:Prerakkumar  * 
 * StudentId : 100846056
 * Date: May 12 2022
 *Purpose: i don t have any purpose just marks
 *Github:https://github.com/prerakkumarpatel/Solution1/fgghfhgffhgggh
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_MouseHover(object sender, EventArgs e)
        {
            if (btnNo.Left == 456)
            {
                btnNo.Left += 100;

            }else
            {
                btnNo.Left -= 100;
            }

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Too bad, You are very wrong");
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yes i am the superman");
            Application.Exit();

        }
    }
}
