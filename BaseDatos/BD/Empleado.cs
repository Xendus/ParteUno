using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaseDatos.BD
{
    public class Empleado
    {
        [Key]public int IDEmpleado { get; set; }
        public String NombreE { get; set; }
        public String Contratacion { get; set; } 
        public virtual ICollection<Ventas> Empleados { get; set; }
    }
}
