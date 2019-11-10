using inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Interfaces
{
    public interface IRepositorio<T> where  T:Base 
    {
        bool Create(T entidad);
        List<T> Read { get; }
        bool Update(T Id, T entidadModificada);
        bool Delete(T entidad);
    }
}
