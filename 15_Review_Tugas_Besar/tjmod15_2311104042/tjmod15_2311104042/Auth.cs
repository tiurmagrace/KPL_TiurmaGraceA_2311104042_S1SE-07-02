using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace modul15_2311104042
{
    public class Auth
    {
        private static string filePath = "users.json";

        public static void Register()
        {
            Console.Write("Masukkan username: ");
            string username = Console.ReadLine();

            if (username.Length < 5 || username.Length > 20 || !Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                Console.WriteLine("Username harus 5-20 karakter dan hanya boleh huruf/angka.");
                return;
            }

            Console.Write("Masukkan password: ");
            string password = Console.ReadLine();

            if (password.Length < 8 || !Regex.IsMatch(password, @"[!@#$%^&*]") || password.Contains(username))
            {
                Console.WriteLine("Password minimal 8 karakter, harus mengandung 1 karakter spesial (!@#$%^&*), dan tidak boleh mengandung username.");
                return;
            }

            string hashPassword = ComputeSha256Hash(password);

            var users = LoadUsers();

            if (users.Any(u => u.Username == username))
            {
                Console.WriteLine("Username sudah digunakan.");
                return;
            }

            users.Add(new User { Username = username, PasswordHash = hashPassword });
            SaveUsers(users);

            Console.WriteLine("Registrasi berhasil.");
        }

        public static void Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            string hashPassword = ComputeSha256Hash(password);
            var users = LoadUsers();

            var user = users.FirstOrDefault(u => u.Username == username && u.PasswordHash == hashPassword);
            if (user != null)
            {
                Console.WriteLine("Login berhasil!");
            }
            else
            {
                Console.WriteLine("Username atau password salah.");
            }
        }

        private static List<User> LoadUsers()
        {
            if (!File.Exists(filePath))
            {
                return new List<User>();
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json);
        }

        private static void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                return Convert.ToHexString(bytes); 
            }
        }
    }
}
