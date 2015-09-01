namespace Projet
{
    partial class ConsoleAdminAccueil
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systèmeDExploitationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plateformeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systèmeDExploitationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plateformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retourInterfaceTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donnéesToolStripMenuItem,
            this.systèmeDExploitationToolStripMenuItem,
            this.plateformeToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1742, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donnéesToolStripMenuItem
            // 
            this.donnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systèmeDExploitationToolStripMenuItem1,
            this.plateformeToolStripMenuItem1,
            this.genreToolStripMenuItem,
            this.classificationToolStripMenuItem});
            this.donnéesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donnéesToolStripMenuItem.Name = "donnéesToolStripMenuItem";
            this.donnéesToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.donnéesToolStripMenuItem.Text = "Données";
            // 
            // systèmeDExploitationToolStripMenuItem1
            // 
            this.systèmeDExploitationToolStripMenuItem1.Name = "systèmeDExploitationToolStripMenuItem1";
            this.systèmeDExploitationToolStripMenuItem1.Size = new System.Drawing.Size(284, 32);
            this.systèmeDExploitationToolStripMenuItem1.Text = "Système d\'Exploitation";
            this.systèmeDExploitationToolStripMenuItem1.Click += new System.EventHandler(this.systèmeDExploitationToolStripMenuItem1_Click);
            // 
            // plateformeToolStripMenuItem1
            // 
            this.plateformeToolStripMenuItem1.Name = "plateformeToolStripMenuItem1";
            this.plateformeToolStripMenuItem1.Size = new System.Drawing.Size(284, 32);
            this.plateformeToolStripMenuItem1.Text = "Plateforme";
            this.plateformeToolStripMenuItem1.Click += new System.EventHandler(this.plateformeToolStripMenuItem1_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(284, 32);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // classificationToolStripMenuItem
            // 
            this.classificationToolStripMenuItem.Name = "classificationToolStripMenuItem";
            this.classificationToolStripMenuItem.Size = new System.Drawing.Size(284, 32);
            this.classificationToolStripMenuItem.Text = "Classification";
            // 
            // systèmeDExploitationToolStripMenuItem
            // 
            this.systèmeDExploitationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.systèmeDExploitationToolStripMenuItem.Name = "systèmeDExploitationToolStripMenuItem";
            this.systèmeDExploitationToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.systèmeDExploitationToolStripMenuItem.Text = "Sécurité";
            // 
            // plateformeToolStripMenuItem
            // 
            this.plateformeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.plateformeToolStripMenuItem.Name = "plateformeToolStripMenuItem";
            this.plateformeToolStripMenuItem.Size = new System.Drawing.Size(117, 32);
            this.plateformeToolStripMenuItem.Text = "Connexion";
            this.plateformeToolStripMenuItem.Click += new System.EventHandler(this.plateformeToolStripMenuItem_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retourInterfaceTestToolStripMenuItem});
            this.testsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
            this.testsToolStripMenuItem.Text = "Tests";
            // 
            // retourInterfaceTestToolStripMenuItem
            // 
            this.retourInterfaceTestToolStripMenuItem.Name = "retourInterfaceTestToolStripMenuItem";
            this.retourInterfaceTestToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.retourInterfaceTestToolStripMenuItem.Text = "Retour interface Test";
            this.retourInterfaceTestToolStripMenuItem.Click += new System.EventHandler(this.retourInterfaceTestToolStripMenuItem_Click);
            // 
            // ConsoleAdminAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 815);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsoleAdminAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console d\'Administration";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systèmeDExploitationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plateformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systèmeDExploitationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plateformeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retourInterfaceTestToolStripMenuItem;
    }
}

