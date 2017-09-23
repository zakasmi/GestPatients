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
    public partial class Afficher_Tout : Form
    {
        public Afficher_Tout()
        {
            InitializeComponent();
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { DGV_Afficher_Tout.DataSource = Global.GetMedecin; }

        }

        private void RB_Afficher_Tout_Patients_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Afficher_Tout_Patients.Checked)
            {
                DGV_Afficher_Tout.DataSource = Global.GetPatient;
            }
        }

        private void RB_Afficher_Tout_RDV_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Afficher_Tout_RDV.Checked)
            {
                DGV_Afficher_Tout.DataSource = Global.GetRDV;
            }
        }

        private void Afficher_Tout_Load(object sender, EventArgs e)
        {
        }
    }
}
