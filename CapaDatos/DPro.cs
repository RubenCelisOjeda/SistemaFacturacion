using CapaEntidades.Producto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPro
    {
        private string consulta = "Data Source = localhost;Initial Catalog=SistemaFacturacion;User=sa;Password=codigolinux89";

        public void RegPro_Gua(Producto_Enc Pro)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmdGuaPro = new SqlCommand("SP_GuaPro",cn))
                {
                    cmdGuaPro.Connection.Open();
                    cmdGuaPro.CommandType = CommandType.StoredProcedure;
                    cmdGuaPro.Parameters.Add("@Nom",SqlDbType.NVarChar,50).Value = Pro.Nom;
                    cmdGuaPro.Parameters.Add("@Pre", SqlDbType.NVarChar,20).Value = Pro.Pre;
                    cmdGuaPro.Parameters.Add("@Stock", SqlDbType.Int).Value = Pro.Stock;
                    cmdGuaPro.Parameters.Add("@IdCat", SqlDbType.Int).Value = Pro.IdCat;
                    cmdGuaPro.Parameters.Add("@IdUsu", SqlDbType.Int).Value = Pro.IdUsu;
                    cmdGuaPro.Parameters.Add("@IdCli", SqlDbType.Int).Value = Pro.IdCli;
                    cmdGuaPro.ExecuteNonQuery();
                }
            }
        }

        public DataTable Pro_Rec()
        {
            SqlDataAdapter daProRec = new SqlDataAdapter("SELECT * FROM Producto",consulta);
            daProRec.SelectCommand.CommandType = CommandType.Text;
            DataTable dtProRec = new DataTable();
            dtProRec.Locale = System.Globalization.CultureInfo.InvariantCulture;
            daProRec.Fill(dtProRec);
            return dtProRec;
        }
        public DataTable Cli_Filtro(string Nombre)
        {
            SqlDataAdapter daFiltro = new SqlDataAdapter("SELECT * FROM Producto", consulta);

            daFiltro.SelectCommand.CommandType = CommandType.Text;
            daFiltro.SelectCommand.Parameters.Add("@Nom", SqlDbType.NVarChar, 50).Value = Nombre;
            DataTable dtFiltro = new DataTable();
            dtFiltro.Locale = CultureInfo.InvariantCulture;
            daFiltro.Fill(dtFiltro);
            return dtFiltro;
        }
    }
}
