using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            System.Text.StringBuilder v = new System.Text.StringBuilder(1054);

            v.Append(s);

            for (int i = 0; i < v.Length;)
            {
                if(v[i]==' ' || v[i] == ',' || v[i] == '.')
                {
                    v.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }



            System.Text.StringBuilder x = new System.Text.StringBuilder(v.Length);
            for(int i = v.Length - 1; i >=0; i--)
            {
                x.Append(v[i]);
            }
            
            string jono = v.ToString();
            return jono == string.Join("", jono.Reverse());
           

            //for (int i = 0; i < v.Length; i++)
            //{
            //    if (x[i] != v[i])
            //    {
            //        return false;
            //    }
            //    else return true;
            //}

            //foreach (var i in charArray)
            //{
            //    (i)
            //}

            //Array.Reverse(charArray);



            //bool OnkoPalindromi(string s)
            //{
            //    if ()
            //}


        }
    }
}
