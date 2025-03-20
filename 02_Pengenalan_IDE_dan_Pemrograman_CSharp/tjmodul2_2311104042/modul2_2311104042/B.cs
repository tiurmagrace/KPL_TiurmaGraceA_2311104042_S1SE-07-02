using System;

class B
{
    static void Main()
    {
        int[] angka = new int[50];

        for (int i = 0; i < angka.Length; i++)
        {
            angka[i] = i;
        }

        for (int i = 0; i < angka.Length; i++)
        {
            Console.Write($"{angka[i]} "); 

            if (angka[i] % 6 == 0)
                Console.Write("#$#$"); 
            else if (angka[i] % 2 == 0)
                Console.Write("##");  
            else if (angka[i] % 3 == 0)
                Console.Write("$$");  

            Console.WriteLine(); 
        }
    }
}

