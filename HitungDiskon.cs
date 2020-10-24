using System;
					
public class Program
{
	public static void Main()
	{
    double total;
		Console.Write("\n\t**SYSTEM TOKO ONLINE A**\n\n");
		Console.WriteLine("Masukkan Jumlah Belanjaan : ");
		total = Convert.ToInt32(Console.ReadLine());
		if(total>=150000){
			Console.WriteLine("Total Belanjaan : "+total+" Dan Berhak Mendapatkan Diskon");
      double diskon;
      Console.WriteLine("\n Masukkan Jumlah Diskon : ");
      diskon = Convert.ToInt32(Console.ReadLine());
      double persen = diskon/100;
      double hasil = total*persen;
      double hasilakhir = total-hasil;
      Console.WriteLine("Total Belanjaan dengan Diskon "+hasilakhir);
		}else{
			Console.WriteLine("total Belanjaan Kurang Untuk Mendapatkan Diskon");
		}
  }

}
