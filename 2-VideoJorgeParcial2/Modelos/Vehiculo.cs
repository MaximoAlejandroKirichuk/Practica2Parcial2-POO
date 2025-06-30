using _2_VideoJorgeParcial2.Intreface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_VideoJorgeParcial2.Modelos
{
    public abstract class Vehiculo : IVehiculo<Vehiculo>
    {
        
        public int VelocidadActual { get; set; }
        public int CantidadPasajeros { get; set; }
        public string TipoCombustible { get; set; }
        public int IDVehiculo { get; set; }
        public string Dominio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Disponible { get; set; }

        //DELEGADO: indican que forma debe tener el metodo escucha
        public delegate void AlquilerHandler(string mensaje);
        public delegate void DevolucionHandler(string mensaje);

        //EVENTOS: se activan cuando se alquila o se devuelve el vehiculo.
        public event AlquilerHandler AlquilarVehiculo;
        public event DevolucionHandler DevolverVehiculo;

        public virtual void Alquilar()
        {
            Disponible = false;
            AlquilarVehiculo?.Invoke("El vehiculo fue alquilado");
        }
        public virtual void Devolver()
        {
            Disponible = true;
            DevolverVehiculo?.Invoke("El vehiculo fue devuelto");
        }
        protected Vehiculo(bool disponible)
        {
            this.Disponible = disponible;
        }
        public void Arrancar()
        {
            throw new NotImplementedException();
        }

        public void Detener()
        {
            throw new NotImplementedException();
        }

        public void Acelerar()
        {
            throw new NotImplementedException();
        }

        public void Frenar()
        {
            throw new NotImplementedException();
        }

        public Vehiculo ObternerEstado(int IDVehiculo)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{IDVehiculo};{Nombre};{TipoCombustible};{CantidadPasajeros};{Dominio};{Disponible};{Descripcion}";
        }
    }
}
