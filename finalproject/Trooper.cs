/* Trooper Class File Definition
 * Author: Clint MacDonald
 * Date: June 27, 2022
 */

#region USING statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
#endregion

namespace ICE4
{
    class Trooper
    {

        #region Global Variables
        public static List<Trooper> troopers = new List<Trooper>();
        private static int nextID = 1;
        #endregion

        #region Properties
        public int Designation { get; set; }
        public String NickName { get; set; }
        public String HomeWorld { get; set; }
        public DateTime Born { get; set; }
        public String Unit { get; set; }
        public Boolean IsDefective { get; set; }
        public Color HairColor { get; set; }
        public Color EyeColor { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor - using autoincrement designation
        /// </summary>
        public Trooper()
        {
            Designation = nextID++;

            SetDefaults();
        }

        /// <summary>
        /// Parameterize Constructor - using autoincrement Designation
        /// </summary>
        /// <param name="nickName">The name that the trooper responds to when communicating</param>
        /// <param name="homeWorld">The world the Trooper was BORN on.</param>
        /// <param name="born">Date of Birth</param>
        /// <param name="unit"></param>
        /// <param name="isDefective"></param>
        /// <param name="hairColor"></param>
        /// <param name="eyeColor"></param>
        public Trooper(String nickName, String homeWorld, DateTime born, String unit,
                        Boolean isDefective, Color hairColor, Color eyeColor)
        {
            Designation = nextID++;

            NickName = nickName;
            HomeWorld = homeWorld;
            Born = born;
            Unit = unit;
            IsDefective = isDefective;
            HairColor = hairColor;
            EyeColor = eyeColor;
        }
        #endregion

        #region Custom Methods

        #region Instance Methods
        /// <summary>
        /// Sets the default values for all properties except the designation
        /// </summary>
        private void SetDefaults()
        {
            NickName = string.Empty;
            HomeWorld = string.Empty;
            Born = DateTime.Today;
            Unit = string.Empty;
            IsDefective = false;
            HairColor = Color.Gray;
            EyeColor = Color.Gray;
        }

        public void ChangeUnit(string newUnit)
        {
            Unit = newUnit;
        }

        #endregion

        #region Static Methods

        public static List<Trooper> GetSampleTroopers()
        {
            List<Trooper> returnList = new List<Trooper>();

            returnList.Add(new Trooper("Clint", "Tatooine", new DateTime(1972, 05, 16), "Blue", false,
                        Color.Brown, Color.Brown));
            returnList.Add(new Trooper("Rex", "Endor", new DateTime(2062, 08, 11), "Red", false,
                        Color.Black, Color.Blue));
            returnList.Add(new Trooper("Ugly", "Hoth", new DateTime(2053, 11, 22), "Blue", true,
                                    Color.Yellow, Color.Red)); ;

            return returnList;
        }

        public static void ChangeUnit(int designation, string newUnit)
        {
            Trooper troop = FindTrooper(designation);
            troop.Unit = newUnit;
        }

        public static Trooper FindTrooper(int designation)
        {
            return troopers.Find(t => t.Designation == designation);

            //Trooper foundTrooper = null;

            //foreach (Trooper t in troopers)
            //{
            //    if (t.Designation == designation)
            //    {
            //        return t;
            //    }
            //}

            //return foundTrooper;
        }

        public static List<String> GetUniqueUnits()
        {
            List<String> returnList = new List<String>();

            foreach (Trooper t in troopers)
            {
                if (!returnList.Contains(t.Unit)) returnList.Add(t.Unit);
            }

            return returnList;
        }

        public static Boolean TrooperExists(int designation)
        {
            return troopers.FindAll(t => t.Designation == designation).Count > 0;
        }

        #endregion

        #endregion
    }
}
