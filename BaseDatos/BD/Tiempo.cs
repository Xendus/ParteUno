﻿using System;
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
    public String NumeroDeEntrega { get; set; }
    public String NombreProveedor { get; set; }
    public virtual ICollection<Ventas> Ventas { get; set; }


    }
}
