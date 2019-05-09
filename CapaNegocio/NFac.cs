using CapaDatos;
using CapaEntidades.Factura;
using CapaEntidades.Facturacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NFac
    {
        private DFac fac = new DFac();

        public void Fac_GuaEnc(Factura_Enc Fac)
        {
            fac.Fac_GuaEnc(Fac);
        }

        public DataTable Fac_Rec()
        {
            return fac.Fac_Rec();
        }
        public DataTable Fac_RecCli()
        {
            return fac.Fac_RecCli();
        }
        public DataTable Cli_Filtro(string Nombre)
        {
            return fac.Cli_Filtro(Nombre);
        }
        public void FacFin(Fac_EncDet Fac)
        {
            fac.FacFin(Fac);
        }
    }
}
