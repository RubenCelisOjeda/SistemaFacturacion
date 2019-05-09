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
    public partial class FrmLisFac : Form
    {
        private NFac fac = new NFac();

        public FrmLisFac()
        {
            InitializeComponent();
        }

        private void FrmLisFac_Load(object sender, EventArgs e)
        {
            Fac_Rec();
        }
        private void Fac_Rec()
        {
            DataTable dtFac = fac.Fac_Rec();

            if (dtFac.Rows.Count > 0)
            {
                dgvFac.DataSource = dtFac;
            }
        }

        private void txtNumFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataTable dt = fac.Cli_Filtro(txtNumFac.Text);
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("NumFac like '%{0}%'", txtNumFac.Text);
                dgvFac.DataSource = dv.ToTable();
            }
        }
    }
}
