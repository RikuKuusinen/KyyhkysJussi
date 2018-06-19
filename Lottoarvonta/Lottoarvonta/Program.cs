using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lottoarvonta
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] rivi = new int[7];
            Console.WriteLine("Anna 7 lukua, jotka ovat väliltä 1-40: ");


            for (int i = 0; i < 7; i++)
                rivi[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tämän illan lottorivi: ");

            Random rng = new Random();
            int[] lottoRivi = new int[7];

            Random rng2 = new Random();
            int[] lisaNumerot = new int[2];
            

            for (int a = 0; a < 7; a++)
            {
                
                    lottoRivi[a] = rng.Next(1, 41);

                    Console.WriteLine(lottoRivi[a]);

                 for(int b = 0; b < a; b++)
                {
                    
                    if (lottoRivi[a] == lottoRivi[b])
                        a--;
                }               
                
            }
            Console.WriteLine("\nJa lisänumerot ovat: ");
            for(int l = 0; l < 2; l++)
            {
                lisaNumerot[l] = rng.Next(1, 41);
                Console.WriteLine(lisaNumerot[l]);

                for (int p = 0; p < l;p++)
                {
                    if (lisaNumerot[l]==lottoRivi[p])
                        l--;
                }
            }
            int osuma=0;
                       
            
                for (int j = 0; j < lottoRivi.Length; j++)
                {

                    for (int u = 0; u < rivi.Length; u++)
                    {
                        if (rivi[u] == lottoRivi[j])
                            osuma++;
                        
                    }

                }
            
               
                
            Console.WriteLine("Sinulla on " + osuma + " osumaa!");

        }
    }
}
