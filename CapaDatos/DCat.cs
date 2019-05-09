using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCat
    {
        private string consulta = "Data Source = localhost;Initial Catalog=SistemaFacturacion;User=sa;Password=codigolinux89";

        public DataTable RecCat()
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                SqlDataAdapter daRecCat = new SqlDataAdapter("select IdCat ,Nom [Nombre],Des [Descripción] from Categoria", cn);
                daRecCat.SelectCommand.CommandType = CommandType.Text;
                DataTable dtCat = new DataTable();
                dtCat.Locale = System.Globalization.CultureInfo.InvariantCulture;
                daRecCat.Fill(dtCat);
                return dtCat;
            }
        }
    }
}
