using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Ejercicio_Consecioanaria
{
    public class Moto : Vehiculo
    {
        public Moto(string Marca, string Modelo) : base(Marca, Modelo)
        {
        }

        public override void MostrarDatos()
        {
            Console.WriteLine("--- Ficha de: MOTO ---");
            Console.WriteLine($"Vehículo: {Marca} {Modelo}");
            Console.WriteLine("Velocidad Máx: 180 km/h"); 
            Console.WriteLine("Precio: $10.000Usd");      
            Console.WriteLine("-----------------------");
        }
     
    }
}
