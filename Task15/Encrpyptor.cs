using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Task15
{
    class Encrpyptor
    {
        public string KeyContainerName { get; private set; }
        private CspParameters csp;
        public readonly UnicodeEncoding ByteConverter = new UnicodeEncoding();
        public Encrpyptor(string s)
        {
            KeyContainerName = s;
            csp = new CspParameters() { KeyContainerName = KeyContainerName };
        }
        public byte[] ToEncrypt(string s)
        {
            byte[] dataToEncrypt = ByteConverter.GetBytes(s);
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                return RSA.Encrypt(dataToEncrypt, false);
            }
        }
        public string ToDecrypt(byte[] data)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                return ByteConverter.GetString(RSA.Decrypt(data, false));
            }
        }
    }
}
