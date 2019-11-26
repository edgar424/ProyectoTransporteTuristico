using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Detalle_Asignacion
    {
        public int IdAsignacion { get; set; }
        public int IdConductor { get; set; }
        public int IdDetalle { get; set; }
        public string Estado { get; set; }
    }
}
