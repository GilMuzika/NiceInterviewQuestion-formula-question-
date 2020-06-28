using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_06_20_NiceInterviewQueation_winForm
{
    public class Verifier
    {
        public bool isDupplicationsAllowed { get; set; }
        public Dictionary<char, int> Duplicates { get; private set; }
        /// <summary>
        /// The formula method
        /// </summary>
        /// <param name="formula"></param>
        /// <param name="inputSentense"></param>
        /// <returns></returns>
        public bool IsAppropriateByFormula(string formula, string inputSentense)
        {
            List<string> lstFormula = SplitBySeparator(formula, '@');
            List<List<string>> formulaLst = new List<List<string>>();
            for (int i = 0; i < lstFormula.Count; i++)
            {
                List<string> lstChar = SplitBySeparator(lstFormula[i], ',');
                formulaLst.Add(lstChar);
            }
            List<char> inputLst = SplitBySeparator(inputSentense, ',').ToCharList();


            if (formulaLst.Count != inputLst.Count) return false;

            //return AnalizeSideStore(formulaLst, inputLst);
            //return AnalizeSideStore_NoDuplications(formulaLst, inputLst);

            return isDupplicationsAllowed ? AnalizeSideStore(formulaLst, inputLst) : AnalizeSideStore_NoDuplications(formulaLst, inputLst);

        }

        public List<string> SplitBySeparator(string stringToBrSplit, char separator)
        {
            List<string> separatedParstLst = new List<string>();
            string tmp = string.Empty;
            char c = default(char);
            for (int i = 0; i < stringToBrSplit.Length; i++)
            {
                if (stringToBrSplit[i] != separator) tmp += stringToBrSplit[i];
                if (i + 1 < stringToBrSplit.Length) c = stringToBrSplit[i + 1];
                if (i == stringToBrSplit.Length - 1) c = separator;
                if (c.Equals(separator)) { separatedParstLst.Add(tmp); tmp = string.Empty; }
            }

            return separatedParstLst;
        }


        private bool AnalizeSideStore(List<List<string>> formulaLst, List<char> inputLst)
        {
            List<bool> boolIst = new List<bool>();
            foreach (var c in inputLst)
            {
                bool flag = false;
                foreach (List<string> s in formulaLst)
                {
                    List<char> s_char = s.ToCharList();
                    if (s_char.Contains(c)) { flag = true; break; }

                }
                boolIst.Add(flag);
            }

            if (boolIst.Contains(false)) return false;

            return true;
        }

        private bool AnalizeSideStore_NoDuplications(List<List<string>> formulaLst, List<char> inputLst)
        {
            Dictionary<char, int> occurences = new Dictionary<char, int>();
            List<bool> boolIst = new List<bool>();
            foreach (var c in inputLst)
            {
                bool flag = false;
                foreach (List<string> s in formulaLst)
                {
                    List<char> s_char = s.ToCharList();
                    if (s_char.Contains(c)) 
                    {
                        

                        try
                        {
                            occurences.Add(c, 1);
                            flag = true;
                        }
                        catch (ArgumentException)
                        {
                            occurences[c]++;
                            flag = false;
                        }

                         
                    }

                }
                boolIst.Add(flag);
            }

            Dictionary<char, int> occursMoreThanOneTime = new Dictionary<char, int>();
            foreach(var s in occurences)
            {
                if (s.Value > 1) occursMoreThanOneTime.Add(s.Key, s.Value);
            }

            this.Duplicates = occursMoreThanOneTime;


            if (boolIst.Contains(false)) return false;

            return true;
        }




    }
}
