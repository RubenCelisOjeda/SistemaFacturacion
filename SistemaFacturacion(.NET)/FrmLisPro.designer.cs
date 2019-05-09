namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmLisPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLisPro));
            this.txtProArt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLisPro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLisPro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProArt
            // 
            this.txtProArt.Location = new System.Drawing.Point(137, 12);
            this.txtProArt.Name = "txtProArt";
            this.txtProArt.Size = new System.Drawing.Size(1096, 22);
            this.txtProArt.TabIndex = 1;
            this.txtProArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProArt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto/Articulo:";
            // 
            // dgvLisPro
            // 
            this.dgvLisPro.AllowUserToAddRows = false;
            this.dgvLisPro.AllowUserToDeleteRows = false;
            this.dgvLisPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLisPro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLisPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLisPro.Location = new System.Drawing.Point(12, 40);
            this.dgvLisPro.Name = "dgvLisPro";
            this.dgvLisPro.ReadOnly = true;
            this.dgvLisPro.RowTemplate.Height = 24;
            this.dgvLisPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLisPro.Size = new System.Drawing.Size(1221, 649);
            this.dgvLisPro.TabIndex = 2;
            // 
            // FrmLisPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 701);
            this.Controls.Add(this.txtProArt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLisPro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLisPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista productos";
            this.Load += new System.EventHandler(this.FrmLisPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLisPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLisPro;
    }
}