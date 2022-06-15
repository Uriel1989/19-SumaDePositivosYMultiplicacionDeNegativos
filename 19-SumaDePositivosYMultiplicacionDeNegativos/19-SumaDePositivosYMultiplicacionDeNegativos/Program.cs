using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19_SumaDePositivosYMultiplicacionDeNegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a, b, c;
            b = 1;
            c = 0;

            Console.WriteLine("Ingresar 10 numeros ");


            for (i = 1; 1 <= 10; i++)
            {

                i = Convert.ToInt32(Console.ReadLine());

                if (i > 0)
                {
                    c = c + i;
                    Console.WriteLine("La suma de los numeros positivos da " + c);
                }
                else
                if (i < 0)
                {
                    b = b * i;
                    Console.WriteLine("El producto de los numeros negativos da " + b);
                }
            }

            Console.WriteLine("La suma de los numeros positivos da " + c);



            Console.ReadKey();
        }
    }
}
