using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginasFacturas
{
    public class Facturas
    {
        public int IdFactura { get; set; }
  
        public IEnumerable<Facturas> GetPage(IEnumerable<Facturas> factura,int paginas,int totalPorPagina ){
                return factura.Skip((paginas-1)*totalPorPagina).Take(totalPorPagina);
            }
    }
}
