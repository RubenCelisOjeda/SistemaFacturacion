using CapaEntidades.ModoPago;
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
    public class DModPag
    {
        private string consulta = "Data Source = localhost;Initial Catalog = SistemaFacturacion;User=sa;Password = codigolinux89";

        public void ModPag_Gua(ModoPago_Enc ModPag)
        {
            using (SqlConnection cn = new SqlConnection(consulta))
            {
                using (SqlCommand cmdGuaModPag = new SqlCommand("INSERT INTO Modo_Pago VALUES (@NumPag,@Nom,@OtrDet)",cn))
                {
                    cmdGuaModPag.Connection.Open();
                    cmdGuaModPag.CommandType = CommandType.Text;
                    cmdGuaModPag.Parameters.Add("@NumPag",SqlDbType.Int).Value = ModPag.NumPag;
                    cmdGuaModPag.Parameters.Add("@Nom", SqlDbType.NVarChar,50).Value = ModPag.NomPag;
                    cmdGuaModPag.Parameters.Add("@OtrDet", SqlDbType.NVarChar,50).Value = ModPag.OtrDet;
                    cmdGuaModPag.ExecuteNonQuery();
                }
            }
        }
        public DataTable ModPag_Rec()
        {
            SqlDataAdapter daRecModPag = new SqlDataAdapter("SELECT * FROM Modo_Pago",consulta);
            daRecModPag.SelectCommand.CommandType = CommandType.Text;
            DataTable dtModPag = new DataTable();
            dtModPag.Locale = CultureInfo.InvariantCulture;
            daRecModPag.Fill(dtModPag);
            return dtModPag;
        }
    }
}
