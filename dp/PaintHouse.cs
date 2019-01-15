using System;

namespace dp{
    
    public class PaintHouse
    {
        public int Paint(int[,]  costs){
            int minCost = int.MaxValue;
            int[] colorsPainted = new int[costs.GetLength(0)];

            for (int i = 0; i < 3; i++)
            {
                if(minCost > costs[0,i] + MinCost(i, 1, costs,colorsPainted)){
                    minCost = costs[0,i] + MinCost(i, 1, costs,colorsPainted);
                    colorsPainted[0] = i;
                } 
            }

            foreach (var item in colorsPainted)
            {
                Console.Write(item + "  ");               
            }

            return minCost;
        }

        public int MinCost(int prevColor, int house, int[,] costs, int[] colorsPainted){
            int minCost = int.MaxValue;
            int selectedColor = -1;
            if(house == costs.GetLength(0)-1) {
                for (int i = 0; i < 3; i++)
                {
                    if(prevColor == i) continue;

                    /*if(costs[house,i] < minCost){
                        minCost = costs[house,i];
                        selectedColor = i;
                        colorsPainted[house] = i;
                    }  */
                }
            }
            

            return house == costs.GetLength(0)-1 ? minCost : minCost + MinCost(selectedColor, house + 1, costs, colorsPainted);                    
        }
    }
}