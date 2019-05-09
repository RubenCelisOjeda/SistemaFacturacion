using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;
using CapaEntidades.Login;

namespace CapaDatos
{
    public class DLog
    {
        private string consulta = "Data Source = localhost;Initial Catalog=SistemaFacturacion;User=sa;Password=codigolinux89";

        public DataTable Log_ValUsu(string Usu,string Pass)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmdValUsu = new SqlCommand("SP_ValUsu", cn))
                {
                    cmdValUsu.Connection.Open();
                    cmdValUsu.CommandType = CommandType.StoredProcedure;
                    cmdValUsu.Parameters.Add("@Usu", SqlDbType.NVarChar, 30).Value = Usu;
                    cmdValUsu.Parameters.Add("@Pass", SqlDbType.NVarChar, 30).Value = Pass;

                    SqlDataReader dr = cmdValUsu.ExecuteReader();
                    DataTable dtUsu = new DataTable();
                    dtUsu.Load(dr);
                    return dtUsu;
                }
            }
        } 

        public void Log_InsUsu(Usuario_Enc Usu)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmdInsCli = new SqlCommand("SP_InsUsu", cn))
                {
                    cmdInsCli.Connection.Open();
                    cmdInsCli.CommandType = CommandType.StoredProcedure;
                    cmdInsCli.Parameters.Add("@Nom", SqlDbType.NVarChar, 50).Value = Usu.Nom;
                    cmdInsCli.Parameters.Add("@Ape", SqlDbType.NVarChar, 50).Value = Usu.Ape;
                    cmdInsCli.Parameters.Add("@Dir", SqlDbType.NVarChar, 50).Value = Usu.Dir;
                    cmdInsCli.Parameters.Add("@Tel", SqlDbType.NVarChar, 20).Value = Usu.Tel;
                    cmdInsCli.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = Usu.Ema;
                    cmdInsCli.Parameters.Add("@Usu", SqlDbType.NVarChar, 50).Value = Usu.Usu;
                    cmdInsCli.Parameters.Add("@Pass", SqlDbType.NVarChar, 50).Value = Usu.Pass;
                    cmdInsCli.ExecuteNonQuery();
                }
            }
        }

        public DataTable Log_ValEma(string Ema)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmdValEma = new SqlCommand("SELECT * FROM Usuario WHERE Ema = @ema", cn))
                {
                    cmdValEma.Connection.Open();
                    cmdValEma.CommandType = CommandType.Text;
                    cmdValEma.Parameters.Add("@ema", SqlDbType.NVarChar, 50).Value = Ema;
                    SqlDataReader dr = cmdValEma.ExecuteReader();

                    DataTable dtUsu = new DataTable();
                    dtUsu.Load(dr);
                    return dtUsu;
                }
            }
        }

        public void Log_UpdPass(int IdUsu,string Pass)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmdUpdPass = new SqlCommand("UPDATE Usuario set Password = @pass "+
                                                                            "WHERE IdUsu = @idUsu", cn))
                {
                    cmdUpdPass.Connection.Open();
                    cmdUpdPass.Parameters.Add("@pass", SqlDbType.NVarChar, 50).Value = Pass;
                    cmdUpdPass.Parameters.Add("@idUsu", SqlDbType.Int).Value = IdUsu;
                    cmdUpdPass.ExecuteNonQuery();
                }
            }
        }
    }
}
