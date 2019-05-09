namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmConsultarVarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarVarios));
            this.dgvConDat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConDat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConDat
            // 
            this.dgvConDat.AllowUserToAddRows = false;
            this.dgvConDat.AllowUserToDeleteRows = false;
            this.dgvConDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConDat.Location = new System.Drawing.Point(13, 12);
            this.dgvConDat.Name = "dgvConDat";
            this.dgvConDat.ReadOnly = true;
            this.dgvConDat.RowTemplate.Height = 24;
            this.dgvConDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConDat.Size = new System.Drawing.Size(899, 509);
            this.dgvConDat.TabIndex = 0;
            this.dgvConDat.DoubleClick += new System.EventHandler(this.dgvConDat_DoubleClick);
            this.dgvConDat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvConDat_KeyDown);
            // 
            // FrmConsultarVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 533);
            this.Controls.Add(this.dgvConDat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultarVarios";
            this.Text = "Consultar datos";
            this.Load += new System.EventHandler(this.FrmConsultarVarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultarVarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConDat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvConDat;
    }
}