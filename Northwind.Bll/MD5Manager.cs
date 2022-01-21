using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class MD5Manager : IMD5Service
    {
        //private string hash = "ASPDOTNETMVC09112021";
        public string ConvertTextToMD5(string text)
        {
            //MD5CryptoServiceProvider pwd = new MD5CryptoServiceProvider();
            //return EncryptionToMD5(text, pwd);
            throw new NotImplementedException();
        }
        //private string EncryptionToMD5(string text, HashAlgorithm alg)
        //{
        //    byte[] byteValue = Encoding.UTF8.GetBytes(text);
        //    byte[] encryptByte = alg.ComputeHash(byteValue);
        //    return Convert.ToBase64String(encryptByte);
        //}
        public string Decrypt(string encryptedValue)
        {
            //byte[] data = Convert.FromBase64String(encryptedValue);
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{
            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //    using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripleDes.CreateDecryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        return UTF8Encoding.UTF8.GetString(results);
            //    }
            //}
            throw new NotImplementedException();
        }

        public string Encrypt(string text)
        {
            //using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            //{
            //    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(text);
            //    byte[] hashBytes = md5.ComputeHash(inputBytes);

            //    // Convert the byte array to hexadecimal string
            //    StringBuilder sb = new StringBuilder();
            //    for (int i = 0; i < hashBytes.Length; i++)
            //    {
            //        sb.Append(hashBytes[i].ToString("X2"));
            //    }
            //    return sb.ToString();
            //}


            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
