namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmCamPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCamPass));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConAct = new System.Windows.Forms.TextBox();
            this.txtNueCon = new System.Windows.Forms.TextBox();
            this.txtConCon = new System.Windows.Forms.TextBox();
            this.btnAce = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña actual:";
            // 
            // txtConAct
            // 
            this.txtConAct.ForeColor = System.Drawing.Color.Blue;
            this.txtConAct.Location = new System.Drawing.Point(205, 71);
            this.txtConAct.Name = "txtConAct";
            this.txtConAct.PasswordChar = '*';
            this.txtConAct.Size = new System.Drawing.Size(208, 22);
            this.txtConAct.TabIndex = 0;
            // 
            // txtNueCon
            // 
            this.txtNueCon.ForeColor = System.Drawing.Color.Blue;
            this.txtNueCon.Location = new System.Drawing.Point(205, 121);
            this.txtNueCon.Name = "txtNueCon";
            this.txtNueCon.PasswordChar = '*';
            this.txtNueCon.Size = new System.Drawing.Size(208, 22);
            this.txtNueCon.TabIndex = 1;
            // 
            // txtConCon
            // 
            this.txtConCon.ForeColor = System.Drawing.Color.Blue;
            this.txtConCon.Location = new System.Drawing.Point(205, 172);
            this.txtConCon.Name = "txtConCon";
            this.txtConCon.PasswordChar = '*';
            this.txtConCon.Size = new System.Drawing.Size(208, 22);
            this.txtConCon.TabIndex = 2;
            // 
            // btnAce
            // 
            this.btnAce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAce.Location = new System.Drawing.Point(115, 237);
            this.btnAce.Name = "btnAce";
            this.btnAce.Size = new System.Drawing.Size(113, 35);
            this.btnAce.TabIndex = 3;
            this.btnAce.Text = "Aceptar";
            this.btnAce.UseVisualStyleBackColor = true;
            this.btnAce.Click += new System.EventHandler(this.btnAce_Click);
            // 
            // btnCan
            // 
            this.btnCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCan.Location = new System.Drawing.Point(279, 237);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(113, 35);
            this.btnCan.TabIndex = 4;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // FrmCamPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 325);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAce);
            this.Controls.Add(this.txtConCon);
            this.Controls.Add(this.txtNueCon);
            this.Controls.Add(this.txtConAct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCamPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConAct;
        private System.Windows.Forms.TextBox txtNueCon;
        private System.Windows.Forms.TextBox txtConCon;
        private System.Windows.Forms.Button btnAce;
        private System.Windows.Forms.Button btnCan;
    }
}