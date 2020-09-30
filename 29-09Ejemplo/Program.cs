using System;

namespace _29_09Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Planet\n");

            System.Console.WriteLine("Ingrese el tipo de animal");
            string tipoAnimal = Console.ReadLine();
            System.Console.WriteLine("Ingrese la raza del animal");
            string razaAnimal = Console.ReadLine();
            System.Console.WriteLine("Ingrese la edad del animal");
            int edad =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Tipo de entrenamiento");
            string tipoE = Console.ReadLine();

            var dog = new perro()
            {
                tipoAnimal = tipoAnimal,
                raza = razaAnimal,
                edad = edad,
                tipoEntrenamiento = tipoE
            };

            System.Console.WriteLine($"{dog.tipoAnimal} {dog.raza} {dog.edad}");
            dog.mostrarTE();

            System.Console.WriteLine($"{cat.tipoAnimal} {cat.raza} {cat.edad}");

        }
    }
}
