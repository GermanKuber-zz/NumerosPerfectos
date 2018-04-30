using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPerfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cant = 0, Num = 2;
            Double NumeroPerfecto = 0;

            Formula Prueba = new Formula();

            while (Num < 11)
            {

                NumeroPerfecto = Prueba.ForEuclides(Num);
                if (NumeroPerfecto > 0)
                {
                    Cant += 1;
                    Prueba.VerDivisores(NumeroPerfecto);
                    Console.WriteLine($"Total es: {NumeroPerfecto}");
                    Console.WriteLine($"{Cant}. Numero Perfecto: {NumeroPerfecto}");
                }
                Num += 1;
            }

        }

    }
}
