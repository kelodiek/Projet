namespace Projet
{
    partial class frmGesJeu
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
            this.GridJeux = new System.Windows.Forms.DataGridView();
            this.gridNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDateSortie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridJeux)).BeginInit();
            this.SuspendLayout();
            // 
            // GridJeux
            // 
            this.GridJeux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridJeux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridNom,
            this.gridDateSortie,
            this.gridGenre,
            this.gridTheme,
            this.gridMode,
            this.gridVersion});
            this.GridJeux.Location = new System.Drawing.Point(12, 71);
            this.GridJeux.Name = "GridJeux";
            this.GridJeux.RowTemplate.Height = 24;
            this.GridJeux.Size = new System.Drawing.Size(1058, 381);
            this.GridJeux.TabIndex = 51;
            // 
            // gridNom
            // 
            this.gridNom.HeaderText = "Nom";
            this.gridNom.Name = "gridNom";
            this.gridNom.Width = 150;
            // 
            // gridDateSortie
            // 
            this.gridDateSortie.HeaderText = "Date de Sortie";
            this.gridDateSortie.Name = "gridDateSortie";
            this.gridDateSortie.Width = 150;
            // 
            // gridGenre
            // 
            this.gridGenre.HeaderText = "Genre";
            this.gridGenre.Name = "gridGenre";
            this.gridGenre.Width = 125;
            // 
            // gridTheme
            // 
            this.gridTheme.HeaderText = "Thème";
            this.gridTheme.Name = "gridTheme";
            this.gridTheme.Width = 150;
            // 
            // gridMode
            // 
            this.gridMode.HeaderText = "Mode";
            this.gridMode.Name = "gridMode";
            this.gridMode.Width = 150;
            // 
            // gridVersion
            // 
            this.gridVersion.HeaderText = "Version";
            this.gridVersion.Name = "gridVersion";
            this.gridVersion.Width = 150;
            // 
            // frmGesJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.GridJeux);
            this.Name = "frmGesJeu";
            this.Text = "frmGesJeu";
            this.Controls.SetChildIndex(this.GridJeux, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridJeux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView GridJeux;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDateSortie;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridVersion;
    }
}