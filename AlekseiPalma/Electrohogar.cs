using System;
using System.Collections.Generic;
using System.Text;

namespace AlekseiPalma
{
    class Electrohogar : Elementos
    {
        public int Voltaje;
        public int Temperatura;

        

        public void AjustarTemperatura()
        {
            int NewTemp;

            Console.WriteLine("Introduzca la nueva temperatura...");

            NewTemp = Convert.ToInt32 (Console.ReadLine());

            Temperatura = NewTemp;

            Console.WriteLine("La nueva temperatura es {0} C°", Temperatura);

            Program.Mesa();
        }
    }
}
