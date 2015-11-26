using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaseDatos.BD
{
    public class Cliente
    {
        [Key]public int IDCliente { get; set; }
        public String NombreC { get; set; }
        public int Tel { get; set; }
        public String Correo { get; set; } 
        public virtual ICollection<Ventas> Clientes { get; set; }
    }
}
