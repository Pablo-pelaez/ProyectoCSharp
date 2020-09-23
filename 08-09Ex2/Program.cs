using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenidos al Hotel Dumort");

            Console.WriteLine("Número de huéspedes");
            int huespedes = int.Parse(Console.ReadLine());

            Console.WriteLine("Días de estadía");
            int nrod = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de la habitación");
            string nomHab = Console.ReadLine();

            //Instancia
            var hotel1 = new GestionHotel()
            {
                habitacion = nomHab,
                huesped = huespedes,
                dias = nrod
            };

            hotel1.cuntaCobro();
            
        }
    }
}
