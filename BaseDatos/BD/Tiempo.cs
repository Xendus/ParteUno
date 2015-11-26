using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaseDatos.BD
{
    public class Tiempo
    {
    [Key]public int IDTiempo { get; set; }
    public String Dia { get; set; }
    public String Mes { get; set; }
    public String Año { get; set; }
    public virtual ICollection<Ventas> Ventas { get; set; }


    }
}
