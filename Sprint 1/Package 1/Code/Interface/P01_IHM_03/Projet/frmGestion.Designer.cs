namespace Projet
{
    partial class frmGestion
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnDonneToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSysExpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlateToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenreToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClassToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSecuriteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnexionToolsTrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTestToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.retourInterfaceTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitterToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(945, 458);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(125, 35);
            this.btnSupprimer.TabIndex = 47;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(814, 458);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(125, 35);
            this.btnDetails.TabIndex = 46;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(687, 458);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(125, 35);
            this.btnAjout.TabIndex = 45;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(26, 40);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(149, 22);
            this.txtRecherche.TabIndex = 48;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(181, 38);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(100, 27);
            this.btnRecherche.TabIndex = 49;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDonneToolStrip,
            this.btnSecuriteToolStrip,
            this.btnConnexionToolsTrip,
            this.btnTestToolStrip,
            this.btnQuitterToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 31);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnDonneToolStrip
            // 
            this.btnDonneToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSysExpToolStrip,
            this.btnPlateToolStrip,
            this.btnGenreToolStrip,
            this.btnClassToolStrip});
            this.btnDonneToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDonneToolStrip.Name = "btnDonneToolStrip";
            this.btnDonneToolStrip.Size = new System.Drawing.Size(89, 27);
            this.btnDonneToolStrip.Text = "Données";
            // 
            // btnSysExpToolStrip
            // 
            this.btnSysExpToolStrip.Name = "btnSysExpToolStrip";
            this.btnSysExpToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnSysExpToolStrip.Text = "Système d\'Exploitation";
            this.btnSysExpToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // btnPlateToolStrip
            // 
            this.btnPlateToolStrip.Name = "btnPlateToolStrip";
            this.btnPlateToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnPlateToolStrip.Text = "Plateforme";
            this.btnPlateToolStrip.Click += new System.EventHandler(this.donneesToolStrip_Click);
            // 
            // btnGenreToolStrip
            // 
            this.btnGenreToolStrip.Name = "btnGenreToolStrip";
            this.btnGenreToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnGenreToolStrip.Text = "Genre";
            // 
            // btnClassToolStrip
            // 
            this.btnClassToolStrip.Name = "btnClassToolStrip";
            this.btnClassToolStrip.Size = new System.Drawing.Size(252, 28);
            this.btnClassToolStrip.Text = "Classification";
            // 
            // btnSecuriteToolStrip
            // 
            this.btnSecuriteToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSecuriteToolStrip.Name = "btnSecuriteToolStrip";
            this.btnSecuriteToolStrip.Size = new System.Drawing.Size(83, 27);
            this.btnSecuriteToolStrip.Text = "Sécurité";
            // 
            // btnConnexionToolsTrip
            // 
            this.btnConnexionToolsTrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConnexionToolsTrip.Name = "btnConnexionToolsTrip";
            this.btnConnexionToolsTrip.Size = new System.Drawing.Size(104, 27);
            this.btnConnexionToolsTrip.Text = "Connexion";
            // 
            // btnTestToolStrip
            // 
            this.btnTestToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retourInterfaceTestToolStripMenuItem});
            this.btnTestToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTestToolStrip.Name = "btnTestToolStrip";
            this.btnTestToolStrip.Size = new System.Drawing.Size(60, 27);
            this.btnTestToolStrip.Text = "Tests";
            // 
            // retourInterfaceTestToolStripMenuItem
            // 
            this.retourInterfaceTestToolStripMenuItem.Name = "retourInterfaceTestToolStripMenuItem";
            this.retourInterfaceTestToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.retourInterfaceTestToolStripMenuItem.Text = "Retour interface Test";
            // 
            // btnQuitterToolStrip
            // 
            this.btnQuitterToolStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuitterToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuitterToolStrip.Name = "btnQuitterToolStrip";
            this.btnQuitterToolStrip.Size = new System.Drawing.Size(76, 27);
            this.btnQuitterToolStrip.Text = "Quitter";
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnAjout);
            this.Name = "frmGestion";
            this.Text = "frmGestion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSupprimer;
        internal System.Windows.Forms.Button btnDetails;
        internal System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox txtRecherche;
        internal System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDonneToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnSysExpToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnPlateToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnGenreToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnClassToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnSecuriteToolStrip;
        private System.Windows.Forms.ToolStripMenuItem btnConnexionToolsTrip;
        private System.Windows.Forms.ToolStripMenuItem btnTestToolStrip;
        private System.Windows.Forms.ToolStripMenuItem retourInterfaceTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQuitterToolStrip;
    }
}