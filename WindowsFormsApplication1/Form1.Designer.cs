namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescCourte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescLongue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.DescCourte,
            this.DescLongue,
            this.point});
            this.dataGridView1.Location = new System.Drawing.Point(20, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(450, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // DescCourte
            // 
            this.DescCourte.HeaderText = "Description courte";
            this.DescCourte.Name = "DescCourte";
            // 
            // DescLongue
            // 
            this.DescLongue.HeaderText = "Description longue";
            this.DescLongue.Name = "DescLongue";
            // 
            // point
            // 
            this.point.HeaderText = "...";
            this.point.Name = "point";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "liste des tables de codes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescCourte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescLongue;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

