using CapaDatos;
using CapaEntidades.ModoPago;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NModPag
    {
        private DModPag mogPag = new DModPag();

        public void ModPag_Gua(ModoPago_Enc ModPag)
        {
            mogPag.ModPag_Gua(ModPag);
        }
        public DataTable ModPag_Rec()
        {
            return mogPag.ModPag_Rec();
        }
    }
}
