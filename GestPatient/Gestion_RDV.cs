using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPatient
{
    public partial class Gestion_RDV : Form
    {
        public Gestion_RDV()
        {
            InitializeComponent();
        }

        private void BTN_GR_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_GR_Nouveau_Click(object sender, EventArgs e)
        {
            Global.clearcontrols(groupBox3);
            Global.clearcontrols(groupBox2);
            Global.clearcontrols(groupBox1);
        }

        private void Gestion_RDV_Load(object sender, EventArgs e)
        {
            CB_GR_CodePatient.SelectedIndexChanged -= new EventHandler(CB_GR_CodePatient_SelectedIndexChanged);
            CB_GR_CodePatient.DataSource = Global.GetPatient;
            CB_GR_CodePatient.DisplayMember = "CodePatient";
            CB_GR_CodePatient.SelectedIndex = -1;
            CB_GR_CodePatient.SelectedIndexChanged += new EventHandler(CB_GR_CodePatient_SelectedIndexChanged);

            CB_GR_CodeMedecin.SelectedIndexChanged -= new EventHandler(CB_GR_CodeMedecin_SelectedIndexChanged);
            CB_GR_CodeMedecin.DataSource = Global.GetMedecin;
            CB_GR_CodeMedecin.DisplayMember = "CodeMedecin";
            CB_GR_CodeMedecin.SelectedIndexChanged += new EventHandler(CB_GR_CodeMedecin_SelectedIndexChanged);
            CB_GR_CodeMedecin.SelectedIndex = -1;
        }

        private void CB_GR_CodePatient_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (CB_GR_CodePatient.SelectedIndex != -1)
                {
                  
                    DataRow[] drow = Global.GetPatientByCodePatient(CB_GR_CodePatient.Text);

                    TXB_GR_NomPatient.Text = drow[0][1].ToString();
                    if (drow[0][4].ToString() == "M") RB_GR_M.Checked = true;
                    else RB_GR_F.Checked = true;
                }
            }
            catch (Exception e8)
            {
                MessageBox.Show(e8.Message.ToString());
            }
        }

        private void CB_GR_CodeMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CB_GR_CodeMedecin.SelectedIndex != -1)
            {
                DataRow[] drow =Global.GetMedecinByCodeMedecin(CB_GR_CodeMedecin.Text);
                TXB_GR_NomMedecin.Text =drow[0][1].ToString();
                TXB_GR_SpecialiteMedecin.Text = drow[0][4].ToString();   
            }
        }

        private void BTN_GR_AjouterRDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (CB_GR_CodeMedecin.SelectedIndex != -1 && CB_GR_CodePatient.SelectedIndex != -1 && (!Global.checkcontrols(groupBox1)))
                {
                    Global.AddRDV(DTP_GR_DateRDV.Value, TXB_GR_HeureRDV.Text, CB_GR_CodeMedecin.Text, CB_GR_CodePatient.Text);

                    MessageBox.Show("Le RDV a été Ajouté avec Succés");
                }
                else MessageBox.Show("Remplir tous les champs !!!", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception e9)
            {
                MessageBox.Show(e9.Message.ToString());
            }
        }

        private void TXB_GR_HeureRDV_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void TXB_GR_HeureRDV_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
              //  toolTip1.ToolTipTitle = "Invalid Date Value";
                MessageBox.Show("We're sorry, but the value you entered is not a valid TIME. Please change the value.");
                e.Cancel = true;
            }
        }
    }
}
