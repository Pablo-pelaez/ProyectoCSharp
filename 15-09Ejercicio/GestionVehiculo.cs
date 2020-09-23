using System;

namespace ProyectoCSharp
{
    class GestionVehiculo
    {
        public String nom { get; set; }
        public String marcav { get; set; }
        public String modelov { get; set; }
        double comb;
        public double combustiblev 
        { 
            get{ return comb; }
            set
            { 
                if (value > 1)
                {
                    comb = value;
                }
                else
                {
                    Console.WriteLine("Ingresa un valor mayor a cero");
                }
            } 
        }
        double kilometro;
        public double kil 
        { 
            get{ return kilometro; }
            set
            {  
                if (value > 1)
                {
                    kilometro = value;
                }
                else
                {
                    Console.WriteLine("No has empezado la carrera!");
                }
            } 
        }

        public double ConsumoVehiculo(double combust, double kilrec)
        {
            double consumog;
            consumog = (combust / kilrec);

            Console.WriteLine("gastas " + consumog);

            // validar con get y set
            return consumog;
        }

        public void CombustibleRestante()
        {
            double combustibleg = ConsumoVehiculo(combustiblev, kil);
            double combustiblegI = combustibleg * 1000;


             if (combustibleg > 0 && combustibleg < 0.15)
             {
                 Console.WriteLine("El combustible gastado es: " + combustiblegI + "ml/km");
                 Console.WriteLine("Has hecho un consumo mínimo de combustible");
             }
             else
             {
                 if (combustibleg > 0.15 && combustibleg < 0.35)
                 {
                     Console.WriteLine("El combustible gastado es: " + combustiblegI + "ml/km");
                     Console.WriteLine("Has hecho un consumo decente de combustible");
                 }
                 else
                 {
                     if (combustibleg > 0.35 && combustibleg < 0.65)
                     {
                         Console.WriteLine("El combustible gastado es: " + combustiblegI + "ml/km");
                         Console.WriteLine("Has hecho un consumo considerable de combustible");
                     }
                     else
                     {
                         Console.WriteLine("El combustible gastado es: " + combustiblegI + "ml/km");
                         Console.WriteLine("Se te está acabando el combustible");
                     }
                 }
             }
        }

        // public void Datos(String nom, String marcav, String modelov)
        // {
        //     String data;
        //     Console.WriteLine("El condutor " + nom + "con el vehículo de marca " + marcav + " y modelo " + modelov + "tiene en la vuelta 1 las siguientes estadísticas:");

        //     return data;
        // }

    }
}