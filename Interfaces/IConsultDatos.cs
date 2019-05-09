using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IConsultDatos
    {

    }
    public interface ILisModoPago
    {
        void RecDat_Cat(string NumPag);
    }

    public interface IProducto_Categoria
    {
        void RecDat_Cat(string IdCat, string DesCat);
    }
    public interface IFactura
    {
        void RecDat_Cat(string IdCod, string Clie,string Dir ,string Tel,string Ema);
    }
    public interface IClienteProducto
    {
        void RecDat_CatCliPro(string IdCli,string Cli);
    }
    public interface IListadoCliente
    {
        void RecDat_Cat(string IdCli, string Nom, string Dir, string Tel, string Ema, string IdFac, string NumPag,string NumFac,string IdPro,string NomPro,string Pre,string Stock);
    }
}
