using System;
using System.Collections.Generic;

namespace tj13_2311104042
{
    public class PusatDataSingleton
    {
        private static PusatDataSingleton _instance;

        public List<string> DataTersimpan { get; set; }

        private PusatDataSingleton()
        {
            DataTersimpan = new List<string>();
        }

        public static PusatDataSingleton GetDataSingleton()
        {
            if (_instance == null)
            {
                _instance = new PusatDataSingleton();
            }
            return _instance;
        }

        public List<string> GetSemuaData()
        {
            return DataTersimpan;
        }

        public void PrintSemuaData()
        {
            Console.WriteLine("Isi Data:");
            foreach (var data in DataTersimpan)
            {
                Console.WriteLine("- " + data);
            }
        }

        public void AddSebuahData(string input)
        {
            DataTersimpan.Add(input);
        }

        public void HapusSebuahData(int index)
        {
            if (index >= 0 && index < DataTersimpan.Count)
            {
                DataTersimpan.RemoveAt(index);
            }
        }
    }
}
