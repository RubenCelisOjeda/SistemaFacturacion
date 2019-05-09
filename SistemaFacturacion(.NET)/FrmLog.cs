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
    public partial class FrmLog : Form
    {
        private NLog log = new NLog(); 

        public FrmLog()
        {
            InitializeComponent();
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {

        }

        private void btnAce_Click(object sender, EventArgs e)
        {
            ///Valida los textos

            DataTable dtUsu = log.Log_ValUsu(txtUsu.Text, txtPas.Text);

            if (txtUsu.Text == "")
            {
                MessageBox.Show("Ingrese usuario","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtUsu.Focus();
            }
            else if(txtPas.Text == "")
            {
                MessageBox.Show("Ingrese contraseña", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPas.Focus();
            }
            else if (dtUsu.Rows.Count == 0) ///Valida si existe el usuario
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsu.Focus();
            }
            else
            {
                //obtenemos el Id en la variable global
                VarGlo.CodUsu = Convert.ToInt32(dtUsu.Rows[0]["IdUsu"]);
                FrmPri fPri = new FrmPri();
                fPri.Show();
                this.Hide();
            }
        }

        private void linkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegUsu fRegCli = new FrmRegUsu();
            fRegCli.ShowDialog();
        }

        private void linkOlvPas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmValEma fValEma = new FrmValEma();
            fValEma.ShowDialog();
        }

        private void txtUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPas.Focus();
            }
        }

        private void txtPas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAce.Focus();
            }
        }
    }
}
