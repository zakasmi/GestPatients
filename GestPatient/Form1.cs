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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void gestionDesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void afficherLesRDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afficher_RDV_Patient Afficher_RDV_Patient = new Afficher_RDV_Patient();
            Afficher_RDV_Patient.ShowDialog();
        }

        private void gestionDesMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Medecin GM = new Gestion_Medecin();
            GM.MdiParent = this;
            GM.Show();


        }

        private void gestionDesPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Patient GP = new Gestion_Patient();

            GP.ShowDialog();

        }

        private void gestionDesRDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_RDV GR = new Gestion_RDV();
            GR.ShowDialog();
        }

        private void afficherToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afficher_Tout AfficherTout = new Afficher_Tout();
            AfficherTout.ShowDialog();

        }

        private void rechercherRDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recherche_RDV_Date RechercheRDVDate = new Recherche_RDV_Date();
            RechercheRDVDate.ShowDialog();
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.FillMedecin();
            Global.FillPatient();
            Global.FillRDV();
        }

    }
}
