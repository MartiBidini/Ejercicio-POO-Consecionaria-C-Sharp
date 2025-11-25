using System.Reflection.Metadata.Ecma335;

namespace _20_Ejercicio_Consecioanaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> consecionaria = new List<Vehiculo>();
            //Los autos de aca ya estan por defecto

            consecionaria.Add(new Auto("Ford","Fiesta"));
            consecionaria.Add(new Moto("Honda", "Titan"));
            consecionaria.Add(new Camioneta("Toyota", "Hilux"));

            while(true)//se ejecuta siempre al menos q el usuario elija "3"
            {
                Console.WriteLine("--- BIENVENIDO A CONCESIONARIA ---");
                Console.WriteLine("1. Agregar Vehículo");
                Console.WriteLine("2. Ver Vehículos en la Concesionaria");
                Console.WriteLine("3. Salir");
                Console.Write("Por favor, elija una opción: ");

                string entradausuario=Console.ReadLine();

                int opcion;//alamcena el numero q verifica el tryparse si es valido

                if(!int.TryParse(entradausuario, out opcion))
                {
                    Console.WriteLine("Error: Eso no es un número. Intente de nuevo.");

                    continue;//hace q retorne al while
                }

                switch (opcion)
                    {
                      case 1:
                        AgregarVehiculos(consecionaria); break;

                    case 2:
                        MostrarVehiculos(consecionaria); ;break;

                    case 3:
                        Console.WriteLine("Gracias por usar la consecionaria!!");
                        return;

                    default:
                        Console.WriteLine("Opcion invalida,escribe un numero valido");
                        break;
                }
            }
        }
        public static void MostrarVehiculos(List<Vehiculo> Listavehiculos)
        {
            foreach (Vehiculo vehiculo in Listavehiculos)
            {
                vehiculo.MostrarDatos();

                if (vehiculo is ICargable cargadescarga)
                {
                    cargadescarga.Cargar();
                    cargadescarga.Descargar();

                }
            }
        }
        public static void AgregarVehiculos(List<Vehiculo> Listavehiculos)
        {
            Console.WriteLine("¿Qué tipo de vehículo desea agregar?");
            Console.WriteLine("1. Auto");
            Console.WriteLine("2. Moto");
            Console.WriteLine("3. Camioneta");
            Console.Write("Elija una opción: ");

           string agregar=Console.ReadLine();
           int TipoVehiculo;//en esta caja se almacena lo q elijan en la variable agregar
           if(!int.TryParse(agregar,out TipoVehiculo))
            {
                Console.WriteLine("Elija un numero valido");

                return;
            }

            Console.WriteLine("Ingresa la Marca");
            string Marca=Console.ReadLine();

            Console.WriteLine("Ingresa el Modelo");
            string Modelo=Console.ReadLine();

               switch (TipoVehiculo)
            {
                case 1:
                    Listavehiculos.Add(new Auto($"{Marca}", $"{Modelo}"));break;

                case 2:
                    Listavehiculos.Add(new Moto($"{Marca}", $"{Modelo}"));break;

                case 3:
                    Listavehiculos.Add(new Camioneta($"{Marca}", $"{Modelo}")); break;

                default:
                    Console.WriteLine("Error,Escribe un numero valido");
                    break;
            }
        }

    }
}
