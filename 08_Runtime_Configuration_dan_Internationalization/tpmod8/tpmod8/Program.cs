﻿using System;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = CovidConfig.LoadConfig();

        Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu + ":");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hari = Convert.ToInt32(Console.ReadLine());

        bool suhuNormal = false;

        if (config.satuan_suhu == "celcius")
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        else if (config.satuan_suhu == "fahrenheit")
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;

        if (suhuNormal && hari < config.batas_hari_deman)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }

        config.UbahSatuan();
        Console.WriteLine("\nSatuan suhu telah diubah menjadi: " + config.satuan_suhu);
    }
}
