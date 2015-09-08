namespace Projet
{
    partial class frmGesClass
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
            this.dataGridClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClass
            // 
            this.dataGridClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClass.Location = new System.Drawing.Point(12, 71);
            this.dataGridClass.Name = "dataGridClass";
            this.dataGridClass.RowTemplate.Height = 24;
            this.dataGridClass.Size = new System.Drawing.Size(1058, 381);
            this.dataGridClass.TabIndex = 51;
            // 
            // frmGesClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.dataGridClass);
            this.Name = "frmGesClass";
            this.Text = "Gestion - Classification";
            this.Load += new System.EventHandler(this.frmGesClass_Load);
            this.Controls.SetChildIndex(this.dataGridClass, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClass;
    }
}