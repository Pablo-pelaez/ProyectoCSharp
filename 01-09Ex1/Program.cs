using System;  // librería genérica

namespace Ex1  // esapcio de nombre (carpeta del proyecto)
{
    class Program // clase/archivo donde codifico cierta tarea
    {
        static void Main(string[] args)  // método
        {
            Console.WriteLine("Thule");

            Console.WriteLine("Ingrese el número 1");
            int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"La suma de {n1} y {n2} es {suma});


            Console.WriteLine("Ingrese el número 2");
            int n2 = int.Parse(Console.ReadLine());

            /*
            Forma estructurada
            Console.WriteLine("El número ingresado es: " + n1);
            Console.WriteLine("El número ingresado es: " + n2);

            int suma = n1 + n2;
            Console.WriteLine("La suma de ambos números es: " + suma);
            //Console.WriteLine($"La suma de ambos números es: {n1 + n2}");
            */
            
            // Forma Orientada a Objetos
            // Instanciar la clase operaciones (objeto de la clase)
            // clase    objeto(instancia) (= new)PalabraReservada constructordelaClase            
            Operaciones myOperacion = new Operaciones()
            {
                num1 = n1, 
                num2 = n2
            };

            // verificar el valor que tiene la propiedad
            // Console.WriteLine(myOperacion.num1);

            // Llevar el valor como parametro a un metodo
            // Para hacer esto, llamar el metodo de la clase
            //Mediante de su instancia

            // myOperacion.sumar(myOperacion.num1, myOperacion.num2);
            myOperacion.imprimirSuma();
        }
    }
}
