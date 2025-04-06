using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Tiurma");

        string[] judulFilm = {
            "Review Film Interstellar oleh Tiurma",
            "Review Film Inception oleh Tiurma",
            "Review Film Parasite oleh Tiurma",
            "Review Film Avatar oleh Tiurma",
            "Review Film Coco oleh Tiurma",
            "Review Film Up oleh Tiurma",
            "Review Film The Batman oleh Tiurma",
            "Review Film Joker oleh Tiurma",
            "Review Film La La Land oleh Tiurma",
            "Review Film Tenet oleh Tiurma"
        };

        foreach (string judul in judulFilm)
        {
            SayaTubeVideo video = new SayaTubeVideo(judul);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine("Total View Count: " + user.GetTotalVideoPlayCount());
    }
}
