using CapaDatos;
using CapaEntidades.Cliente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCli
    {
        private DCli regCli = new DCli();

        public void RegCli_Ins(Cli_Enc Cli)
        {
            regCli.RegCli_Ins(Cli);
        }
        public DataTable Cli_Rec()
        {
            return regCli.Cli_Rec();
        }
        public DataTable Cli_Filtro(string Nombre)
        {
            return regCli.Cli_Filtro(Nombre);
        }
        public DataTable Cli_LisFacCliPro()
        {
            return regCli.Cli_LisFacCliPro();
        }
    }
}
