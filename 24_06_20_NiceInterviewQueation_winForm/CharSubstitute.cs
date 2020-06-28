using System;
using System.Collections.Generic;
using System.Text;

namespace _24_06_20_NiceInterviewQueation_winForm
{
    public class CharSubstitute
    {
        public char Char { get; }
        public int CharOccurences { get; set; }

        public CharSubstitute(char @char, int charOccurences)
        {
            Char = @char;
            CharOccurences = charOccurences;
        }
    }
}
