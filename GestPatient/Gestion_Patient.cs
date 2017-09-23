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
    public partial class Gestion_Patient : Form
    {
        public Gestion_Patient()
        {
            InitializeComponent();
        }

        private void Gestion_Patient_Load(object sender, EventArgs e)
        {

        }

        private void BTN_GP_Rechercher_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TXB_GP_CodePatient.Text))
            {
                string s = TXB_GP_CodePatient.Text;
                Global.clearcontrols(groupBox1);
                TXB_GP_CodePatient.Text = s;
                DataRow[] drow = Global.GetPatientByCodePatient(TXB_GP_CodePatient.Text);

                if (drow.Length > 0)
                {
                    TXB_GP_CodePatient.Text = drow[0][0].ToString();
                    TXB_GP_NomPatient.Text = drow[0][1].ToString();
                    TXB_GP_Adresse.Text = drow[0][2].ToString();
                    DTP_GP_DateNaissance.Value = DateTime.Parse(drow[0][3].ToString());
                    if (drow[0][4].ToString() == "M") RB_GP_M.Checked = true;
                    else RB_GP_F.Checked = true;
                }
                else MessageBox.Show("Le Patient n'existe Pas !!"); 
            }else MessageBox.Show("Entrer un Code Patient!!");

        }

        private void BTN_GP_Nouveau_Click(object sender, EventArgs e)
        {
            Global.clearcontrols(groupBox1);
        }

        private void BTN_GP_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.checkcontrols(groupBox1))
            {
                string s;
                if (RB_GP_F.Checked) s = RB_GP_F.Text;
                else s = RB_GP_M.Text;
                bool ajouter = Global.AddPatient(TXB_GP_CodePatient.Text, TXB_GP_NomPatient.Text, TXB_GP_Adresse.Text, DTP_GP_DateNaissance.Value, s);
                    if (ajouter) {
                        Global.clearcontrols(groupBox1);
                        MessageBox.Show(" Le patient est Ajouté"); }
                    else MessageBox.Show("Le Patient n'est pas ajouté");
            }
            else MessageBox.Show("remplir tous les champs !!");
            }
            catch (Exception e7)
            {
                MessageBox.Show(e7.Message.ToString());
            }
        }

        private void BTN_GP_Quiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_GP_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TXB_GP_CodePatient.Text))
                {
                    if (MessageBox.Show("etes Vous sure de Vouloir supprimer", "Supprimer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (Global.DeletePatient(TXB_GP_CodePatient.Text))
                        {
                            MessageBox.Show("Le Patient a été supprimer");
                        }
                        else MessageBox.Show("Le patient n'existe Pas!! entrer un code valide !!");

                    }
                }
                else MessageBox.Show("Entrer un code patient !!", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception e8)
            {

                MessageBox.Show(e8.Message.ToString());
            }
        }

        private void BTN_GP_Modifier_Click(object sender, EventArgs e)
        {
            if (!Global.checkcontrols(groupBox1))
            {
                string sexe;
                if (RB_GP_F.Checked) sexe = "F";
                else sexe = "M";
                if (Global.ModifyPatient(TXB_GP_CodePatient.Text, TXB_GP_NomPatient.Text, TXB_GP_Adresse.Text, DTP_GP_DateNaissance.Value, sexe))
                {
                    MessageBox.Show("Le Patient a éte Modifié avec Succés ");
                }
                else MessageBox.Show("Le Patient N'existe Pas !! enter un Code Valide !!");

            }
            else MessageBox.Show("Remplir Tous Les champs !!!");

        }
    }
}
