using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Transporte.Models;

namespace Transporte.Repositories.EntityFramework
{
   public class TransporteDBContext: DbContext
    {

        public TransporteDBContext(): base("TransporteDBConnection")
        {
            Database.SetInitializer<TransporteDBContext>(null);
            Configuration.AutoDetectChangesEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.ValidateOnSaveEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Cuando tenemos problemas con el ID, no lo reconoce en la tabla
            modelBuilder.Entity<Cliente>().HasKey(n => n.IdCliente);
        }

        public virtual DbSet<Cliente> Clientes { get; set; }

    }
}
