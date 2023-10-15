using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IStatic.Extension
{
    internal static class Helper
    {
        public static bool IsOdd(int numero)
        {
            if (numero % 2 != 0) return true;
            else return false;
        }
        public static bool IsEven(int numero)
        {
            if (numero % 2 == 0) return true;
            else return false;
        }

        public static bool HasDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                //if (word[i] % 1 == 0)
                if (int.TryParse(word[i].ToString(), out int n))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPassword(string pass)
        {
            Regex rg = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$");
            if (rg.IsMatch(pass)) return true;
            else return false;
        }

        public static string Capitalize(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }
    }
}
