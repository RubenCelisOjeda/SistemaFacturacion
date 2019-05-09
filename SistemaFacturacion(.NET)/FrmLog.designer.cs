namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmLog
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAce = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.linkOlvPas = new System.Windows.Forms.LinkLabel();
            this.linkReg = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Facturación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // txtUsu
            // 
            this.txtUsu.Location = new System.Drawing.Point(68, 242);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(286, 22);
            this.txtUsu.TabIndex = 3;
            this.txtUsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsu_KeyPress);
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(68, 308);
            this.txtPas.Name = "txtPas";
            this.txtPas.PasswordChar = '*';
            this.txtPas.Size = new System.Drawing.Size(286, 22);
            this.txtPas.TabIndex = 5;
            this.txtPas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPas_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // btnAce
            // 
            this.btnAce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAce.Location = new System.Drawing.Point(68, 361);
            this.btnAce.Name = "btnAce";
            this.btnAce.Size = new System.Drawing.Size(109, 32);
            this.btnAce.TabIndex = 6;
            this.btnAce.Text = "Aceptar";
            this.btnAce.UseVisualStyleBackColor = true;
            this.btnAce.Click += new System.EventHandler(this.btnAce_Click);
            // 
            // btnCan
            // 
            this.btnCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCan.Location = new System.Drawing.Point(245, 361);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(109, 32);
            this.btnCan.TabIndex = 7;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            // 
            // linkOlvPas
            // 
            this.linkOlvPas.AutoSize = true;
            this.linkOlvPas.Location = new System.Drawing.Point(11, 407);
            this.linkOlvPas.Name = "linkOlvPas";
            this.linkOlvPas.Size = new System.Drawing.Size(174, 17);
            this.linkOlvPas.TabIndex = 8;
            this.linkOlvPas.TabStop = true;
            this.linkOlvPas.Text = "¿Olvidaste tu contraseña?";
            this.linkOlvPas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkOlvPas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOlvPas_LinkClicked);
            // 
            // linkReg
            // 
            this.linkReg.AutoSize = true;
            this.linkReg.Location = new System.Drawing.Point(315, 407);
            this.linkReg.Name = "linkReg";
            this.linkReg.Size = new System.Drawing.Size(73, 17);
            this.linkReg.TabIndex = 9;
            this.linkReg.TabStop = true;
            this.linkReg.Text = "Registrate";
            this.linkReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReg_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaFacturacion_.NET_.Properties.Resources.sidebar_usuario_corporativo;
            this.pictureBox1.Location = new System.Drawing.Point(110, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 432);
            this.Controls.Add(this.linkReg);
            this.Controls.Add(this.linkOlvPas);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAce);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAce;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.LinkLabel linkOlvPas;
        private System.Windows.Forms.LinkLabel linkReg;
    }
}

