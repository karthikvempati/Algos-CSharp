using System;
using System.Linq;

namespace Contest119 
{
    public class Distance
    {
        public int key {get;set;}

        public double distance {get;set;}


    }
    public class KClosestSum
    {
            public int[][] KClosest(int[][] points, int K) {
            int[][] closestArray = new int[K][];
            Distance[] distances = new Distance[points.GetLength(0)];

            for (int i = 0; i < points.GetLength(0); i++)
            {
                distances[i] = new Distance() { key = i, distance = GetDistance(points[i][0],points[i][1]) }; 
            }

            var ordered = distances.OrderBy(d => d.distance);

            int count = 0;
            
            foreach (var item in ordered)
            {
                if(count >= K){
                    break;
                }         

                closestArray[count] = points[item.key]; 
                count++;
            }

            return closestArray;
        } 

        public double GetDistance(int a, int b){
            return Math.Sqrt(a*a + b*b);
        }
    }

}