using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte.Models;

namespace Transporte.Repositories.TransporteDB
{
    public interface ITransporteUnitOfWork:IDisposable
    {
        IClienteRepository Clientes { get; set; }
        int Complete();
    }
}
