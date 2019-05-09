using CapaDatos;
using CapaEntidades.Producto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NPro
    {
        private DPro regPro = new DPro();

        public void RegPro_Gua(Producto_Enc Pro)
        {
            regPro.RegPro_Gua(Pro);
        }
        public DataTable Pro_Rec()
        {
            return regPro.Pro_Rec(); 
        }
        public DataTable Cli_Filtro(string Nombre)
        {
            return regPro.Cli_Filtro(Nombre);
        }
    }
}
