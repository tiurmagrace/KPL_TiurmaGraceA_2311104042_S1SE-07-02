﻿class Program
{
    static void Main1()
    {
        Console.Write("Masukkan nama buah: ");
        string inputBuah = Console.ReadLine();
        Console.WriteLine("Kode untuk {0} adalah: {1}", inputBuah, KodeBuah.getKodeBuah(inputBuah));
    }
}
