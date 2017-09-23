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
    public partial class Gestion_Medecin : Form
    {
        public Gestion_Medecin()
        {
            InitializeComponent();
        }
      

        private void BTN_GM_Nouveau_Click(object sender, EventArgs e)
        {
            Global.clearcontrols(GroupBox_GM);
        }

        private void GroupBox_GM_Enter(object sender, EventArgs e)
        {

        }

        private void Gestion_Medecin_Load(object sender, EventArgs e)
        {
            CB_GM_Specialite.DataSource = Global.GetMedecin;
            CB_GM_Specialite.ValueMember = "SpecialiteMedecin";

        }

        private void BTN_GM_Rechercher_Click(object sender, EventArgs e)
        {
            string s = TXB_GM_CodeMedecin.Text;
            Global.clearcontrols(GroupBox_GM);
            TXB_GM_CodeMedecin.Text = s;
            if (!string.IsNullOrWhiteSpace(TXB_GM_CodeMedecin.Text))
            {
                DataRow[] drow = Global.GetMedecinByCodeMedecin(TXB_GM_CodeMedecin.Text);
                if (drow.Length>0)
                {
                    TXB_GM_CodeMedecin.Text = drow[0][0].ToString();
                    TXB_GM_NomMedecin.Text = drow[0][1].ToString();
                    TXB_GM_Tele.Text = drow[0][2].ToString();
                    DTP_GM_DateEmbauche.Value = DateTime.Parse(drow[0][3].ToString());
                    CB_GM_Specialite.SelectedValue = drow[0][4].ToString();
                }
                else MessageBox.Show("Pas De Medecin avec Ce Code !! Enter un Code Valide ");
            }
            else MessageBox.Show("Entrer un Code Medecin !!!","Code Medecin",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void BTN_GM_Quiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_GM_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Global.AddMedecin(TXB_GM_CodeMedecin.Text, TXB_GM_NomMedecin.Text, TXB_GM_Tele.Text, DateTime.Parse(DTP_GM_DateEmbauche.Value.ToString()), CB_GM_Specialite.SelectedValue.ToString());
                MessageBox.Show("Le Medecin a été ajouté avec succés !!!");
            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.Message.ToString());
            }


        }

        private void BTN_GM_Modifier_Click(object sender, EventArgs e)
        {

            try
            {

                if (!string.IsNullOrEmpty(TXB_GM_CodeMedecin.Text))
            {
                    if (Global.ModifyMedecin(TXB_GM_CodeMedecin.Text, TXB_GM_NomMedecin.Text, TXB_GM_Tele.Text, DTP_GM_DateEmbauche.Value, CB_GM_Specialite.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Le Medecin a été Modifier avec Succés");
                    }
                    else MessageBox.Show("Le Medecin n'existe pas");
            }
        }
            catch (Exception e7)
            {

                MessageBox.Show(e7.Message.ToString());
            }

}

        private void BTN_GM_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TXB_GM_CodeMedecin.Text)) {

                    if (Global.DeleteMedecinByCodeMedecin(TXB_GM_CodeMedecin.Text))
                    {
                        MessageBox.Show("Le Medecin a été Supprimé !!");
                    }
                    else MessageBox.Show("Le Medecin n'existe Pas !! Entrer Un Autre Code Medecin");

                }
                MessageBox.Show("Entrer un Code Medecin !!!", "Medecin", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.Message.ToString());
            }
        }
    }
}
