namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmModPag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModPag));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumPag = new System.Windows.Forms.TextBox();
            this.txtNomPag = new System.Windows.Forms.TextBox();
            this.txtDetPago = new System.Windows.Forms.TextBox();
            this.btnAce = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalles:";
            // 
            // txtNumPag
            // 
            this.txtNumPag.Location = new System.Drawing.Point(185, 73);
            this.txtNumPag.Name = "txtNumPag";
            this.txtNumPag.Size = new System.Drawing.Size(245, 22);
            this.txtNumPag.TabIndex = 0;
            this.txtNumPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPag_KeyPress);
            // 
            // txtNomPag
            // 
            this.txtNomPag.Location = new System.Drawing.Point(185, 113);
            this.txtNomPag.Name = "txtNomPag";
            this.txtNomPag.Size = new System.Drawing.Size(245, 22);
            this.txtNomPag.TabIndex = 1;
            this.txtNomPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomPag_KeyPress);
            // 
            // txtDetPago
            // 
            this.txtDetPago.Location = new System.Drawing.Point(129, 164);
            this.txtDetPago.Multiline = true;
            this.txtDetPago.Name = "txtDetPago";
            this.txtDetPago.Size = new System.Drawing.Size(301, 51);
            this.txtDetPago.TabIndex = 2;
            this.txtDetPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetPago_KeyPress);
            // 
            // btnAce
            // 
            this.btnAce.Location = new System.Drawing.Point(129, 247);
            this.btnAce.Name = "btnAce";
            this.btnAce.Size = new System.Drawing.Size(101, 34);
            this.btnAce.TabIndex = 3;
            this.btnAce.Text = "Aceptar";
            this.btnAce.UseVisualStyleBackColor = true;
            this.btnAce.Click += new System.EventHandler(this.btnAce_Click);
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(329, 247);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(101, 34);
            this.btnCan.TabIndex = 4;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // FrmModPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 301);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAce);
            this.Controls.Add(this.txtDetPago);
            this.Controls.Add(this.txtNomPag);
            this.Controls.Add(this.txtNumPag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmModPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modo de pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumPag;
        private System.Windows.Forms.TextBox txtNomPag;
        private System.Windows.Forms.TextBox txtDetPago;
        private System.Windows.Forms.Button btnAce;
        private System.Windows.Forms.Button btnCan;
    }
}