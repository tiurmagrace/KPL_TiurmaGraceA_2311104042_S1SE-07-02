class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Tiurma Grace Angelina");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}

