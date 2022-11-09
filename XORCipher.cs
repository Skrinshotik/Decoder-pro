using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder_pro
{
    public class XORCipher
    {
        //генератор повторений пароля
        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)   // подгоняет ключ под размер текста для шифровки
            {
                r += r;
            }

            return r.Substring(0, n);
        }

        //метод шифрования/дешифровки
        private string Cipher(string text, string secretKey)
        {
            var currentKey = GetRepeatKey(secretKey, text.Length); // генерируют ключ и записывает в переменную
            var res = string.Empty; // пустая строка для результата
            for (var i = 0; i < text.Length; i++)
            {
                res += ((char)(text[i] ^ currentKey[i])).ToString();   
            }

            return res;
        }

        //шифрование текста
        public string Encrypt(string plainText, string password)
            => Cipher(plainText, password);

        //расшифровка текста
        public string Decrypt(string encryptedText, string password)
            => Cipher(encryptedText, password);
    }

    /*private string GetRandomKey(int k, int len)
    {
    var gamma = string.Empty;
    var rnd = new Random(k);
    for (var i = 0; i < len; i++)
    {
        gamma += ((char)rnd.Next(35, 126)).ToString();
    }

    return gamma;
    }           
    */
}
