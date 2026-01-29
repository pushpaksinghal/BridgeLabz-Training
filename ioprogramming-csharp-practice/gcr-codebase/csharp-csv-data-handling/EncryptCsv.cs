using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class EncryptCsv
    {
        static byte[] key = Encoding.UTF8.GetBytes("1234567890123456");

        static string Encrypt(string text)
        {
            using Aes aes = Aes.Create();
            aes.Key = key;
            aes.GenerateIV();

            var encryptor = aes.CreateEncryptor();
            byte[] cipher = encryptor.TransformFinalBlock(
                Encoding.UTF8.GetBytes(text), 0, text.Length);

            return Convert.ToBase64String(aes.IV) + ":" +
                   Convert.ToBase64String(cipher);
        }

        static void Main(string[] args)
        {
            using StreamWriter writer = new StreamWriter("secure.csv");
            writer.WriteLine("ID,Name,Salary");

            writer.WriteLine($"1,Amit,{Encrypt("60000")}");
        }
    }
}
