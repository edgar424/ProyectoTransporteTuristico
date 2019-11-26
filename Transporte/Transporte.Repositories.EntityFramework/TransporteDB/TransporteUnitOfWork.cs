using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Transporte.Repositories.TransporteDB;

namespace Transporte.Repositories.EntityFramework.TransporteDB
{
    public class TransporteUnitOfWork: ITransporteUnitOfWork
    {
        private readonly TransporteDBContext _context;
        public TransporteUnitOfWork(TransporteDBContext connectionString)
        {
            _context = connectionString;
            Clientes = new ClienteRepository(_context);
        }

        public IClienteRepository Clientes { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
