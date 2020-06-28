using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace _24_06_20_NiceInterviewQueation_winForm
{
    public static class Statics
    {
        static public List<char> ToCharList<T>(this IEnumerable<T> ie)
        {
            List<char> charlist = new List<char>();
            foreach (T s in ie)
            {
                string sAsStr = s.ToString();
                if (sAsStr.Length == 1) charlist.Add(sAsStr[0]);
                else throw new ArgumentException("the argument mus be a collection of one-byte symbols!");
            }
            return charlist;
        }

        static public bool ContainsCharSubstituteByChar(this IEnumerable<CharSubstitute> ie, char c)
        {            
            foreach (CharSubstitute s in ie)
            {
                if (s.Char == c)
                {
                    return true;
                }
            }
            return false;
        }

        static public bool ContainsSomethingThatIsNot<T>(this IEnumerable<T> ie, T something)
        {
            foreach(T s in ie)
            {
                if (!s.Equals(something)) return false;
            }

            return false;
        }

        static public int HowMuchTimesOccurs<T>(this IEnumerable<T> ie, T x)
        {
            int count = 0;
            foreach(T s in ie)
            {
                if (s.Equals(x)) count++;
            }
            return count;
        }

        static public string PrepareSentence(this string sentence)
        {
            string strOut = string.Empty;
            int count = 0;
            foreach(var s in sentence)
            {
                if(!Char.IsWhiteSpace(s) && !s.Equals(','))
                {                    
                    strOut += s + ','.ToString();
                    count++;
                }
            }
            return strOut.ChopCharsfromTheEnd(1).ToUpper();
        }

        static public string ChopCharsfromTheEnd(this string str, int charsNum)
        {
            string strOut = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - charsNum) strOut += str[i];
            }
            return strOut;
        }

        static public List<T> FlattenList<T>(this List<List<T>> deepLst)
        {
            List<T> flatLst = new List<T>();
            foreach (List<T> s in deepLst)
            {
                foreach (T ss in s)
                {
                    flatLst.Add(ss);
                }

            }
            return flatLst;
        }


        static public List<char> SideStore = new List<char>();
    }
}
