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
    public partial class FrmNuePass : Form
    {
        private NLog log = new NLog();

        public FrmNuePass()
        {
            InitializeComponent();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            txtNuePass.Text = "";
            txtConPass.Text = "";
            this.Close();
        }

        private void btnAce_Click(object sender, EventArgs e)
        {
            //validamos los textbox
            if (txtNuePass.Text == "")
            {
                MessageBox.Show("Ingrese contraseña nueva","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNuePass.Focus();
            }
            else if(txtConPass.Text == "")
            {
                MessageBox.Show("Ingrese la confirmación de la contraseña", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConPass.Focus();
            }
            else if(txtNuePass.Text != txtConPass.Text)
            {
                MessageBox.Show("Contraseñas no coninciden", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConPass.Focus();
            }
            else
            {
                //ejecutamos la consulta
                log.Log_UpdPass(VarGlo.CodUsu,txtNuePass.Text);
                MessageBox.Show("Contraseña actualizadad correctamente","Mensaj del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNuePass.Text = "";
                VarGlo.CodUsu = 0; //le damos valor 0 a la variable global CodUsu
                this.Close();
            }
        }
    }
}
