using System;

namespace CochesOOP
{
    class Vehiculo
    {
        //Propiedades

        /* Modificador de acceso 
           public: esta propiedad/método se puede usar de forma global
           private: esta propiedad/método solo se usa en la clase
           protected: esta propiedad/método se puede usar en las clases que heredan de la clase 
                      padre donde están las propiedades/métodos 
        */
        public string Marca { get; set; }
        public string Serie { get; set; }

        //Ej concatenar propiedades (Marca y Serie)

        public string MarcaSerie
        {
            get
            {
               return $"Vehículo de marca {Marca} y serie {Serie}";
            }
        }

        short modelo;
        public short Modelo { 
            get
            {
                return modelo;
            }
            set
            {
                if (value > 2017 && value < 2022)
                {
                    modelo = value;
                }
                else
                {
                    Console.WriteLine("Modelo no valido");
                }                
            }
        }


        string placa;
        public string Placa {
            get
            {
                return placa;
            }
            set
            {
                if (value.Length == 6)
                {
                    placa = value;
                }
                else
                {
                    Console.WriteLine("La placa debe ser de 6 digitos");
                }
            }
        }

        protected string Ruta { get; set; }


        //Metodos
        public void prender()
        {
            Console.WriteLine("El vehiculo esta prendiendo");        
        }


    }
}