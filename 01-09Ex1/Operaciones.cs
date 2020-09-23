using System;

namespace Ex1
{
    internal class Operaciones
    {
        // Atributos (propiedades)
        public      int         num1              { get; set; }
    //  modif acc   tip dato   nom propiedad   métodos a recibir(set) y para entregar(get) el valor de la propiedad.
        public int num2 { get; set; }
        
        /*
        // Métodos (funciones)
        public void sumar(int nUno, int nDos)
        // mod acc tipo retorno nombreMetodo (parametros)
        {
            int suma = nUno + nDos;
            Console.WriteLine("La suma de estos numeros es: " + suma);
        } */
        public int calcular(int nUno, int nDos)
        {
            int resultadoSuma = 0;
            
            resultadoSuma = nUno + nDos;

            return resultadoSuma;

        }

        public void imprimirSuma()
        {
            Console.WriteLine("La suma de ambos números es: " + calcular(num1, num2));
        }
    }
}