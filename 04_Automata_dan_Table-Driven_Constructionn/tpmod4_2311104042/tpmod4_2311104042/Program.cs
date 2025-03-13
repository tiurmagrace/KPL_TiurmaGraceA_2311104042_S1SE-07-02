using System;
using System.Collections.Generic;
using tpmod4_2311104042;

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

        Console.ReadLine();
    }
}
