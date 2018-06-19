using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Viitenumerolaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna laskunnumero: ");
            string laskunNumero = (Console.ReadLine());
            
            string n;
            int summa = 0;
            int numero =0;
            int[] painoArvot = { 7, 3, 1 };
            int painoArvoCounter =0;

            Console.Write("Monella nostetaan laskunnumeroa? ");
            int increment = Convert.ToInt32(Console.ReadLine());

            int nro=Convert.ToInt32(laskunNumero);

            nro += increment;

            string r=Convert.ToString(nro);

            Console.WriteLine("Laskunnumero lisäyksen jälkeen: "+r);

            int loppuSumma = 0;


            char[] inputarray = r.ToCharArray();
            Array.Reverse(inputarray);
            string output = new string(inputarray);

            



            //Console.WriteLine("Kuinka monta kertaa viitenumero tulostetaan? ");
            //int kerrat= Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i<r.Length; i++)
            {
                n = output.Substring(i,1);
                                            
                numero=Convert.ToInt32(n);
                
                
                summa = numero * painoArvot[painoArvoCounter];
                Console.WriteLine("Summa on :" + summa);

                painoArvoCounter++;

                if (painoArvoCounter == 3)
                {
                    painoArvoCounter = 0;
                }

                loppuSumma += summa;

                Console.WriteLine(loppuSumma);

            }



            int tarkista = (((summa / 10) + 1) * 10) - summa;
            if (tarkista == 10)
            {
                tarkista = 0;
            }
            return "${nro4}{tarkista} ";

        }
    }
}
