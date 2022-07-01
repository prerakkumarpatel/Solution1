/*prerakkumar
 * ice 8
 * calculate form
 * 30 june 2022
 * https://github.com/prerakkumarpatel/Solution1/tree/master/ICE3
 */

using System;
using System.Windows.Forms;

namespace ICE3
{
    public partial class frmCalculate : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public frmCalculate()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calculate Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int X = (Int32)nudX.Value;
            int Y = (Int32)nudY.Value;

            frmResult frm = new frmResult(X,Y);
            frm.ShowDialog();
        }
    }
}
