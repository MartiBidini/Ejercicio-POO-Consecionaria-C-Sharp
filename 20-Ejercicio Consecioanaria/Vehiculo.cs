using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Ejercicio_Consecioanaria
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }

        public abstract void MostrarDatos();
    }
}

    
