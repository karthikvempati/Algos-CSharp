using System;
namespace lcmedium
{

    public class DivideNoMulti
    {
        public int Divide(int dividend, int divisor)
        {
            int q = 0;
            if (dividend == 0 && divisor != 0)
                return 0;

            if (divisor == 1)
                return dividend;

            else if (divisor == -1)
                q = dividend * -1;
            else
            {

                if (dividend > 0 && divisor > 0)
                {
                    //q--;
                    while (dividend - divisor >= 0)
                    {
                        dividend -= divisor;
                        q++;
                        //Console.WriteLine(dividend + "," + q);                
                    }
                }

                else if (dividend > 0 && divisor < 0)
                {
                    while (dividend + divisor >= 0)
                    {
                        dividend += divisor;
                        q--;
                        //Console.WriteLine(dividend + "," + q);                
                    }
                }

                else if (dividend < 0 && divisor > 0)
                {
                    while (dividend + divisor <= 0)
                    {
                        dividend += divisor;
                        q--;
                        //Console.WriteLine(dividend + "," + q);                
                    }
                }

                else if (dividend < 0 && divisor < 0)
                {
                    //q--;
                    while (dividend - divisor <= 0)
                    {
                        dividend -= divisor;
                        q++;
                        if(dividend == 0) break;
                        //Console.WriteLine(dividend + "," + q);
                    }
                }
            }

            if (q == -2147483648)
                return 2147483647;

            return q;
        }
    }

}