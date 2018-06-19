namespace Demo
{
	class Program
		{
			static void Main(string [] args)
			{
				string tulostus = "Tämä on C# kurssin eka harjoitus";
				int sisennys = 0;
				int tulostusLkm= 0;
				
			if(args.Length==0){
				System.Console.WriteLine("parametri puuttuu!");
				return;
				}
								
				if(args.Length>=1){
				sisennys=int.Parse(args[1]);}
				
							
				tulostusLkm=int.Parse(args[0]);
				
				sisennys=int.Parse(args[1]);
				
				for(int i=0;i<tulostusLkm;i++)
				{  for ( int j =0;j<sisennys;j++){
					System.Console.Write(' ');
					
				}}	
			}
		}
}		