using System;
using System.Collections.Generic;
using System.Text;

namespace AlekseiPalma
{
    class ArticulosDeLimpieza
    {
        public int NumeroDeHojas = 100;
        public int LargoHojas;
        public int AnchoHojas;

        public void SacarHoja()
        {
            string Opcion;
            int HojasR;
            int x;

            Console.WriteLine("Introduzca la cantidad de hojas a sacar...");

            HojasR = Convert.ToInt32(Console.ReadLine());

            x = NumeroDeHojas - HojasR;

            NumeroDeHojas = x;

            if(x > 0)
            {
                Console.WriteLine("Se han sacado {0} hojas", HojasR);
                Console.WriteLine("Quedan {0} hojas", NumeroDeHojas);

                Console.WriteLine("¿Desea sacar mas hojas? Escriba <O> para si y <X> para no");
                Opcion = Console.ReadLine().ToUpper();

                if (Opcion == "O")
                {
                    SacarHoja();
                }
                else if (Opcion == "X")
                {
                    Program.Preparar();
                }
            }
            else if (x <= 0)
            {
                Console.WriteLine("Has agotado un rollo entero");

                Program.Preparar();
            }
        }
    }
}
