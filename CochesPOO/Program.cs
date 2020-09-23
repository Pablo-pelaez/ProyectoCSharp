using System;

namespace CochesOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONCESIONARIO");

            Console.WriteLine("Marca");
            string marca = Console.ReadLine();
            Console.WriteLine("Serie");
            string serie = Console.ReadLine();
            Console.WriteLine("Modelo");
            short modelo = short.Parse(Console.ReadLine());
            Console.WriteLine("Placa");
            string placa = Console.ReadLine();
            System.Console.WriteLine("Tipo de Remolque");
            string remolque = Console.ReadLine();
            System.Console.WriteLine("Tipo de taxímetro");
            string taximetro = Console.ReadLine();


            //Instanciar la class vehiculo

            /*var vehiculoUno = new Vehiculo()
            {
                Marca = marca,
                Serie = serie,
                Modelo = modelo,
                Placa = placa
            };*/

            /*Console.WriteLine("Vehículo tipo " + vehiculoUno.Marca + "serie" + vehiculoUno.Serie);
            Console.WriteLine(vehiculoUno.MarcaSerie);

            vehiculoUno.prender();*/

            //Instancia de herencia

            var CamionUno = new Camion()
            {
                Marca = marca,
                Serie = serie,
                Modelo = modelo,
                Placa = placa,
                Remolque = remolque
            };

            Console.WriteLine($"{CamionUno.MarcaSerie} con remolque {CamionUno.Remolque}");
            // Console.WriteLine(CamionUno.MarcaSerie + " con remolque" + CamionUno.Remolque);

            var Taxis = new Taxi()
            {
                Marca = marca,
                Serie = serie,
                Modelo = modelo,
                Placa = placa,
                tipoTaximetro = taximetro
            };

            System.Console.WriteLine($"{CamionUno.MarcaSerie} con un taxímetro de tipo {Taxis.tipoTaximetro}");
        }
    }
}
