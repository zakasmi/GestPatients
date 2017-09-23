using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace GestPatient
{
    
    class Global
    {
       public static  SqlConnection cnx = new SqlConnection("Data Source=DELL;Initial Catalog=GestPatient;Integrated Security=True");
        public static DataSet ds = new DataSet();
        
        public DataSet returnPatient
        {
           get { return ds; }
        }
         
        //------------------------ Medecin------------------------------------------
        //return The Medecin Table 
        public static  DataTable GetMedecin
        {

           get {
                 return ds.Tables["Medecin"];  }
            
        }
        //FIll Medecin Table in dataset
        public static void FillMedecin()
        {
            if (ds.Tables.Contains("Medecin")) { ds.Tables["Medecin"].Rows.Clear(); }
            using (SqlDataAdapter da = new SqlDataAdapter("select * from Medecin ", cnx))
            {

                da.Fill(ds, "Medecin");
                ds.Tables["Medecin"].PrimaryKey = new DataColumn[] { ds.Tables["Medecin"].Columns["CodeMedecin"] };
            }
        }
        // Update Medecin in database 
        public static void UpdateMedecin() {

            using (SqlDataAdapter da = new SqlDataAdapter("select *from Medecin",cnx)) {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds,"Medecin");
            }

        }
        //  Add Medecin to dataset and update database
        public static void AddMedecin(string codemedecin,string nomedecin,string telmedecin,DateTime dateembauche,string Specialitemedecin)
        {

            DataRow drow = ds.Tables["Medecin"].NewRow();

            drow[0] = codemedecin;
            drow[1] = nomedecin;
            drow[2] = telmedecin;
            drow[3] = dateembauche;
            drow[4] = Specialitemedecin;

            ds.Tables["Medecin"].Rows.Add(drow);
            UpdateMedecin();

        }
        // Modify Medecin and update the database
        public static bool ModifyMedecin(string codemedecin, string nomedecin, string telmedecin, DateTime dateembauche, string Specialitemedecin)
        {
           DataRow drow =  ds.Tables["Medecin"].Rows.Find(codemedecin);

            if (drow != null)
            {
                MessageBox.Show("" + drow[0].ToString());
                drow[1] = nomedecin;
                drow[2] = telmedecin;
                drow[3] = dateembauche;
                drow[4] = Specialitemedecin;
                UpdateMedecin();
                FillRDV();
                return true;
            }
            return false;
        }
        // Delete Medecin By codeMedecin
        public static bool DeleteMedecinByCodeMedecin(string codeMedecin)
        {
            bool exist = false;
            foreach(DataRow drow in ds.Tables["Medecin"].Rows)
            {
                if(drow[0].ToString() == codeMedecin)
                {
                    drow.Delete();
                    exist = true;
                    break; 
                }
            }

            UpdateMedecin();
            FillRDV();
            return exist;

        }
        //Get Medecin By Codemedecin
        public static DataRow[] GetMedecinByCodeMedecin(string codemedecin)
        {

            DataRow[] result = ds.Tables["Medecin"].Select("CodeMedecin ='" + codemedecin + "'");

            return result;
        }

        //--------------------------- RDV -------------------------------------
        public static DataTable GetRDV
        {
            get { return ds.Tables["RDV"]; }
        }
        // FILL RDV from database
        public static void FillRDV()
        {
            if (ds.Tables.Contains("RDV")){ ds.Tables["RDV"].Rows.Clear(); }
            using (SqlDataAdapter da = new SqlDataAdapter("select * from RDV",cnx)) {
                da.Fill(ds, "RDV");
                ds.Tables["RDV"].PrimaryKey = new DataColumn[] { ds.Tables["RDV"].Columns["NumeroRDV"] };
            }

        }
        //update database table RDV
        public static void UpdateRDV() {

            using (SqlDataAdapter da = new SqlDataAdapter("select *from RDV ",cnx)) {

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "RDV");
            }

        }
        // Modify  table RDV in dataset

            public static void ModifyRDVDatasetByCodeRDV(string codeRDV, string  dateRDV, string heure, string codemedecin) {

            DataRow[] drow = ds.Tables["RDV"].Select("NumeroRDV="+codeRDV);
            drow[0][1] = DateTime.Parse(dateRDV);
            drow[0][2] = heure;
            drow[0][3] = codemedecin;
            UpdateRDV();
        }
        // delete RDV by Numero RDV
        public static void DeleteRDVByNumRDV(string s)
        {
            foreach (DataRow drow in ds.Tables["RDV"].Rows)
            {

                if (drow[0].ToString() == s) { drow.Delete(); break; }

            }

        }
        // search RDV by Date
        public static DataTable SearchRDVByDate(string date)
        {
            DataTable result = ds.Tables["RDV"].Clone();

            DataRow[] Drow = ds.Tables["RDV"].Select("DateRDV ='" + DateTime.Parse(date) + "'");

            foreach (DataRow drow in Drow) result.ImportRow(drow);

            return result;
        }
        // Add RDV 

            public static void AddRDV(DateTime daterdv, string heurerdv, string codemedecin,string codepatient)
        {
            DataRow drow = ds.Tables["RDV"].NewRow();
            drow[0] = 1 ;
            drow[1] = daterdv;
            drow[2] = heurerdv;
            drow[3] = codemedecin;
            drow[4] = codepatient;

            ds.Tables["RDV"].Rows.Add(drow);
            UpdateRDV();
            FillRDV();
        }

        //--------------------------- Patient --------------------------------------------
        //--------------------------------------------------------------------------------
        public static DataTable GetPatient
        {
            get { return ds.Tables["Patient"]; }

        }
        public static void FillPatient()
        {
            if (ds.Tables.Contains("Patient")) ds.Tables["Patient"].Rows.Clear();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from Patient", cnx))
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "Patient");
                ds.Tables["Patient"].PrimaryKey = new DataColumn[] { ds.Tables["Patient"].Columns["CodePatient"] };
            }

        }

        // Update Patient in Database
        public static void UpdatePatient()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("select * from Patient",cnx)) {

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds,"Patient");
            }
        }

        //  Get Patient By CodePatient

        public static DataRow[] GetPatientByCodePatient(string codePatient)
        {

            DataRow[] result = ds.Tables["Patient"].Select("CodePatient ='" + codePatient + "'");
            return result;
        }
        // get Patient By NomPatient
        public static DataTable GetRDVByCodePatient(string codepatient)
        {


            DataRow[] Drow = ds.Tables["RDV"].Select("codepatient='" + codepatient + "'");

            DataTable result = ds.Tables["RDV"].Clone();
            foreach (DataRow drow in Drow) result.ImportRow(drow);

            return result;

        }
        // Add Patient
        public static bool AddPatient(string codePatient,string nompatient,string adressepatient,DateTime dateembauche,string sexe)
        {
            DataRow drow = ds.Tables["Patient"].NewRow();
            drow[0] = codePatient;
            drow[1] = nompatient;
            drow[2] = adressepatient;
            drow[3] = dateembauche;
            drow[4] = sexe;
            ds.Tables["Patient"].Rows.Add(drow);
            UpdatePatient();
            return true;
        }
        // delete Patient by code patient
       public static bool DeletePatient(string codepatient)
        {
            bool exist =false;
            foreach (DataRow item in ds.Tables["Patient"].Rows)
            {
                if (item[0].ToString() == codepatient)
                {
                    item.Delete();
                    exist = true;
                    UpdatePatient();
                    FillRDV();
                    break;
                }
            }
            return exist;
        }
       
        // modify Patient 
        public static bool ModifyPatient(string codePatient, string nompatient, string adressepatient, DateTime datenaissance, string sexe)
        {

            DataRow drow =ds.Tables["Patient"].Rows.Find(codePatient);

            if(drow != null) {

                drow[1] = nompatient;
                drow[2] = adressepatient;
                drow[3] = datenaissance;
                drow[4] = sexe;

                UpdatePatient();
                FillPatient();
                return true;
            }

            return false;
        } 

















        public static void clearcontrols(GroupBox groupb)
        {


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
                if(C is RadioButton)
                {
                    var c2 = C as RadioButton;
                    c2.Checked = false;

                }
                if (C is MaskedTextBox) {
                    var c2 = C as MaskedTextBox;
                    C.Text = "";
                }


            }

        }
        public static bool checkcontrols(GroupBox groupbox) {
           
            int i = 0;
            foreach(Control c in groupbox.Controls)
            {
                if(c is TextBox)
                {               
                    var c2 = c as TextBox;
                    if (string.IsNullOrWhiteSpace(c2.Text)) { return true; }
                }else if(c is ComboBox)
                {
                    var c2 = c as ComboBox;
                    if (c2.SelectedIndex == -1) { return true; }

                }else if(c is DateTimePicker)
                {
                    var c2 = c as DateTimePicker;
                    if (string.IsNullOrWhiteSpace(c2.Value.ToString())) { return true; }
                }else if(c is RadioButton)
                {
                    var c2 = c as RadioButton;
                    if((c2.Checked==false) && i >= 2) { i++; return true; }


                }


            }


            return false;
        }

    }
}
