namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmFac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFac));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumPag = new System.Windows.Forms.TextBox();
            this.txtFecEmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbCli = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNue = new System.Windows.Forms.Button();
            this.txtCorEle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAce = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.gpbCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de factura";
            // 
            // txtFac
            // 
            this.txtFac.ForeColor = System.Drawing.Color.Blue;
            this.txtFac.Location = new System.Drawing.Point(52, 68);
            this.txtFac.Name = "txtFac";
            this.txtFac.Size = new System.Drawing.Size(345, 22);
            this.txtFac.TabIndex = 1;
            this.txtFac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFac_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de pago";
            // 
            // txtNumPag
            // 
            this.txtNumPag.ForeColor = System.Drawing.Color.Blue;
            this.txtNumPag.Location = new System.Drawing.Point(419, 68);
            this.txtNumPag.Name = "txtNumPag";
            this.txtNumPag.Size = new System.Drawing.Size(228, 22);
            this.txtNumPag.TabIndex = 2;
            this.txtNumPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPag_KeyPress);
            // 
            // txtFecEmi
            // 
            this.txtFecEmi.ForeColor = System.Drawing.Color.Blue;
            this.txtFecEmi.Location = new System.Drawing.Point(664, 68);
            this.txtFecEmi.Name = "txtFecEmi";
            this.txtFecEmi.Size = new System.Drawing.Size(117, 22);
            this.txtFecEmi.TabIndex = 3;
            this.txtFecEmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Emisión";
            // 
            // gpbCli
            // 
            this.gpbCli.Controls.Add(this.txtId);
            this.gpbCli.Controls.Add(this.label8);
            this.gpbCli.Controls.Add(this.btnNue);
            this.gpbCli.Controls.Add(this.txtCorEle);
            this.gpbCli.Controls.Add(this.label7);
            this.gpbCli.Controls.Add(this.txtTel);
            this.gpbCli.Controls.Add(this.label6);
            this.gpbCli.Controls.Add(this.label5);
            this.gpbCli.Controls.Add(this.txtDir);
            this.gpbCli.Controls.Add(this.txtCli);
            this.gpbCli.Controls.Add(this.label4);
            this.gpbCli.Location = new System.Drawing.Point(52, 117);
            this.gpbCli.Name = "gpbCli";
            this.gpbCli.Size = new System.Drawing.Size(819, 197);
            this.gpbCli.TabIndex = 6;
            this.gpbCli.TabStop = false;
            this.gpbCli.Text = "Cliente";
            // 
            // txtId
            // 
            this.txtId.ForeColor = System.Drawing.Color.Blue;
            this.txtId.Location = new System.Drawing.Point(86, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(82, 22);
            this.txtId.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo:";
            // 
            // btnNue
            // 
            this.btnNue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNue.Location = new System.Drawing.Point(714, 161);
            this.btnNue.Name = "btnNue";
            this.btnNue.Size = new System.Drawing.Size(90, 30);
            this.btnNue.TabIndex = 8;
            this.btnNue.Text = "Nuevo";
            this.btnNue.UseVisualStyleBackColor = true;
            this.btnNue.Click += new System.EventHandler(this.btnNue_Click);
            // 
            // txtCorEle
            // 
            this.txtCorEle.ForeColor = System.Drawing.Color.Blue;
            this.txtCorEle.Location = new System.Drawing.Point(365, 75);
            this.txtCorEle.Name = "txtCorEle";
            this.txtCorEle.Size = new System.Drawing.Size(439, 22);
            this.txtCorEle.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Correo electrónico:";
            // 
            // txtTel
            // 
            this.txtTel.ForeColor = System.Drawing.Color.Blue;
            this.txtTel.Location = new System.Drawing.Point(86, 77);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(139, 22);
            this.txtTel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección:";
            // 
            // txtDir
            // 
            this.txtDir.ForeColor = System.Drawing.Color.Blue;
            this.txtDir.Location = new System.Drawing.Point(588, 34);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(216, 22);
            this.txtDir.TabIndex = 6;
            // 
            // txtCli
            // 
            this.txtCli.ForeColor = System.Drawing.Color.Blue;
            this.txtCli.Location = new System.Drawing.Point(314, 34);
            this.txtCli.Name = "txtCli";
            this.txtCli.Size = new System.Drawing.Size(172, 22);
            this.txtCli.TabIndex = 5;
            this.txtCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCli_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cliente /Empresa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaFacturacion_.NET_.Properties.Resources.libro;
            this.pictureBox1.Location = new System.Drawing.Point(959, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAce
            // 
            this.btnAce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAce.Location = new System.Drawing.Point(52, 320);
            this.btnAce.Name = "btnAce";
            this.btnAce.Size = new System.Drawing.Size(90, 30);
            this.btnAce.TabIndex = 9;
            this.btnAce.Text = "Aceptar";
            this.btnAce.UseVisualStyleBackColor = true;
            this.btnAce.Click += new System.EventHandler(this.btnAce_Click);
            // 
            // btnCan
            // 
            this.btnCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCan.Location = new System.Drawing.Point(148, 320);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(90, 30);
            this.btnCan.TabIndex = 10;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnLim
            // 
            this.btnLim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLim.Location = new System.Drawing.Point(244, 320);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(90, 30);
            this.btnLim.TabIndex = 11;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // FrmFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 405);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAce);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFecEmi);
            this.Controls.Add(this.txtNumPag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFac);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pre - Factura";
            this.Load += new System.EventHandler(this.FrmFac_Load);
            this.gpbCli.ResumeLayout(false);
            this.gpbCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumPag;
        private System.Windows.Forms.TextBox txtFecEmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCorEle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNue;
        private System.Windows.Forms.Button btnAce;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
    }
}