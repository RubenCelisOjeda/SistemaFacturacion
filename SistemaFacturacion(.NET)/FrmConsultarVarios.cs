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
    public partial class FrmConsultarVarios : Form
    {
        //interface de la clase
        public IProducto_Categoria producto_Categoria_Rec { get; set; }
        public IFactura Factura_ReCli { get; set; }
        public IListadoCliente ListadoCliente_Rec { get; set; }
        public IClienteProducto ClienteProducto_Rec { get; set; }
        public ILisModoPago LisModoPago_Rec { get; set; }

        private NCat recCat = new NCat(); private NFac fac = new NFac(); private NCli cli = new NCli(); private NModPag modPag = new NModPag();
        public int Formulario;
        public string Vista;

        public FrmConsultarVarios()
        {
            InitializeComponent();
        }

        private void FrmConsultarVarios_Load(object sender, EventArgs e)
        {
           
            DataTable dtRecDat = new DataTable();

            //valida el formulario y llena el grid con la consulta
            switch (Formulario)
            {
                case 1:
                    dtRecDat = recCat.RecCat();
                    if (dtRecDat.Rows.Count > 0)
                    {
                        dgvConDat.DataSource = dtRecDat;
                    }
                    break;
                case 2:
                    dtRecDat = fac.Fac_RecCli();
                    if (dtRecDat.Rows.Count > 0)
                    {
                        dgvConDat.DataSource = dtRecDat;
                    }
                    break;
                case 3:
                    dtRecDat = cli.Cli_LisFacCliPro();
                    if (dtRecDat.Rows.Count > 0)
                    {
                        dgvConDat.DataSource = dtRecDat;
                    }
                    break;
                case 4:
                    dtRecDat = cli.Cli_Rec();
                    if (dtRecDat.Rows.Count > 0)
                    {
                        dgvConDat.DataSource = dtRecDat;
                    }
                    break;
                case 5:
                    dtRecDat = modPag.ModPag_Rec();
                    if (dtRecDat.Rows.Count > 0)
                    {
                        dgvConDat.DataSource = dtRecDat;
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgvConDat_DoubleClick(object sender, EventArgs e)
        {
            ConsultarVarios_RecDat();
        }

        private void dgvConDat_KeyDown(object sender, KeyEventArgs e)
        {
            //obtiene los datos al apretar enter
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarVarios_RecDat();
                e.SuppressKeyPress = true;
            }
        }

        private void ConsultarVarios_RecDat()
        {
            this.Hide();

            switch (Formulario) //valida el formulario
            {
                case 1:
                    switch (this.Vista) //valida la vista
                    {
                        case "Categoria":
                            producto_Categoria_Rec.RecDat_Cat(
                            this.dgvConDat.CurrentRow.Cells[0].Value.ToString(),
                            this.dgvConDat.CurrentRow.Cells[1].Value.ToString());
                            break;
                    }
                    break;

                case 2:
                    switch (this.Vista) //valida la vista
                    {
                        case "Cliente":
                            Factura_ReCli.RecDat_Cat(
                            this.dgvConDat.CurrentRow.Cells[0].Value.ToString(),
                            this.dgvConDat.CurrentRow.Cells[1].Value.ToString(),
                            this.dgvConDat.CurrentRow.Cells[1].Value.ToString(),
                            this.dgvConDat.CurrentRow.Cells[1].Value.ToString(),
                            this.dgvConDat.CurrentRow.Cells[1].Value.ToString());
                            break;
                    }
                    break;
                case 3:
                    switch (this.Vista)
                    {
                        case "Listado Cliente":
                           ListadoCliente_Rec.RecDat_Cat(
                           this.dgvConDat.CurrentRow.Cells[0].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[1].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[2].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[3].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[4].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[5].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[6].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[7].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[8].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[9].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[10].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[11].Value.ToString());
                            break;
                    }
                    break;
                case 4:
                    switch (this.Vista)
                    {
                        case "Cliente producto":
                            ClienteProducto_Rec.RecDat_CatCliPro(
                           this.dgvConDat.CurrentRow.Cells[0].Value.ToString(),
                           this.dgvConDat.CurrentRow.Cells[1].Value.ToString());
                           break;
                    }
                    break;
                case 5:
                    switch (this.Vista)
                    {
                        case "Modo pago":
                           LisModoPago_Rec.RecDat_Cat(
                           this.dgvConDat.CurrentRow.Cells[0].Value.ToString());
                           break;
                    }
                    break;
                
                default:
                    break;
            }
        }

        private void FrmConsultarVarios_KeyDown(object sender, KeyEventArgs e)
        {
            //al apretar espace se cierra
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
