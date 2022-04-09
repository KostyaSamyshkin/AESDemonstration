using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AESDemonstration
{
    public static class AESUtils
    {
        public static string Encrypt(string data, string password)
        {
            // превращаем строку в массив байт
            byte[] clearBytes = Encoding.UTF8.GetBytes(data);

            using (Aes aes = Aes.Create() )
            {
                // Используем RFC 2898 для получения ключа и IV из пароля
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(password, new byte[]
                {
                    0x49, 0x76, 0x61, 0x6e, 0x20,
                    0x4d, 0x65, 0x64, 0x76, 0x65,
                    0x64, 0x65, 0x76
                }, 50000); // 50000 итераций

                aes.Key = pdb.GetBytes(32);
                aes.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream() ) // поток с шифротекстом
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write) ) // шифрующий поток
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }

                    // кодируем массив байт в base64 для передачи в виде строки
                    data = Convert.ToBase64String(ms.ToArray() );
                }
            }

            return data;
        }

        public static string Decrypt(string data, string password)
        {
            //data = data.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(data); // декодируем из base64

            using (Aes encryptor = Aes.Create() )
            {
                // Используем RFC 2898 для получения ключа и IV из пароля
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(password, new byte[]
                {
                    0x49, 0x76, 0x61, 0x6e, 0x20,
                    0x4d, 0x65, 0x64, 0x76, 0x65,
                    0x64, 0x65, 0x76
                }, 50000); // 50000 итераций

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream() ) // поток с исходным текстом
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write) ) // расшифровывающий поток
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }

                    // Превращаем массив байт в строку
                    data = Encoding.UTF8.GetString(ms.ToArray() );
                }
            }

            return data;
        }
    }
}
