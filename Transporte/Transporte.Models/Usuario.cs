using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public string Foto { get; set; }
        public int IdPerfil { get; set; }
    }
}
