/*
 prerakkumar 
editor form 
100846056
july 15 2022
https://github.com/prerakkumarpatel/Solution1
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab3
{
    public partial class Editor : Form
    {

        #region Global Vars
        /// <summary>
        /// global variable
        /// </summary>
        List<String> PizzaType = new List<String>();
        int OrderID = 0;
        #endregion

        /// <summary>
        /// editor constructor
        /// </summary>
        public Editor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// editor constructor parameterized
        /// </summary>
        /// <param name="orderID"></param>
        public Editor(int orderID)
        {
            InitializeComponent();
            OrderID = orderID;
            nudOrder.Enabled = false;

        }
        /// <summary>
        /// function when form load  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editor_Load(object sender, EventArgs e)
        {
            PopulatePizzaType();
            this.cboPizzaType.DataSource = PizzaType;
            if (OrderID > 0)
            {   // editing an existing Pizza
                Pizza piz = Pizza.FindPizza(OrderID);
                PopulatePizza(piz);
            } else
            {   // adding a new Pizza
                SetDefaults(); 
            }

        }

        #region Custom Methods
        /// <summary>
        /// to poppup pizza type
        /// </summary>
        private void PopulatePizzaType()
        {
            PizzaType.Add("Veg");
            PizzaType.Add("Italian");
            PizzaType.Add("3cheese");
            PizzaType.Add("4cheese");
            PizzaType.Add("Meat");
            PizzaType.Add("Paperoni");
            PizzaType.Add("Vegan");
            PizzaType.Add("WholeWheat");
            PizzaType.Add("DietPizza");
            PizzaType.Add("Masroom");
        }
        /// <summary>
        /// to set all default values
        /// </summary>
        private void SetDefaults()
        {
            txtOrderOf.Clear();
            nudQuantity.Value = 1;
            cboPizzaType.SelectedIndex = 0;
            dtpOrderOn.Value = DateTime.Now;
            nudOrder.Value = 0;
            chkIsPremium.Checked = false;
            chkIsPickup.Checked = false;
            chkIsSpicy.Checked = false;
        }
        /// <summary>
        /// to popup pizza details
        /// </summary>
        /// <param name="p"></param>
        private void PopulatePizza(Pizza p)
        {
            this.txtOrderOf.Text = p.OrderOf;
            this.chkIsPremium.Checked = p.IsPremium;
            this.chkIsSpicy.Checked = p.IsSpicy;
            this.chkIsPickup.Checked = p.IsPickup;
            this.nudOrder.Value = p.Order;
            this.cboPizzaType.SelectedItem = p.PizzaType;
            this.dtpOrderOn.Value = p.OrderOn;
            this.nudQuantity.Value = p.Quantity;
        }

        #endregion
        /// <summary>
        /// reset function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
        /// <summary>
        /// save function 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Pizza piz = new Pizza();
            piz.OrderOf = txtOrderOf.Text;
            piz.Quantity = (int)nudQuantity.Value;
            piz.IsPremium = chkIsPremium.Checked;
            piz.IsSpicy = chkIsSpicy.Checked;
            piz.IsPickup = chkIsPickup.Checked;
            piz.PizzaType = cboPizzaType.SelectedValue.ToString();
            piz.OrderOn = dtpOrderOn.Value;

            if (this.txtOrderOf.Text !="")
            {   // adding a new Pizza
                  
                Pizza.pizzas.Add(piz);
                Pizza.pizzas.Remove(Pizza.FindPizza(OrderID));
                this.Close();
            } else
            {   
                MessageBox.Show("Order MUST have Customer NAME");

            }

        }

    }
}
