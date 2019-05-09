using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Factura
{
    public class Factura_Enc
    {
        public int IdCli { get; set; }
        public DateTime Fec { get; set; }
        public int NumPag { get; set; }
        public string NumFac { get; set; }

    }
}
