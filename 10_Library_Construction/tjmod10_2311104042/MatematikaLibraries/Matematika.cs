using System;

namespace MatematikaLibraries

{
    public static class Matematika
    {
        public static int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        public static int KPK(int a, int b)
        {
            return Math.Abs(a * b) / FPB(a, b);
        }

        public static string Turunan(int[] koef)
        {
            string hasil = "";
            for (int i = 1; i < koef.Length; i++)
            {
                int k = koef[i] * i;
                string term = $"{(k >= 0 && hasil != "" ? "+" : "")}{k}x^{i - 1}";
                hasil += term;
            }
            return hasil;
        }

        public static string Integral(int[] koef)
        {
            string hasil = "";
            for (int i = 0; i < koef.Length; i++)
            {
                double k = (double)koef[i] / (i + 1);
                string term = $"{(k >= 0 && hasil != "" ? "+" : "")}{k}x^{i + 1}";
                hasil += term;
            }
            return hasil + "+C";
        }
    }
}
