namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPro));
            this.gpbCotPro = new System.Windows.Forms.GroupBox();
            this.txtCli = new System.Windows.Forms.TextBox();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesCat = new System.Windows.Forms.TextBox();
            this.txtIdCat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnNue = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbCotPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCotPro
            // 
            this.gpbCotPro.Controls.Add(this.txtCli);
            this.gpbCotPro.Controls.Add(this.txtIdCli);
            this.gpbCotPro.Controls.Add(this.label5);
            this.gpbCotPro.Controls.Add(this.txtDesCat);
            this.gpbCotPro.Controls.Add(this.txtIdCat);
            this.gpbCotPro.Controls.Add(this.label4);
            this.gpbCotPro.Controls.Add(this.txtSto);
            this.gpbCotPro.Controls.Add(this.label3);
            this.gpbCotPro.Controls.Add(this.txtPre);
            this.gpbCotPro.Controls.Add(this.txtPro);
            this.gpbCotPro.Controls.Add(this.label2);
            this.gpbCotPro.Controls.Add(this.label1);
            this.gpbCotPro.Location = new System.Drawing.Point(12, 33);
            this.gpbCotPro.Name = "gpbCotPro";
            this.gpbCotPro.Size = new System.Drawing.Size(667, 248);
            this.gpbCotPro.TabIndex = 1;
            this.gpbCotPro.TabStop = false;
            this.gpbCotPro.Text = "Cotizador producto";
            // 
            // txtCli
            // 
            this.txtCli.ForeColor = System.Drawing.Color.Blue;
            this.txtCli.Location = new System.Drawing.Point(171, 209);
            this.txtCli.Name = "txtCli";
            this.txtCli.Size = new System.Drawing.Size(405, 22);
            this.txtCli.TabIndex = 12;
            this.txtCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCli_KeyPress);
            // 
            // txtIdCli
            // 
            this.txtIdCli.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtIdCli.Location = new System.Drawing.Point(92, 209);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(78, 22);
            this.txtIdCli.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cliente:";
            // 
            // txtDesCat
            // 
            this.txtDesCat.ForeColor = System.Drawing.Color.Blue;
            this.txtDesCat.Location = new System.Drawing.Point(171, 168);
            this.txtDesCat.Name = "txtDesCat";
            this.txtDesCat.Size = new System.Drawing.Size(405, 22);
            this.txtDesCat.TabIndex = 5;
            this.txtDesCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesCat_KeyPress);
            // 
            // txtIdCat
            // 
            this.txtIdCat.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtIdCat.Location = new System.Drawing.Point(92, 168);
            this.txtIdCat.Name = "txtIdCat";
            this.txtIdCat.Size = new System.Drawing.Size(78, 22);
            this.txtIdCat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categoria:";
            // 
            // txtSto
            // 
            this.txtSto.ForeColor = System.Drawing.Color.Blue;
            this.txtSto.Location = new System.Drawing.Point(298, 122);
            this.txtSto.Name = "txtSto";
            this.txtSto.Size = new System.Drawing.Size(266, 22);
            this.txtSto.TabIndex = 3;
            this.txtSto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stock";
            // 
            // txtPre
            // 
            this.txtPre.ForeColor = System.Drawing.Color.Blue;
            this.txtPre.Location = new System.Drawing.Point(26, 122);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(266, 22);
            this.txtPre.TabIndex = 2;
            this.txtPre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPre_KeyPress);
            // 
            // txtPro
            // 
            this.txtPro.ForeColor = System.Drawing.Color.Blue;
            this.txtPro.Location = new System.Drawing.Point(26, 65);
            this.txtPro.Name = "txtPro";
            this.txtPro.Size = new System.Drawing.Size(578, 22);
            this.txtPro.TabIndex = 1;
            this.txtPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomdre producto";
            // 
            // btnReg
            // 
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.Location = new System.Drawing.Point(13, 303);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(97, 37);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnNue
            // 
            this.btnNue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNue.Location = new System.Drawing.Point(116, 303);
            this.btnNue.Name = "btnNue";
            this.btnNue.Size = new System.Drawing.Size(97, 37);
            this.btnNue.TabIndex = 7;
            this.btnNue.Text = "Nuevo";
            this.btnNue.UseVisualStyleBackColor = true;
            this.btnNue.Click += new System.EventHandler(this.btnNue_Click);
            // 
            // btnCan
            // 
            this.btnCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCan.Location = new System.Drawing.Point(219, 303);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(97, 37);
            this.btnCan.TabIndex = 8;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaFacturacion_.NET_.Properties.Resources.carrito2;
            this.pictureBox1.Location = new System.Drawing.Point(704, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnNue);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.gpbCotPro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPro";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FrmPro_Load);
            this.gpbCotPro.ResumeLayout(false);
            this.gpbCotPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCotPro;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnNue;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtIdCat;
        public System.Windows.Forms.TextBox txtDesCat;
        public System.Windows.Forms.TextBox txtCli;
        public System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.Label label5;
    }
}