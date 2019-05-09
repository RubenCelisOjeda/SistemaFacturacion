using CapaDatos;
using CapaEntidades.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NLog
    {
        private DLog log = new DLog();

        public DataTable Log_ValUsu(string Usu, string Pass)
        {
            return log.Log_ValUsu(Usu,Pass);
        }

        public void Log_InsUsu(Usuario_Enc Usu)
        {
            log.Log_InsUsu(Usu);
        }

        public DataTable Log_ValEma(string Ema)
        {
            return log.Log_ValEma(Ema);
        }

        public void Log_UpdPass(int IdUsu, string Pass)
        {
            log.Log_UpdPass(IdUsu, Pass);
        }
    }
}
