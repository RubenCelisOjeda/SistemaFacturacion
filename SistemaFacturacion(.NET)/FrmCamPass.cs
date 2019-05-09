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
    public partial class FrmCamPass : Form
    {
        private NCamPass camPass = new NCamPass();

        public FrmCamPass()
        {
            InitializeComponent();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            txtConAct.Text = "";
            txtNueCon.Text = "";
            txtConCon.Text = "";
            this.Close();
        }

        private void btnAce_Click(object sender, EventArgs e)
        {
            if (txtConAct.Text == "")
            {
                MessageBox.Show("Ingrese su contraseña actual","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtConAct.Focus();
            }
            else if(txtNueCon.Text == "")
            {
                MessageBox.Show("Ingrese su nueva contraseña", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNueCon.Focus();
            }
            else if(txtConCon.Text == "")
            {
                MessageBox.Show("Ingrese confirmación dela contraseña", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConCon.Focus();
            }
            else if(txtNueCon.Text != txtConCon.Text)
            {
                MessageBox.Show("Contraseñas no coinciden", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConCon.Focus();
            }
            else
            {
                camPass.CamPass(txtNueCon.Text,VarGlo.CodUsu);
                MessageBox.Show("Se actulizo correctamente la contraseña","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtConAct.Text = "";
                txtNueCon.Text = "";
                txtConCon.Text = "";
            }
        }
    }
}
