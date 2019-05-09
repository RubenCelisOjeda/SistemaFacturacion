using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCat
    {
        private DCat recCtat = new DCat();

        public DataTable RecCat()
        {
            return recCtat.RecCat();
        }
    }
}
