using System.Text;
using System.Security.Cryptography;


namespace Decoder_pro
{
    internal class AES
    {
        /*Тест шифрования:
         private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
         private void encode_button_Click(object sender, EventArgs e)
         {
         AES aes = new AES();
         public_key_1_text.Text = aes.Encrypt("Бэтмен and Batman","1234567890123456",IV);
         }*/
        /*Тест дешифрования:
         private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
         AES aes = new AES();
         MessageBox.Show(aes.Decrypt("d8CagLwe4XX9kjgVLgO5NHSVnsezIX3/1Ftz+3ICQ50=", "1234567890123456", IV));
         }*/
        //private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string Encrypt(string plainText, string Password, byte[] IV)//Зашифровать
            {
                byte[] Key = Encoding.UTF8.GetBytes(Password);
            //
                // Create a new AesManaged.    
                AesManaged aes = new AesManaged();
                aes.Key = Key;
                aes.IV = IV;

                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

                byte[] InputBytes = Encoding.UTF8.GetBytes(plainText);
                cryptoStream.Write(InputBytes, 0, InputBytes.Length);
                cryptoStream.FlushFinalBlock();

                byte[] Encrypted = memoryStream.ToArray();
                // Return encrypted data    
                return Convert.ToBase64String(Encrypted);
            }

            public string Decrypt(string plaintext, string Password, byte[] IV)//Расшифровать
            {
            try
            {
                byte[] Key = Encoding.UTF8.GetBytes(Password);

                // Create a new AesManaged.    
                AesManaged aes = new AesManaged();
                aes.Key = Key;
                aes.IV = IV;

                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

                byte[] InputBytes = Convert.FromBase64String(plaintext);
                cryptoStream.Write(InputBytes, 0, InputBytes.Length);
                cryptoStream.FlushFinalBlock();

                byte[] Decrypted = memoryStream.ToArray();
                // Return encrypted data    
                return UTF8Encoding.UTF8.GetString(Decrypted, 0, Decrypted.Length);
            }
            catch (Exception)
            {

                return "";
            }
            }
        }
    }
