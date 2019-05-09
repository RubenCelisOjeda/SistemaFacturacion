using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades.Cliente;
using System.Globalization;

namespace CapaDatos
{
    public class DCli
    {
        private string consulta = "Data Source = localhost;Initial Catalog=SistemaFacturacion;User=sa;Password=codigolinux89";

        public void RegCli_Ins(Cli_Enc Cli)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmInsCli = new SqlCommand("SP_InsCli",cn))
                {
                    cmInsCli.Connection.Open();
                    cmInsCli.CommandType = CommandType.StoredProcedure;
                    cmInsCli.Parameters.Add("@Nom",SqlDbType.NVarChar,50).Value = Cli.Nom;
                    cmInsCli.Parameters.Add("@Ape", SqlDbType.NVarChar, 50).Value = Cli.Ape;
                    cmInsCli.Parameters.Add("@Dir", SqlDbType.NVarChar, 50).Value = Cli.Dir;
                    cmInsCli.Parameters.Add("@FecNac", SqlDbType.Date).Value = Cli.FecNac;
                    cmInsCli.Parameters.Add("@Tel", SqlDbType.NVarChar, 20).Value = Cli.Tel;
                    cmInsCli.Parameters.Add("@Ema", SqlDbType.NVarChar, 50).Value = Cli.Ema;
                    cmInsCli.Parameters.Add("@IdUsu", SqlDbType.NVarChar, 50).Value = Cli.IdUsu;
                    cmInsCli.ExecuteNonQuery();
                }
            }
        }

        public DataTable Cli_Rec()
        {
            using (SqlDataAdapter daRecCli= new SqlDataAdapter("select * from Cliente",consulta))
            {
                daRecCli.SelectCommand.CommandType = CommandType.Text;
                DataTable dtCliRec = new DataTable();
                dtCliRec.Locale = System.Globalization.CultureInfo.InvariantCulture;
                daRecCli.Fill(dtCliRec);
                return dtCliRec;
            }
        }

        public DataTable Cli_Filtro(string Nombre)
        {
            SqlDataAdapter daFiltro = new SqlDataAdapter("SELECT * FROM Cliente",consulta);
            
            daFiltro.SelectCommand.CommandType = CommandType.Text;
            daFiltro.SelectCommand.Parameters.Add("@Nom", SqlDbType.NVarChar, 50).Value = Nombre;
            DataTable dtFiltro = new DataTable();
            dtFiltro.Locale = CultureInfo.InvariantCulture;
            daFiltro.Fill(dtFiltro);
            return dtFiltro;    
        }

        public DataTable Cli_LisFacCliPro()
        {
            SqlDataAdapter daLisFacCliPro = new SqlDataAdapter("SP_LisFacCliPro", consulta);
            daLisFacCliPro.SelectCommand.CommandType = CommandType.Text;
            DataTable dtLisFacCliPro = new DataTable();
            dtLisFacCliPro.Locale = CultureInfo.InvariantCulture;
            daLisFacCliPro.Fill(dtLisFacCliPro);
            return dtLisFacCliPro;
        }
    }
}
