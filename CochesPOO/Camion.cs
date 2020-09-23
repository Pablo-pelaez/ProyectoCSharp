using System;

namespace CochesOOP
{
    class Camion : Vehiculo
    {
        //Propiedades específicas de Camion
        string tipoRemolque;
        public string Remolque
        {
            get
            {
                return tipoRemolque;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "cama baja":
                        tipoRemolque = value;
                        break;
                    case "estacas":
                        tipoRemolque = value;
                        break;
                    case "contenedor":
                        tipoRemolque = value;
                        break;
                    case "sisterna":
                        tipoRemolque = value;
                        break;
                    case "niñera":
                        tipoRemolque = value;
                        break;
                    default:
                        System.Console.WriteLine("Debes ingresar un tipo de remolque válido");
                        break;
                }
            }
        }

        public string listarRuta()
        {
            return Ruta.ToString();
        }
    }
}