using System;
using System.Collections.Generic;

public class KodeBuah
{
    private static Dictionary<string, string> kodeBuah = new Dictionary<string, string>
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Kurma", "K00"},
        {"Durian", "L00"},
        {"Anggur", "M00"},
        {"Melon", "N00"},
        {"Semangka", "O00"}
    };

    public static string getKodeBuah(string buah)
    {
        return kodeBuah.ContainsKey(buah) ? kodeBuah[buah] : "Kode tidak ditemukan";
    }
}
