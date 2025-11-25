using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Ejercicio_Consecioanaria
{
    public class Camioneta : Vehiculo,ICargable
    {
        public Camioneta(string Marca, string Modelo) : base(Marca, Modelo)
        {
        }
        public override void MostrarDatos()
        {
            Console.WriteLine("--- Ficha de: Camioneta ---");
            Console.WriteLine($"Vehículo: {Marca} {Modelo}");
            Console.WriteLine("Velocidad Máx: 210 km/h");
            Console.WriteLine("Precio: $50.000Usd");
            
        }
        public void Cargar()
        {
            Console.WriteLine("La camioneta esta cargando...");
            Console.WriteLine("-----------------------");
        }
        public void Descargar()
        {
            Console.WriteLine("La camioneta esta descargando..");
            Console.WriteLine("-----------------------");
        }
    }
}
