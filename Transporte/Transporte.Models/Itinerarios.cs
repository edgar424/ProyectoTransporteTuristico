using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Itinerarios
    {
        public int IdItinerario { get; set; }
        public string Descripcion { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal Costo { get; set; }
        public string Estado { get; set; }
    }
}
