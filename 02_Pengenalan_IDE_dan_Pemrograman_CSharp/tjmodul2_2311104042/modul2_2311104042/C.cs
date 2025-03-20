using System;

class C
{
    static void Main()
    {
        Console.Write("Masukkan angka (1 - 10000): ");
        int angka = Convert.ToInt32(Console.ReadLine()); 

        bool isPrima = CekBilanganPrima(angka);

        if (isPrima)
            Console.WriteLine($"Angka {angka} merupakan bilangan prima.");
        else
            Console.WriteLine($"Angka {angka} bukan merupakan bilangan prima.");
    }

    static bool CekBilanganPrima(int n)
    {
        if (n < 2) return false; 
        for (int i = 2; i * i <= n; i++) 
        {
            if (n % i == 0)
                return false; 
        }
        return true; 
    }
}
