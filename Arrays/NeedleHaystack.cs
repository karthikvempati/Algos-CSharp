using System;

namespace Arrays 
{
    public class  NeedleInHayStack
    {
        public int StrStr(string haystack, string needle) 
        {
            if(string.IsNullOrEmpty(needle)) return 0;
            int i = 0; 
            int j = needle.Length-1;

            while(j < haystack.Length){
                if(AreStringsEqual(haystack,needle,i,j)) return i;
                i++;
                j++;
            }

            return -1;
        }

        public bool AreStringsEqual(string haystack, string needle, int i, int j)
        {
            int b = 0;
            for (int a = i; a <= j; a++)
            {
                if(haystack[a] != needle[b++]) return false;
            }

            return true;
        }        
    }

}