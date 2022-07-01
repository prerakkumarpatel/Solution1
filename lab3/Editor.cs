using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Week10_MultiFormEditor
{
    public partial class Editor : Form
    {

        #region Global Vars
        List<String> Planets = new List<String>();
        int TrooperID = 0;
        #endregion

        public Editor()
        {
            InitializeComponent();
        }

        public Editor(int trooperID)
        {
            InitializeComponent();
            TrooperID = trooperID;
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            PopulatePlanets();
            this.cboPlanets.DataSource = Planets;
            if (TrooperID > 0)
            {   // editing an existing trooper
                Trooper trp = Trooper.FindTrooper(TrooperID);
                PopulateTrooper(trp);
            }
            else
            {   // adding a new trooper
                SetDefaults();
            }

        }

        #region Custom Methods
        private void PopulatePlanets()
        {
            Planets.Add("Alderaan");
            Planets.Add("Bespin");
            Planets.Add("Coruscant");
            Planets.Add("Dagobah");
            Planets.Add("Endor");
            Planets.Add("Geonosis");
            Planets.Add("Hoth");
            Planets.Add("Jakku");
            Planets.Add("Kamino");
            Planets.Add("Mandalore");
            Planets.Add("Mustafar");
            Planets.Add("Naboo");
            Planets.Add("Scarif");
            Planets.Add("Tatooine");
            Planets.Add("Yavin");
        }

        private void SetDefaults()
        {
            lblHairColour.BackColor = Color.Gray;
            lblEyeColour.BackColor = Color.Gray;
            txtNickName.Clear();
            txtUnit.Clear();
            cboPlanets.SelectedIndex = -1;
            dtpBorn.Value = DateTime.Now;
            nudDesignation.Value = 0;
            chkDefective.Checked = false;
        }
        private void PopulateTrooper(Trooper t)
        {
            this.txtNickName.Text = t.NickName;
            this.chkDefective.Checked = t.IsDefective;
            this.nudDesignation.Value = t.Designation;
            this.cboPlanets.SelectedItem = t.HomeWorld;
            this.dtpBorn.Value = t.Born;
            this.txtUnit.Text = t.Unit;
            this.lblHairColour.BackColor = t.HairColor;
            this.lblEyeColour.BackColor = t.EyeColor;
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Trooper trp = new Trooper();
            // do not do designation as it is autonumber
            trp.NickName = txtNickName.Text;
            trp.Unit = txtUnit.Text;
            trp.IsDefective = chkDefective.Checked;
            trp.HairColor = lblHairColour.BackColor;
            trp.EyeColor = lblEyeColour.BackColor;
            trp.HomeWorld = cboPlanets.SelectedValue.ToString();
            trp.Born = dtpBorn.Value;

            if (this.nudDesignation.Value == 0)
            {   // adding a new trooper
                Trooper.troopers.Add(trp);
            }
            else
            {   // editing a trooper
                trp.Designation = (Int32)nudDesignation.Value;
                // remove original trooper
                Trooper.troopers.Remove(Trooper.FindTrooper(trp.Designation));
                // add the replacement back in
                Trooper.troopers.Add(trp);
            }

            this.Close();
        }

        private void btnSetHairColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblHairColour.BackColor = colorDialog1.Color;
        }

        private void btnSetEyeColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblEyeColour.BackColor = colorDialog1.Color;
        }
    }
}