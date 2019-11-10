using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Entidades
{
    public class Material: Base
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int Cantidades { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }

    }
}
