using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Detalle_Cotizacion
    {
        public int IdDetalle { get; set; }
        public int IdCotizacion { get; set; }
        public int IdItinerario { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string Estado { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal Costo { get; set; }
    }
}
