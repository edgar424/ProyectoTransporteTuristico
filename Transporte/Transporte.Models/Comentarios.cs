using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Models
{
    public class Comentarios
    {
        public int IdComentario { get; set; }

        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
        public int IdCotizacion { get; set; }
        public string Estado { get; set; }

    }
}
