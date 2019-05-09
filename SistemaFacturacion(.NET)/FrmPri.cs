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
    public partial class FrmPri : Form
    {
        public FrmPri()
        {
            InitializeComponent();
        }

        private void crearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCli fCli = new FrmCli();
            fCli.MdiParent = this;
            fCli.Show();
        }

        private void cotizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPro fPro = new FrmPro();
            fPro.MdiParent = this;
            fPro.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLisFac fFac = new FrmLisFac();
            fFac.MdiParent = this;
            fFac.Show();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFac fFac = new FrmFac();
            fFac.MdiParent = this;
            fFac.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLisCli fCli = new FrmLisCli();
            fCli.MdiParent = this;
            fCli.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCamPass fPass = new FrmCamPass();
            fPass.MdiParent = this;
            fPass.Show();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCli fCli = new FrmCli();
            fCli.MdiParent = this;
            fCli.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLisPro fPro = new FrmLisPro();
            fPro.MdiParent = this;
            fPro.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void facturacionFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacFin fFac = new FrmFacFin();
            fFac.MdiParent = this;
            fFac.Show();
        }

        private void modoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModPag fPag = new FrmModPag();
            fPag.MdiParent = this;
            fPag.Show();
        }
    }
}
