using System;

namespace _29_09Ejemplo
{
    class animalDomestico
    {
        //propiedades
        public string tipoAnimal { get; set; }
        public string raza { get; set; }
        public int edad { get; set; }


        //métodos
        public void comer()
        {
            Console.WriteLine("Está comiendo");
        }
    }
}