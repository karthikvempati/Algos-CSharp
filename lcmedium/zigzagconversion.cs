using System;
using System.Collections.Generic;
using System.Text;

namespace lcmedium
{

    public class zigzagconversion
    {
        public string Convert(string s, int numRows){
            List<List<char>> list = new List<List<char>>();
            if(numRows == 0) return string.Empty;
            if(numRows == 1) return s;

            int row = 0;
            bool up = false;

            for (int i = 0; i < numRows; i++)
            {
                list.Add(new List<char>());
            }

            for (int i = 0; i < s.Length; i++)
            {  
                list[row].Add(s[i]);

                if(numRows - row - 1 == 0) up = true;
                if(row == 0) up = false;
                //else up = false;

                if(up) row--;
                else row++; 
            }

            StringBuilder sb = new StringBuilder();

            foreach(var l in list){
                foreach(char c in l){
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }

}