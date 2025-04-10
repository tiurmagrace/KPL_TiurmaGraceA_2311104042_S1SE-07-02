using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa2311104042
{
    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public static void ReadJSON()
    {
        string filePath = "tp7_1_2311104042.json";

        string jsonString = File.ReadAllText(filePath);

        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

        Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
        Console.ReadLine();

    }
}
