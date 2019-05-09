using CapaEntidades.ModoPago;
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
    public partial class FrmModPag : Form
    {
        private NModPag modPag = new NModPag();

        public FrmModPag()
        {
            InitializeComponent();
        }

        private void btnAce_Click(object sender, EventArgs e)
        {
            if (txtNumPag.Text == "")
            {
                MessageBox.Show("Ingrese numero de pago","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNumPag.Focus();
            }
            else if(txtNomPag.Text == "")
            {
                MessageBox.Show("Ingrese nombre de pago", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomPag.Focus();
            }
            else
            {
                ModoPago_Enc ModPag = new ModoPago_Enc();
                ModPag.NumPag = Convert.ToInt32(txtNumPag.Text);
                ModPag.NomPag = txtNomPag.Text;
                ModPag.OtrDet = txtDetPago.Text;
                modPag.ModPag_Gua(ModPag);

                MessageBox.Show("Se registro el pago correctamente","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNumPag.Text = "";
                txtNomPag.Text = "";
                txtDetPago.Text = "";
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            txtNumPag.Text = "";
            txtNumPag.Text = "";
            txtDetPago.Text = "";
            this.Close();
        }

        private void txtNumPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtNomPag.Focus();
            }
        }

        private void txtNomPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtDetPago.Focus();
            }
        }

        private void txtDetPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAce.Focus();
            }
        }
    }
}
