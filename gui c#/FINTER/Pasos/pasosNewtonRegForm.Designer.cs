namespace FINTER.Pasos
{
    partial class PasosNewtonRegForm
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
            this.gridDiferencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDiferencias
            // 
            this.gridDiferencias.AllowUserToAddRows = false;
            this.gridDiferencias.AllowUserToDeleteRows = false;
            this.gridDiferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiferencias.Location = new System.Drawing.Point(59, 128);
            this.gridDiferencias.Name = "gridDiferencias";
            this.gridDiferencias.ReadOnly = true;
            this.gridDiferencias.RowHeadersWidth = 51;
            this.gridDiferencias.RowTemplate.Height = 24;
            this.gridDiferencias.Size = new System.Drawing.Size(368, 254);
            this.gridDiferencias.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matriz de diferencias";
            // 
            // pasosNewtonRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDiferencias);
            this.Name = "pasosNewtonRegForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridDiferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDiferencias;
        private System.Windows.Forms.Label label1;
    }
}