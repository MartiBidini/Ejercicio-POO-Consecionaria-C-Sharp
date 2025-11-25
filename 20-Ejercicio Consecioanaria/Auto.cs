using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Ejercicio_Consecioanaria
{
    public class Auto:Vehiculo
    {
        public Auto(string Marca,string Modelo) : base(Marca, Modelo)
         { 
        
         }
        public override void MostrarDatos()
        {
            Console.WriteLine("--- Ficha de: AUTO ---");
            Console.WriteLine($"Vehículo: {Marca} {Modelo}");
            Console.WriteLine("Velocidad Máx: 220 km/h");
            Console.WriteLine("Precio: $30.000Usd");
            Console.WriteLine("-----------------------");
        }
    }
}
