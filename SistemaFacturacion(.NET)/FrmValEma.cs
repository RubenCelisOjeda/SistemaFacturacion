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
    public partial class FrmValEma : Form
    {
        private NLog log = new NLog();

        public FrmValEma()
        {
            InitializeComponent();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            txtEma.Text = "";
            this.Close();
        }

        private void btnAce_Click(object sender, EventArgs e)
        {
            //validamos el textbox
            if (txtEma.Text == "")
            {
                MessageBox.Show("Ingrese el correo electrónico","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtEma.Focus();
            }
            else
            {
                //validamos que sea un correo electronico
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

                //Valida el valor
                if (!valor)
                {
                    MessageBox.Show("Correo ingresado es inválido", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEma.Focus();
                    return;
                }
                
                //validamos el datable
                DataTable dtUsu = log.Log_ValEma(txtEma.Text);

                if (dtUsu.Rows[0]["Ema"].ToString() == txtEma.Text)
                {
                    VarGlo.CodUsu = Convert.ToInt32(dtUsu.Rows[0]["IdUsu"]);
                    FrmNuePass fNuePass = new FrmNuePass();
                    fNuePass.Show();
                    this.Close();
                }
            }
        }
    }
}
