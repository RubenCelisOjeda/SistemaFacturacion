namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmNuePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuePass));
            this.btnCan = new System.Windows.Forms.Button();
            this.btnAce = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuePass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCan
            // 
            this.btnCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCan.Location = new System.Drawing.Point(149, 184);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(94, 31);
            this.btnCan.TabIndex = 9;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnAce
            // 
            this.btnAce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAce.Location = new System.Drawing.Point(49, 184);
            this.btnAce.Name = "btnAce";
            this.btnAce.Size = new System.Drawing.Size(94, 31);
            this.btnAce.TabIndex = 8;
            this.btnAce.Text = "Aceptar";
            this.btnAce.UseVisualStyleBackColor = true;
            this.btnAce.Click += new System.EventHandler(this.btnAce_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese nueva contraseña";
            // 
            // txtNuePass
            // 
            this.txtNuePass.Location = new System.Drawing.Point(49, 101);
            this.txtNuePass.Name = "txtNuePass";
            this.txtNuePass.Size = new System.Drawing.Size(550, 22);
            this.txtNuePass.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nueva contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirmar nueva contraseña";
            // 
            // txtConPass
            // 
            this.txtConPass.Location = new System.Drawing.Point(49, 156);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(550, 22);
            this.txtConPass.TabIndex = 10;
            // 
            // FrmNuePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNuePass);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNuePass";
            this.Text = "Recuperacion de contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnAce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConPass;
    }
}