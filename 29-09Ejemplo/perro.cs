using System;

namespace _29_09Ejemplo
{
    class perro : animalDomestico
    {
        //propiedades
        private string tipoEntrenamiento { get; set; }

        public void mostrarTE()
        {
            System.Console.WriteLine();
            Console.WriteLine(tipoEntrenamiento);
        }
    }
}