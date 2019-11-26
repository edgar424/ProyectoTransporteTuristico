using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Conductor
    {
        public int IdConductor { get; set; }
        public string Estado { get; set; }
        public int IdVehiculo { get; set; }
        public string Licencia { get; set; }
        
    }
}
