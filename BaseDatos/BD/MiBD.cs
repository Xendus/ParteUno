using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.BD
{
    public class MiBD:DbContext 
    {
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Tiempo> Tiempos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
