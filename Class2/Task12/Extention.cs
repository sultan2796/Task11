using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal static class Extention
    {
        public static bool IsOdd( this int x)
        {
            if(x % 2 == 1)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven( this int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsContain(this string text)
        {
            foreach(char c in text)
            {
                return true;
            }
            return false;
        }
       
        public static string ToCaptalize(this string text)
        {
            text = text.Replace(text[0], char.ToUpper(text[0]));
            return text;
        }

        public static int[] GetValueIndex(this string text,char x)
        {
            int[] index = new int[text.Length];
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == x)
                {
                    index[i] = i;
                }
                else
                {
                    index[i] = -1;
                }
            }
            return index;
        }
    }
}
