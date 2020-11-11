using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "my data";
            Encrpyptor enc = new Encrpyptor("MyKeyContainer");
            byte[] encryptedData = enc.ToEncrypt(data);
            string s = enc.ByteConverter.GetString(encryptedData);
            Console.WriteLine(s);
            s = enc.ToDecrypt(encryptedData);
            Console.WriteLine(s);
        }
    }
}
