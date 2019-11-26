using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte.Models;
using Transporte.Repositories.TransporteDB;

namespace Transporte.Repositories.EntityFramework.TransporteDB
{
    class ClienteRepository: Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(TransporteDBContext context):base(context)
        {

        }
    }
}
