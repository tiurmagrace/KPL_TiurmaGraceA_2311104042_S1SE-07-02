using System;
using MatematikaLibraries;

class Showcase
{
    static void Main()
    {
        int a = 12, b = 18;
        Console.WriteLine($"FPB dari {a} dan {b} = {Matematika.FPB(a, b)}");
        Console.WriteLine($"KPK dari {a} dan {b} = {Matematika.KPK(a, b)}");

        int[] polinomial = { -3, 6, 0, -4 }; 
        Console.WriteLine("Turunan dari -3 + 6x - 4x^3 = " + Matematika.Turunan(polinomial));
        Console.WriteLine("Integral dari -3 + 6x - 4x^3 = " + Matematika.Integral(polinomial));
    }
}
