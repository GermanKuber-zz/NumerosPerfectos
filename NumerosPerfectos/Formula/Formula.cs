using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPerfectos
{
    public class Formula
    {

        public Boolean EsPrimo(Double num)
        {

            int suma = 0;
            for (Double i = num; i >= 1; i--)
            {
                if (num % i == 0)
                {
                    suma += 1;
                }
            }

            if (suma == 2)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public void VerDivisores(Double num)
        {

            for (Double i = num - 1; i >= 1; i--)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public Double ForEuclides(Double test)
        {

            Double NumPrueba, Res;
            //se evalua el segundo termio de la formula de euclides
            NumPrueba = (Math.Pow(2, test) - 1);
            // si el segundo termino da como resultado un numero primo se aplica la ecuacion
            if (EsPrimo(NumPrueba))
            {
                // n = (2ˆ(n-1))((2ˆn) -1) ---- ecuacion de Euclides
                // se le asigna a "Res" el numero perfecto resultante de la ecuacion
                Res = (Math.Pow(2, (test - 1))) * (Math.Pow(2, test) - 1);
                return Res;

            }
            else
            {
                return 0;
            }
        }
    }
}
