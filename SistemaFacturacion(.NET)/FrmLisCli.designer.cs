namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmLisCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLisCli));
            this.dgvCli = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCli
            // 
            this.dgvCli.AllowUserToAddRows = false;
            this.dgvCli.AllowUserToDeleteRows = false;
            this.dgvCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCli.Location = new System.Drawing.Point(13, 56);
            this.dgvCli.Name = "dgvCli";
            this.dgvCli.ReadOnly = true;
            this.dgvCli.RowTemplate.Height = 24;
            this.dgvCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCli.Size = new System.Drawing.Size(1206, 621);
            this.dgvCli.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // txtCli
            // 
            this.txtCli.Location = new System.Drawing.Point(74, 13);
            this.txtCli.Name = "txtCli";
            this.txtCli.Size = new System.Drawing.Size(1145, 22);
            this.txtCli.TabIndex = 1;
            this.txtCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCli_KeyPress);
            // 
            // FrmLisCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 689);
            this.Controls.Add(this.txtCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLisCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de clientes";
            this.Load += new System.EventHandler(this.FrmRecCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCli;
    }
}