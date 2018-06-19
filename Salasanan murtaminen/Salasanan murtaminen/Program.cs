using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Salasanan_murtaminen
{
    class Program
    {
        static void Main(string[] args)
        {
            string murrettava_salasana = Console.ReadLine();
            string hash1 = "";

            byte[] encodedPassword1 = new UTF8Encoding().GetBytes(murrettava_salasana);
            byte[] hash3 = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword1);
            hash1 = BitConverter.ToString(hash3).Replace("-", string.Empty).ToLower();

            Console.WriteLine(hash1);
            string salasana = "";
            string merkit = "0123456789abcdefghijklmnopqrstuvwxyz";
            string hash2 = "";

            foreach (char c1 in merkit)
            {
                foreach(char c2 in merkit)
                {
                    foreach (char c3 in merkit)
                    {
                        foreach (char c4 in merkit)
                        {
                            salasana = "" + c1 + c2 + c3 + c4;
                            byte[] encodedPassword = new UTF8Encoding().GetBytes(salasana);
                            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
                            hash2 = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
                            if(hash2==hash1)
                            {
                                goto Lopetus;
                            }
                            
                        }
                    }

                }

            }
        Lopetus:
            Console.WriteLine("Mursin salasanasi ja se on: " + salasana);
        }
    }
}
