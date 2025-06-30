using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VideoJorgeParcial2.Intreface
{
    public interface IVehiculo<T>
    {

        void Arrancar();
        void Detener();
        void Acelerar();
        void Frenar();
        T ObternerEstado(int IDVehiculo); //me devuelve la info que le pido
    }
}
