namespace GestPatient
{
    partial class Afficher_Tout
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Afficher_Tout_RDV = new System.Windows.Forms.RadioButton();
            this.RB_Afficher_Tout_Patients = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.DGV_Afficher_Tout = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Afficher_Tout)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Afficher_Tout_RDV);
            this.groupBox1.Controls.Add(this.RB_Afficher_Tout_Patients);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix";
            // 
            // RB_Afficher_Tout_RDV
            // 
            this.RB_Afficher_Tout_RDV.AutoSize = true;
            this.RB_Afficher_Tout_RDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Afficher_Tout_RDV.Location = new System.Drawing.Point(502, 29);
            this.RB_Afficher_Tout_RDV.Name = "RB_Afficher_Tout_RDV";
            this.RB_Afficher_Tout_RDV.Size = new System.Drawing.Size(119, 22);
            this.RB_Afficher_Tout_RDV.TabIndex = 1;
            this.RB_Afficher_Tout_RDV.Text = "Tout Les RDV";
            this.RB_Afficher_Tout_RDV.UseVisualStyleBackColor = true;
            this.RB_Afficher_Tout_RDV.CheckedChanged += new System.EventHandler(this.RB_Afficher_Tout_RDV_CheckedChanged);
            // 
            // RB_Afficher_Tout_Patients
            // 
            this.RB_Afficher_Tout_Patients.AutoSize = true;
            this.RB_Afficher_Tout_Patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Afficher_Tout_Patients.Location = new System.Drawing.Point(277, 29);
            this.RB_Afficher_Tout_Patients.Name = "RB_Afficher_Tout_Patients";
            this.RB_Afficher_Tout_Patients.Size = new System.Drawing.Size(141, 22);
            this.RB_Afficher_Tout_Patients.TabIndex = 2;
            this.RB_Afficher_Tout_Patients.Text = "Tout Les Patients";
            this.RB_Afficher_Tout_Patients.UseVisualStyleBackColor = true;
            this.RB_Afficher_Tout_Patients.CheckedChanged += new System.EventHandler(this.RB_Afficher_Tout_Patients_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(51, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 22);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Tout Les Medecins";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DGV_Afficher_Tout
            // 
            this.DGV_Afficher_Tout.AllowUserToAddRows = false;
            this.DGV_Afficher_Tout.AllowUserToDeleteRows = false;
            this.DGV_Afficher_Tout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Afficher_Tout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Afficher_Tout.Location = new System.Drawing.Point(37, 117);
            this.DGV_Afficher_Tout.Name = "DGV_Afficher_Tout";
            this.DGV_Afficher_Tout.ReadOnly = true;
            this.DGV_Afficher_Tout.Size = new System.Drawing.Size(674, 207);
            this.DGV_Afficher_Tout.TabIndex = 1;
            // 
            // Afficher_Tout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 361);
            this.Controls.Add(this.DGV_Afficher_Tout);
            this.Controls.Add(this.groupBox1);
            this.Name = "Afficher_Tout";
            this.Text = "Afficher_Tout";
            this.Load += new System.EventHandler(this.Afficher_Tout_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Afficher_Tout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Afficher_Tout_RDV;
        private System.Windows.Forms.RadioButton RB_Afficher_Tout_Patients;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView DGV_Afficher_Tout;
    }
}