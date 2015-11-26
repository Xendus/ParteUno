using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaseDatos.BD
{
    public class Producto
    {
        [Key]public int IDCodigo { get; set; }
        public String NombreP { get; set; }
        public String NombreCa { get; set; }
        public int Precio { get; set; }
        public virtual ICollection<Ventas> Productos { get; set; }
    }
}
