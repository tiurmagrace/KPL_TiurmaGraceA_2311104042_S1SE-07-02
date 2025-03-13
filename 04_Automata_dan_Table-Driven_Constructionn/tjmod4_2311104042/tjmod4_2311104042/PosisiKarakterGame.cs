using System;

public class PosisiKarakterGame
{
    private string state;

    public PosisiKarakterGame()
    {
        state = "Berdiri";
    }

    public void TombolS()
    {
        Console.WriteLine("tombol arah bawah ditekan");

        if (state == "Berdiri")
        {
            state = "Jongkok";
            Console.WriteLine("Posisi jongkok");
        }
        else if (state == "Jongkok")
        {
            state = "Tengkurap";
            Console.WriteLine("Posisi tengkurap");
        }
    }

    public void TombolW()
    {
        Console.WriteLine("tombol arah atas ditekan");

        if (state == "Jongkok")
        {
            state = "Berdiri";
            Console.WriteLine("Posisi berdiri");
        }
        else if (state == "Berdiri")
        {
            state = "Terbang";
            Console.WriteLine("Posisi terbang");
        }
    }
}
