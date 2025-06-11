using System;

namespace modul15_2311104042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Aplikasi Login/Register ===");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.Write("Pilih menu (1/2): ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Auth.Register();
                    break;
                case "2":
                    Auth.Login();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
