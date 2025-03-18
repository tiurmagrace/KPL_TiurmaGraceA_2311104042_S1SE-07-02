using System;

namespace tjmod5_2311104042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Implementasi Generic Method ===");

            // Sesuai NIM akhiran 2 => tipe data float
            float angka1 = 23f; // dua digit pertama NIM
            float angka2 = 11f; // dua digit kedua NIM
            float angka3 = 4f;  // dua digit ketiga NIM (04)

            var hasil = Penjumlahan.JumlahTigaAngka<float>(angka1, angka2, angka3);
            Console.WriteLine($"Hasil penjumlahan tiga angka: {hasil}");

            Console.WriteLine("\n=== Implementasi Generic Class ===");

            // Implementasi Generic Class
            SimpleDataBase<int> database = new SimpleDataBase<int>();

            database.AddNewData(23);
            database.AddNewData(11);
            database.AddNewData(4);

            database.PrintAllData();

            Console.ReadKey();
        }
    }
}
