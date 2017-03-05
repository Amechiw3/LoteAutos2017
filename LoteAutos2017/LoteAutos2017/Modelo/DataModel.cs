using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
namespace LoteAutos2017.Modelo
{
    class DataModel:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteVendedor> ClientesVendedor { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
