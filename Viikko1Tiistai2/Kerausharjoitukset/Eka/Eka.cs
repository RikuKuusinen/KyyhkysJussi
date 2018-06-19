namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                System.Console.WriteLine("parametri(t) puuttuu!");
                return;
            }
            int tulostusLkm = 0; // muista demota mitä warning tarkoittaa
            tulostusLkm = int.Parse(args[0]);
            int sisennys = 0;
            string tulostus = "Tämä on C# -kurssin eka harjoitus";
            if (args.Length >= 2)
            {
                sisennys = int.Parse(args[1]);
            }
            if (args.Length >= 3)
            {
                tulostus = args[2];
            }
            for (int i = 0; i < tulostusLkm; i++)
            {
                for (int j = 0; j < sisennys; j++)
                {
                    System.Console.Write(' ');
                }
                System.Console.WriteLine(tulostus);
            }

        }
    }
}

