using System;

namespace Ex2
{
    class GestionHotel
    {
        // Propiedades
        public string habitacion { get; set; }
        public int huesped { get; set; }
        int Dias;
        //public int dias { get; set; }
        public int dias 
        { 
            get { return Dias; } 
            set 
            {
                if (value >= 1)
                {
                    Dias = value;
                }
                else
                {
                    Console.WriteLine("La cantidad de días debe ser al menos 1");
                }
            }
        }

        // Métodos
        public int valorEstadia(int huesp, int ndias)
        {
            int TINDIVIDUAL = 2500;
            int TDOBLE = 4600;
            int TFAMILIAR = 5200;
            int cobro = 0;

            switch (huesp)
            {
                case 1:
                    cobro = ndias * TINDIVIDUAL;
                break;

                case 2:
                    cobro = ndias * TDOBLE;
                break;

                default:
                    cobro = ndias * TFAMILIAR;
                break;             
            }return cobro;
            
        }

        public void cuntaCobro()
        {
            int IVA = 19;
            int preciosinIVA = 0;
            int precioconIVA = 0;
            preciosinIVA = valorEstadia(huesped, dias);

            precioconIVA = ((preciosinIVA * IVA) / 100 + preciosinIVA);

            Console.WriteLine(precioconIVA);
            
        }
    }
}