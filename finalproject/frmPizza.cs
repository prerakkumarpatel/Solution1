﻿/* prerakkumar
 * 100846056
 * Date: july 14 2022
 * Title: ICE 4 - Pizza Shop
 * https://github.com/prerakkumarpatel/Solution1
 */
#region USING statements
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

namespace lab3
{
    /// <summary>
    /// class
    /// </summary>
    public partial class frmPizza : Form
    {
        public frmPizza()
        {
            InitializeComponent();
        }

        #region GLOBAL VAR s
        /// <summary>
        /// global variable
        /// </summary>
        List<String> PizzaType = new List<String>();
        public Boolean DoGridSelectionChange = false;
        #endregion


        #region EVENT HANDLERS
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            Pizza.pizzas.AddRange(Pizza.GetSamplePizzas());
            UpdateDataGrid();
        }

        #endregion

        #region CUSTOM METHODS
        /// <summary>
        /// function that update datasource
        /// </summary>
        public void UpdateDataGrid()
        {
            DoGridSelectionChange = false;
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = Pizza.pizzas;
            dgvOrders.Columns[0].Width = 70;
            dgvOrders.Columns[1].Width = 120;
            dgvOrders.Columns[2].Width = 120;
            dgvOrders.Columns[3].Width = 200;
            dgvOrders.Columns[4].Width =80;
            dgvOrders.Columns[5].Width = 100;
            dgvOrders.Columns[6].Width = 80;
            dgvOrders.Columns[7].Width = 80;
            dgvOrders.ClearSelection();
            DoGridSelectionChange = true;
        }

        #endregion
        #region UI Events


        /// <summary>
        /// add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmPizzaEditor frmEditor = new frmPizzaEditor();
            frmEditor.ShowDialog();
            UpdateDataGrid();
        }
        /// <summary>
        /// refressh the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshForm(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        /// <summary>
        /// about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmPizzaAbout frmAbout = new frmPizzaAbout();
            frmAbout.ShowDialog();
        }
        /// <summary>
        /// remove selected pizza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count != 0)
            {
                int orderID = int.Parse(dgvOrders.SelectedRows[0].Cells[0].Value.ToString());
                if (MessageBox.Show("Are you sure you want to REMOVE Order?",
                   "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Pizza.pizzas.Remove(Pizza.FindPizza(orderID));
                      UpdateDataGrid();
                };
            }
            else
                MessageBox.Show("Please click any order  to REMOVE");
        }

        /// <summary>
        /// reset the pizza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {   if(dgvOrders.SelectedRows.Count == 1)
            {
                int orderID = int.Parse(dgvOrders.SelectedRows[0].Cells[0].Value.ToString());
                frmPizzaEditor frmEditor = new frmPizzaEditor(orderID);
                
                frmEditor.ShowDialog();
                UpdateDataGrid();

            }
           
            else
                MessageBox.Show("Please click any order  to RESET");
        }

        #endregion
    }
}