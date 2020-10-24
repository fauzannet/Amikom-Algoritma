using System;
					
public class Program
{
	public static void Main()
	{
		string Username, Password;
    Console.Write("\n\n------------------------------------------------------\n");
		Console.WriteLine(" Masukkan Username dan Password");
    Console.WriteLine(" Username dan Password Default admin");
    Console.Write("------------------------------------------------------\n");
	  Console.Write("Username : ");
		Username = Console.ReadLine();
    Console.Write("Password : ");
    Password = Console.ReadLine();
    Console.Write("------------------------------------------------------\n");
		 if (Username == "admin" & Password == "admin")
    {
			 Console.WriteLine("\n\n Login Berhasil");
    }else
			 Console.WriteLine("\n\n Login Gagal");
	}
	}
