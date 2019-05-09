using CapaEntidades.Producto;
using CapaNegocio;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    public partial class FrmPro : Form, IProducto_Categoria, IClienteProducto
    {
        private NPro regPro = new NPro();

        public FrmPro()
        {
            InitializeComponent();
        }

        private void txtDesCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                FrmConsultarVarios f = new FrmConsultarVarios();
                f.Formulario = 1;
                f.Vista = "Categoria";
                f.producto_Categoria_Rec = this;
                f.ShowDialog();
                txtCli.Focus();
            }
        }

        private void FrmPro_Load(object sender, EventArgs e)
        {
            txtIdCat.ReadOnly = true;
        }

        public void RecDat_Cat(string IdCat, string DesCat)
        {
            txtIdCat.Text = IdCat;
            txtDesCat.Text = DesCat;
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is DateTimePicker) ((DateTimePicker)control).Value = DateTime.Now.Date;
            }

            this.Close(); //cierra el formulario
        }

        private void Pro_LimTex()
        {
            //recorremos los texbox para limpiar
            foreach (Control control in gpbCotPro.Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is DateTimePicker) ((DateTimePicker)control).Value = DateTime.Now.Date;
            }
        }

        private void btnNue_Click(object sender, EventArgs e)
        {
            Pro_LimTex();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //valida los textos
            if (txtPro.Text == "")
            {
                MessageBox.Show("Ingrese un producto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPro.Focus();
            }
            else if (txtPre.Text == "")
            {
                MessageBox.Show("Ingrese precio del producto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPre.Focus();
            }
            else if (txtSto.Text == "")
            {
                MessageBox.Show("Ingrese stock", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSto.Focus();
            }
            else if (txtIdCat.Text == "")
            {
                MessageBox.Show("Ingrese una categoria", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdCat.Focus();
            }
            else if(txtIdCli.Text == "")
            {
                MessageBox.Show("Ingrese un cliente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdCli.Focus();
            }
            else
            {
                //guarda los datos en la entidad
                Producto_Enc Pro = new Producto_Enc();
                Pro.Nom = txtPro.Text;
                double n = Convert.ToDouble(txtPre.Text);
                Pro.Pre = txtPre.Text;
                Pro.Stock = Convert.ToInt32(txtSto.Text);
                Pro.IdCat = Convert.ToInt32(txtIdCat.Text);
                Pro.IdUsu = VarGlo.CodUsu;
                Pro.IdCli = Convert.ToInt32(txtIdCli.Text);

                //ejecutamos la consulta
                regPro.RegPro_Gua(Pro);

                MessageBox.Show("Se registro corretamente el producto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pro_LimTex();
            }
        }

        private void txtPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pro_EveKeyPre(e,txtPre);
        }
        private void Pro_EveKeyPre(KeyPressEventArgs e ,TextBox text)
        {
            //permite obtener el foco cuando se presiona enter
            if (e.KeyChar == (char)13)
            {
                text.Focus();
            }
        }

        private void txtPre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) // permite ingresar datos numericos
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))//permite utilizar la tecla backspace
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && !txtPre.Text.Contains(".")) //verificar que solo hañña un punto decimal
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; //desahabilita las demas entradas del teclado
            }

            Pro_EveKeyPre(e, txtSto);
        }

        private void txtSto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite que sea entero
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            Pro_EveKeyPre(e, txtDesCat);
        }

        private void txtCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                FrmConsultarVarios f = new FrmConsultarVarios();
                f.Formulario = 4;
                f.Vista = "Cliente producto";
                f.ClienteProducto_Rec = this;
                f.ShowDialog();
                txtCli.Focus();
            }
        }

        public void RecDat_CatCliPro(string IdCli, string Cli)
        {
            txtIdCli.Text = IdCli;
            txtCli.Text = Cli;
        }
    }
}
