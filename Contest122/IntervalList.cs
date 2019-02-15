using System;
using System.Collections.Generic;

namespace Contest122
{
     public class Interval {
      public int start;
      public int end;
      public Interval() { start = 0; end = 0; }
      public Interval(int s, int e) { start = s; end = e; }
    }
    public class IntervalListIntersection
    {
        public Interval[] IntervalIntersection(Interval[] A, Interval[] B)
        {
            int i = 0;
            int j = 0;
            List<Interval> list = new List<Interval>();
            while (i < A.Length && j < B.Length)
            {
                if (A[i].end == B[j].start)
                {
                    list.Add(new Interval(A[i].end, A[i].end));
                    i++;
                }
                else if (A[i].start == B[j].end)
                {
                    list.Add(new Interval(A[i].start, A[i].start));
                    j++;
                }
                else if(A[i].start > B[j].end){
                    j++;
                }
                else if(A[i].end < B[j].start){
                    i++;
                }
                else if (A[i].end > B[j].start && A[i].end < B[j].end)
                {
                    list.Add(new Interval(Math.Max(A[i].start, B[j].start), Math.Min(A[i].end, B[j].end)));
                    i++;
                }
                else if (A[i].end > B[j].start && A[i].end > B[j].end)
                {
                    list.Add(new Interval(Math.Max(A[i].start, B[j].start), Math.Min(A[i].end, B[j].end)));
                    j++;
                }
                else if (B[j].end > A[i].start && B[j].end < A[i].end)
                {
                    list.Add(new Interval(Math.Max(A[i].start, B[j].start), Math.Min(A[i].end, B[j].end)));
                    j++;
                }
                else if (B[j].end > A[i].start && B[j].end > A[i].end)
                {
                    list.Add(new Interval(Math.Max(A[i].start, B[j].start), Math.Min(A[i].end, B[j].end)));
                    i++;
                }
            }

            return list.ToArray();
        }
    }
}