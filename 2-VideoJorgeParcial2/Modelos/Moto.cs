using _2_VideoJorgeParcial2.Intreface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VideoJorgeParcial2.Modelos
{
    public class Moto : Vehiculo
    {
        public Moto(bool disponible, int idVehiculo, string dominio, string tipoCombustible, string nombre, string descripcion) : base(disponible)
        {
            this.Descripcion = descripcion;
            this.Disponible = disponible;
            this.IDVehiculo = idVehiculo;
            this.CantidadPasajeros = 2;
            this.Dominio = dominio;
            this.TipoCombustible = tipoCombustible;
            this.Nombre = nombre;
        }

        
    }
}
