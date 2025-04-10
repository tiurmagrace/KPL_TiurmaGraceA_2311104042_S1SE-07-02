using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class KuliahMahasiswa2311104042
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseData
    {
        public List<Course> courses { get; set; }
    }

    public static void ReadJSON()
    {
        try
        {
            string filePath = "tp7_2_2311104042.json";
            string jsonString = File.ReadAllText(filePath);

            CourseData data = JsonSerializer.Deserialize<CourseData>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int index = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {index} {course.code} - {course.name}");
                index++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi kesalahan saat membaca JSON: " + ex.Message);
        }

        Console.ReadLine(); 
    }
}
