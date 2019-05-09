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
    public partial class FrmLisCli : Form
    {
        private NCli cli = new NCli();

        public FrmLisCli()
        {
            InitializeComponent();
        }

        private void FrmRecCli_Load(object sender, EventArgs e)
        {
            Cli_Rec();
        }

        private void Cli_Rec()
        {
            DataTable dtCli = cli.Cli_Rec();

            if (dtCli.Rows.Count > 0)
            {
                dgvCli.DataSource = dtCli;
            }
        }

        private void txtCli_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataTable dt = cli.Cli_Filtro(txtCli.Text);
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Nombre like '%{0}%'",txtCli.Text);
                dgvCli.DataSource = dv.ToTable();
            }
        }
    }
}
