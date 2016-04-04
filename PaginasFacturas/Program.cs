using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginasFacturas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var facturasList = new List<Facturas>() 
            {
                new Facturas(){IdFactura=1},
                new Facturas(){IdFactura=2},
                new Facturas(){IdFactura=3},
                new Facturas(){IdFactura=4},
            };

            var factura = new Facturas();
            var v=factura.GetPage(facturasList, 1, 2);
            foreach (var bucle in v) {
                Console.WriteLine(bucle.IdFactura);
            }
            Console.ReadLine();
        }
    }
}
