using System;
using AljabarLibraries;

namespace ConsoleAppAljabar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mencari Akar Persamaan Kuadrat dari x^2 - 3x - 10");
            double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine($"Akar: {akar[0]} dan {akar[1]}");

            Console.WriteLine("\nMenghitung Hasil Kuadrat dari 2x - 3");
            double[] hasil = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine($"Hasil Kuadrat: {hasil[0]}x^2 + ({hasil[1]})x + {hasil[2]}");
        }
    }
}
