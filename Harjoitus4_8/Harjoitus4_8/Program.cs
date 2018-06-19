using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä yläraja kokonaislukuna: ");
            int ylaraja = Convert.ToInt32(Console.ReadLine());
            int numero=2;
            int jakaja;
            bool lippu=false;

            while (ylaraja >= numero)
            {
                
                jakaja = 2;

                while (numero >= jakaja)
                {
                    if (numero % jakaja == 0&&numero!=jakaja)
                    {
                       
                        lippu = true;
                    }
                   
                    jakaja++;
                }
                if (lippu == false)
                {
                    Console.WriteLine(numero);
                }
                else
                {
                    lippu = false;
                }
                numero++;
            }
        }
    }
}
