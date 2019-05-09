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
    public partial class FrmLisPro : Form
    {
        private NPro pro = new NPro();

        public FrmLisPro()
        {
            InitializeComponent();
        }

        private void FrmLisPro_Load(object sender, EventArgs e)
        {
            LisPro_Rec();
        }
        private void LisPro_Rec()
        {
            DataTable dtProRec = pro.Pro_Rec();

            if (dtProRec.Rows.Count > 0)
            {
                dgvLisPro.DataSource = dtProRec;    
            }
        }

        private void txtProArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataTable dt = pro.Cli_Filtro(txtProArt.Text);
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Nom like '%{0}%'", txtProArt.Text);
                dgvLisPro.DataSource = dv.ToTable();
            }
        }
    }
}
