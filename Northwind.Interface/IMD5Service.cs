using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IMD5Service
    {
        /// <summary>
        /// Metni MD'e Dönüştür
        /// </summary>

        string ConvertTextToMD5(string text);

        /// <summary>
        /// MD5 ile Şifreleme
        /// </summary>

        string Encrypt(string text);

        /// <summary>
        /// Şifresini Çöz (MD5)
        /// </summary>

        string Decrypt(string encryptedValue);
    }
}
