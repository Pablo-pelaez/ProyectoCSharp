using System;

namespace CochesOOP
{
    class Taxi:Vehiculo
    {
        string tipotaxim;
        public string tipoTaximetro 
        { 
            get
            {
                return tipotaxim;
            } 
            set
            {
                if(value == "mecanico")
                {
                    tipotaxim = value;
                }
                else
                {
                    if(value == "electronico")
                    {
                        tipotaxim = value;
                    }
                    else
                    {
                        System.Console.WriteLine("Tipo de taxímetro inexistente; por favor ingresa uno válido");
                    }
                }
            } 
        }

        public string listarRuta()
        {
            return Ruta.ToString();
        }
    }
}