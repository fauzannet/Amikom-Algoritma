using System;
					
public class Program
{
	public static void Main()
	{
		double nilai;
    bool While = true;
    while(While)
    {
    Console.Write("\n\n------------------------------------------------------\n");
		Console.WriteLine(" Klasifikasi Nilai");
    Console.Write("------------------------------------------------------\n");
	  Console.Write("Jumlah Nilai : ");
		nilai = Convert.ToInt32(Console.ReadLine());
		 if (nilai>80 && nilai>=100)
    {
			 Console.WriteLine("Menjadi Nilai A");
           Console.Write("------------------------------------------------------\n");
    }
    else if (nilai>60 && nilai<=80)
    {
			 Console.WriteLine("Menjadi Nilai B");
           Console.Write("------------------------------------------------------\n");
    }
    else if (nilai>40 && nilai<=60)
    {
			 Console.WriteLine("Menjadi Nilai C");
           Console.Write("------------------------------------------------------\n");
    }
    else if (nilai>20 && nilai<=40)
    {
			 Console.WriteLine("Menjadi Nilai D");
           Console.Write("------------------------------------------------------\n");
    }
    else if (nilai>1 && nilai<=20)
    {
			 Console.WriteLine("Menjadi Nilai E");
           Console.Write("------------------------------------------------------\n");
    }
	}
  }
	}
