namespace Demo
{
	class Program
		{
			static void Main(string [] args)
			{
				System.Console.Write("Anna luku kuinka monta kertaa haluat, että lause tulostuu: ");
				int a = int.Parse(System.Console.ReadLine());
				
				if (a!=0){
				for(int i=0;i<=a;i++)
				{
					System.Console.WriteLine("Tämä on C# kurssin eka harjoitus");
					
				}	}
				else if(a==0)
					System.Console.WriteLine("Tämä on C# kurssin eka harjoitus");
			}
		}
}		