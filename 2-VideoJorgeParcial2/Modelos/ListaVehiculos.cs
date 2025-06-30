using _2_VideoJorgeParcial2.Intreface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VideoJorgeParcial2.Modelos
{
    public class ListaVehiculos: IABM<Vehiculo>
    {
        private List<Vehiculo> _listaVehiculo = new List<Vehiculo>();

        public void Agregar(Vehiculo elementoAgregar)
        {
            _listaVehiculo.Add(elementoAgregar);
        }

        public void Bajar(Vehiculo elementoAgregar)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Vehiculo elementoAgregar)
        {
            throw new NotImplementedException();
        }

        public List<Vehiculo> MostrarLista()
        {
            return _listaVehiculo;
        }


    }
}
