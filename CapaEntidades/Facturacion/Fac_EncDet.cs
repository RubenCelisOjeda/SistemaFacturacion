using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Facturacion
{
    public class Fac_EncDet
    {
        public int IdFac { get; set; }
        public int IdPro { get; set; }
        public int Can { get; set; }
        public string Pre { get; set; }
        public int IdCli { get; set; }
    }
}
