using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCamPass
    {
        private string consulta = "Data Source = localhost;Initial Catalog = SistemaFacturacion;User=sa;Password = codigolinux89";

        public void CamPass(string Pass,int IdUsu)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmdCamPass = new SqlCommand("UPDATE Usuario set Password = @Pass WHERE IdUsu =@IdUsu",cn))
                {
                    cmdCamPass.Connection.Open();
                    cmdCamPass.Parameters.Add("@Pass", SqlDbType.NVarChar,30).Value = Pass;
                    cmdCamPass.Parameters.Add("@IdUsu", SqlDbType.Int).Value = IdUsu;
                    cmdCamPass.ExecuteNonQuery();
                }
            }
        }
    }
}
