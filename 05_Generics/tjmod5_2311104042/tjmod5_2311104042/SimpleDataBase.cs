using System;
using System.Collections.Generic;

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int data1 = 23; 
        int data2 = 11; 
        int data3 = 04; 

        SimpleDataBase<int> database = new SimpleDataBase<int>();

        database.AddNewData(data1);
        database.AddNewData(data2);
        database.AddNewData(data3);

        database.PrintAllData();
    }
}
