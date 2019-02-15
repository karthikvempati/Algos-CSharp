using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace codility
{

    class Solution
    {
        public int NoOfCandies(int[] T)
        {
            var result = 0;
            HashSet<int> h = new HashSet<int>();
            var duplicates = 0;
            for (int i = 0; i < T.Length; i++)
            {
                if(!h.Add(T[i])){
                    duplicates++;
                }
            }

            if(h.Count >= T.Length/2){
                result = T.Length/2;
            } else
            {
                result = h.Count;
            }

            return result;
        }
    }
}