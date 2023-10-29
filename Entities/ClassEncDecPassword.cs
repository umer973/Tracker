using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;


namespace DEntities
{
   public class ClassEncDecPassword
    {
       const string passphrase = "AaZzAaZzUuLlHhAaQqUuEeEeMmPp00180";

       public string encrypt(string Password)
       {
           byte[] results;
           UTF8Encoding utf8 = new UTF8Encoding();

           MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
           byte[] deskey = md5.ComputeHash(utf8.GetBytes(passphrase));

           TripleDESCryptoServiceProvider desalg = new TripleDESCryptoServiceProvider();
           desalg.Key = deskey;
           desalg.Mode = CipherMode.ECB;
           desalg.Padding = PaddingMode.PKCS7;
           byte[] encrypt_data = utf8.GetBytes(Password);


           try
           {
               ICryptoTransform encryptor = desalg.CreateEncryptor();
               results = encryptor.TransformFinalBlock(encrypt_data, 0, encrypt_data.Length);

           }
           finally
           {

               desalg.Clear();
               md5.Clear();
           }

           return Convert.ToBase64String(results);

       }

       public string decrypt(string message)
       {
           byte[] results;
           UTF8Encoding utf8 = new UTF8Encoding();
           MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
           byte[] deskey = md5.ComputeHash(utf8.GetBytes(passphrase));
           TripleDESCryptoServiceProvider desalg = new TripleDESCryptoServiceProvider();
           desalg.Key = deskey;
           desalg.Mode = CipherMode.ECB;
           desalg.Padding = PaddingMode.PKCS7;
           byte[] decrypt_data = Convert.FromBase64String(message);
           try
           {

               ICryptoTransform decryptor = desalg.CreateDecryptor();
               results = decryptor.TransformFinalBlock(decrypt_data, 0, decrypt_data.Length);
           }
           finally
           {
               desalg.Clear();
               md5.Clear();

           }

           return utf8.GetString(results);
       }
    }
}
