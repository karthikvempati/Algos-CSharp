using System;
using System.Collections.Generic;
using System.Linq;

namespace lceasy
{

    public class KeyBoardRow
    {
        public string[] FindWords(string[] words)
        {
            IList<string> list = new List<string>();
            foreach (string s in words)
            {
                if (IsStringInSameRow(s))
                    list.Add(s);
            }
            return list.ToArray();
        }

        public bool IsStringInSameRow(string s)
        {
            HashSet<char> row1 = new HashSet<char>();
            HashSet<char> row2 = new HashSet<char>();
            HashSet<char> row3 = new HashSet<char>();
            string s1 = "qwertyuiop";
            string s2 = "asdfghjkl";
            string s3 = "zxcvbnm";

            foreach (char c in s1) row1.Add(c);
            foreach (char c in s2) row2.Add(c);
            foreach (char c in s3) row3.Add(c);
            HashSet<char> prev = null;
            foreach (char ch in s)
            {
                HashSet<char> current = null;
                var c = ch;
                if ((int)c >= 65 && (int)c <= 90){
                    c = (char)((int)c - 65 + 97);
                }

                if (row1.Contains(c)) current = row1;
                if (row2.Contains(c)) current = row2;
                if (row3.Contains(c)) current = row3;

                if (prev != null && prev != current) return false;
            }

            return true;
        }
    }

}