using System;

namespace lcmedium
{

    public class IntegerReplacementCount
    {
        public int IntegerReplacement(int n)
        {

            if (n <= 1)
                return 0;

            int count = 0;

            count = GetMinCount(n, count);

            return count;
        }

        public int GetMinCount(int n, int c)
        {
            if (n == 1)
                return c;

            if (n % 2 == 0)
            {
                c++;
                return GetMinCount(n / 2, c);
            }
            else
            {
                return Math.Min(GetMinCount(n - 1, c + 1), GetMinCount(n + 1, c + 1));
            }
        }
    }

}