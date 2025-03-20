using System;

class A
{
    static void Main()
    {
        Console.Write("Masukkan satu huruf: ");
        char huruf = char.Parse(Console.ReadLine().ToUpper());

        if (huruf == 'A' || huruf == 'I' || huruf == 'U' || huruf == 'E' || huruf == 'O')
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }
    }
}
