using System;
using System.Collections.Generic;

namespace lceasy
{
    public class HappyNumber
    {
        HashSet<int> numbers = new HashSet<int>();
        public bool IsHappy(int n)
        {
            int sum = 0;
            numbers.Add(n);            
            while (n != 0)
            {
                int digit = n % 10; 
                sum += digit * digit;
                n = n / 10; 
            }

            if(!numbers.Add(sum)) return false;

            if(sum == 1) return true;

            return IsHappy(sum);

        }

    }

}