namespace GestPatient
{
    partial class Gestion_RDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXB_GM_Code = new System.Windows.Forms.Label();
            this.TXB_GM_Nom = new System.Windows.Forms.Label();
            this.RB_GR_F = new System.Windows.Forms.RadioButton();
            this.RB_GR_M = new System.Windows.Forms.RadioButton();
            this.TXB_GM_Specialite = new System.Windows.Forms.Label();
            this.CB_GR_CodePatient = new System.Windows.Forms.ComboBox();
            this.TXB_GR_NomPatient = new System.Windows.Forms.TextBox();
            this.DTP_GR_DateRDV = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_GM_DateEmbauche = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_GR_CodeMedecin = new System.Windows.Forms.ComboBox();
            this.TXB_GR_NomMedecin = new System.Windows.Forms.TextBox();
            this.TXB_GR_SpecialiteMedecin = new System.Windows.Forms.TextBox();
            this.BTN_GR_AjouterRDV = new System.Windows.Forms.Button();
            this.BTN_GR_Nouveau = new System.Windows.Forms.Button();
            this.BTN_GR_Quitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXB_GR_HeureRDV = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXB_GM_Code
            // 
            this.TXB_GM_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_GM_Code.ForeColor = System.Drawing.Color.Black;
            this.TXB_GM_Code.Location = new System.Drawing.Point(16, 24);
            this.TXB_GM_Code.Name = "TXB_GM_Code";
            this.TXB_GM_Code.Size = new System.Drawing.Size(106, 18);
            this.TXB_GM_Code.TabIndex = 3;
            this.TXB_GM_Code.Text = "Code Patient";
            // 
            // TXB_GM_Nom
            // 
            this.TXB_GM_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_GM_Nom.ForeColor = System.Drawing.Color.Black;
            this.TXB_GM_Nom.Location = new System.Drawing.Point(16, 62);
            this.TXB_GM_Nom.Name = "TXB_GM_Nom";
            this.TXB_GM_Nom.Size = new System.Drawing.Size(106, 20);
            this.TXB_GM_Nom.TabIndex = 4;
            this.TXB_GM_Nom.Text = "Nom Patient";
            // 
            // RB_GR_F
            // 
            this.RB_GR_F.AutoSize = true;
            this.RB_GR_F.ForeColor = System.Drawing.Color.Black;
            this.RB_GR_F.Location = new System.Drawing.Point(250, 102);
            this.RB_GR_F.Name = "RB_GR_F";
            this.RB_GR_F.Size = new System.Drawing.Size(34, 21);
            this.RB_GR_F.TabIndex = 10;
            this.RB_GR_F.TabStop = true;
            this.RB_GR_F.Text = "F";
            this.RB_GR_F.UseVisualStyleBackColor = true;
            // 
            // RB_GR_M
            // 
            this.RB_GR_M.AutoSize = true;
            this.RB_GR_M.ForeColor = System.Drawing.Color.Black;
            this.RB_GR_M.Location = new System.Drawing.Point(179, 102);
            this.RB_GR_M.Name = "RB_GR_M";
            this.RB_GR_M.Size = new System.Drawing.Size(37, 21);
            this.RB_GR_M.TabIndex = 9;
            this.RB_GR_M.TabStop = true;
            this.RB_GR_M.Text = "M";
            this.RB_GR_M.UseVisualStyleBackColor = true;
            // 
            // TXB_GM_Specialite
            // 
            this.TXB_GM_Specialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_GM_Specialite.ForeColor = System.Drawing.Color.Black;
            this.TXB_GM_Specialite.Location = new System.Drawing.Point(16, 102);
            this.TXB_GM_Specialite.Name = "TXB_GM_Specialite";
            this.TXB_GM_Specialite.Size = new System.Drawing.Size(106, 17);
            this.TXB_GM_Specialite.TabIndex = 8;
            this.TXB_GM_Specialite.Text = "Sexe Patient";
            // 
            // CB_GR_CodePatient
            // 
            this.CB_GR_CodePatient.FormattingEnabled = true;
            this.CB_GR_CodePatient.Location = new System.Drawing.Point(154, 23);
            this.CB_GR_CodePatient.Name = "CB_GR_CodePatient";
            this.CB_GR_CodePatient.Size = new System.Drawing.Size(150, 24);
            this.CB_GR_CodePatient.TabIndex = 12;
            this.CB_GR_CodePatient.SelectedIndexChanged += new System.EventHandler(this.CB_GR_CodePatient_SelectedIndexChanged);
            // 
            // TXB_GR_NomPatient
            // 
            this.TXB_GR_NomPatient.Enabled = false;
            this.TXB_GR_NomPatient.Location = new System.Drawing.Point(154, 62);
            this.TXB_GR_NomPatient.Name = "TXB_GR_NomPatient";
            this.TXB_GR_NomPatient.Size = new System.Drawing.Size(150, 23);
            this.TXB_GR_NomPatient.TabIndex = 11;
            // 
            // DTP_GR_DateRDV
            // 
            this.DTP_GR_DateRDV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_GR_DateRDV.Location = new System.Drawing.Point(154, 25);
            this.DTP_GR_DateRDV.Name = "DTP_GR_DateRDV";
            this.DTP_GR_DateRDV.Size = new System.Drawing.Size(150, 23);
            this.DTP_GR_DateRDV.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Heure RDV";
            // 
            // TXB_GM_DateEmbauche
            // 
            this.TXB_GM_DateEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_GM_DateEmbauche.ForeColor = System.Drawing.Color.Black;
            this.TXB_GM_DateEmbauche.Location = new System.Drawing.Point(16, 25);
            this.TXB_GM_DateEmbauche.Name = "TXB_GM_DateEmbauche";
            this.TXB_GM_DateEmbauche.Size = new System.Drawing.Size(93, 17);
            this.TXB_GM_DateEmbauche.TabIndex = 14;
            this.TXB_GM_DateEmbauche.Text = "Date RDV";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom Medecin";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code Medecin";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Specialite Medecin";
            // 
            // CB_GR_CodeMedecin
            // 
            this.CB_GR_CodeMedecin.FormattingEnabled = true;
            this.CB_GR_CodeMedecin.Location = new System.Drawing.Point(201, 23);
            this.CB_GR_CodeMedecin.Name = "CB_GR_CodeMedecin";
            this.CB_GR_CodeMedecin.Size = new System.Drawing.Size(150, 24);
            this.CB_GR_CodeMedecin.TabIndex = 12;
            this.CB_GR_CodeMedecin.SelectedIndexChanged += new System.EventHandler(this.CB_GR_CodeMedecin_SelectedIndexChanged);
            // 
            // TXB_GR_NomMedecin
            // 
            this.TXB_GR_NomMedecin.Enabled = false;
            this.TXB_GR_NomMedecin.Location = new System.Drawing.Point(201, 62);
            this.TXB_GR_NomMedecin.Name = "TXB_GR_NomMedecin";
            this.TXB_GR_NomMedecin.Size = new System.Drawing.Size(150, 23);
            this.TXB_GR_NomMedecin.TabIndex = 11;
            // 
            // TXB_GR_SpecialiteMedecin
            // 
            this.TXB_GR_SpecialiteMedecin.Enabled = false;
            this.TXB_GR_SpecialiteMedecin.Location = new System.Drawing.Point(201, 100);
            this.TXB_GR_SpecialiteMedecin.Name = "TXB_GR_SpecialiteMedecin";
            this.TXB_GR_SpecialiteMedecin.Size = new System.Drawing.Size(150, 23);
            this.TXB_GR_SpecialiteMedecin.TabIndex = 11;
            // 
            // BTN_GR_AjouterRDV
            // 
            this.BTN_GR_AjouterRDV.Location = new System.Drawing.Point(425, 210);
            this.BTN_GR_AjouterRDV.Name = "BTN_GR_AjouterRDV";
            this.BTN_GR_AjouterRDV.Size = new System.Drawing.Size(281, 37);
            this.BTN_GR_AjouterRDV.TabIndex = 16;
            this.BTN_GR_AjouterRDV.Text = "Ajouter RDV";
            this.BTN_GR_AjouterRDV.UseVisualStyleBackColor = true;
            this.BTN_GR_AjouterRDV.Click += new System.EventHandler(this.BTN_GR_AjouterRDV_Click);
            // 
            // BTN_GR_Nouveau
            // 
            this.BTN_GR_Nouveau.Location = new System.Drawing.Point(425, 261);
            this.BTN_GR_Nouveau.Name = "BTN_GR_Nouveau";
            this.BTN_GR_Nouveau.Size = new System.Drawing.Size(130, 37);
            this.BTN_GR_Nouveau.TabIndex = 16;
            this.BTN_GR_Nouveau.Text = "Nouveau";
            this.BTN_GR_Nouveau.UseVisualStyleBackColor = true;
            this.BTN_GR_Nouveau.Click += new System.EventHandler(this.BTN_GR_Nouveau_Click);
            // 
            // BTN_GR_Quitter
            // 
            this.BTN_GR_Quitter.Location = new System.Drawing.Point(576, 262);
            this.BTN_GR_Quitter.Name = "BTN_GR_Quitter";
            this.BTN_GR_Quitter.Size = new System.Drawing.Size(130, 37);
            this.BTN_GR_Quitter.TabIndex = 16;
            this.BTN_GR_Quitter.Text = "Quuitter";
            this.BTN_GR_Quitter.UseVisualStyleBackColor = true;
            this.BTN_GR_Quitter.Click += new System.EventHandler(this.BTN_GR_Quitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXB_GR_HeureRDV);
            this.groupBox1.Controls.Add(this.TXB_GM_DateEmbauche);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DTP_GR_DateRDV);
            this.groupBox1.Location = new System.Drawing.Point(26, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 109);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // TXB_GR_HeureRDV
            // 
            this.TXB_GR_HeureRDV.Location = new System.Drawing.Point(154, 67);
            this.TXB_GR_HeureRDV.Mask = "00:00";
            this.TXB_GR_HeureRDV.Name = "TXB_GR_HeureRDV";
            this.TXB_GR_HeureRDV.Size = new System.Drawing.Size(150, 23);
            this.TXB_GR_HeureRDV.TabIndex = 16;
            this.TXB_GR_HeureRDV.ValidatingType = typeof(System.DateTime);
            this.TXB_GR_HeureRDV.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.TXB_GR_HeureRDV_TypeValidationCompleted);
            this.TXB_GR_HeureRDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_GR_HeureRDV_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXB_GM_Code);
            this.groupBox2.Controls.Add(this.TXB_GM_Nom);
            this.groupBox2.Controls.Add(this.TXB_GM_Specialite);
            this.groupBox2.Controls.Add(this.RB_GR_M);
            this.groupBox2.Controls.Add(this.RB_GR_F);
            this.groupBox2.Controls.Add(this.TXB_GR_NomPatient);
            this.groupBox2.Controls.Add(this.CB_GR_CodePatient);
            this.groupBox2.Location = new System.Drawing.Point(26, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 142);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TXB_GR_NomMedecin);
            this.groupBox3.Controls.Add(this.TXB_GR_SpecialiteMedecin);
            this.groupBox3.Controls.Add(this.CB_GR_CodeMedecin);
            this.groupBox3.Location = new System.Drawing.Point(382, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 142);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.BTN_GR_Quitter);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.BTN_GR_AjouterRDV);
            this.groupBox4.Controls.Add(this.BTN_GR_Nouveau);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(778, 328);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gestion des Rendez-vous";
            // 
            // Gestion_RDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 365);
            this.Controls.Add(this.groupBox4);
            this.Name = "Gestion_RDV";
            this.Text = "Gestion_RDV";
            this.Load += new System.EventHandler(this.Gestion_RDV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TXB_GM_Code;
        private System.Windows.Forms.Label TXB_GM_Nom;
        private System.Windows.Forms.RadioButton RB_GR_F;
        private System.Windows.Forms.RadioButton RB_GR_M;
        private System.Windows.Forms.Label TXB_GM_Specialite;
        private System.Windows.Forms.ComboBox CB_GR_CodePatient;
        private System.Windows.Forms.TextBox TXB_GR_NomPatient;
        private System.Windows.Forms.DateTimePicker DTP_GR_DateRDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TXB_GM_DateEmbauche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_GR_CodeMedecin;
        private System.Windows.Forms.TextBox TXB_GR_NomMedecin;
        private System.Windows.Forms.TextBox TXB_GR_SpecialiteMedecin;
        private System.Windows.Forms.Button BTN_GR_AjouterRDV;
        private System.Windows.Forms.Button BTN_GR_Nouveau;
        private System.Windows.Forms.Button BTN_GR_Quitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox TXB_GR_HeureRDV;
    }
}