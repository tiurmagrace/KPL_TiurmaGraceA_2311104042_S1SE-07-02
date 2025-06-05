using System;

/// <summary>
/// Representasi video dengan fitur penambahan play count dan cetak detail.
/// </summary>
public class SayaTubeVideo
{
    private int _id;
    private string _title;
    private int _playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Judul video tidak boleh kosong atau null.");

        if (title.Length > 100)
            throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.");

        Random random = new Random();
        _id = random.Next(10000, 99999);
        _title = title;
        _playCount = 0;
    }

    /// <summary>
    /// Menambahkan jumlah play dengan batas maksimal 10 juta.
    /// </summary>
    public void IncreasePlayCount(int count)
    {
        if (count > 10000000)
            throw new ArgumentException("Penambahan play count tidak boleh lebih dari 10.000.000.");

        try
        {
            checked
            {
                _playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer!");
        }
    }

    /// <summary>
    /// Mencetak detail video.
    /// </summary>
    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID Video   : {_id}");
        Console.WriteLine($"Judul      : {_title}");
        Console.WriteLine($"Jumlah Play: {_playCount}");
    }
}
