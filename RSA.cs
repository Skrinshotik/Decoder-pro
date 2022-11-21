using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Decoder_pro
{
    internal class RSA
    {
        char[] characters = new char[] { ' ', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', '.', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0' };
        public bool IsTheNumberSimple(long n)
        {
            if (n < 10)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        public long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }
        public long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }
        public List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        public List<string> Encrypt(string s, string p1, string q1)
        {
            long p = Convert.ToInt64(p1);
            long q = Convert.ToInt64(q1);
            List<string> result = new List<string>();
            if (p != q && IsTheNumberSimple(p) && IsTheNumberSimple(q))
            {
                s = s.ToUpper();
                long n = p * q;
                long m = (p - 1) * (q - 1);
                long d = Calculate_d(m);
                long e_ = Calculate_e(d, m);

                result = RSA_Endoce(s, e_, n);
            }
            return result;
        }
        public string Decipher(List<string> input, string p1, string q1)
        {

            long p = Convert.ToInt64(p1);
            long q = Convert.ToInt64(q1);
            long n = p * q;
            string result;
            long m = (p - 1) * (q - 1);
            long d = Calculate_d(m);
            result = RSA_Dedoce(input, d, n);
            return result;
        }

        public string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }
    }
}
