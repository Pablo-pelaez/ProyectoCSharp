using System;

namespace ProyectoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de participantes de la competición: ");
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Estadística de consumo de gasolina en la vuelta 1 de la F1");

                Console.WriteLine("Ingrese el nombre del conductor: ");
                String nombre = Console.ReadLine();

                Console.WriteLine("Ingresa la marca del vehículo: ");
                String marca = Console.ReadLine();

                Console.WriteLine("Ingresa el modelo del vehículo: ");
                String modelo = Console.ReadLine();
                
                Console.WriteLine("Ingresa la capacidad de combustible de tu automóvil: ");
                double combustible = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa la cantidad de Kilómetros recorridos en la vuelta 1: ");
                double kilom = double.Parse(Console.ReadLine());


                // Realizar metodo que calcule el combustible gastado y el restante

                var estadisticas = new GestionVehiculo()
                {
                    combustiblev = combustible,
                    kil = kilom,
                    nom = nombre
                };


                estadisticas.CombustibleRestante();
            }
        }
    }
}
