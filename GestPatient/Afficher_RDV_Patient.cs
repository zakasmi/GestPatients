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
    public partial class Afficher_RDV_Patient : Form
    {
        public Afficher_RDV_Patient()
        {
            InitializeComponent();
        }
        string codepatient;
        private void BTN_Afficher_RDV_Patient_OK_Click(object sender, EventArgs e)
        {
            try {
                codepatient = TXB_Afficher_RDV_Patient_CodePatient.Text;
                Global.clearcontrols(groupBox3);
                Global.clearcontrols(groupBox2);
 DGV_Afficher_RDV_Patient_RDVPatient.DataSource=Global.GetRDVByCodePatient(TXB_Afficher_RDV_Patient_CodePatient.Text);

                DataRow[] row = Global.GetPatientByCodePatient(TXB_Afficher_RDV_Patient_CodePatient.Text);

                TXB_Afficher_RDV_Patient_NomPatient.Text = row[0][1].ToString();
                TXB_Afficher_RDV_Patient_DateNaissance.Text = row[0][3].ToString();
                TXB_Afficher_RDV_Patient_Adresse.Text = row[0][2].ToString();
                if (row[0][4].ToString() == "F") RB_Afficher_RDV_Patient_F.Checked = true;
                else RB_Afficher_RDV_Patient_M.Checked = true;
            }
            catch (Exception e3 ) { MessageBox.Show(e3.Message.ToString()); }
        }

        private void BTN_Afficher_RDV_Patient_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Afficher_RDV_Patient_RDVPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXB_Afficher_RDV_Patient_NumRendezvous.Text = DGV_Afficher_RDV_Patient_RDVPatient.Rows[e.RowIndex].Cells[0].Value.ToString();
            DTP_Afficher_RDV_Patient_DateRDV.Text = DGV_Afficher_RDV_Patient_RDVPatient.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXB_Afficher_RDV_Patient_HeureRDV.Text = DGV_Afficher_RDV_Patient_RDVPatient.Rows[e.RowIndex].Cells[2].Value.ToString();
            CB_Afficher_RDV_Patient_CodeMedecin.SelectedValue = DGV_Afficher_RDV_Patient_RDVPatient.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Afficher_RDV_Patient_Load(object sender, EventArgs e)
        {
            CB_Afficher_RDV_Patient_CodeMedecin.DataSource = Global.GetMedecin;
            CB_Afficher_RDV_Patient_CodeMedecin.ValueMember = "CodeMedecin";

        }

        private void BTN_TXB_Afficher_RDV_Patient_Enregistrer_Click(object sender, EventArgs e)
        {

            try
            {
                Global.ModifyRDVDatasetByCodeRDV(TXB_Afficher_RDV_Patient_NumRendezvous.Text, DTP_Afficher_RDV_Patient_DateRDV.Value.ToString(), TXB_Afficher_RDV_Patient_HeureRDV.Text, CB_Afficher_RDV_Patient_CodeMedecin.SelectedValue.ToString());
                refreshDGV();
                MessageBox.Show("Les Modifications sont enregistré avec succes");
            }
            catch (Exception e4)
            {
                MessageBox.Show(e4.ToString());
                
            }
        }

        private void TXB_Afficher_RDV_Patient_Supprimer_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Global.checkcontrols(groupBox3))
                {
                    Global.DeleteRDVByNumRDV(TXB_Afficher_RDV_Patient_NumRendezvous.Text);
                    refreshDGV();
                    MessageBox.Show("Le Rendez-vous a éte supprimer avec succés !!");
                }
                else MessageBox.Show(" Remplir tous les champs SVP !!!");

            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message.ToString());
                
            }
        }
        private void refreshDGV()
        {
            DGV_Afficher_RDV_Patient_RDVPatient.DataSource = Global.GetRDVByCodePatient(codepatient);



        }

        private void TXB_Afficher_RDV_Patient_HeureRDV_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
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
