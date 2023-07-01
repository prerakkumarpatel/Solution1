 /* Pizza 
 * Prerakkumar
 * Date: July 14, 2022
 */

#region USING statements
using System;
using System.Collections.Generic;
#endregion

namespace lab3
{
    /// <summary>
    /// /pizza class 
    /// </summary>
    class Pizza
    {

        #region Global Variables
        public static List<Pizza> pizzas = new List<Pizza>();
        private static int nextID = 1;
        #endregion

        #region Properties
        public int Order { get; set; }
        public String OrderOf { get; set; }
        public String PizzaType { get; set; }
        public DateTime OrderOn { get; set; }
        public int Quantity { get; set; }
        public Boolean IsPremium { get; set; }
        public Boolean IsSpicy { get; set; }
        public Boolean IsPickup { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor - using autoincrement order 
        /// </summary>
        public Pizza() 
        {
            Order = nextID++;

            SetDefaults();
        }

        /// <summary>
        /// Parameterize Constructor - using autoincrement Order
        /// </summary>
        /// <param name="orderof">The name of customer</param>
        /// <param name="pizzatype">The type of pizza on.</param>
        /// <param name="orderon">order on</param>
        /// <param name="quantity"></param>
        /// <param name="ispremium"></param>
        /// <param name="isspicy"></param>
        /// <param name="ispickup"></param>
        public Pizza(String orderof, String pizzatype, DateTime orderon, int quantity,
                        Boolean ispremium, Boolean isspicy, Boolean ispickup)
        {
            Order = nextID++;

            OrderOf = orderof;
            PizzaType = pizzatype;
            OrderOn = orderon;
            Quantity = quantity;
            IsPremium = ispremium;
            IsSpicy = isspicy;
            IsPickup = ispickup;
        }
        #endregion

        #region Custom Methods

        #region Instance Methods
        /// <summary>
        /// Sets the default values for all properties except the designation
        /// </summary>
        private void SetDefaults()
        {
            OrderOf = string.Empty;
            PizzaType = string.Empty;
            OrderOn = DateTime.Today;
            Quantity = 0;
            IsPremium = false;
            IsPickup = false;
            IsSpicy = false;
        }


        #endregion

        #region Static Methods
        /// <summary>
        /// sample of orders
        /// </summary>
        /// <returns></returns>
        public static List<Pizza> GetSamplePizzas()
        {
            List<Pizza> returnList = new List<Pizza>();

            returnList.Add(new Pizza("Patel", "Veggie", new DateTime(2022, 07, 23, 12,00,00), 2, false,
                        false ,true));
            returnList.Add(new Pizza("ankit", "italian", new DateTime(2022, 07, 23,11,24,00), 3, false,
                        true, true));
            returnList.Add(new Pizza("parth", "herb", new DateTime(2022, 07, 22 ,10,20,00), 1, true,
                                    false, false)); ;

            return returnList;
        }

        /// <summary>
        /// serch for pizza
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static Pizza FindPizza(int order)
        {
            return pizzas.Find(p=> p.Order == order);

        }
        
        #endregion

        #endregion
    }
}
