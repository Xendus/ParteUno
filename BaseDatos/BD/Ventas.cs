using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaseDatos.BD
{
    public class Ventas
    {
       
        [Key]public int IDVenta { get; set; }
        public virtual int IDTiempo { get; set; }
        public virtual int IDCodigo { get; set; }
        public virtual int IDCliente { get; set; }
        public virtual int IDEmpleado { get; set; }
        public string DiaReq { get; set; }
        public int CantUn { get; set; }
        
    }
}
