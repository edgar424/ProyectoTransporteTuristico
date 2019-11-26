using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public string Marca { get; set; }
    }
}
