using CapaEntidades.Login;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    public partial class FrmRegUsu : Form
    {
        private NLog log = new NLog();

        public FrmRegUsu()
        {
            InitializeComponent();
        }

        private void btnReg_Click_1(object sender, EventArgs e)
        {
            ///Valida los campos de texto
            if (txtNom.Text == "")
            {
                MessageBox.Show("Ingrese su nombre", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNom.Focus();
            }
            else if (txtApe.Text == "")
            {
                MessageBox.Show("Ingrese su apellido", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApe.Focus();
            }
            else if (txtDir.Text == "")
            {
                MessageBox.Show("Ingrese su dirección", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDir.Focus();
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Ingrese su teléfono", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTel.Focus();
            }
            else if (txtEma.Text == "")
            {
                MessageBox.Show("Ingrese su correo electrónico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEma.Focus();
            }
            else if (txtUsu.Text == "")
            {
                MessageBox.Show("Ingrese un usuario", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsu.Focus();
            }
            else if (txtCon.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCon.Focus();
            }
            else
            {
                ///Valida el campo de texto Email
                bool valor = false;
                try
                {
                    new System.Net.Mail.MailAddress(txtEma.Text);
                    valor = true;
                }
                catch
                {
                    valor = false;
                }

                ///Valida el valor
                if (!valor)
                {
                    MessageBox.Show("Correo ingresado es inválido", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEma.Focus();
                    return;
                }

                ///Guardamos los textos en la entidad
                Usuario_Enc Usu = new Usuario_Enc();
                Usu.Nom = txtNom.Text;
                Usu.Ape = txtApe.Text;
                Usu.Dir = txtDir.Text;
                Usu.Tel = txtTel.Text;
                Usu.Ema = txtEma.Text;
                Usu.Usu = txtUsu.Text;
                Usu.Pass = txtCon.Text;

                ///Ejecutamos el procedimiento
                log.Log_InsUsu(Usu); 
                MessageBox.Show("Se registro correctamene", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RegCli_LimText();
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            RegCli_LimText();
        }

        private void RegCli_LimText()
        {
            ///Recorre y limpia las cajas de texto y el datapicker,cierra el formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) control.Text = "";
                if(control is DateTimePicker) ((DateTimePicker)control).Value = DateTime.Now.Date;
            }

            this.Close();
        }
    }
}
