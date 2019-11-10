using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Entidades
{
    public class Empleado: Base
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Area { get; set; }
        public string Puesto { get; set; }
    }
}
