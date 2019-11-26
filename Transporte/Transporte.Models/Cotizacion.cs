using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Cotizacion
    {
        public int IdCotizacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public decimal Costo_Total { get; set; }
        public int IdCliente { get; set; }
    }
}
