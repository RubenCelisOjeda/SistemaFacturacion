using CapaEntidades.Facturacion;
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
    public partial class FrmFacFin : Form, IListadoCliente
    {
        private int IdFactura = 0;
        private int IdProdcuto = 0;
        private NFac fac = new NFac();

        public FrmFacFin()
        {
            InitializeComponent();
        }

        private void FrmFacFin_Load(object sender, EventArgs e)
        {
            FacFin_DesBtn();
        }
        private void FacFin_DesBtn()
        {
            txtFac.ReadOnly = true;
            txtNumPag.ReadOnly = true;
            txtId.ReadOnly = true;
            txtDir.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtCorEle.ReadOnly = true;
            txtPre.ReadOnly = true;
            txtSto.ReadOnly = true;
            txtFecEmi.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnNueFac_Click(object sender, EventArgs e)
        {
            FacFin_LimTex();
        }

        private void FacFin_LimTex()
        {
            txtFac.Text = "";
            txtNumPag.Text = "";
            foreach (Control control in gpbCli.Controls)
            {
                if (control is TextBox) control.Text = "";

                foreach (Control control2 in gpbCotPro.Controls)
                {
                    if (control2 is TextBox) control2.Text = "";
                }
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            FacFin_LimTex();
            this.Close();
        }

        private void txtCli_KeyPress(object sender, KeyPressEventArgs e)
        
{
            if (e.KeyChar == (char)13)
            {
                FrmConsultarVarios f = new FrmConsultarVarios();
                f.Formulario = 3;
                f.Vista = "Listado Cliente";
                f.ListadoCliente_Rec = this;
                f.ShowDialog();
                btnFac.Focus();
            }
        }

        public void RecDat_Cat(string IdCli, string Nom, string Dir, string Tel, string Ema, string IdFac, string NumPag, string NumFac,string IdPro, string NomPro, string Pre, string Stock)
        {
            txtId.Text = IdCli;
            txtCli.Text = Nom;
            txtDir.Text = Dir;
            txtTel.Text = Tel;
            txtCorEle.Text = Ema;
            IdFactura = Convert.ToInt32(IdFac);
            txtNumPag.Text = NumPag;
            txtFac.Text = NumFac;
            IdProdcuto = Convert.ToInt32(IdPro);
            txtPro.Text = NomPro;
            txtPre.Text = Pre;
            txtSto.Text = Stock;
        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Ingrese cliente a facturar","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtCli.Focus();
            }
            else if(txtNumPag.Text == "")
            {
                MessageBox.Show("Ingrese numero de pago", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumPag.Focus();
            }
            else
            {
                Fac_EncDet Fac = new Fac_EncDet();
                Fac.IdFac = IdFactura;
                Fac.IdPro = IdProdcuto;
                Fac.Can =  Convert.ToInt32(txtCan.Text);
                Fac.Pre = txtPre.Text;
                Fac.IdCli = Convert.ToInt32(txtId.Text);
                fac.FacFin(Fac);
                MessageBox.Show("Se factura correctamente","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                FacFin_LimTex();
            }
        }

        private void btnNue_Click(object sender, EventArgs e)
        {
            foreach (Control control in gpbCli.Controls)
            {
                if (control is TextBox) control.Text = "";
            }
        }
    }
}
