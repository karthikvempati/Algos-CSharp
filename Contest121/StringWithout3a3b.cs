namespace Contest121
{
    public class StringWithout3a3b
    {
        public string StrWithout3a3b(int A, int B)
        {
            /*if((A == 0 && B >=3) || (B <= 0 && A >=3))
                return "";
            if( A != 0 && (B != 0 && A/B > 4) || B/A > 4)
                return "";*/
            char[] S = new char[A + B];
            for (int a = 0; a < A; a++)
            {
                S[a] = 'a';
            }
            for (int b = A; b < A + B; b++)
            {
                S[b] = 'b';
            }

            int count = 0;
            char prev = 'a';
            int end = S.Length - 1;
            int start = 0;
            for (int i = 0; i < A + B; i++)
            {
                if (S[i] == prev)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                if (count == 3 && S[i] != S[end])
                {
                    var temp = S[i];
                    S[i] = S[end];
                    S[end] = temp;
                    end--;
                }

                if (count == 3 && S[i] != S[start])
                {
                    var temp = S[i];
                    S[i] = S[start];
                    S[start] = temp;
                }
            }

            return S.ToString();
        }
    }
} 
