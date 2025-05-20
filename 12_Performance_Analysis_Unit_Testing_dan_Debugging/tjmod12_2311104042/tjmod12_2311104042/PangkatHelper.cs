using System;

namespace tjmod12_2311104042
{
    public class PangkatHelper
    {
        public static int CariNilaiPangkat(int a, int b)
        {
            if (b == 0) return 1;
            if (b < 0) return -1;
            if (b > 10 || a > 100) return -2;

            int hasil = 1;
            try
            {
                checked
                {
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                }
            }
            catch (OverflowException)
            {
                return -3;
            }

            return hasil;
        }
    }
}
