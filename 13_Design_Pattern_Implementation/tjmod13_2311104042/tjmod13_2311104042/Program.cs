using System;

namespace tj13_2311104042
{
    class Program
    {
        static void Main(string[] args)
        {
            var data1 = PusatDataSingleton.GetDataSingleton();
            var data2 = PusatDataSingleton.GetDataSingleton();

            data1.AddSebuahData("Tiurma Grace Angelina");
            data1.AddSebuahData("caca");
            data1.AddSebuahData("cici");
            data1.AddSebuahData("Asisten: cece");

            Console.WriteLine("Data2 sebelum penghapusan:");
            data2.PrintSemuaData();

            data2.HapusSebuahData(3);

            Console.WriteLine("\nData1 setelah penghapusan dari data2:");
            data1.PrintSemuaData();

            Console.WriteLine($"\nJumlah data (data1): {data1.GetSemuaData().Count}");
            Console.WriteLine($"Jumlah data (data2): {data2.GetSemuaData().Count}");

            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}
