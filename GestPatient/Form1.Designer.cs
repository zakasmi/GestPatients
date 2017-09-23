namespace GestPatient
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesRDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherRDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesRDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.quiterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesMedecinToolStripMenuItem,
            this.gestionDesPatientToolStripMenuItem,
            this.gestionDesRDVToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // gestionDesMedecinToolStripMenuItem
            // 
            this.gestionDesMedecinToolStripMenuItem.Name = "gestionDesMedecinToolStripMenuItem";
            this.gestionDesMedecinToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gestionDesMedecinToolStripMenuItem.Text = "Gestion des Medecin";
            this.gestionDesMedecinToolStripMenuItem.Click += new System.EventHandler(this.gestionDesMedecinToolStripMenuItem_Click);
            // 
            // gestionDesPatientToolStripMenuItem
            // 
            this.gestionDesPatientToolStripMenuItem.Name = "gestionDesPatientToolStripMenuItem";
            this.gestionDesPatientToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gestionDesPatientToolStripMenuItem.Text = "Gestion des Patient";
            this.gestionDesPatientToolStripMenuItem.Click += new System.EventHandler(this.gestionDesPatientToolStripMenuItem_Click);
            // 
            // gestionDesRDVToolStripMenuItem
            // 
            this.gestionDesRDVToolStripMenuItem.Name = "gestionDesRDVToolStripMenuItem";
            this.gestionDesRDVToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gestionDesRDVToolStripMenuItem.Text = "Gestion des RDV";
            this.gestionDesRDVToolStripMenuItem.Click += new System.EventHandler(this.gestionDesRDVToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToutToolStripMenuItem,
            this.rechercherRDVToolStripMenuItem,
            this.afficherLesRDVToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // afficherToutToolStripMenuItem
            // 
            this.afficherToutToolStripMenuItem.Name = "afficherToutToolStripMenuItem";
            this.afficherToutToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.afficherToutToolStripMenuItem.Text = "Afficher tout ";
            this.afficherToutToolStripMenuItem.Click += new System.EventHandler(this.afficherToutToolStripMenuItem_Click);
            // 
            // rechercherRDVToolStripMenuItem
            // 
            this.rechercherRDVToolStripMenuItem.Name = "rechercherRDVToolStripMenuItem";
            this.rechercherRDVToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.rechercherRDVToolStripMenuItem.Text = "Rechercher RDV";
            this.rechercherRDVToolStripMenuItem.Click += new System.EventHandler(this.rechercherRDVToolStripMenuItem_Click);
            // 
            // afficherLesRDVToolStripMenuItem
            // 
            this.afficherLesRDVToolStripMenuItem.Name = "afficherLesRDVToolStripMenuItem";
            this.afficherLesRDVToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.afficherLesRDVToolStripMenuItem.Text = "Afficher les RDV d\'un Patient";
            this.afficherLesRDVToolStripMenuItem.Click += new System.EventHandler(this.afficherLesRDVToolStripMenuItem_Click);
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.quiterToolStripMenuItem.Text = "Quiter";
            this.quiterToolStripMenuItem.Click += new System.EventHandler(this.quiterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 434);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMedecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesRDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherRDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesRDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
    }
}

