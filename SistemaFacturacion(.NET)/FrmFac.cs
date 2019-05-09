using CapaEntidades.Factura;
using CapaNegocio;
using Interfaces;
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
    public partial class FrmFac : Form, IFactura, ILisModoPago
    {
        private NFac fac = new NFac();

        public FrmFac()
        {
            InitializeComponent();
        }

        private void FrmFac_Load(object sender, EventArgs e)
        {
            txtDir.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtCorEle.ReadOnly = true;
            txtFecEmi.ReadOnly = true;
            txtId.ReadOnly = true;
            txtFecEmi.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            Fac_LimText();
        }

        private void Fac_LimText()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) control.Text = "";

                foreach (Control gpb in gpbCli.Controls)
                {
                    if (gpb is TextBox) gpb.Text = "";
                }
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Fac_LimText();
            this.Close();
        }

        private void btnNue_Click(object sender, EventArgs e)
        {
            foreach (Control gpb in gpbCli.Controls)
            {
                if (gpb is TextBox) gpb.Text = "";
            }
        }

        private void btnAce_Click(object sender, EventArgs e)
        {
            if (txtFac.Text == "")
            {
                MessageBox.Show("Ingrese factura","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtFac.Focus();
            }
            else if(txtNumPag.Text == "")
            {
                MessageBox.Show("Ingrese numero de pago", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumPag.Focus();
            }
            else if (txtCli.Text == "")
            {
                MessageBox.Show("Ingrese cliente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCli.Focus();
            }
            else
            {
                Factura_Enc Fac = new Factura_Enc();
                Fac.NumFac = txtFac.Text;
                Fac.NumPag = Convert.ToInt32(txtNumPag.Text);
                Fac.Fec = Convert.ToDateTime(txtFecEmi.Text);
                Fac.IdCli = Convert.ToInt32(txtId.Text);

                fac.Fac_GuaEnc(Fac);

                MessageBox.Show("Regristro con éxito","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Fac_LimText();
            }
        }

        private void txtFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fac_EveKeyPres(e,txtNumPag);
        }
        private void Fac_EveKeyPres(KeyPressEventArgs e,Control c)
        {
            if (e.KeyChar == (char)13)
            {
                c.Focus();
            }
        }

        private void txtNumPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                FrmConsultarVarios f = new FrmConsultarVarios();
                f.Formulario = 5;
                f.Vista = "Modo pago";
                f.LisModoPago_Rec = this;
                f.ShowDialog();
                txtCli.Focus();
            }
        }

        private void txtCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                FrmConsultarVarios f = new FrmConsultarVarios();
                f.Formulario = 2;
                f.Vista = "Cliente";
                f.Factura_ReCli = this;
                f.ShowDialog();
                btnAce.Focus();
            }
        }

        public void RecDat_Cat(string IdCod, string Clie, string Dir, string Tel, string Ema)
        {
            txtId.Text = IdCod;
            txtCli.Text = Clie;
            txtDir.Text = Dir;
            txtTel.Text = Tel;
            txtCorEle.Text = Ema;

        }

        public void RecDat_Cat(string NumPag)
        {
            txtNumPag.Text = NumPag;
        }
    }
}
