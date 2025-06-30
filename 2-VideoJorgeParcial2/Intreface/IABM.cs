using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VideoJorgeParcial2.Intreface
{
    public interface IABM<T>
    {
        void Agregar(T elementoAgregar);
        void Bajar(T elementoAgregar);
        void Modificar(T elementoAgregar);
    }
}
