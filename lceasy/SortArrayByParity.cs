using System;

namespace lceasy {
    public class SortArrayParity
    {
        public int[] SortArrayByParity(int[] A){
            
            int i=0, j = A.Length -1;

            while(i <= j){
                bool iEven = A[i] % 2 == 0;
                bool jEven = A[j] % 2 == 0;                
                if(iEven && jEven){
                    i++;
                } else if(iEven && !jEven){
                    i++;j--;
                } else if(!iEven && jEven){
                    var temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++;j--;
                } else {
                    j--;
                } 
            }
            

            return A;
        }        
    }
}