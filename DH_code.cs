using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Decoder_pro
{
    //Суть в создании ключей с некоторой математической зависимостью, но без возможности обратной расшифровки со стороны отправителя
    internal class DH_code
    {
        //          Не большое тестирование функционала!!!!!
        //int public_key1, public_key2, private_key;
        //public_key1 = Convert.ToInt32(public_key_1_text.Text);
        //public_key2 = Convert.ToInt32(public_key_2_text.Text);
        //private_key = Convert.ToInt32(private_key_text.Text);
        //DH_code dh_code = new DH_code(public_key1, public_key2, private_key);
        //dh_code.generate_partial_key();
        //MessageBox.Show(dh_code.generate_partial_key().ToString());
        //MessageBox.Show(dh_code.generate_full_key(66).ToString());

        private int public_key1, public_key2, private_key;
        public DH_code(int public_key1, int public_key2, int private_key)
        {
            this.public_key1 = public_key1;
            this.public_key2 = public_key2;
            this.private_key = private_key;
        }

        //Создание частичного ключа, для передачи его нашему собеседнику
        public BigInteger generate_partial_key()
        {
            BigInteger partial_key = BigInteger.Pow(public_key1, private_key);
            partial_key = partial_key % public_key2;
            return partial_key;
        }

        //После получения частичного ключа нашего собеседника, мы можем получить ГЛАВНЫЙ ключ к нашим шифам
        public BigInteger generate_full_key(BigInteger partial_key_r)
        {
            BigInteger full_key = BigInteger.Pow(partial_key_r, private_key);
            full_key = full_key % public_key2;
            return full_key;
        }
    }
}
