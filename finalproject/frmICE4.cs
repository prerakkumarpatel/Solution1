/*  NAME:   Zeel Sutariya 
 *  ID:     100846187
 *  DATE:   JULY 7, 2022
 *  TITLE:  ICE 04 - Trooper Inventory
 *  GITHUB: 
 */

#region USING STATEMENTS
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

namespace ICE4
{
    public partial class frmICE4 : Form
    {
        public frmICE4()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS
        List<String> Planets = new List<String>();
        Boolean DoGridSelectionChange = false;
        #endregion

        #region EVENT HANDLERS
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulatePlanets();
            cboPlanets.DataSource = Planets;
            Trooper.troopers.AddRange(Trooper.GetSampleTroopers());
            UpdateDataGrid();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        #endregion

        #region CUSTOM METHODS
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

        private void UpdateDataGrid()
        {
            DoGridSelectionChange = false;
            dgvClones.DataSource = null;
            dgvClones.DataSource = Trooper.troopers;
            dgvClones.ClearSelection();
            DoGridSelectionChange = true;
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






        private void btnSave_Click(object sender, EventArgs e)
        {
            Trooper trp = new Trooper();
            trp.NickName = txtNickName.Text;
            trp.IsDefective = chkDefective.Checked;
            trp.HomeWorld = cboPlanets.Text;
            trp.Born = dtpBorn.Value;
            trp.HairColor = lblHairColour.BackColor;
            trp.EyeColor = lblEyeColour.BackColor;
            trp.Unit = txtUnit.Text;

            Trooper.troopers.Add(trp);

            PopulateTrooper(trp);
            UpdateDataGrid();
        }

        private void Selected_Trooper(object sender, EventArgs e)
        {
            if (DoGridSelectionChange && dgvClones.SelectedRows.Count > 0)
            {
                int trooperID = int.Parse(dgvClones.SelectedRows[0].Cells[0].Value.ToString());
                Trooper trp = Trooper.FindTrooper(trooperID);
                PopulateTrooper(trp);
            }
        }
    }
}
