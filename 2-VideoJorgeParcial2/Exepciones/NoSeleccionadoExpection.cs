using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VideoJorgeParcial2.Exepciones
{
    internal class NoSeleccionadoExpection : Exception
    {
        public override string Message => $"No se selecciono un tipo de vehiculo";
    }
}
