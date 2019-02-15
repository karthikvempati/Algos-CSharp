namespace Contest122
{

    public class SumOfEvenNumbers
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            int alen = A.Length;
            int qlen = queries.Length;
            bool[] e = new bool[A.Length];
            int[] result = new int[qlen];
            int totalEvenSum = 0;
            for (int i = 0; i < alen; i++)
            {
                if (A[i] % 2 == 0)
                {
                    e[i] = true;
                    totalEvenSum += A[i];
                }
                //e[i] = == 0 ? true : false; 
            }

            for (int j = 0; j < qlen; j++)
            {
                var q = queries[j];
                var index = q[1];
                var value = q[0];
                if (e[index])
                {
                    totalEvenSum -= A[index];
                }

                A[index] += value;

                if (A[index] % 2 == 0)
                {
                    totalEvenSum += A[index];
                }

                result[j] = totalEvenSum;
            }

            return result;
        } 
    }
}