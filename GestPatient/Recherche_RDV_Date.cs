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
    public partial class Recherche_RDV_Date : Form
    {
        public Recherche_RDV_Date()
        {
            InitializeComponent();
        }

        private void BTN_Recherche_RDV_Date_OK_Click(object sender, EventArgs e)
        {
            try{

                clearcontrols(groupBox2);
                clearcontrols(groupBox3);
                DGV_Recherche_RDV_Date_RDV.DataSource = Global.SearchRDVByDate(TXB_Recherche_RDV_Date_Date.Text);
            }catch (Exception e1){
                MessageBox.Show(e1.Message.ToString()); }
        }

        private void BTN_Recherche_RDV_Date_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Recherche_RDV_Date_RDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int i = e.RowIndex;

                DataRow[] drow = Global.GetMedecinByCodeMedecin(DGV_Recherche_RDV_Date_RDV.Rows[i].Cells[3].Value.ToString());

                TXB_Recherche_RDV_Date_NomMedecin.Text = drow[0][1].ToString();
                TXB_Recherche_RDV_Date_SpecialiteMedecin.Text = drow[0][4].ToString();

                DataRow[] drow2 = Global.GetPatientByCodePatient(DGV_Recherche_RDV_Date_RDV.Rows[i].Cells[4].Value.ToString());
                TXB_Recherche_RDV_Date_NomPatient.Text = drow2[0][1].ToString();
                TXB_Recherche_RDV_Date_DateNaissanceP.Text = drow2[0][3].ToString();
                if (drow2[0][4].ToString() == "M") RB_Recherche_RDV_Date_M.Checked = true;
                else RB_Recherche_RDV_Date_F.Checked = true;


            }
            catch (Exception e2) { MessageBox.Show(e2.Message.ToString()); }
        }
        public static void clearcontrols(GroupBox groupb) {


            foreach (Control C in groupb.Controls)
            {

                if (C is TextBox) C.Text = "";
                if (C is DateTimePicker)
                {
                    var C2 = C as DateTimePicker;
                    C2.Value = DateTime.Now;
                }
                if (C is ComboBox)
                {
                    var C2 = C as ComboBox;
                    C2.SelectedIndex = -1;
                }


            }

        }

        private void Recherche_RDV_Date_Load(object sender, EventArgs e)
        {

        }

        private void TXB_Recherche_RDV_Date_Date_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

            if (!e.IsValidInput)
            {
                //  toolTip1.ToolTipTitle = "Invalid Date Value";
                MessageBox.Show("We're sorry, but the value you entered is not a valid DATE. Please change the value.");
                e.Cancel = true;
            }
        }
    }
}
