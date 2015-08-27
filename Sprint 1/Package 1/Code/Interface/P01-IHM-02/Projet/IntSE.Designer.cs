namespace Projet
{
    partial class IntSE
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sécuritéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.systèmeDExploitationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Édition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Code,
            this.Nom,
            this.Édition,
            this.Version,
            this.Supprimer});
            this.dataGridView1.Location = new System.Drawing.Point(27, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donéeToolStripMenuItem,
            this.sécuritéToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donéeToolStripMenuItem
            // 
            this.donéeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systèmeDExploitationToolStripMenuItem});
            this.donéeToolStripMenuItem.Name = "donéeToolStripMenuItem";
            this.donéeToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.donéeToolStripMenuItem.Text = "Donnée";
            // 
            // sécuritéToolStripMenuItem
            // 
            this.sécuritéToolStripMenuItem.Name = "sécuritéToolStripMenuItem";
            this.sécuritéToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.sécuritéToolStripMenuItem.Text = "Sécurité";
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRecherche.Location = new System.Drawing.Point(28, 59);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(253, 30);
            this.txtRecherche.TabIndex = 2;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(287, 59);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(125, 30);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAjouter.Location = new System.Drawing.Point(582, 432);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(140, 32);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // systèmeDExploitationToolStripMenuItem
            // 
            this.systèmeDExploitationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem});
            this.systèmeDExploitationToolStripMenuItem.Name = "systèmeDExploitationToolStripMenuItem";
            this.systèmeDExploitationToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.systèmeDExploitationToolStripMenuItem.Text = "Système d\'Exploitation";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 10;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Édition
            // 
            this.Édition.HeaderText = "Édition";
            this.Édition.Name = "Édition";
            this.Édition.Width = 175;
            // 
            // Version
            // 
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.Width = 150;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supp.";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.UseColumnTextForButtonValue = true;
            this.Supprimer.Width = 50;
            // 
            // IntSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 495);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IntSE";
            this.Text = "Systeme Exploitation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sécuritéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ToolStripMenuItem systèmeDExploitationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Édition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}

