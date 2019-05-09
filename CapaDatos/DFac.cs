using CapaEntidades.Factura;
using CapaEntidades.Facturacion;
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
    public class DFac
    {
        private string consulta = "Data Source = localhost;Initial Catalog = SistemaFacturacion;User=sa;Password = codigolinux89";

        public void Fac_GuaEnc(Factura_Enc Fac)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmdGuaFac = new SqlCommand("SP_GuaFac",cn))
                {
                    cmdGuaFac.Connection.Open();
                    cmdGuaFac.CommandType = CommandType.StoredProcedure;
                    cmdGuaFac.Parameters.Add("@IdCli",SqlDbType.Int).Value = Fac.IdCli;
                    cmdGuaFac.Parameters.Add("@Fec", SqlDbType.SmallDateTime).Value = Fac.Fec;
                    cmdGuaFac.Parameters.Add("@NumPag", SqlDbType.Int).Value = Fac.NumPag;
                    cmdGuaFac.Parameters.Add("@NumFac", SqlDbType.NVarChar,50).Value = Fac.NumFac;
                    cmdGuaFac.ExecuteNonQuery();
                }
            }
        }
        public DataTable Fac_Rec()
        {
            using (SqlDataAdapter daRecFac = new SqlDataAdapter("select * from Factura", consulta))
            {
                daRecFac.SelectCommand.CommandType = CommandType.Text;
                DataTable dtCliFac = new DataTable();
                dtCliFac.Locale = System.Globalization.CultureInfo.InvariantCulture;
                daRecFac.Fill(dtCliFac);
                return dtCliFac;
            }
        }
        public DataTable Fac_RecCli()
        {
            using (SqlDataAdapter daRecCli = new SqlDataAdapter("select * from Cliente", consulta))
            {
                daRecCli.SelectCommand.CommandType = CommandType.Text;
                DataTable dtCli = new DataTable();
                dtCli.Locale = System.Globalization.CultureInfo.InvariantCulture;
                daRecCli.Fill(dtCli);
                return dtCli;
            }
        }
        public DataTable Cli_Filtro(string Nombre)
        {
            SqlDataAdapter daFiltro = new SqlDataAdapter("SELECT * FROM Factura", consulta);

            daFiltro.SelectCommand.CommandType = CommandType.Text;
            daFiltro.SelectCommand.Parameters.Add("@Nom", SqlDbType.NVarChar, 50).Value = Nombre;
            DataTable dtFiltro = new DataTable();
            dtFiltro.Locale = CultureInfo.InvariantCulture;
            daFiltro.Fill(dtFiltro);
            return dtFiltro;
        }

        public void FacFin(Fac_EncDet Fac)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmdGuaFacFin = new SqlCommand("INSERT INTO Factura_Producto VALUES(@IdFac,@IdPro,@Can,@Pre,@IdCli)", cn))
                {
                    cmdGuaFacFin.Connection.Open();
                    cmdGuaFacFin.CommandType = CommandType.Text;
                    cmdGuaFacFin.Parameters.Add("@IdFac", SqlDbType.Int).Value = Fac.IdFac;
                    cmdGuaFacFin.Parameters.Add("@IdPro", SqlDbType.Int).Value = Fac.IdPro;
                    cmdGuaFacFin.Parameters.Add("@Can", SqlDbType.Int).Value = Fac.Can;
                    cmdGuaFacFin.Parameters.Add("@Pre", SqlDbType.Int).Value = Fac.Pre;
                    cmdGuaFacFin.Parameters.Add("@IdCli", SqlDbType.Int).Value = Fac.IdCli;
                    cmdGuaFacFin.ExecuteNonQuery();
                }
            }
        }
    }
}
