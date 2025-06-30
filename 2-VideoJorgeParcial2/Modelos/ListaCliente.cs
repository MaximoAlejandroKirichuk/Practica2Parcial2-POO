using _2_VideoJorgeParcial2.Intreface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VideoJorgeParcial2.Modelos
{
    public class ListaCliente : IABM<Cliente>
    {
        private List<Cliente> _listaCliente = new List<Cliente>();
        public void Agregar(Cliente elementoAgregar)
        {
            _listaCliente.Add(elementoAgregar);
        }

        public void Bajar(Cliente elementoAgregar)
        {
        }

        public List<Cliente> MostrarLista()
        {
            return _listaCliente;
        }
        public void Modificar(Cliente elementoAgregar)
        {
            throw new NotImplementedException();
        }
    }
}
