using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Razon { get; set; }
        public string Documento { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; } 
        public int IdUsuario { get; set; }
        public int Tipo_Documento { get; set; }
    }
}
