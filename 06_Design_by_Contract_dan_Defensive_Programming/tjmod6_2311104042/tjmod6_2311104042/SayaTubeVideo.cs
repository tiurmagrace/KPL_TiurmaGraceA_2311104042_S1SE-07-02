using System;
using System.Diagnostics;


public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null && title.Length <= 100, "Judul tidak boleh null dan maksimal 100 karakter");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count >= 0 && count <= 10000000, "Penambahan play count harus antara 0 dan 10.000.000");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow terjadi saat menambah play count.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID Video       : " + this.id);
        Console.WriteLine("Judul Video    : " + this.title);
        Console.WriteLine("Jumlah Ditonton: " + this.playCount);
    }

    public int GetPlayCount()
    {
        return this.playCount;
    }

    public string GetTitle()
    {
        return this.title;
    }
}
