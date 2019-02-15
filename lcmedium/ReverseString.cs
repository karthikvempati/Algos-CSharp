using System;
using System.Collections.Generic;
using System.Text;

namespace lcmedium
{

    public class ReverseString
    {
        public string ReverseWords(string s)
        {
            var a = s.Split(" ");
            Stack<string> st = new Stack<string>();
            StringBuilder sb = new StringBuilder();
            foreach (var str in a)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    st.Push(str);
                }
            }

            foreach (var item in st)
            {
                sb.Append(item);
                sb.Append(" ");
            }

            return sb.ToString().Trim();
        }
    }

}
