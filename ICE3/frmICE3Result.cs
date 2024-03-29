﻿/*prerakkumar
 * ice 8
 * result form
 * 30 june 2022
 * https://github.com/prerakkumarpatel/Solution1/tree/master/ICE3
 */

using System;
using System.Windows.Forms;

namespace ICE3
{
    public partial class frmICE3Result : Form
    {
        /// <summary>
        /// normal construuctor
        /// </summary>
        public frmICE3Result()
        {
            InitializeComponent();
        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public frmICE3Result(int X ,int Y)
        {
            InitializeComponent();

            lblPlus.Text = (X + Y).ToString();
            lblMinus.Text = (X - Y).ToString();
            lblMultiply.Text = (X * Y).ToString();
            if(!(Y==0))lblDivide.Text = ((Decimal)X /(Decimal) Y).ToString();
            lblPower.Text = Math.Pow(X , Y).ToString();
        }
        /// <summary>
        /// ok button to close result form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
