using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama kelurahan: ");
        string? kelurahan = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(kelurahan))
        {
            Console.WriteLine("Nama kelurahan tidak boleh kosong.");
        }
        else
        {
            string kodePos = KodePos.GetKodePos(kelurahan);
            Console.WriteLine($"Kode pos {kelurahan}: {kodePos}");
        }

        Console.ReadLine(); // Mencegah konsol langsung tertutup
    }
}