using CapaEntidades.Cliente;
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
    public partial class FrmCli : Form
    {
        private NCli regCli = new NCli();

        public FrmCli()
        {
            InitializeComponent();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Cli_LimText();
        }
        private void Cli_LimText()
        {
            ///Recorre y limpia las cajas de texto y el datapicker,cierra el formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is DateTimePicker) ((DateTimePicker)control).Value = DateTime.Now.Date;
            }

            this.Close();
        }

        private void btnGua_Click(object sender, EventArgs e)
        {
            if (txtNomCli.Text == "")
            {
                MessageBox.Show("Ingrese el nombre","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNomCli.Focus();
            }
            else if(txtApeCli.Text == "")
            {
                MessageBox.Show("Ingrese el apellido", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApeCli.Focus();
            }
            else if (txtDirCli.Text == "")
            {
                MessageBox.Show("Ingrese la dirección", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApeCli.Focus();
            }
            else if (txtTelCli.Text == "")
            {
                MessageBox.Show("Ingrese el teléfono", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelCli.Focus();
            }
            else if(txtCorEleCli.Text == "")
            {
                MessageBox.Show("Ingrese el correo electrónico", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelCli.Focus();
            }
            else
            {
                bool valor = false;
                try
                {
                    new System.Net.Mail.MailAddress(txtCorEleCli.Text);
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
                    txtCorEleCli.Focus();
                    return;
                }

                Cli_Enc Cli = new Cli_Enc();
                Cli.Nom = txtNomCli.Text;
                Cli.Ape = txtApeCli.Text;
                Cli.Dir = txtDirCli.Text;
                Cli.Tel = txtTelCli.Text;
                Cli.FecNac = dtpFecNacCli.Value.Date;
                Cli.Ema = txtCorEleCli.Text;
                Cli.IdUsu = VarGlo.CodUsu;
                regCli.RegCli_Ins(Cli);
                MessageBox.Show("Se registro correctamente el cliente","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Cli_LimText();
            }
        }

        private void btnNue_Click(object sender, EventArgs e)
        {
            ///Recorre y limpia las cajas de texto y el datapicker,cierra el formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is DateTimePicker) ((DateTimePicker)control).Value = DateTime.Now.Date;
            }
        }
    }
}
