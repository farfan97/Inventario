﻿using inventario.COMMON.Entidades;
using inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeEmpleados : IRepositorio<Empleado>
    {
        public List<Empleado> Read => throw new NotImplementedException();

        public bool Create(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(Empleado entidadOriginal, Empleado entidadModificada)
        {
            throw new NotImplementedException();
        }
    }
}
