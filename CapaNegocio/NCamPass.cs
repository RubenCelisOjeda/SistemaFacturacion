using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCamPass
    {
        private DCamPass camPas = new DCamPass();

        public void CamPass(string Pass, int IdUsu)
        {
            camPas.CamPass(Pass,IdUsu);
        }
    }
}
