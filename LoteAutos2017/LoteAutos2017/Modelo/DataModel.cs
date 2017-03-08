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
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PermisoNegado> PermisosNegados { get; set; }

        public DbSet<Acceso> Accesos { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// CONSTRUCTOR DE LA CLASE Y SE LE INDICA EL NOMBRE DE LA CADENA DE 
        /// CONCECCION
        /// </summary>
        public DataModel():base("DataModel") { }
    }
}
